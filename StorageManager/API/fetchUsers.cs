using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
public class UserDetails
{
    public string User
    {
        get;
        set;
    }
    public string UserWorkplace
    {
        get;
        set;
    }
    public string UserPosition
    {
        get;
        set;
    }
    public double UserSalary
    {
        get;
        set;
    }
    public bool UserCanEditItems
    {
        get;
        set;
    }
    public string UserSalaryCurrency
    {
        get;
        set;
    }
}

public class Program
{
    public static MySqlConnection connection
    {
        get;
        set;
    }
    public static string server
    {
        get;
        set;
    }
    public static string database
    {
        get;
        set;
    }
    public static string user
    {
        get;
        set;
    }
    public static string password
    {
        get;
        set;
    }
    public static string port
    {
        get;
        set;
    }
    public static string connectionString
    {
        get;
        set;
    }
    public static string sslM
    {
        get;
        set;
    }
    public static string conString
    {
        get;
        set;
    }
    public static bool connected
    {
        get;
        set;
    }
    public static void Run()
    {
        MySqlCommand getUsers = new MySqlCommand("SELECT * FROM users_details", StorageManager.Databases.Project.projectDatabase.connection);
        List<UserDetails> userDetailsList = new List<UserDetails>();
        using (MySqlDataReader reader = getUsers.ExecuteReader())
        {
            while (reader.Read())
            {
                userDetailsList.Add(new UserDetails
                {
                    User = reader.GetString(0),
                    UserWorkplace = reader.GetString(1),
                    UserPosition = reader.GetString(2),
                    UserSalary = reader.GetDouble(3),
                    UserCanEditItems = reader.GetBoolean(4),
                    UserSalaryCurrency = reader.GetString(5),
                });
            }

        }
        for (int i = 0; i < userDetailsList.Count; i++)
        {
            Console.WriteLine($"Username: {userDetailsList[i].User} | WorkPlace: {userDetailsList[i].UserWorkplace} | Position : {userDetailsList[i].UserPosition} | Salary: {userDetailsList[i].UserSalary} | Can Edit Items: {userDetailsList[i].UserCanEditItems} | Currency: {userDetailsList[i].UserSalaryCurrency}");
        }
    }
}