namespace RealEstate_Dapper_Api.Tools
{
    public class JwtTokenDefaults
    {
        public const string ValidAudience = ("https://localhost");
        public const string ValidIssuer= ("https://localhost");
        public const string Key = "RealEstate..0102030405Asp.netCore9.0.1+-";
        public const int Expire = 5;
    }
}
