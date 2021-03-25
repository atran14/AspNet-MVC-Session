using Microsoft.AspNetCore.Mvc;

namespace AspNet_MVC_Session.Filters
{
    public class AuthorizeFilter : TypeFilterAttribute
    {

        private readonly string  _roleName;
        //todo complete the authorization filter
        public AuthorizeFilter(string roleName)
            : base(typeof(AuthorizeFilter))
        {
            this._roleName = roleName;
        }        
    }
}