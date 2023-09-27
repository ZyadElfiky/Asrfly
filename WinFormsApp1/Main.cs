using Asrfly.Code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asrfly
{
    public partial class Main : Form
    {
        private readonly PageManager pageManager;
        public Main()
        {
            InitializeComponent();
            pageManager = new PageManager(this);

            // Make Home Page as a Start Page
            pageManager.LoadPage(Gui.HomeGui.HomeUserControl.Instance());

        }
        #region Events
        private void buttonHome_Click(object sender, EventArgs e)
        {
            // Load Home Page
            pageManager.LoadPage(Gui.HomeGui.HomeUserControl.Instance());
        }


        #endregion

        private void buttonCategories_Click(object sender, EventArgs e)
        {
            // Load Categories Page
            pageManager.LoadPage(Gui.CategoriesGui.CategoryUserControl.Instance());
        }
    }
}
