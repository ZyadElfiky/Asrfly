using Asrfly.Code;
using Asrfly.Core.Entities;
using Asrfly.Data.repo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asrfly.Gui.GuiCategories
{
    public partial class AddCategoryForm : Form
    {
        #region variables
        private readonly int _id;
        private readonly CategoryUserControl _categoryUserControl;
        private Categories _category;
        private readonly IDataHelper<Categories> _dataHelper;
        private readonly IDataHelper<SystemRecords> _dataHelperSystemRecords;
        private readonly GuiLoading.LoadingForm _loadingForm;
  
        #endregion
        public AddCategoryForm(int Id, CategoryUserControl categoryUserControl)
        {
            InitializeComponent();
            this._id = Id;
            this._categoryUserControl = categoryUserControl;
            _dataHelper = (IDataHelper<Categories>?)ConfigurationObjectManager.GetObject("Categories");
            _dataHelperSystemRecords = (IDataHelper<SystemRecords>?)ConfigurationObjectManager.GetObject("SystemRecords");
            _loadingForm = new GuiLoading.LoadingForm();
        }

        #region Events
        private async void buttonSaveAndClose_Click(object sender, EventArgs e)
        {
            if (IsFiledsEmpty())
            {
                MessageCollection.ShowFiledRequireMessage();
            }
            else
            {
                _loadingForm.Show();
                if (await SaveData())
                {
                    if (_id == 0)
                    {
                        MessageCollection.AddDataNotification();
                    }
                    else
                    {
                        MessageCollection.EditDataNotification();
                    }
                    Close();
                }
                else
                {
                    MessageCollection.ShowErrorServerMessage();
                }
                _loadingForm.Hide();
            }
        }

        private async void buttonSave_Click(object sender, EventArgs e)
        {
            if (IsFiledsEmpty())
            {
                MessageCollection.ShowFiledRequireMessage();
            }
            else
            {
                _loadingForm.Show();
                if (await SaveData())
                {
                    if (_id == 0)
                    {
                        MessageCollection.AddDataNotification();
                    }
                    else
                    {
                        MessageCollection.EditDataNotification();
                    }
                }
                else
                {
                    MessageCollection.ShowErrorServerMessage();
                }
                _loadingForm.Hide();
            }
        }

        private  void AddCategoryForm_Load(object sender, EventArgs e)
        {
            _loadingForm.Show();
            SetFiledData();
            _loadingForm.Hide();
        }
        #endregion

        #region Methods

        private async Task<bool> SaveData()
        {
            // Add
            if (_id == 0)
            {
                return await AddData();
            }
            // Edit
            else
            {

                return await EditData();
            }
        }

        private bool IsFiledsEmpty() => textBoxName.Text == string.Empty || comboBoxType.Text == string.Empty;

        private async Task<bool> AddData()
        {
            // Set Data
            _category = new Categories
            {
                Name = textBoxName.Text,
                Type = comboBoxType.SelectedItem.ToString(),
                Details = richTextBoxDetails.Text,
                AddedDate = DateTime.Now,
            };

            // Submit
            var result = await _dataHelper.AddAsync(_category);
            if (result == 1)
            {
                // Save System Records
                SystemRecords systemRecords = new SystemRecords
                {
                    Title = " اضافة صنف",
                    UserName = Properties.Settings.Default.UserName,
                    Details = "تمت اضافة صنف  " + _category.Name,
                    AddedDate = DateTime.Now
                };
                await _dataHelperSystemRecords.AddAsync(systemRecords);
                _categoryUserControl.LoadData();
                return true;
            }
            else
            {
                return false;
            }
        }

        private async Task<bool> EditData()
        {
            // Set Data
            _category = new Categories
            {
                Id = _id,
                Name = textBoxName.Text,
                Type = comboBoxType.SelectedItem.ToString(),
                Details = richTextBoxDetails.Text,
                AddedDate = DateTime.Now,
            };

            // Submit
            var result = await _dataHelper.UpdateAsync(_category);
            if (result == 1)
            {
                // Save System Records
                SystemRecords systemRecords = new SystemRecords
                {
                    Title = " تعديل صنف",
                    UserName = Properties.Settings.Default.UserName,
                    Details = "تم تعديل صنف  " + _category.Name,
                    AddedDate = DateTime.Now
                };
                await _dataHelperSystemRecords.AddAsync(systemRecords);
                _categoryUserControl.LoadData();
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion
        private async void SetFiledData()
        {
            if (_id > 0)
            {
                 _category = await _dataHelper.FindByIdAsync(_id);
                if (_category != null)
                {
                    textBoxName.Text = _category.Name;
                    comboBoxType.SelectedItem = _category.Type;
                    richTextBoxDetails.Text = _category.Details;
                    textBoxBalance.Text = _category.Balance.ToString();
                }
                else
                {
                    MessageCollection.ShowErrorServerMessage();
                }
            }
        }

    }
}
