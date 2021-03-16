
namespace Group3_ClinicDB.UserControls
{
    partial class AllVisitsUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllVisitsUserControl));
            this.visitsDALBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.visitsDALBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.visitsDALBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.visitsDALDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.visitsDALBindingNavigator)).BeginInit();
            this.visitsDALBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visitsDALBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitsDALDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // visitsDALBindingNavigator
            // 
            this.visitsDALBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.visitsDALBindingNavigator.BindingSource = this.visitsDALBindingSource;
            this.visitsDALBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.visitsDALBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.visitsDALBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.visitsDALBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.visitsDALBindingNavigatorSaveItem});
            this.visitsDALBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.visitsDALBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.visitsDALBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.visitsDALBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.visitsDALBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.visitsDALBindingNavigator.Name = "visitsDALBindingNavigator";
            this.visitsDALBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.visitsDALBindingNavigator.Size = new System.Drawing.Size(857, 30);
            this.visitsDALBindingNavigator.TabIndex = 1;
            this.visitsDALBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 27);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // visitsDALBindingSource
            // 
            this.visitsDALBindingSource.DataSource = typeof(Group3_ClinicDB.DAL.VisitsDAL);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(49, 27);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 27);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 27);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 27);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 30);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 30);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 30);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 27);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 27);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 30);
            // 
            // visitsDALBindingNavigatorSaveItem
            // 
            this.visitsDALBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.visitsDALBindingNavigatorSaveItem.Enabled = false;
            this.visitsDALBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("visitsDALBindingNavigatorSaveItem.Image")));
            this.visitsDALBindingNavigatorSaveItem.Name = "visitsDALBindingNavigatorSaveItem";
            this.visitsDALBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 27);
            this.visitsDALBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // visitsDALDataGridView
            // 
            this.visitsDALDataGridView.AutoGenerateColumns = false;
            this.visitsDALDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.visitsDALDataGridView.DataSource = this.visitsDALBindingSource;
            this.visitsDALDataGridView.Location = new System.Drawing.Point(34, 51);
            this.visitsDALDataGridView.Name = "visitsDALDataGridView";
            this.visitsDALDataGridView.RowHeadersWidth = 51;
            this.visitsDALDataGridView.RowTemplate.Height = 24;
            this.visitsDALDataGridView.Size = new System.Drawing.Size(779, 287);
            this.visitsDALDataGridView.TabIndex = 2;
            // 
            // AllVisitsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.visitsDALDataGridView);
            this.Controls.Add(this.visitsDALBindingNavigator);
            this.Name = "AllVisitsUserControl";
            this.Size = new System.Drawing.Size(857, 358);
            this.Load += new System.EventHandler(this.AllVisitsUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.visitsDALBindingNavigator)).EndInit();
            this.visitsDALBindingNavigator.ResumeLayout(false);
            this.visitsDALBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visitsDALBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitsDALDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource visitsDALBindingSource;
        private System.Windows.Forms.BindingNavigator visitsDALBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton visitsDALBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView visitsDALDataGridView;
    }
}
