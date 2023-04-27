using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
//using System.Windows.Shapes;
using CommunityToolkit.Common;
using CommunityToolkit.Mvvm;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace RevitAddinManager
{
    public sealed partial class ViewModel : ObservableObject
    {
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(VersionBox))]
        private List<string> versions;
        public ObservableCollection<string> VersionBox => new ObservableCollection<string>();

        #region Commands
        /// <summary>
        /// 启用开关
        /// </summary>
        [RelayCommand]
        private void EnableOrDisable() { }

        /// <summary>
        /// 全选
        /// </summary>
        [RelayCommand]
        public void SelectAll()
        {
        }

        /// <summary>
        /// 反选
        /// </summary>
        [RelayCommand]
        private void Invert()
        {

        }

        /// <summary>
        /// 选择启用
        /// </summary>
        [RelayCommand]
        private void SelectEnabled()
        {

        }

        /// <summary>
        /// 选择禁用
        /// </summary>
        [RelayCommand]
        private void SelectDisabled() { }

        /// <summary>
        /// 打开路径
        /// </summary>
        [RelayCommand]
        private void Open()
        {
        }
        #endregion
    }
}
