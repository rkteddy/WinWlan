using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using WinWlan.Model;
using WinWlan.DataHelper;

namespace WinWlan.ViewModel
{
    class WlanListViewModel
    {
        public ObservableCollection<Wlan> WlanList { get; private set; }

        public WlanListViewModel()
        {
            WlanList = WlanDataHelper.GetWlans();
        }
    }
}
