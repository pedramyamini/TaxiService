using BaseFormLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    public partial class frmPaths : BaseForm
    {

        private Models.Path initialBizObject = new Models.Path()
        {
            Id = 0,
            Origin = string.Empty,
            Destination =string.Empty,
            OriginDestination= string.Empty,
            Cost=0
        };
        private Models.Path bizObject { get; set; }

        private Models.Path BizObject
        {
            set
            {

                if(value==null)
                {

                    bizObject = new Models.Path()
                    {
                        Id = 0,
                        Origin = string.Empty,
                        Destination = string.Empty,
                        OriginDestination = string.Empty,
                        Cost = 0
                    };

                    this.Controls.OfType<SizableTextBox>().ToList().ForEach(t => t.ResetText());
                    this.Controls.OfType<NumericTextBox>().ToList().ForEach(t => t.ResetText());
                    lblCost.ResetText();
                    lblOrigin.ResetText();
                    lblDestination.ResetText();

                    //gridPaths.ClearSelection();
                }
                else
                {
                    bizObject = value;
                }

                txtOrigin.DataBindings.Clear();
                txtOrigin.DataBindings.Add("Text", bizObject, nameof(Models.Path.Origin));

                lblOrigin.DataBindings.Clear();
                lblOrigin.DataBindings.Add("Text", txtOrigin, "Text");

                txtDestination.DataBindings.Clear();
                txtDestination.DataBindings.Add("Text", bizObject, nameof(Models.Path.Destination));

                lblDestination.DataBindings.Clear();
                lblDestination.DataBindings.Add("Text", txtDestination, "Text");

                txtCost.DataBindings.Clear();
                txtCost.DataBindings.Add("Text", bizObject, nameof(Models.Path.Cost));

                lblCost.DataBindings.Clear();
                lblCost.DataBindings.Add("Text", txtCost, "Text");

                


            }
            get
            {
                return bizObject;
            }
        }

        void DeleteBizObject()
        {
            Models.Path PathToRemove = TaxiDbContext.Instance.Paths.Find(gridPaths.CurrentRow.Cells["Id"].Value);
            DialogResult dr = MessageBoxRTL.Ask("آیا از حذف مسیر اطمینان دارید؟", string.Empty);
            if (dr == DialogResult.OK)
            {
                try
                {
                    //TaxiDbContext.Instance.Paths.Remove(PathToRemove);
                    PathToRemove.IsDeleted = true;
                    TaxiDbContext.Instance.SaveChanges();
                    MessageBoxRTL.Info(".مسیر با موفقیت حذف شد", string.Empty);
                    UpdateGrid();
                }
                catch
                {
                    MessageBoxRTL.Error("حذف مسیر با خطا روبرو شد", string.Empty);
                }
            }
        }

        public frmPaths()
        {
            btnPaths.ChangeMenuItemImage(Properties.Resources.Paths_out);

            InitializeComponent();

            UpdateGrid();

            BizObject = new Models.Path();

            gridPaths.CellClick += gridPaths_CellClick;
        }

        void UpdateGrid()
        {
            gridPaths.DataSource = TaxiDbContext.Instance.Paths.Where(p=>!p.IsDeleted).ToList();

            gridPaths.Columns.Where(c => c.Name == "ServicePaths").Single().IsVisible = false;
            gridPaths.Columns.Where(c => c.Name == "OriginDestination").Single().IsVisible = false;
            gridPaths.Columns.Where(c => c.Name == "IsDeleted").Single().IsVisible = false;

            gridPaths.BestFit();
        }

        protected override void BaseForm_Load(object sender, EventArgs e)
        {

            base.BaseForm_Load(sender, e);
        }

        protected override void btnDashboard_Click(object sender, EventArgs e)
        {
            this.CloseWithoutAsk();
            new frmDashboard();

            base.btnDashboard_Click(sender, e);
        }

        protected override void btnDrivers_Click(object sender, EventArgs e)
        {
            this.CloseWithoutAsk();
            new frmDrivers();

            base.btnDrivers_Click(sender, e);
        }

        protected override void btnPaths_Click(object sender, EventArgs e)
        {


            base.btnPaths_Click(sender, e);
        }

        protected override void btnServices_Click(object sender, EventArgs e)
        {
            this.CloseWithoutAsk();
            new frmServices();

            base.btnServices_Click(sender, e);
        }

        private void frmPaths_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (BizObject!= null && Validation.Validate(BizObject))
            {
                try
                {
                    if (BizObject.Id != 0)
                    {
                        Models.Path Path = TaxiDbContext.Instance.Paths.Find(BizObject.Id);
                        Path.Origin = BizObject.Origin;
                        Path.Destination = BizObject.Destination;
                        Path.Cost = BizObject.Cost;
                        TaxiDbContext.Instance.SaveChanges();
                        BizObject = null;
                        MessageBoxRTL.Info(".مسیر با موفقیت ویرایش شد", string.Empty);
                        UpdateGrid();
                    }
                    else if (BizObject.Id == 0)
                    {
                        TaxiDbContext.Instance.Paths.Add(BizObject);
                        TaxiDbContext.Instance.SaveChanges();
                        MessageBoxRTL.Info(".مسیر با موفقیت افزوده شد", string.Empty);
                        UpdateGrid();
                    }
                    BizObject = null;
                }
                catch
                {
                    MessageBoxRTL.Error("ذخیره سازی مسیر با خطا روبرو شد.", string.Empty);
                }
            }
        }

        private void gridPaths_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            if (gridPaths.Rows.Count > 0)
            {
                switch (gridPaths.SelectedCells[0].ColumnInfo.Name)
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

        private void EditBizObject()
        {
            BizObject = null;
            int id;
            int.TryParse(gridPaths.SelectedCells.First().RowInfo.Cells["Id"].Value.ToString(), out id);
            UpdateGrid();
            Models.Path PathToEdit = TaxiDbContext.Instance.Paths.Find(id);
            if (PathToEdit != null)
            {
                //BizObject = (Models.Driver)DriverToEdit.Clone();
                BizObject = (Models.Path)PathToEdit.Clone();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            BizObject = null;
        }
    }
}
