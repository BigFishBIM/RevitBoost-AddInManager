using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;

namespace RevitAddinManager
{
    public class Addin : INotifyPropertyChanged
    {
        private string _name;

        private string _version;

        private string _path;

        private string _enabled;

        private string _aa;

        public Addin(string name, string version, string path, string enabled,string aa) : base()
        {
            _name = name;
            _version = version;
            _path = path;
            _enabled = enabled;
        }

        public string Name
        {
            get { return  _name; }
            set
            {
                _name = value;
                OnPropertyChanged("Name");
            }
        }

        public string Version
        {
            get { return _version; }
            set
            {
                _version = value;
                OnPropertyChanged("Version");
            }
        }

        public string Path
        {
            get { return _path; }
            set
            {
                _path = value;
                OnPropertyChanged("Path");
            }
        }

        public string Enabled
        {
            get { return _enabled; }
            set
            {
                _enabled = value;
                OnPropertyChanged("Enabled");
            }
        }

        public string AA
        {
            get { return _aa; }
            set
            {
                _aa  = value;
                OnPropertyChanged("AA");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string info)
        {
            var handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(info));
        }
    }
}
