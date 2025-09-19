
namespace Migration_service.Controller
{
    class ConnectionString
    {
        public static string ConnStr
        {
            get { return "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|/App_Data/Миграционная_служба.mdb"; }
        }
    }
}
