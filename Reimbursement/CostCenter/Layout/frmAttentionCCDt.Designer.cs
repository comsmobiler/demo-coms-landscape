
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using Smobiler.Core;
namespace COMSSmobilerDemo.Reimbursement.CostCenter.Layout
{
public partial class frmAttentionCCDt : Smobiler.Core.MobileForm
{

    #region "SmobilerForm Designer generated code "

    public frmAttentionCCDt()
        : base()
    {

        //This call is required by the SmobilerForm Designer.
        InitializeComponent();

        //Add any initialization after the InitializeComponent() call

    }

    //VTForm overrides dispose to clean up the component list.
    protected override void Dispose(bool disposing)
    {
        base.Dispose(disposing);
    }


    //NOTE: The following procedure is required by the SmobilerForm Designer
    //It can be modified using the SmobilerForm Designer.  
    //Do not modify it using the code editor.
    [System.Diagnostics.DebuggerStepThrough()]

    private void InitializeComponent()
    {
            this.lblCC_ID = new Smobiler.Core.Controls.Label();
            this.lblCC_NAME = new Smobiler.Core.Controls.Label();
            this.imgUserAttention = new Smobiler.Core.Controls.ImageButton();
            this.Line6 = new Smobiler.Core.Controls.Line();
            // 
            // lblCC_ID
            // 
            this.lblCC_ID.DataMember = "CC_ID";
            this.lblCC_ID.DisplayMember = "CC_ID";
            this.lblCC_ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lblCC_ID.Name = "lblCC_ID";
            this.lblCC_ID.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.lblCC_ID.Size = new System.Drawing.Size(460, 25);
            this.lblCC_ID.TabIndex = 2;
            this.lblCC_ID.ZIndex = 1;
            // 
            // lblCC_NAME
            // 
            this.lblCC_NAME.DataMember = "CC_USER";
            this.lblCC_NAME.DisplayMember = "CC_NAME";
            this.lblCC_NAME.FontSize = 13F;
            this.lblCC_NAME.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.lblCC_NAME.Location = new System.Drawing.Point(0, 25);
            this.lblCC_NAME.Name = "lblCC_NAME";
            this.lblCC_NAME.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.lblCC_NAME.Size = new System.Drawing.Size(460, 20);
            this.lblCC_NAME.TabIndex = 3;
            this.lblCC_NAME.ZIndex = 2;
            // 
            // imgUserAttention
            // 
            this.imgUserAttention.FontSize = 10F;
            this.imgUserAttention.Location = new System.Drawing.Point(460, 5);
            this.imgUserAttention.Name = "imgUserAttention";
            this.imgUserAttention.ResourceID = "unAttention";
            this.imgUserAttention.Size = new System.Drawing.Size(35, 35);
            this.imgUserAttention.TabIndex = 4;
            this.imgUserAttention.ZIndex = 3;
            // 
            // Line6
            // 
            this.Line6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Line6.Location = new System.Drawing.Point(0, 45);
            this.Line6.Name = "Line6";
            this.Line6.Size = new System.Drawing.Size(500, 3);
            this.Line6.TabIndex = 5;
            this.Line6.ZIndex = 4;
            // 
            // frmAttentionCCDt
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.lblCC_ID,
            this.lblCC_NAME,
            this.imgUserAttention,
            this.Line6});
            this.Size = new System.Drawing.Size(500, 45);
            this.Name = "frmAttentionCCDt";

    }
    internal Smobiler.Core.Controls.Label lblCC_ID;
    internal Smobiler.Core.Controls.Label lblCC_NAME;
    internal Smobiler.Core.Controls.ImageButton imgUserAttention;
    internal Smobiler.Core.Controls.Line Line6;

    #endregion

}
}
