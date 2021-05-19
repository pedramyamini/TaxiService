using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace Utility
{
    public class RadGridViewCustom : RadGridView
    {
        public override string ThemeClassName
        {
            get { return typeof(RadGridView).FullName; }
            set { }
        }
        public RadGridViewCustom()
        {
            

            foreach (var column in this.Columns)
            {
                column.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            }
            this.Cursor = Cursors.Hand;
            this.Font = new System.Drawing.Font("IRANYekan", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MasterTemplate.AllowAddNewRow = false;
            this.MasterTemplate.AllowColumnReorder = false;
            this.MasterTemplate.AllowDragToGroup = false;
            this.MasterTemplate.AllowEditRow = false;
            this.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
            
            

            //delete btn
            GridViewCommandColumn deleteBtnColumn = new GridViewCommandColumn();
            deleteBtnColumn.AllowHide = false;
            deleteBtnColumn.HeaderText = "حذف";
            deleteBtnColumn.Image = Utility.Properties.Resources.Icon_material_delete_forever;
            deleteBtnColumn.MaxWidth = 50;
            deleteBtnColumn.Name = "GridDeleteBtn";
            deleteBtnColumn.Width = 50;

            //edit btn
            GridViewCommandColumn editBtnColumn = new GridViewCommandColumn();
            editBtnColumn.AllowHide = false;
            editBtnColumn.HeaderText = "ویرایش";
            editBtnColumn.Image = Utility.Properties.Resources.Icon_feather_edit;
            editBtnColumn.MaxWidth = 60;
            editBtnColumn.Name = "GridEditBtn";
            editBtnColumn.Width = 60;

            this.MasterTemplate.Columns.AddRange(new GridViewDataColumn[] {
            editBtnColumn,deleteBtnColumn});

            this.MasterTemplate.EnableGrouping = false;
            TableViewDefinition tableViewDefinition = new TableViewDefinition();
            this.ViewDefinition = tableViewDefinition;
            this.ReadOnly = true;
            this.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.Auto;
            this.ThemeName = "Material";
            this.SelectionMode = GridViewSelectionMode.None;
            this.AutoGenerateColumns = true;

            

        }

        public void BestFit()
        {

            foreach (GridViewColumn col in this.MasterTemplate.Columns)
                col.TextAlignment = ContentAlignment.MiddleCenter;

            this.AutoGenerateColumns = true;
            this.Columns.Where(c => c.Name == "Id").Single().IsVisible = false;

            this.Columns.Move(this.Columns.Where(c => c.Name == "GridEditBtn").Single().Index, this.Columns.Count - 1);
            this.Columns.Move(this.Columns.Where(c => c.Name == "GridDeleteBtn").Single().Index, this.Columns.Count - 1);

            this.BestFitColumns(Telerik.WinControls.UI.BestFitColumnMode.DisplayedCells);
        }

        protected override void OnSelectionChanged(object sender, EventArgs e)
        {
            //if (this != null && this.SelectedCells.Count > 0)
            //{
            //    if (!this.CurrentCell.IsSelected)
            //    {
            //        this.CurrentRow.IsSelected = true;
            //        this.HideSelection = false;
            //    }
            //    else
            //    {
            //        this.CurrentRow.IsSelected = false;
            //        this.HideSelection = true;
            //    }
            //}

            base.OnSelectionChanged(sender, e);
        }

        //protected override void OnCellClick(object sender, GridViewCellEventArgs e)
        //{

        //    base.OnCellClick(sender, e);
        //}
    }
}
