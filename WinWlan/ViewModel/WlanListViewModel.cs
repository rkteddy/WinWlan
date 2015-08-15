using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using WinWlan.Model;

namespace WinWlan.ViewModel
{
    class WlanListViewModel
    {
        public ObservableCollection<Wlan> List { get; private set; }

        public WlanListViewModel()
        {
            
        }
    }
}
