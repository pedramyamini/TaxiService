using BaseFormLibrary;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utility;
using WND.Data;
using WND.Forms;

namespace WND.Forms
{
    public partial class frmSecretaries : BaseForm
    {
        public frmSecretaries()
        {
            InitializeComponent();

            if (TaxiDbContext.Instance.Users.OfType<Models.AuthenticatedUser>().Any())
            {
                UpdateGrid();
            }

            BizObject = null;

            BizObject = new Models.AuthenticatedUser()
            {
                Id = 0,
                FullName = string.Empty,
                Mobile = string.Empty,
                IsDeleted = false,
                Username = string.Empty,
                Password = string.Empty,
                Role = Roles.Secretary,
                TaxiName = TaxiDbContext.Instance.AuthenticatedUsers.Where(u => u.Role == Roles.Admin).First().TaxiName,
                DateJoined = DateTime.Today,
                SecurityQuestion = " ",
                SecurityAnswer = " "
            };

            gridSecretaries.CellClick += gridSecretaries_CellClick;

            lblDateJoined.Text = DateTime.Today.ToPersianDateString();
        }

        private Models.AuthenticatedUser bizObject { get; set; }

        private Models.AuthenticatedUser BizObject
        {
            set
            {

                if (value == null)
                {

                    bizObject = new Models.AuthenticatedUser()
                    {
                        Id = 0,
                        FullName = string.Empty,
                        Mobile = string.Empty,
                        Role = Roles.Secretary,
                        DateJoined = DateTime.Today,
                        IsDeleted = false,
                        Password = string.Empty,
                        Username = string.Empty,
                        SecurityQuestion = string.Empty,
                        SecurityAnswer = string.Empty,
                        TaxiName = string.Empty
                    };

                    this.Controls.OfType<SizableTextBox>().ToList().ForEach(t => t.ResetText());
                    this.Controls.OfType<NumericTextBox>().ToList().ForEach(t => t.ResetText());

                    //gridDrivers.ClearSelection();
                }
                else
                {
                    bizObject = value;
                }

                txtSecretaryUsername.DataBindings.Clear();
                txtSecretaryUsername.DataBindings.Add("Text", BizObject, nameof(Models.AuthenticatedUser.Username));

                txtSecretaryPassword.DataBindings.Clear();
                txtSecretaryPassword.DataBindings.Add("Text", BizObject, nameof(Models.AuthenticatedUser.Password));

                txtSecretaryName.DataBindings.Clear();
                txtSecretaryName.DataBindings.Add("Text", BizObject, nameof(Models.AuthenticatedUser.FullName));

                txtSecretaryPhone.DataBindings.Clear();
                txtSecretaryPhone.DataBindings.Add("Text", BizObject, nameof(Models.AuthenticatedUser.Mobile));

                lblDateJoined.Text = BizObject.DateJoined.ToPersianDateString();

            }
            get
            {
                return bizObject;
            }
        }


        void DeleteBizObject()
        {
            Models.AuthenticatedUser SecretaryToRemove = TaxiDbContext.Instance.Users
                .Find(int.Parse(gridSecretaries.CurrentRow.Cells["Id"].Value.ToString())) as Models.AuthenticatedUser;
            DialogResult dr = MessageBoxRTL.Ask("آیا از حذف منشی اطمینان دارید؟", string.Empty);
            if (dr == DialogResult.OK)
            {
                try
                {
                    //TaxiDbContext.Instance.Users.Remove(DriverToRemove);
                    SecretaryToRemove.IsDeleted = true;
                    TaxiDbContext.Instance.SaveChanges();
                    MessageBoxRTL.Info(".منشی با موفقیت حذف شد", string.Empty);
                    UpdateGrid();
                    BizObject = null;
                }
                catch
                {
                    MessageBoxRTL.Error("حذف منشی با خطا روبرو شد", string.Empty);
                }
            }
        }

        void EditBizObject()
        {
            BizObject = null;
            int id;
            int.TryParse(gridSecretaries.SelectedCells.First().RowInfo.Cells["Id"].Value.ToString(), out id);
            UpdateGrid();
            Models.AuthenticatedUser SecretaryToEdit = TaxiDbContext.Instance.Users.OfType<Models.AuthenticatedUser>().SingleOrDefault(c => c.Id == (int)id && c.Role == Roles.Secretary);
            if (SecretaryToEdit != null)
            {
                //BizObject = (Models.Driver)DriverToEdit.Clone();
                BizObject = (Models.AuthenticatedUser)SecretaryToEdit.Clone();
            }
        }
        void UpdateGrid()
        {
            gridSecretaries.DataSource = TaxiDbContext.Instance.Users.OfType<Models.AuthenticatedUser>()
                .Where(d => !d.IsDeleted && d.Role == Roles.Secretary).ToList();

            gridSecretaries.Columns.Where(c => c.Name == "Id").Single().IsVisible = false;
            gridSecretaries.Columns.Where(c => c.Name == "Password").Single().IsVisible = false;
            gridSecretaries.Columns.Where(c => c.Name == "Role").Single().IsVisible = false;
            gridSecretaries.Columns.Where(c => c.Name == "SecurityQuestion").Single().IsVisible = false;
            gridSecretaries.Columns.Where(c => c.Name == "SecurityAnswer").Single().IsVisible = false;
            gridSecretaries.Columns.Where(c => c.Name == "TaxiName").Single().IsVisible = false;
            gridSecretaries.Columns.Where(c => c.Name == "IsDeleted").Single().IsVisible = false;

            gridSecretaries.BestFit();



        }

