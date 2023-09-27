using Asrfly.Gui.HomeGui;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asrfly.Gui.CategoriesGui
{
    public partial class CategoryUserControl : UserControl
    {
        // variables
        private static CategoryUserControl _instance;
        public CategoryUserControl()
        {
            InitializeComponent();
        }
        #region Methods
        public static CategoryUserControl Instance()
        {
            return _instance ?? (new CategoryUserControl());
        }
        #endregion
        #region Events
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddCategoryForm addCategoryForm =new AddCategoryForm();
            addCategoryForm.Show();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            Code.MessageCollection.ShowEmptyDataMessage();
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {

        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        #endregion
    }
}
