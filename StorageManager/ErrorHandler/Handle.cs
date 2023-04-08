using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms.VisualStyles;

namespace StorageManager.ErrorHandler
{
    class Handle
    {
        class ErrorCode
        {
            public IDictionary<int, string> codeErrors = new Dictionary<int, string>();
        }
        public static void WriteError(string error)
        {
            if (!Directory.Exists(@"Errors"))
            {
                Directory.CreateDirectory(@"Errors");
            }
            else
            {
                File.AppendAllText(@"Errors/error_log.txt", "[" + DateTime.Now.ToString() + "] > " + error + Environment.NewLine);
            }
        }
        public static string getErrorInfo(int errorCode)
        {
            ErrorCode errorCodes = new ErrorCode();
            if (errorCodes.codeErrors.ContainsKey(errorCode))
            {
                // TODO
            }
            else
            {
                // TODO
            }
            return "";
        }
    }
}
