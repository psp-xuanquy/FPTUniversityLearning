using CRMBook.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json.Linq;
using System.IdentityModel.Tokens.Jwt;
using System.Reflection.Emit;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace CRMBook.Sevices
{
    public interface IAuthencationServices
    {
        ResponseloginModel Authencation(RequestLoginModel model);

        void Register(RequestRegisterModel model);

        ResponseloginModel RefeshTokens(String refreshToken);

    }
    public class AuthencationServices : IAuthencationServices
    {
        private readonly String Key = "hgfashdasjdgkjashdjkhasjkdhaadasda";
        public AuthencationServices()
        {
        }

        public ResponseloginModel Authencation(RequestLoginModel model)
        {
            using (var context = new cmdBookContext())
            {
                var Account = context.Set<User>().Where(x => x.Username == model.UserName && x.Password == model.Password).FirstOrDefault();
                if (Account == null)
                {
                    throw new Exception("can't found Accont");
                }

                var token = CreateJwtToken(Account);
                var RefreshToken = CreateRefreshToken(Account);
                var result = new ResponseloginModel
                {
                    FullName = model.UserName,
                    Accout_id = Account.Accout_id,
                    Token = token,
                    RefreshToken = RefreshToken.Token
                };
                return result;
            }
        }

        private RefeshTokens CreateRefreshToken(User Account)
        {
            var ramdomByte = new byte[64];
            var token = Convert.ToBase64String(ramdomByte);
            var refreshToken = new RefeshTokens
            {              
                Refresh_Accout_id = Account.Accout_id,
                Expires = DateTime.Now.AddDays(1),
                IsActive = true,
                Token = token
            };
            using (var context = new cmdBookContext())
            {
                context.RefreshTokens.Add(refreshToken);     
                context.SaveChanges();
            }
            return refreshToken;

        }

        public ResponseloginModel RefeshTokens(String refreshToken)
        {
            using (var context = new cmdBookContext())
            {
                
                var validateToken = context.RefreshTokens.Where(x => x.Token != refreshToken || x.Expires < DateTime.Now ).FirstOrDefault();
                var user = context.Users.Where(x => x.Accout_id == validateToken.Refresh_Accout_id).FirstOrDefault();
                var jwtToken = CreateJwtToken(user);
                var newRefreshToken = CreateRefreshToken(user);
                var result = new ResponseloginModel
                {
                    FullName = user.Username,
                    Accout_id = user.Accout_id,
                    Token = jwtToken,
                    RefreshToken = newRefreshToken.Token
                };
                return result;
            }            
        }

        public void Register(RequestRegisterModel model) 
        {
            using (var context = new cmdBookContext())
            {
                var AccountEsixt = context.Users.Where(x => x.Username == model.Username).FirstOrDefault();
                if (AccountEsixt != null) 
                {
                    throw new ("Account Has Existed");
                }
                var verifyToken =  new Random().Next(0, 1000000).ToString("D6");
                var UserId = "s" + new Random().Next(0, 10000000);
                var user = new User { 
                    Accout_id = UserId,
                    Username = model.Username,
                    Name = model.Name,
                    Email = model.Email,
                    Password = model.Password,
                    VerificationToken = verifyToken
                };
                context.Users.Add(user);
                context.SaveChanges();                
            }        
        }


        private string CreateJwtToken(User Account)
        {
            var tokenHanler = new JwtSecurityTokenHandler();
            var key = Encoding.UTF8.GetBytes(Key);
            var SecurityKey = new SymmetricSecurityKey(key);
            var Credential = new SigningCredentials(SecurityKey, SecurityAlgorithms.HmacSha256);
            var tokenDescription = new SecurityTokenDescriptor
            {
                Audience = "",
                Issuer = "",
                Subject = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.Name, Account.Name),
                    new Claim(ClaimTypes.Email, Account.Email),
                    new Claim("CarlNumber", "1")

                }),
                Expires = DateTime.UtcNow.AddHours(1),
                SigningCredentials = Credential
            };
            var token = tokenHanler.CreateToken(tokenDescription);
            return tokenHanler.WriteToken(token);
        }

    }
}
