using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eligibility_checker.Helpers
{
    /// <summary>
    /// Helper methods.
    /// </summary>
    public static class HelperMethods
    {
        public static string GetVerifyLink(string environment)
        {
            string urlToReturn = string.Empty;

            switch (environment)
            {
                case "Development":
                    urlToReturn = "https://nicts-probate-sandbox.london.cloudapps.digital/Dashboard";
                    break;

                case "Sandbox":
                    urlToReturn = "https://nicts-probate-sandbox.london.cloudapps.digital/Dashboard";
                    break;

                case "Staging":
                    urlToReturn = "https://nicts-probate-staging.london.cloudapps.digital/Dashboard";
                    break;

                case "Production":
                    urlToReturn = "https://apply-for-probate.nidirect.gov.uk/Dashboard";
                    break;

                default:
                    break;
            }

            return urlToReturn;
        }
    }
}