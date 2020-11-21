using System;
using System.Collections.Generic;
using Aplikacja_X.Droid;
using Xamarin.Forms;
using System.Diagnostics;
using MySqlConnector;
using System.Data;
using Aplikacja_X.Database;
using System.Reflection;
using Aplikacja_X.Returning_resources;
using System.Collections.ObjectModel;

[assembly: Dependency(typeof(DatabaseAndroid))]
namespace Aplikacja_X.Droid
{
    class DatabaseAndroid : IDatabase
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
            else {
                conn.Close();
            }

            return conn;
        }

        public List<HobbiesCategories> HobbiesList(int data_processing, MySqlConnection msc)
        {
            List<HobbiesCategories> hobbies_categories = new List<HobbiesCategories>();

            try
            {
                MySqlConnection conn = msc;
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "Select id_hc, name, picture_name, description, `order` From hobby_categories ORDER BY `order`;";

                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    var assembly = typeof(EmbeddedImage).GetTypeInfo().Assembly;
                    var my_image_source = ImageSource.FromResource("Aplikacja_X.Images." + dr["picture_name"].ToString(), assembly);
                    hobbies_categories.Add(new HobbiesCategories(Convert.ToInt32(dr["id_hc"].ToString()), dr["name"].ToString(), dr["picture_name"].ToString(), dr["description"].ToString(), Convert.ToInt32(dr["order"].ToString()), my_image_source));
                }

                if (data_processing == 0)
                {
                    foreach (HobbiesCategories hobbie_category in hobbies_categories)
                    {
                        Debug.WriteLine($"-------------------------------------------\n {hobbie_category.Id_hc}\n {hobbie_category.Name}\n {hobbie_category.Picture}\n {hobbie_category.Description}\n {hobbie_category.Order}\n -------------------------------------------\n");
                    }

                    return hobbies_categories;
                }
                else if (data_processing == 1)
                {
                    return hobbies_categories;
                }
                else
                {
                    return hobbies_categories;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"-------------------------------------------\n Not Connected ...\n {ex.Message}\n -------------------------------------------\n");
                return hobbies_categories;
            }
        }

        public ObservableCollection<HobbiesCategories> HobbiesOC(int data_processing, MySqlConnection msc)
        {
            ObservableCollection<HobbiesCategories> hobbies_categories = new ObservableCollection<HobbiesCategories>();

            try
            {
                MySqlConnection conn = msc;
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "Select id_hc, name, picture_name, description, `order` From hobby_categories ORDER BY `order`;";

                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    var assembly = typeof(EmbeddedImage).GetTypeInfo().Assembly;
                    var my_image_source = ImageSource.FromResource("Aplikacja_X.Images." + dr["picture_name"].ToString(), assembly);
                    hobbies_categories.Add(new HobbiesCategories(Convert.ToInt32(dr["id_hc"].ToString()), dr["name"].ToString(), dr["picture_name"].ToString(), dr["description"].ToString(), Convert.ToInt32(dr["order"].ToString()), my_image_source));
                }

                if (data_processing == 0)
                {
                    foreach (HobbiesCategories hobbie_category in hobbies_categories)
                    {
                        Debug.WriteLine($"-------------------------------------------\n {hobbie_category.Id_hc}\n {hobbie_category.Name}\n {hobbie_category.Picture}\n {hobbie_category.Description}\n {hobbie_category.Order}\n -------------------------------------------\n");
                    }

                    return hobbies_categories;
                }
                else if (data_processing == 1)
                {
                    return hobbies_categories;
                }
                else
                {
                    return hobbies_categories;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"-------------------------------------------\n Not Connected ...\n {ex.Message}\n -------------------------------------------\n");
                return hobbies_categories;
            }
        }

        public ObservableCollection<Jobs> JobList(int data_processing, MySqlConnection msc)
        {
            ObservableCollection<Jobs> jobs = new ObservableCollection<Jobs>();

            try
            {
                MySqlConnection conn = msc;
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "Select * From jobs;";

                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    var assembly = typeof(EmbeddedImage).GetTypeInfo().Assembly;
                    var my_image_source = ImageSource.FromResource("Aplikacja_X.Images." + dr["picture_name"].ToString(), assembly);
                    jobs.Add(new Jobs(Convert.ToInt32(dr["id_j"].ToString()), dr["name"].ToString(), dr["business"].ToString(), dr["page"].ToString(), dr["start_date"].ToString(), dr["end_date"].ToString(), dr["city"].ToString(), dr["country"].ToString(), dr["created_at"].ToString(), dr["updated_at"].ToString(), dr["deleted_at"].ToString(), my_image_source));
                }

                if (data_processing == 0)
                {
                    foreach (Jobs job in jobs)
                    {
                        Debug.WriteLine($"-------------------------------------------\n {job.Id_j}\n {job.Name}\n {job.Business}\n {job.Page}\n {job.Start_date}\n {job.End_date}\n {job.City}\n {job.Country}\n {job.Created_at}\n {job.Updated_at}\n {job.Deleted_at}\n {job.Picture_image_source}\n -------------------------------------------\n");
                    }

                    return jobs;
                }
                else if (data_processing == 1)
                {
                    return jobs;
                }
                else {
                    return jobs;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"-------------------------------------------\n Not Connected ...\n {ex.Message}\n -------------------------------------------\n");
                return jobs;
            }
        }

        public List<Titles> TitleList(int data_processing, MySqlConnection msc)
        {
            List<Titles> titles = new List<Titles>();

            try
            {
                MySqlConnection conn = msc;
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "Select * From education;";

                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    titles.Add(new Titles(Convert.ToInt32(dr["id_e"].ToString()), dr["school"].ToString(), dr["school_website"].ToString(), dr["direction"].ToString(), dr["specialization"].ToString(), Convert.ToInt32(dr["start_year"].ToString()), Convert.ToInt32(dr["end_year"].ToString()), dr["academic_title"].ToString()));
                }

                if (data_processing == 0)
                {
                    foreach (Titles title in titles)
                    {
                        Debug.WriteLine($"-------------------------------------------\n {title.Id_e}\n {title.School}\n {title.School_website}\n {title.Direction}\n {title.Specialization}\n {title.Start_year}\n {title.End_year}\n {title.Academic_title}\n -------------------------------------------\n");
                    }

                    return titles;
                }
                else if (data_processing == 1)
                {
                    return titles;
                }
                else
                {
                    return titles;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"-------------------------------------------\n Not Connected ...\n {ex.Message}\n -------------------------------------------\n");
                return titles;
            }
        }
    }
}