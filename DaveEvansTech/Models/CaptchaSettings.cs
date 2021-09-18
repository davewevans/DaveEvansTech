namespace DaveEvansTech.Models
{
    public class CaptchaSettings
    {
        public const string V2 = "V2";
        public const string V3 = "V3";

        public string SiteKey { get; set; }
        public string SecretKey { get; set; }
    }
}