using Asrfly.Code;
using Asrfly.Core.Entities;
using Asrfly.Data.repo;
using DocumentFormat.OpenXml.Office2010.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Asrfly.Gui.GuiCustomers
{
    public partial class AddCustomerForm : Form
    {
        #region variables
        private readonly int _id;
        private readonly CustomerUserControl _categoryUserControl;
        private Customers _customer;
        private readonly IDataHelper<Customers> _CustomersdataHelper;
        private readonly IDataHelper<SystemRecords> _systemRecordsDataHelper;
        private readonly GuiLoading.LoadingForm _loadingForm;
  
        #endregion
        public AddCustomerForm(int Id, CustomerUserControl categoryUserControl)
        {
            InitializeComponent();
            this._id = Id;
            this._categoryUserControl = categoryUserControl;
            _CustomersdataHelper = (IDataHelper<Customers>?)ConfigurationObjectManager.GetObject("Customers");
            _systemRecordsDataHelper = (IDataHelper<SystemRecords>?)ConfigurationObjectManager.GetObject("SystemRecords");
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

        private bool IsFiledsEmpty() => textBoxName.Text == string.Empty;

        private async Task<bool> AddData()
        {
            // Set Data
            _customer = new Customers
            {
                Name = textBoxName.Text,
                Address = textBoxAddress.Text,
                PhoneNumber = textBoxPhoneNo.Text,
                Details = richTextBoxDetails.Text,
                AddedDate = DateTime.Now,
                Email = textBoxEmail.Text,
            };

            // Submit
            var result = await _CustomersdataHelper.AddAsync(_customer);
            if (result == 1)
            {
                // Save System Records
                SystemRecords systemRecords = new SystemRecords
                {
                    Title = " اضافة عميل",
                    UserName = Properties.Settings.Default.UserName,
                    Details = "تمت اضافة عميل  " + _customer.Name,
                    AddedDate = DateTime.Now
                };
                await _systemRecordsDataHelper.AddAsync(systemRecords);
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
            _customer = new Customers
            {
                Id = _id,
                Name = textBoxName.Text,
                Address = textBoxAddress.Text,
                PhoneNumber = textBoxPhoneNo.Text,
                Details = richTextBoxDetails.Text,
                AddedDate = DateTime.Now,
                Email = textBoxEmail.Text,
            };

            // Submit
            var result = await _CustomersdataHelper.UpdateAsync(_customer);
            if (result == 1)
            {
                // Save System Records
                SystemRecords systemRecords = new SystemRecords
                {
                    Title = " تعديل عميل",
                    UserName = Properties.Settings.Default.UserName,
                    Details = "تم تعديل عميل  " + _customer.Name,
                    AddedDate = DateTime.Now
                };
                await _systemRecordsDataHelper.AddAsync(systemRecords);
                _categoryUserControl.LoadData();
                return true;
            }
            else
            {
                return false;
            }
        }

        private async void SetFiledData()
        {
            if (_id > 0)
            {
                _customer = await _CustomersdataHelper.FindByIdAsync(_id);
                if (_customer != null)
                {
                    textBoxName.Text = _customer.Name;
                    textBoxEmail.Text = _customer.Email;
                    textBoxPhoneNo.Text = _customer.PhoneNumber;
                    textBoxAddress.Text = _customer.Address;
                    textBoxBalance.Text = _customer.Balance.ToString();
                    richTextBoxDetails.Text = _customer.Details;
                }
                else
                {
                    MessageCollection.ShowErrorServerMessage();
                }
            }
        }


        #endregion

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
