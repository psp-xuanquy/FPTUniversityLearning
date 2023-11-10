using BusinessObject;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DataAccess
{
    public class MemberDAO
    {
        // Get default user from appsettings
        private MemberObject GetDefaultMember()
        {
            MemberObject Default = null;
            using (StreamReader r = new StreamReader("appsettings.json"))
            {
                string json = r.ReadToEnd();
                IConfiguration config = new ConfigurationBuilder()
                                        .SetBasePath(Directory.GetCurrentDirectory())
                                        .AddJsonFile("appsettings.json", true, true)
                                        .Build();
                string email = config["account:defaultAccount:email"];
                string password = config["account:defaultAccount:password"];
                Default = new MemberObject
                {
                    MemberID = 1,
                    Email = email,
                    Password = password,
                    City = "",
                    Country = "",
                    MemberName = "Admin"
                };
            }

            return Default;
        }

        // Initialize MemberList
        private static List<MemberObject> members = new List<MemberObject>
        {
            new MemberObject
            {
                MemberID = 2,
                MemberName = "Xuân Quý",
                Email = "quy@fpt.edu.vn",
                Password = "123",
                City = "Ho Chi Minh City",
                Country = "Vietnam"
            },
            new MemberObject
            {
                MemberID = 3,
                MemberName = "Anh Khoa",
                Email = "khoa@fpt.edu.vn",
                Password = "123",
                City = "Hanoi",
                Country = "Vietnam"
            },
            new MemberObject
            {
                MemberID = 4,
                MemberName = "Hoàng Thái",
                Email = "thai@fpt.edu.vn",
                Password = "123",
                City = "Ho Chi Minh City",
                Country = "Vietnam"
            },
            new MemberObject
            {
                MemberID = 5,
                MemberName = "Đen",
                Email = "den@fpt.edu.vn",
                Password = "123",
                City = "New York",
                Country = "America"
            },
            new MemberObject
            {
                MemberID = 6,
                MemberName = "Karik",
                Email = "karik@fpt.edu.vn",
                Password = "123",
                City = "Lyon",
                Country = "France"
            },
            new MemberObject
            {
                MemberID = 7,
                MemberName = "Wowy",
                Email = "wowy@fpt.edu.vn",
                Password = "123",
                City = "Paris",
                Country = "France"
            },
            new MemberObject
            {
                MemberID = 8,
                MemberName = "Suboi",
                Email = "suboi@fpt.edu.vn",
                Password = "123",
                City = "Tokyo",
                Country = "Japan"
            },
            new MemberObject
            {
                MemberID = 9,
                MemberName = "BinZ",
                Email = "binz@fpt.edu.vn",
                Password = "123",
                City = "Cairo",
                Country = "Egypt"
            },
            new MemberObject
            {
                MemberID = 10,
                MemberName = "Rhymastic",
                Email = "rhymastic@fpt.edu.vn",
                Password = "123",
                City = "Yaounde",
                Country = "Cameroon"
            },
            new MemberObject
            {
                MemberID = 11,
                MemberName = "JustaTee",
                Email = "justatee@fpt.edu.vn",
                Password = "123",
                City = "Yaounde",
                Country = "Cameroon"
            },
            new MemberObject
            {
                MemberID = 12,
                MemberName = "LK",
                Email = "lk@fpt.edu.vn",
                Password = "123",
                City = "Douala",
                Country = "Cameroon"
            },
            new MemberObject
            {
                MemberID = 13,
                MemberName = "Touliver",
                Email = "touliver@fpt.edu.vn",
                Password = "123",
                City = "Cairo",
                Country = "Egypt"
            }
        };
        private MemberDAO()
        {
            MemberObject DefaultAdmin = GetDefaultMember();
            if (DefaultAdmin != null)
            {
                members.Add(DefaultAdmin);
            }
        }

        // Using Singleton Pattern
        private static MemberDAO instance = null;
        private static object instanceLook = new object();

        public static MemberDAO Instance
        {
            get
            {
                lock (instanceLook)
                {
                    if (instance == null)
                    {
                        instance = new MemberDAO();
                    }
                    return instance;
                }
            }
        }

//--------------------------------------------------------------------------------------------
        //get Member List
        public List<MemberObject> GetMembersList => members;
//--------------------------------------------------------------------------------------------
        public MemberObject Login(string Email, string Password)
        {
            MemberObject member = members.SingleOrDefault(mb => mb.Email.Equals(Email) && mb.Password.Equals(Password));
            return member;
        }
//--------------------------------------------------------------------------------------------
        //getMember by ID
        public MemberObject GetMemberByID(int MemberId)
        {
            MemberObject member = members.SingleOrDefault(mb => mb.MemberID == MemberId);
            return member;
            /*return members.SingleOrDefault(mb => mb.MemberID == MemberId);*/
        }

        //getMember by Email
        public MemberObject GetMemberByEmail(string MemberEmail)
        {
            MemberObject member = members.SingleOrDefault(mb => mb.Email.Equals(MemberEmail));
            return member;
           /* return members.SingleOrDefault(mb => mb.Email.Equals(MemberEmail));*/
        }
//--------------------------------------------------------------------------------------------
        //add new Member
        public void AddMember(MemberObject member)
        {
            if (member == null)
            {
                throw new Exception("Member is undefined!!!");
            }
            MemberObject mem = GetMemberByID(member.MemberID);
            if (mem != null)
            {
                members.Add(member);
            } else
            {
                throw new Exception("Member is existed.");
            }
        }

        //update Member
        public void Update(MemberObject member)
        {
            if (member == null)
            {
                throw new Exception("Member is undefined!!!");
            }
            MemberObject mem = GetMemberByID(member.MemberID);
            if (mem != null)
            {
                var index = members.IndexOf(mem);
                members[index] = member;
            } else
            {
                throw new Exception("Member does not exist.");
            }
        }

        //delete Member
        public void Delete(int MemberId)
        {
            MemberObject member = GetMemberByID(MemberId);
            if (member != null)
            {
                members.Remove(member);
            } else
            {
                throw new Exception("Member does not exist.");
            }
        }

        //search member by ID
        public IEnumerable<MemberObject> SearchMemberByID(int id)
        {
            IEnumerable<MemberObject> searchResult = null;

            var memberSearch = from member in members
                               where member.MemberID == id
                               select member;
            searchResult = memberSearch;

            return searchResult;
        }

        //search member by Name
        public IEnumerable<MemberObject> SearchMemberByName(string name)
        {
            IEnumerable<MemberObject> searchResult = null;

            var memberSearch = from member in members
                               where member.MemberName.ToLower().Contains(name.ToLower())
                               select member;
            searchResult = memberSearch;

            return searchResult;
        }

        //filter member by Country
        public IEnumerable<MemberObject> FilterMemberByCountry(string country, IEnumerable<MemberObject> searchList)
        {
            IEnumerable<MemberObject> searchResult = null;

            var memberSearch = from member in searchList
                               where member.Country == country
                               select member;
            if (country.Equals("All"))
            {
                memberSearch = from member in searchList
                               select member;
            }
            searchResult = memberSearch;

            return searchResult;
        }

        //filter member by City in a Country
        public IEnumerable<MemberObject> FilterMemberByCity(string country, string city, IEnumerable<MemberObject> searchList)
        {
            IEnumerable<MemberObject> searchResult = null;

            var memberSearch = from member in searchList
                               where member.City == city
                               select member;
            if (city.Equals("All"))
            {
                memberSearch = from member in searchList
                               where member.Country == country
                               select member;
                if (country.Equals("All"))
                {
                    memberSearch = from member in searchList
                                   select member;
                }
            }
            searchResult = memberSearch;

            return searchResult;
        }
    }
}
