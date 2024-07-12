using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormsApp2.Class
{
    internal class dBFunctions
    {
        public static string ConnectionStringSQLite
        { 
        get
            {

                string database = AppDomain.CurrentDomain.BaseDirectory +
                    "\\DataBase\\Contact_files\\Database\\Contact.s3db";
                string connectionString = @"Data Source=" + database;
                return connectionString;
            }
        }
    }
}
