using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asrfly.Gui.GuiNotification
{
    public partial class NotificationForm : Form
    {
        public NotificationForm()
        {
            InitializeComponent();
            timerNotification.Interval = Properties.Settings.Default.HideNotificationInterval;
        }

        private void timerNotification_Tick(object sender, EventArgs e)
        {
            Close();
        }

        private void labelNotificationTitle_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
