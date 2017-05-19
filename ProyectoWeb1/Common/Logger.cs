using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace ProyectoWeb1.Common
{
    public static class Logger
    {
        public static void Log(string mensaje)
        {
            File.AppendAllText(@"C:\Users\VAIO\Desktop\ProyectoWeb1\ArchivoLogs.txt", string.Format("{0} - INFO: {1}", DateTime.Now , mensaje + Environment.NewLine));
        }
    }
}