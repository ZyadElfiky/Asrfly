﻿using Asrfly.Code;
using Asrfly.Core.Entities;
using Asrfly.Data.repo;
using Asrfly.Gui.HomeGui;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.Drawing.Spreadsheet;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asrfly.Gui.GuiCategories
{
    public partial class CategoryUserControl : UserControl
    {
        #region Variables
        private readonly IDataHelper<Categories> _dataHelperCategories;
        private readonly IDataHelper<SystemRecords> _dataHelperSystemRecords;
        private static CategoryUserControl _instance;
        private int _rowId;
        private List<int> _idList = new List<int>();
        private readonly GuiLoading.LoadingForm _loadingForm;
        #endregion
        public CategoryUserControl()
        {
            InitializeComponent();
            _dataHelperCategories = (IDataHelper<Categories>?)ConfigurationObjectManager.GetObject("Categories");
            _dataHelperSystemRecords = (IDataHelper<SystemRecords>?)ConfigurationObjectManager.GetObject("SystemRecords");
            _loadingForm= new GuiLoading.LoadingForm();
            LoadData();
        }

        #region Events
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddCategoryForm addCategoryForm = new AddCategoryForm(0, this);
            addCategoryForm.Show();
        }

        private async void buttonDelete_Click(object sender, EventArgs e)
        {
            if(dataGridView1.RowCount> 0)
            {
                var deleteResult = MessageCollection.ShowDeleteDialog();
                if (deleteResult)
                {
                   
                    SetRowIdForDelete();
                    _loadingForm.Show();
                    if(_idList != null)
                    {
                        for (int i = 0; i < _idList.Count; i++)
                        {
                            _rowId = _idList[i];
                            var result = await _dataHelperCategories.DeleteAsync(_rowId);
                            if (result == 1)
                            {
                                // Save System Records
                                SystemRecords systemRecords = new SystemRecords
                                {
                                    Title = "عملية حذف",
                                    UserName = Properties.Settings.Default.UserName,
                                    Details = "تم حذف صنف ذي الرقم التعريفي " +_rowId.ToString(),
                                    AddedDate = DateTime.Now
                                };
                                await _dataHelperSystemRecords.AddAsync(systemRecords);
                                MessageCollection.ShowDeleteNotification();

                            }
                            else
                            {
                                MessageCollection.ShowErrorServerMessage();
                            }
                            if (_idList != null)
                                _idList.Clear();
                        }
                        LoadData();

                    }
                    else
                    {
                        MessageCollection.ShowRequiredDeleteRowMessage();
                    }
                    _loadingForm.Hide();
                }
            }
            else
            {
                MessageCollection.ShowEmptyDataMessage();
            }
        }

     
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            Edit();
        }

        private async void buttonExport_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            // Convert List Of Data To Data Table
            _loadingForm.Show();
            var data = await _dataHelperCategories.GetAllDataAsync();
            using (var reader = FastMember.ObjectReader.Create(data))
            {
                dataTable.Load(reader);
            }
            _loadingForm.Hide();
            // Re-Set Columns
           DataTable dataTableArranged =SetDataTableColumns(dataTable);
            // Export Data As Sheet Excel
            ExportAsXlsxFile(dataTableArranged);
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Edit();
        }

        private void buttonReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }


        private async void comboBoxPageNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            _loadingForm.Show();
            var data = await _dataHelperCategories.GetAllDataAsync();
            var pageNo = comboBoxPageNo.SelectedIndex;
            var pageSize = Properties.Settings.Default.PageSize;
            dataGridView1.DataSource = data.Skip((pageNo) * pageSize ).Take(pageSize).ToList();

            if (dataGridView1.DataSource == null)
            {
                MessageCollection.ShowErrorServerMessage();
            }
            else
            {
                SetColumnsTitle();
            }
            _loadingForm.Hide();
            data.Clear();
        }

        #endregion

        #region Methods
        public static CategoryUserControl Instance()
        {
            return _instance ?? (new CategoryUserControl());
        }
       
        public async void LoadData()
        {
            _loadingForm.Show();
            var data = await _dataHelperCategories.GetAllDataAsync();
            dataGridView1.DataSource = data.Take(Properties.Settings.Default.PageSize).ToList();
            comboBoxPageNo.Items.Clear();
            var totalPages = (int)Math.Ceiling((double)data.Count / Properties.Settings.Default.PageSize);

            for(int i=1; i<= totalPages; i++)
            {
                comboBoxPageNo.Items.Add(i.ToString());
            }
            if (dataGridView1.DataSource == null)
            {
                MessageCollection.ShowErrorServerMessage();
            }
            else
            {
                SetColumnsTitle();
            }
            _loadingForm.Hide();
            data.Clear();
        }

        private void SetColumnsTitle()
        {
            dataGridView1.Columns[0].HeaderText = "المعرف";
            dataGridView1.Columns[1].HeaderText = "الاسم";
            dataGridView1.Columns[2].HeaderText = "النوع";
            dataGridView1.Columns[3].HeaderText = "التفاصيل";
            dataGridView1.Columns[4].HeaderText = "الرصيد";
            dataGridView1.Columns[5].HeaderText = "تاريخ الاضافة";
        }

        private void Edit()
        {
            if (dataGridView1.RowCount > 0)
            {
                _rowId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                AddCategoryForm addCategoryForm = new AddCategoryForm(_rowId, this);
                addCategoryForm.Show();
            }
            else
            {
                Code.MessageCollection.ShowEmptyDataMessage();
            }
        }

        private void SetRowIdForDelete()
        {
           
            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Selected)
                {
                    _idList.Add(Convert.ToInt32(row.Cells[0].Value));
                }
            }
        }

        public async void Search()
        {
            _loadingForm.Show();
            var searchItem = textBoxSearch.Text;      
            dataGridView1.DataSource = await _dataHelperCategories.SearchAsync(searchItem);
            if (dataGridView1.DataSource == null)
            {
                MessageCollection.ShowErrorServerMessage();
            }
            else
            {
                SetColumnsTitle();
            }
            _loadingForm.Hide();
        }

        private DataTable SetDataTableColumns(DataTable dataTable)
        {
            dataTable.Columns["Id"].SetOrdinal(0);
            dataTable.Columns["Id"].ColumnName = "المعرف";
            dataTable.Columns["Name"].SetOrdinal(1);
            dataTable.Columns["Name"].ColumnName = "الاسم";
            dataTable.Columns["Type"].SetOrdinal(2);
            dataTable.Columns["Type"].ColumnName = "النوع";
            dataTable.Columns["Details"].SetOrdinal(3);
            dataTable.Columns["Details"].ColumnName = "التفاصيل";
            dataTable.Columns["Balance"].SetOrdinal(4);
            dataTable.Columns["Balance"].ColumnName = "الرصيد";
            dataTable.Columns["AddedDate"].SetOrdinal(5);
            dataTable.Columns["AddedDate"].ColumnName = "طابع زمني";
            return dataTable;
        }

        private void ExportAsXlsxFile(DataTable dataTableArranged)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "تصدير الملف على شكل اكسل";
            saveFileDialog.DefaultExt = "xlsx";
            saveFileDialog.AddExtension = true;
            saveFileDialog.Filter = "Excel File (.xlsx)|*.xlsx";
            saveFileDialog.RestoreDirectory = true;
            var result = saveFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    using (XLWorkbook xLWorkbook = new XLWorkbook()) // Creat Excel File
                    {
                        xLWorkbook.AddWorksheet(dataTableArranged, "Data"); // Add Sheet
                        using (MemoryStream ma = new MemoryStream())
                        {
                            xLWorkbook.SaveAs(ma);
                            File.WriteAllBytes(saveFileDialog.FileName, ma.ToArray());
                        }
                    }
                 //   System.Diagnostics.Process.Start(saveFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
        #endregion

    }
}
