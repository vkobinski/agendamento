namespace AgendamentoCliente.Models
{
    internal static class Utils
    {
        //private static string ip = "http://154.56.43.220:8080";
        private static string ip = "http://192.168.2.101:8080";
        public static string GetIp(string path)
        {
            return ip + path;
        }
    }
}
