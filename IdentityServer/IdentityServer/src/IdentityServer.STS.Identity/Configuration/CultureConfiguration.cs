using System.Collections.Generic;

namespace IdentityServer.STS.Identity.Configuration
{
    public class CultureConfiguration
    {
        //public static readonly string[] AvailableCultures = { "en", "fr", "ru", "es", "de" };
        //public static readonly string DefaultRequestCulture = "en";

        public List<string> Cultures { get; set; }
        public string DefaultCulture { get; set; }
    }
}