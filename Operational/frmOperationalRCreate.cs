﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using System.Data;

namespace COMSSmobilerDemo.Operational
{
    partial class frmOperationalRCreate : Smobiler.Core.MobileForm
    {
        #region "Properties"
        //客户
        private string CUST_ID = "";
        //处理结果
        private string OR_PROCESSRESULT = "";
        //维护人员
        private string OR_MAINTAINER = "";
        //button标识
        private object  btnmode;
        #endregion

        /// <summary>
        /// 客户，处理结果，审批人选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnpop_Click(object sender, EventArgs e)
        {
            try
            {
                PopList1.Groups.Clear();
                //获取审批人
                btnmode = sender;
                OperationalInfo OperationalR = new OperationalInfo();
                DataTable table = new DataTable();
                PopListGroup poli = new PopListGroup();
                PopList1.Groups.Add(poli);

                switch (((Button)sender).Name)
                {
                    case "btnCU":
                    case "btnCU2":
                        poli.Text = "客户选择";
                        table = OperationalR.GetCUData();
                        break;
                    case "btnOR_PROCESSRESULT":
                    case "btnOR_PROCESSRESULT2":
                        poli.Text = "处理方式选择";
                        table = OperationalR.GetProcessResultData();
                        break;
                    case "btnOR_MAINTAINER":
                    case "btnOR_MAINTAINER2":
                        poli.Text = "维护人员选择";
                        table = OperationalR.GetUserData();
                        break;
                }

                foreach (DataRow rowli in table.Rows)
                {
                    switch (((Button)sender).Name)
                    {
                        case "btnCU":
                        case "btnCU2":
                            poli.Items.Add(rowli["CUST_NAME"].ToString(), rowli["CUST_ID"].ToString());
                            if (CUST_ID.Trim().Length > 0)
                            {
                                if (CUST_ID.Trim().Equals ( rowli["CUST_ID"].ToString().Trim()))
                                {
                                    PopList1.SetSelections(poli.Items[(poli.Items.Count - 1)]);
                                }
                            }
                            break;
                        case "btnOR_PROCESSRESULT":
                        case "btnOR_PROCESSRESULT2":
                            poli.Items.Add(rowli["ProcessResultStateName"].ToString(), rowli["ProcessResultState"].ToString());
                            if (OR_PROCESSRESULT.Trim().Length > 0)
                            {
                                if (OR_PROCESSRESULT.Trim() .Equals ( rowli["ProcessResultState"].ToString().Trim()))
                                {
                                    PopList1.SetSelections(poli.Items[(poli.Items.Count - 1)]);
                                }
                            }
                            break;
                        case "btnOR_MAINTAINER":
                        case "btnOR_MAINTAINER2":
                            poli.Items.Add(rowli["USER_ID"].ToString(), rowli["USER_ID"].ToString());
                            if (OR_MAINTAINER.Trim().Length > 0)
                            {
                                if (OR_MAINTAINER.Trim().ToUpper().Equals ( rowli["USER_ID"].ToString().Trim().ToUpper()))
                                {
                                    PopList1.SetSelections(poli.Items[(poli.Items.Count - 1)]);
                                }
                            }
                            break;
                    }
                }
                switch (((Button)sender).Name)
                {
                    case "btnCU":
                    case "btnCU2":
                    case "btnOR_MAINTAINER":
                    case "btnOR_MAINTAINER2":
                        PopList1.Show();
                        poli.Text = "客户选择";
                        table = OperationalR.GetCUData();
                        break;
                    case "btnOR_PROCESSRESULT":
                    case "btnOR_PROCESSRESULT2":
                        PopList1.ShowDialog();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        /// <summary>
        /// 客户，处理结果，审批人赋值
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PopList1_Selected(object sender, EventArgs e)
        {
            try
            {
                if (PopList1.Selection != null)
                {
                    switch (((Button)btnmode ).Name)
                    {
                        case "btnCU":
                        case "btnCU2":
                            CUST_ID = PopList1.Selection.Value;
                            this.btnCU.Text = PopList1.Selection.Text.Trim();
                            break;
                        case "btnOR_PROCESSRESULT":
                        case "btnOR_PROCESSRESULT2":
                            OR_PROCESSRESULT = PopList1.Selection.Value;
                            this.btnOR_PROCESSRESULT.Text = PopList1.Selection.Text.Trim();
                            break;
                        case "btnOR_MAINTAINER":
                        case "btnOR_MAINTAINER2":
                            OR_MAINTAINER = PopList1.Selection.Value;
                            this.btnOR_MAINTAINER.Text = PopList1.Selection.Text.Trim();
                            break;
                    }
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
        private void frmOperationalRCreate_Load(object sender, EventArgs e)
        {
            Bind();
        }
        /// <summary>
        /// 初始化方法
        /// </summary>
        private void Bind()
        {
            try
            {
                OR_PROCESSRESULT = Convert.ToInt32(ProcessResultState.待跟踪).ToString ();
                btnOR_PROCESSRESULT.Text = "待跟踪";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 图片上传
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OR_IMG_Click(object sender, EventArgs e)
        {
            Camera1.GetPhoto();
        }
        /// <summary>
        /// 图片上传赋值
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Camera1_ImageCaptured(object sender, BinaryData e)
        {
            try
            {
                if (string.IsNullOrEmpty(e.ErrorInfo))
                {
                    if (OR_IMG.ResourceID.Length > 0)
                    {
                        e.SaveFile(OR_IMG.ResourceID);
                        OR_IMG.Refresh();
                    }
                    else
                    {
                        e.SaveFile();
                        OR_IMG.ResourceID = e.ResourceID;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmOperationalRCreate_ToolbarItemClick(object sender, ToolbarClickEventArgs e)
        {
            try
            {
                if (e.Name.Equals(tExit.Name))
                {
                    MessageBox.Show("是否确定返回？", MessageBoxButtons.YesNo, (Object s, MessageBoxHandlerArgs args) =>
                    {
                        if (args.Result == Smobiler.Core.ShowResult.Yes)
                        {
                            this.Close();
                        }
                    }
                    );

                }
                else if (e.Name.Equals(save.Name))
                {
                    if (txtOR_DECLARANT.Text.Length < 0)
                    {
                        throw new Exception("请输入申报人！");
                    }

                    if (txtOR_FAULTINFO.Text.Length < 0)
                    {
                        throw new Exception("请输入故障描述！");
                    }
                    MessageBox.Show("运维记录已创建成功！", (Object s, MessageBoxHandlerArgs args) =>
                    {
                        ShowResult = Smobiler.Core.ShowResult.Yes;
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}