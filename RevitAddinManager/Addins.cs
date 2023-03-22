using System.Collections.ObjectModel;

namespace RevitAddinManager
{
    public class Addins : ObservableCollection<Addin>
    {
        public Addins()
        {
            Add(new Addin("Michael", "2016", "Bellevue", "yes", "aa"));
            Add(new Addin("Jeff", "2017", "Redmond", "yes", "bb"));
            Add(new Addin("Christina", "2018", "Kirkland", "yes","cc"));
            Add(new Addin("Samantha", "2018", "Seattle", "yes","dd"));
        }
    }
}
