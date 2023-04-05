using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace StorageManager.ErrorHandler
{
    class Handle
    {
        public static void WriteError(string error)
        {
            if (!Directory.Exists(@"Errors"))
            {
                Directory.CreateDirectory(@"Errors");
            }
            else
            {
                File.AppendAllText(@"Errors/error_log.txt", "[" + DateTime.Now.ToString() + "]" + error + Environment.NewLine);
            }
        }
    }
}
