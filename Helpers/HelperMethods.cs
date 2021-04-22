namespace eligibility_checker.Helpers
{
    /// <summary>
    /// Helper methods.
    /// </summary>
    public static class HelperMethods
    {
        /// <summary>
        /// This determines what env the app is in and provides the create link to the app.
        /// </summary>
        /// <param name="environment"></param>
        /// <returns></returns>
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