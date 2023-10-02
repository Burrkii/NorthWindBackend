using Core.Utilities.Security.Jwt;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SecurityKey = Microsoft.IdentityModel.Tokens.SecurityKey;
using SymmetricSecurityKey = Microsoft.IdentityModel.Tokens.SymmetricSecurityKey;

namespace Core.Utilities.Security.Encypiton
{
    public class SecurityKeyHelper
    {
        public static SecurityKey CreateSecurityKey(string securityKey)
        {
           return new SymmetricSecurityKey(Encoding.UTF8.GetBytes(securityKey));
        }
    }
}
