﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace COMSSmobilerDemo.WorkDocument
{
    partial class frmWorkDocumentDetail : Smobiler.Core.MobileForm
    {
        private void frmWorkDocumentDetail_Load(object sender, EventArgs e)
        {
            Bind();
        }
        private void Bind()
        {
            lbllNO.Text = "WD001";
            lbltype.Text = "日结单";
            lblCC.Text = "2015年项目预算";
            lblworkday.Text = "2.00";
            lblNote.Text = "测试";
            lblMenDay.Text = "人天值2.00天";
            lblState.Text = "已提交";
        }

        private void frmWorkDocumentDetail_ToolbarItemClick(object sender, ToolbarClickEventArgs e)
        {
            Close();
        }
    }
}