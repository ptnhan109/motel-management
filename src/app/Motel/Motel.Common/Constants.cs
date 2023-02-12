namespace Motel.Common
{
    public class Constants
    {
        public const string AppName = "iMoma";

        public const string Authorization = nameof(Authorization);

        public class Url
        {
            public const string Android = "http://192.168.0.101:8080";

            public const string Authenticate = $"{Android}/api/Auth";
        }
    }
}