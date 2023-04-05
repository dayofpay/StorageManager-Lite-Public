using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageManager.API
{
    class Info
    {
        public static string requestUsername { get; set; }
        public static string logUsername { get; set; }
        public static bool validLicense { get; set; }
        public static string sessionIp { get; set; }
        public static string sessionLicense { get; set; }
        public static int recoveryCode { get; set; }
        public static int getPin { get; set; }
        public static string getName { get; set; }
        public static string getWorkPlace { get; set; }
        public bool noProducts = false;
        public static string getRole { get; set; }
        public static double getSalary { get; set; }
        public static string getHostname { get; set; }
        public static bool canEditItems { get; set; }
        public static string salaryCurrency { get; set; }
        public static string getPersonName { get; set; }
        public static string getPhoneNum { get; set; }
        public static string getEmail { get; set; }
        public static string pregetPersonName { get; set; }
        public static string pregetPhoneNum { get; set; }
        public static string pregetEmail { get; set; }
        public static int totalStorages { get; set; }
        public static bool loggedWithPin { get; set; }
        public static List<string> storages = new List<string>();
        public static string productCheckName { get; set; }
        public static bool adminRights { get; set; }
    }
}
