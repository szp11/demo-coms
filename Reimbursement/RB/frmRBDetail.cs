﻿
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using Smobiler.Core;
using Smobiler.Core.Controls;
using COMSSmobilerDemo.common;
namespace COMSSmobilerDemo.Reimbursement.RB
{
    public partial class frmRBDetail : Smobiler.Core.MobileForm
    {

        #region "Properties"
        internal string RB_NO;
        public string GetRB_NO
        {
            get { return RB_NO; }
            set { RB_NO = value; }
        }
        #endregion
   
        private void Bind()
        {

            try
            {
                //获取报销单信息
                this.lblRBNO.Text = "RB0001";
                this.lblRBCC.Text = "2015年项目预算/MobilerUser";
                int top = 71;
                int RB_STATE = 1;
                switch (RB_STATE)
                {
                    case -1:
                        string REASON = "报销不符合";
                        if (REASON.Length > 0)
                        {
                            txtRB_REASON.Text = "拒绝理由:" + REASON;
                        }
                        else
                        {
                            txtRB_REASON.Text = "拒绝理由:无";
                        }
                         txtRB_REASON.Visible = true;
                        lblRB_REASON1.Visible = true;
                        lblRBAmount.Top = top + txtRB_REASON.Height + 3;
                        lblRBState.Top = lblRBAmount.Top + lblRBAmount.Height;
                        GridView1.Top = lblRBState.Top + lblRBState.Height;
                        break;
                    default:
                         txtRB_REASON.Visible = false;
                         lblRB_REASON1.Visible = false;
                        lblRBAmount.Top = top + 3;
                        lblRBState.Top = lblRBAmount.Top + lblRBAmount.Height;
                        GridView1.Top = lblRBState.Top + lblRBState.Height;
                        break;
                }
                switch (RB_STATE)
                {
                    case 0:
                        this.lblRBState.Text = "已创建(可编辑)";
                        break;
                    case 1:
                        this.lblRBState.Text = "已提交";
                        break;
                    case 2:
                        this.lblRBState.Text = "已审批(责任人已审核)";
                        break;
                    case 3:
                        this.lblRBState.Text = "已审批(行政已审核)";
                        break;
                    case 4:
                        this.lblRBState.Text = "已完成(财务已审核)";
                        break;
                    case -1:
                        this.lblRBState.Text = "已拒绝";
                        break;
                }
                this.lblnote.Text = "无";
                this.lblRBAmount.Text = "￥250.00";

                ConsumptionInfo Consumptioninfo = new ConsumptionInfo();
                DataTable rbrowtable = Consumptioninfo.GetConsumptioninfo();
                if (rbrowtable.Rows.Count > 0)
                {
                    rbrowtable.Columns.Add("ROW_NOTE", typeof(System.String));
                    rbrowtable.Columns.Add("ROW_DATE", typeof(System.String));
                    foreach (DataRow row in rbrowtable.Rows)
                    {
                        if (row["RBROW_NOTE"].ToString().Length > 0)
                        {
                            row["ROW_NOTE"] = row["RBROW_NOTE"];
                        }
                        else
                        {
                            row["ROW_NOTE"] = "无";
                        }
                        row["ROW_DATE"] = Convert.ToDateTime(row["RBROW_DATE"]).ToShortDateString();
                    }
                    this.GridView1.DataSource = rbrowtable;
                    this.GridView1.DataBind();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 初始化事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>
        private void frmRBDetail_Load(object sender, EventArgs e)
        {
            try
            {
                Bind();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmRBDetail_ToolbarItemClick(object sender, ToolbarClickEventArgs e)
        {
            try
            {
                if (e.Name.Equals(tExit.Name))
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    
    }
}
