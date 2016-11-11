using System;
using Smobiler.Core;
namespace COMSSmobilerDemo.WorkDocument
{
    partial class frmUserKPI : Smobiler.Core.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmUserKPI()
            : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();

            //Add any initialization after the InitializeComponent() call
        }

        //SmobilerForm overrides dispose to clean up the component list.
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }


        //NOTE: The following procedure is required by the SmobilerForm
        //It can be modified using the SmobilerForm.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]

        private void InitializeComponent()
        {
            Smobiler.Core.Controls.TableViewLabelColumn tableViewLabelColumn15 = new Smobiler.Core.Controls.TableViewLabelColumn();
            Smobiler.Core.Controls.TableViewImageColumn tableViewImageColumn3 = new Smobiler.Core.Controls.TableViewImageColumn();
            Smobiler.Core.Controls.TableViewLabelColumn tableViewLabelColumn16 = new Smobiler.Core.Controls.TableViewLabelColumn();
            Smobiler.Core.Controls.TableViewLabelColumn tableViewLabelColumn17 = new Smobiler.Core.Controls.TableViewLabelColumn();
            Smobiler.Core.Controls.TableViewLabelColumn tableViewLabelColumn18 = new Smobiler.Core.Controls.TableViewLabelColumn();
            Smobiler.Core.Controls.TableViewLabelColumn tableViewLabelColumn19 = new Smobiler.Core.Controls.TableViewLabelColumn();
            Smobiler.Core.Controls.TableViewLabelColumn tableViewLabelColumn20 = new Smobiler.Core.Controls.TableViewLabelColumn();
            Smobiler.Core.Controls.TableViewLabelColumn tableViewLabelColumn21 = new Smobiler.Core.Controls.TableViewLabelColumn();
            this.TableView1 = new Smobiler.Core.Controls.TableView();
            // 
            // TableView1
            // 
            this.TableView1.AutoHeight = false;
            this.TableView1.BackColorAlpha = 0;
            this.TableView1.ColumnHeaderStyle = new Smobiler.Core.Controls.TableViewColumnHeaderStyle(((float)(20)), 15F, System.Drawing.Color.LightBlue, System.Drawing.Color.White);
            tableViewLabelColumn15.DataMember = "PERIOD_ID";
            tableViewLabelColumn15.DefaultBindPropertyValue = "日期";
            tableViewLabelColumn15.DisplayMember = "PERIOD_ID";
            tableViewLabelColumn15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            tableViewLabelColumn15.HeaderText = "日期";
            tableViewLabelColumn15.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Center;
            tableViewLabelColumn15.Text = "日期";
            tableViewLabelColumn15.VerticalAlignment = Smobiler.Core.VerticalAlignment.Center;
            tableViewLabelColumn15.Width = 62;
            tableViewImageColumn3.DataMember = "ISWARNING1";
            tableViewImageColumn3.DefaultBindPropertyValue = "!\\ue84d000000000";
            tableViewImageColumn3.DefaultImageVisible = true;
            tableViewImageColumn3.DisplayMember = "ISWARNING1";
            tableViewImageColumn3.Enlarged = false;
            tableViewImageColumn3.HeaderText = "是否完成";
            tableViewImageColumn3.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Center;
            tableViewImageColumn3.Mode = Smobiler.Core.Controls.ResourceMode.File;
            tableViewImageColumn3.ResourceID = "!\\ue84d000000000";
            tableViewImageColumn3.ResourcePath = "";
            tableViewImageColumn3.SizeMode = Smobiler.Core.ImageSizeMode.Zoom;
            tableViewImageColumn3.VerticalAlignment = Smobiler.Core.VerticalAlignment.Center;
            tableViewImageColumn3.Width = 62;
            tableViewLabelColumn16.DataMember = "WDOC_MENDAY";
            tableViewLabelColumn16.DefaultBindPropertyValue = "";
            tableViewLabelColumn16.DisplayMember = "WDOC_MENDAY";
            tableViewLabelColumn16.HeaderText = "目标业务人天";
            tableViewLabelColumn16.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Center;
            tableViewLabelColumn16.Text = "";
            tableViewLabelColumn16.VerticalAlignment = Smobiler.Core.VerticalAlignment.Center;
            tableViewLabelColumn16.Width = 80;
            tableViewLabelColumn17.DataMember = "USER_OBJMENDAY";
            tableViewLabelColumn17.DefaultBindPropertyValue = "";
            tableViewLabelColumn17.DisplayMember = "USER_OBJMENDAY";
            tableViewLabelColumn17.HeaderText = "工单业务人天";
            tableViewLabelColumn17.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Center;
            tableViewLabelColumn17.Text = "";
            tableViewLabelColumn17.VerticalAlignment = Smobiler.Core.VerticalAlignment.Center;
            tableViewLabelColumn17.Width = 80;
            tableViewLabelColumn18.DataMember = "USER_OBJMENDAYRATE";
            tableViewLabelColumn18.DefaultBindPropertyValue = "";
            tableViewLabelColumn18.DisplayMember = "USER_OBJMENDAYRATE";
            tableViewLabelColumn18.HeaderText = "工单业务人天比率";
            tableViewLabelColumn18.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Center;
            tableViewLabelColumn18.Text = "";
            tableViewLabelColumn18.VerticalAlignment = Smobiler.Core.VerticalAlignment.Center;
            tableViewLabelColumn18.Width = 110;
            tableViewLabelColumn19.DataMember = "WDOC_MENDAY1";
            tableViewLabelColumn19.DefaultBindPropertyValue = "";
            tableViewLabelColumn19.DisplayMember = "WDOC_MENDAY1";
            tableViewLabelColumn19.HeaderText = "其他人天";
            tableViewLabelColumn19.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Center;
            tableViewLabelColumn19.Text = "";
            tableViewLabelColumn19.VerticalAlignment = Smobiler.Core.VerticalAlignment.Center;
            tableViewLabelColumn19.Width = 62;
            tableViewLabelColumn20.DataMember = "USER_OBJMENDAY1";
            tableViewLabelColumn20.DefaultBindPropertyValue = "";
            tableViewLabelColumn20.DisplayMember = "USER_OBJMENDAY1";
            tableViewLabelColumn20.HeaderText = "目标其他人天";
            tableViewLabelColumn20.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Center;
            tableViewLabelColumn20.Text = "";
            tableViewLabelColumn20.VerticalAlignment = Smobiler.Core.VerticalAlignment.Center;
            tableViewLabelColumn20.Width = 80;
            tableViewLabelColumn21.DataMember = "USER_OBJMENDAY1RATE";
            tableViewLabelColumn21.DefaultBindPropertyValue = "";
            tableViewLabelColumn21.DisplayMember = "USER_OBJMENDAY1RATE";
            tableViewLabelColumn21.HeaderText = "目标其他人天比率";
            tableViewLabelColumn21.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Center;
            tableViewLabelColumn21.Text = "";
            tableViewLabelColumn21.VerticalAlignment = Smobiler.Core.VerticalAlignment.Center;
            tableViewLabelColumn21.Width = 110;
            this.TableView1.Columns.AddRange(new Smobiler.Core.Controls.TableViewColumn[] {
            tableViewLabelColumn15,
            tableViewImageColumn3,
            tableViewLabelColumn16,
            tableViewLabelColumn17,
            tableViewLabelColumn18,
            tableViewLabelColumn19,
            tableViewLabelColumn20,
            tableViewLabelColumn21});
            this.TableView1.GridLinesColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.TableView1.Name = "TableView1";
            this.TableView1.Size = new System.Drawing.Size(500, 230);
            this.TableView1.TabIndex = 5;
            // 
            // frmUserKPI
            // 
            this.AllowSlip = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.TableView1});
            this.ScreenOrientation = Smobiler.Core.ScreenOrientation.Landscape;
            this.Size = new System.Drawing.Size(500, 230);
            this.StatusBarStyle = Smobiler.Core.StatusBarStyle.Default;
            this.TitleStyle = new Smobiler.Core.MobileFormTitleStyle("Exit", System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242))))), System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(50))))));
            this.TitleText = "个人KPI";
            this.Load += new System.EventHandler(this.frmUserKPI_Load);
            this.TitleImageClick += new System.EventHandler(this.frmUserKPI_TitleImageClick);
            this.KeyDown += new Smobiler.Core.KeyDownEventHandler(this.frmUserKPI_KeyDown);
            this.Name = "frmUserKPI";

        }
        internal Smobiler.Core.Controls.TableView TableView1;
        #endregion

    }
}
