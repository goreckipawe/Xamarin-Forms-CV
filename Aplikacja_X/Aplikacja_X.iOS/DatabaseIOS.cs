using System;
using System.Collections.Generic;
using Aplikacja_X.iOS;
using Xamarin.Forms;
using System.Diagnostics;
using MySqlConnector;
using System.Data;
using Aplikacja_X.Database;
using System.Collections.ObjectModel;

[assembly: Dependency(typeof(DatabaseIOS))]
namespace Aplikacja_X.iOS
{
    class DatabaseIOS : IDatabase
    {
        public MySqlConnection DatabaseConnection(int connection_open_close)
        {
            MySqlConnectionStringBuilder con = new MySqlConnectionStringBuilder();

            con.Server = "10.0.2.2";
            con.Port = 3303;
            con.UserID = "root";
            con.Password = "kajak";
            con.Database = "cv";
            con.ConnectionTimeout = 200;

            MySqlConnection conn = new MySqlConnection(con.ToString());

            if (connection_open_close == 1)
            {
                conn.Open();
            }
            else
            {
                conn.Close();
            }

            return conn;
        }

        public List<HobbiesCategories> HobbiesList(int data_processing, MySqlConnection msc)
        {
            throw new NotImplementedException();
        }

        public ObservableCollection<HobbiesCategories> HobbiesOC(int data_processing, MySqlConnection msc)
        {
            throw new NotImplementedException();
        }

        public ObservableCollection<Jobs> JobList(int data_processing, MySqlConnection msc)
        {
            ObservableCollection<Jobs> jobs = new ObservableCollection<Jobs>();

            try
            {
                MySqlConnection conn = msc;
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "Select * From jobs";

                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    jobs.Add(new Jobs((int)dr["id_j"], dr["name"].ToString(), dr["business"].ToString(), dr["page"].ToString(), dr["start_date"].ToString(), dr["end_date"].ToString(), dr["city"].ToString(), dr["country"].ToString(), dr["created_at"].ToString(), dr["updated_at"].ToString(), dr["deleted_at"].ToString()));
                }

                if (data_processing == 0)
                {
                    foreach (Jobs job in jobs)
                    {
                        Debug.WriteLine(job);
                    }

                    return jobs;
                }
                else if (data_processing == 1)
                {
                    return jobs;
                }
                else
                {
                    return jobs;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Not Connected ...");
                Debug.WriteLine(ex.Message);
                return jobs;
            }
        }

        public List<Titles> TitleList(int data_processing, MySqlConnection msc)
        {
            throw new NotImplementedException();
        }
    }
}