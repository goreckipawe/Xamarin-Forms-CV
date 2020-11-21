using System.Collections.Generic;
using System.Collections.ObjectModel;
using Aplikacja_X.Database;
using MySqlConnector;

namespace Aplikacja_X
{
    public interface IDatabase
    {
        MySqlConnection DatabaseConnection(int connection_open_close);
        ObservableCollection<Jobs> JobList(int data_processing, MySqlConnection msc);
        List<Titles> TitleList(int data_processing, MySqlConnection msc);
        List<HobbiesCategories> HobbiesList(int data_processing, MySqlConnection msc);
        ObservableCollection<HobbiesCategories> HobbiesOC(int data_processing, MySqlConnection msc);
    }
}
