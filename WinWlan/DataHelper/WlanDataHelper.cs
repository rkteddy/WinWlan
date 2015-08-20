using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using WinWlan.Model;

namespace WinWlan.DataHelper
{
    class WlanDataHelper
    {
        public static ObservableCollection<Wlan> GetWlans()
        {
            ObservableCollection<Wlan> sampleWlan = new ObservableCollection<Wlan>();
            sampleWlan.Add(new Wlan() { name = "a", rssi = "1", ssid = "2" });
            return sampleWlan;
        }
    }
}
