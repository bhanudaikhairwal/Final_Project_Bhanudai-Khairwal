using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace Final_Project
{
    public class MYPAGES
    {
        private static string User { get { return "bhanu"; } }
        private static string Password { get { return "test"; } }
        private static string Database { get { return "mypages"; } }
        private static string Server { get { return "localhost"; } }
        private static string Port { get { return "3306"; } }

        
        private static string ConnectionString
        {
            get
            {
                return "server = " + Server
                    + "; user = " + User
                    + "; database = " + Database
                    + "; port = " + Port
                    + "; password = " + Password;
            }
        }

        public List<Dictionary<String, String>> List_Query(string query)
        {

            MySqlConnection Connect = new MySqlConnection(ConnectionString);
            List<Dictionary<String, String>> ResultSet = new List<Dictionary<String, String>>();


            try
            {
                Debug.WriteLine("Connection Initialized...");
                Debug.WriteLine("Attempting to execute query " + query);

                Connect.Open();

                MySqlCommand cmd = new MySqlCommand(query, Connect);

                MySqlDataReader resultset = cmd.ExecuteReader();


                while (resultset.Read())
                {
                    Dictionary<String, String> Row = new Dictionary<String, String>();

                    for (int i = 0; i < resultset.FieldCount; i++)
                    {
                        Row.Add(resultset.GetName(i), resultset.GetString(i));

                    }

                    ResultSet.Add(Row);
                }
                resultset.Close();


            }
            catch (Exception ex)
            {
                Debug.WriteLine("Something went wrong in the List_Query method!");
                Debug.WriteLine(ex.ToString());

            }

            Connect.Close();
            Debug.WriteLine("Database Connection Terminated.");

            return ResultSet;
        }
        public Dictionary<String, String> FindPage(int id)
        {
           
            MySqlConnection Connect = new MySqlConnection(ConnectionString);
            
            Dictionary<String, String> page = new Dictionary<String, String>();

            try
            {
                string query = "select * from pages where pageid = " + id;
                Debug.WriteLine("Connection Initialized...");
                
                Connect.Open();
               
                MySqlCommand cmd = new MySqlCommand(query, Connect);
                
                MySqlDataReader resultset = cmd.ExecuteReader();

                
                List<Dictionary<String, String>> Pages = new List<Dictionary<String, String>>();

                
                while (resultset.Read())
                {
                   
                    Dictionary<String, String> Page = new Dictionary<String, String>();

                    
                    for (int i = 0; i < resultset.FieldCount; i++)
                    {
                        Debug.WriteLine("Attempting to transfer data of " + resultset.GetName(i));
                        Debug.WriteLine("Attempting to transfer data of " + resultset.GetString(i));
                        Page.Add(resultset.GetName(i), resultset.GetString(i));

                    }
                    
                    Pages.Add(Page);
                }

                page = Pages[0]; 

            }
            catch (Exception ex)
            {
                
                Debug.WriteLine("Something went wrong in the find Student method!");
                Debug.WriteLine(ex.ToString());
            }

            Connect.Close();
            Debug.WriteLine("Database Connection Terminated.");

            return page;
        }
    }
}