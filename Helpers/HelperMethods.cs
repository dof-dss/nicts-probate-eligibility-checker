namespace eligibility_checker.Helpers
{
    /// <summary>
    /// Helper methods.
    /// </summary>
    public static class HelperMethods
    {
        /// <summary>
        /// This determines what env the app is in and provides the citizen link to the app.
        /// </summary>
        /// <param name="environment"></param>
        /// <returns></returns>
        public static string GetCitizenLink(string environment)
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

        /// <summary>
        /// This determines what env the app is in and provides the citizen link to the app for caveat.
        /// </summary>
        /// <param name="environment"></param>
        /// <returns></returns>
        public static string GetCitizenLinkCaveat(string environment)
        {
            string urlToReturn = string.Empty;

            switch (environment)
            {
                case "Development":
                    urlToReturn = "https://nicts-probate-sandbox.london.cloudapps.digital/Caveat";
                    break;

                case "Sandbox":
                    urlToReturn = "https://nicts-probate-sandbox.london.cloudapps.digital/Caveat";
                    break;

                case "Staging":
                    urlToReturn = "https://nicts-probate-staging.london.cloudapps.digital/Caveat";
                    break;

                case "Production":
                    urlToReturn = "https://apply-for-probate.nidirect.gov.uk/Caveat";
                    break;

                default:
                    break;
            }

            return urlToReturn;
        }

        /// <summary>
        /// This determines what env the app is in and provides the solicitor link to the app.
        /// </summary>
        /// <param name="environment"></param>
        /// <returns></returns>
        public static string GetSolicitorLink(string environment)
        {
            string urlToReturn = string.Empty;

            switch (environment)
            {
                case "Development":
                    urlToReturn = "https://nicts-probate-solicitor-sandbox.london.cloudapps.digital/Dashboard";
                    break;

                case "Sandbox":
                    urlToReturn = "https://nicts-probate-solicitor-sandbox.london.cloudapps.digital/Dashboard";
                    break;

                case "Staging":
                    urlToReturn = "https://nicts-probate-solicitor-staging.london.cloudapps.digital/Dashboard";
                    break;

                case "Production":
                    urlToReturn = "https://apply-for-probate-professional.nidirect.gov.uk/Dashboard";
                    break;

                default:
                    break;
            }

            return urlToReturn;
        }

        /// <summary>
        /// This determines what env the app is in and provides the solicitor link to the app for caveat.
        /// </summary>
        /// <param name="environment"></param>
        /// <returns></returns>
        public static string GetSolicitorLinkCaveat(string environment)
        {
            string urlToReturn = string.Empty;

            switch (environment)
            {
                case "Development":
                    urlToReturn = "https://nicts-probate-solicitor-sandbox.london.cloudapps.digital/Caveat";
                    break;

                case "Sandbox":
                    urlToReturn = "https://nicts-probate-solicitor-sandbox.london.cloudapps.digital/Caveat";
                    break;

                case "Staging":
                    urlToReturn = "https://nicts-probate-solicitor-staging.london.cloudapps.digital/Caveat";
                    break;

                case "Production":
                    urlToReturn = "https://apply-for-probate-professional.nidirect.gov.uk/Caveat";
                    break;

                default:
                    break;
            }

            return urlToReturn;
        }
    }
}