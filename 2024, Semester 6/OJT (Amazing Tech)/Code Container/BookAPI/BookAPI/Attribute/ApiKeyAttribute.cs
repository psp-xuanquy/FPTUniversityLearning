using BookAPI.Extensions;
using DocnetCorePractice.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace BookAPI.Attribute
{
    public class ApiKeyAttribute : ServiceFilterAttribute
    {
        public ApiKeyAttribute()
            : base(typeof(ApiKeyAuthorizationFilter))
        {
        }
    }
}
