using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;

namespace RevitAddinManager
{
    public sealed partial class Addin : ObservableObject
    {
        [ObservableProperty]
        private string fileName;

        [ObservableProperty]
        private string name;

        [ObservableProperty]
        private string version;

        [ObservableProperty]
        private string filepath;

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(FileName))]
        private bool enabled;

        public Addin(string name, string version, string path, bool enabled)
        {
            this.filepath = path;
            this.name = name;
            this.version = version;
            this.enabled = enabled;
            this.fileName = System.IO.Path.GetFileName(path);
        }

        //TODO: Enabled 改了之后，文件名跟着修改

    }
}
