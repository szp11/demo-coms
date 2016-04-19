﻿using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using Smobiler.Core;
namespace COMSSmobilerDemo.WorkDocument.Layout
{
    public partial class frmWorkDLayout : Smobiler.Core.MobileForm
    {

        #region "SmobilerForm Designer generated code "

        public frmWorkDLayout()
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
            this.lblNOTE = new Smobiler.Core.Controls.Label();
            this.lblCC = new Smobiler.Core.Controls.Label();
            this.lblState = new Smobiler.Core.Controls.Label();
            this.lblMENDAYV = new Smobiler.Core.Controls.Label();
            // 
            // lblNOTE
            // 
            this.lblNOTE.DataMember = "WDOC_NOTE";
            this.lblNOTE.DisplayMember = "WDOC_NOTE";
            this.lblNOTE.Name = "lblNOTE";
            this.lblNOTE.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.lblNOTE.Size = new System.Drawing.SizeF(100F, 20F);
            this.lblNOTE.TabIndex = 2;
            this.lblNOTE.Text = "lblNOTE";
            // 
            // lblCC
            // 
            this.lblCC.DataMember = "CC_NAMEUSER";
            this.lblCC.DisplayMember = "CC_NAMEUSER";
            this.lblCC.ForeColor = System.Drawing.Color.Silver;
            this.lblCC.Location = new Smobiler.Core.PointS(0F, 20F);
            this.lblCC.Name = "lblCC";
            this.lblCC.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.lblCC.Size = new System.Drawing.SizeF(100F, 8F);
            this.lblCC.TabIndex = 3;
            this.lblCC.Text = "lblCC";
            this.lblCC.VerticalAlignment = Smobiler.Core.VerticalAlignment.Top;
            // 
            // lblState
            // 
            this.lblState.DataMember = "WDOC_STATE";
            this.lblState.DisplayMember = "STATEDESC";
            this.lblState.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblState.Location = new Smobiler.Core.PointS(100F, 0F);
            this.lblState.Name = "lblState";
            this.lblState.Padding = new Smobiler.Core.Padding(0F, 0F, 2F, 0F);
            this.lblState.Size = new System.Drawing.SizeF(20F, 20F);
            this.lblState.TabIndex = 4;
            this.lblState.Text = "lblState";
            // 
            // lblMENDAYV
            // 
            this.lblMENDAYV.DataMember = "WDOCMENDAYVFIELD";
            this.lblMENDAYV.DisplayMember = "WDOCMENDAYVFIELD";
            this.lblMENDAYV.ForeColor = System.Drawing.Color.Silver;
            this.lblMENDAYV.Location = new Smobiler.Core.PointS(100F, 20F);
            this.lblMENDAYV.Name = "lblMENDAYV";
            this.lblMENDAYV.Padding = new Smobiler.Core.Padding(0F, 0F, 2F, 0F);
            this.lblMENDAYV.Size = new System.Drawing.SizeF(20F, 10F);
            this.lblMENDAYV.TabIndex = 5;
            this.lblMENDAYV.Text = "lblMENDAYV";
            // 
            // frmWorkDLayout
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.lblNOTE,
            this.lblCC,
            this.lblState,
            this.lblMENDAYV});
            this.Size = new System.Drawing.Size(120, 28);

        }
        internal Smobiler.Core.Controls.Label lblNOTE;
        internal Smobiler.Core.Controls.Label lblCC;
        internal Smobiler.Core.Controls.Label lblState;

        internal Smobiler.Core.Controls.Label lblMENDAYV;
        #endregion

    }


}