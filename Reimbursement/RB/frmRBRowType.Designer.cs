﻿using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using Smobiler.Core;
namespace COMSSmobilerDemo.Reimbursement.RB
{
    public partial class frmRBRowType : Smobiler.Core.MobileForm
    {

        #region "SmobilerForm Designer generated code "

        public frmRBRowType()
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
            this.GridView1 = new Smobiler.Core.Controls.GridView();
            this.tExit = new Smobiler.Core.Controls.ToolbarItem();
            this.Line6 = new Smobiler.Core.Controls.Line();
            // 
            // GridView1
            // 
            this.GridView1.Layout = "frmRBTypeLayout";
            this.GridView1.Location = new Smobiler.Core.PointS(0F, 1F);
            this.GridView1.Name = "GridView1";
            this.GridView1.ShowGridLines = false;
            this.GridView1.Size = new System.Drawing.SizeF(120F, 199F);
            this.GridView1.TabIndex = 2;
            this.GridView1.CellClick += new Smobiler.Core.Controls.GridViewCellClickEventHandler(this.GridView1_CellClick);
            // 
            // tExit
            // 
            this.tExit.IconID = "Exit";
            this.tExit.Name = "tExit";
            this.tExit.Text = "返回";
            // 
            // Line6
            // 
            this.Line6.BackColor = System.Drawing.Color.Gray;
            this.Line6.LineSize = 0.5F;
            this.Line6.Name = "Line6";
            this.Line6.Size = new System.Drawing.SizeF(120F, 1F);
            this.Line6.TabIndex = 4;
            // 
            // frmRBRowType
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.GridView1,
            this.Line6});
            this.TitleBackColor = System.Drawing.Color.DeepSkyBlue;
            this.TitleImage = "formimg";
            this.TitleText = "消费类型";
            this.Toolbar.AddRange(new Smobiler.Core.Controls.ToolbarItem[] {
            this.tExit});
            this.Load += new System.EventHandler(this.frmRBRowType_Load);
            this.ToolbarItemClick += new Smobiler.Core.ToolbarItemClickEventHandler(this.frmRBRowType_ToolbarItemClick);

        }
        internal Smobiler.Core.Controls.GridView GridView1;
        internal Smobiler.Core.Controls.ToolbarItem tExit;

        internal Smobiler.Core.Controls.Line Line6;
        #endregion

    }
}