using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace OA.WASM.Services.Auth.Extention
{
    public static class ClaimPrencipalExtentions
    {

        public static bool HasClaimPremission(this ClaimsPrincipal user, string claimPremission)
        {
            var claims = user?.Claims?.Where(c => c.Type == "Permission" && c.Value == claimPremission);

            return claims != null && claims.Count() > 0;
        }

        public static string GetPositionClaim(this ClaimsPrincipal user)
        {
            var positionClaims = user?.Claims?.Where(c => c.Type == "Permission" && c.Value.Contains("position"));

            return (positionClaims.Count() == 1) ? positionClaims.FirstOrDefault().Value : "";

        }

        public static List<string> PositionsClaims = new List<string>()
        {
            "position-loan-officer",
            "position-supervisor",
            "position-credit-empl",
            "position-credit-manager",
            "position-risk-empl",
            "position-risk-manager",
            "position-branches-manager",
            "position-ceo"
        };

    }
}