        void UpdateSecretary()
        {
            Models.AuthenticatedUser Secretary = (Models.AuthenticatedUser)TaxiDbContext.Instance.Users.Single(d => d.Id == BizObject.Id);

            Secretary.FullName = BizObject.FullName;
            Secretary.Mobile = BizObject.Mobile;
            Secretary.Password = EasyHash.Hash(BizObject.Password);
            Secretary.Role = Roles.Secretary;
            Secretary.SecurityQuestion = string.Empty;
            Secretary.SecurityAnswer = string.Empty;
            Secretary.TaxiName = TaxiDbContext.Instance.AuthenticatedUsers.Where(u => u.Role == Roles.Admin).First().TaxiName;

            BizObject.IsDeleted = false;
            TaxiDbContext.Instance.SaveChanges();
            BizObject = null;
            MessageBoxRTL.Info(".منشی با موفقیت ویرایش شد", string.Empty);
            UpdateGrid();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            BizObject.TaxiName = TaxiDbContext.Instance.AuthenticatedUsers.Where(u => u.Role == Roles.Admin).First().TaxiName;
            if (BizObject != null && Validation.Validate(BizObject))
            {

                try
                {
                    if (BizObject.Id != 0)
                    {
                        UpdateSecretary();
                    }
                    else if (BizObject.Id == 0)
                    {
                        //avoid repeating Secretary Mobile
                        if (TaxiDbContext.Instance.Users.Any(u => u.Mobile == BizObject.Mobile
                        && u.FullName != BizObject.FullName))
                        {
                            MessageBoxRTL.Error("شماره همراه قبلا ثبت شده است. لطفا شماره دیگری وارد کنید", string.Empty);
                            return;
                        }

                        if (TaxiDbContext.Instance.Users.Any(u => u.Mobile == BizObject.Mobile
                        && u.FullName == BizObject.FullName))
                        {
                            DialogResult dr = MessageBoxRTL.Ask("این منشی قبلا ثبت شده است. آیا مایل به ویرایش آن هستید؟", string.Empty);
                            if (dr == DialogResult.OK)
                            {
                                Models.AuthenticatedUser CheckExistingSecretary = TaxiDbContext.Instance.Users
                                    .OfType<Models.AuthenticatedUser>().Single(u => u.Mobile == BizObject.Mobile
                        && u.FullName == BizObject.FullName);
                                BizObject = null;
                                BizObject = CheckExistingSecretary;
                                UpdateSecretary();
                                return;
                            }
                            return;
                        }
                        BizObject.Role = Roles.Secretary;
                        BizObject.TaxiName = TaxiDbContext.Instance.AuthenticatedUsers.Where(u => u.Role == Roles.Admin).First().TaxiName;
                        TaxiDbContext.Instance.Users.Add(BizObject);
                        TaxiDbContext.Instance.SaveChanges();
                        MessageBoxRTL.Info(".منشی با موفقیت افزوده شد", string.Empty);
                        UpdateGrid();
                        BizObject = null;
                    }
                }
                catch
                {
                    MessageBoxRTL.Error("ذخیره سازی منشی با خطا روبرو شد.", string.Empty);
                }
            }
        }

        private void gridSecretaries_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            if (gridSecretaries.SelectedCells.Count > 0)
            {
                switch (gridSecretaries.SelectedCells[0].ColumnInfo.Name)
                {
                    case "GridEditBtn":
                        EditBizObject();
                        break;
                    case "GridDeleteBtn":
                        DeleteBizObject();
                        break;
                    default:
                        break;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            BizObject = null;
        }


        protected override void btnDashboard_Click(object sender, EventArgs e)
        {
            //Nothing to do because already dashboard is open
            base.btnDashboard_Click(sender, e);
        }

        protected override void btnDrivers_Click(object sender, EventArgs e)
        {
            SwitchBetweenForms = true;
            this.Close();
            new frmDrivers();

            base.btnDrivers_Click(sender, e);
        }

        protected override void btnPaths_Click(object sender, EventArgs e)
        {
            SwitchBetweenForms = true;
            this.Close();
            new frmPaths();

            base.btnPaths_Click(sender, e);
        }

        protected override void btnServices_Click(object sender, EventArgs e)
        {
            this.CloseWithoutAsk();
            new frmServices();

            base.btnServices_Click(sender, e);
        }


        private void btnDriversThumbnail_Click(object sender, EventArgs e)
        {
            this.CloseWithoutAsk();
            new frmDrivers();
        }

        private void btnServicesThumbnail_Click(object sender, EventArgs e)
        {
            this.CloseWithoutAsk();
            new frmServices();
        }

        private void btnPathsThumbnail_Click(object sender, EventArgs e)
        {
            this.CloseWithoutAsk();
            new frmPaths();
        }

        private void btnCustomersThumbnail_Click(object sender, EventArgs e)
        {
            this.CloseWithoutAsk();
            new frmCustomers();
        }

        private void btnDashboard_Click_1(object sender, EventArgs e)
        {
            this.CloseWithoutAsk();
            new frmDashboard();
        }

        
    }
}
