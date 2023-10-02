using Core.Entities.Concrete;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Security.Jwt
{
    public interface ITokenHelper
    {
        AccessToken CreateToken(UserAssertion user,List<OperationClaim> operationClaims);
        //AccessToken CreateToken(UserAssertion user, List<OperationClaim> operationClaims);
    }
}
