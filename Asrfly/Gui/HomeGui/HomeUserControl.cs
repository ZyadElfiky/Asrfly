using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asrfly.Gui.HomeGui
{
    public partial class HomeUserControl : UserControl
    {

        private static HomeUserControl _instance;
        public HomeUserControl()
        {
            InitializeComponent();
        }

        public static HomeUserControl Instance()
        {
            return _instance?? (new HomeUserControl());
        }
    }
}
