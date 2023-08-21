using DataLayer.Context;
using Fury;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Utility.Convertor;

namespace Ui.Boost
{
    public partial class frmBoostSetting : Form
    {
        public frmBoostSetting()
        {
            InitializeComponent();
        }
        void frmRefresh()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                List<DataLayer.Boost> result = new List<DataLayer.Boost>();

                if (txtfilter.Text != "")
                {
                    result = db.BoostRepository.Search(txtfilter.Text).OrderByDescending(b => b.DateTime).ToList();
                }
                else
                {
                    result = db.BoostRepository.GetAllBoost();
                }


                if (chbFromDate.Checked)
                {
                    result = result.Where(b => b.DateTime >= dateFrom.Value).ToList();
                }

                if (chbToDate.Checked)
                {
                    result = result.Where(b => b.DateTime <= dateTo.Value).ToList();
                }


                //if (txtFrom.Text != "  /  /")
                //{
                //    startDate = Convert.ToDateTime(txtFrom.Text);
                //    result = result.Where(b => b.DateTime >= startDate.Value).ToList();
                //}
                //if (txtToo.Text != "  /  /")
                //{
                //    endDate = Convert.ToDateTime(txtToo.Text);
                //    result = result.Where(b => b.DateTime <= endDate.Value).ToList();
                //}


                dgvBoostList.Rows.Clear();
                dgvBoostList.AutoGenerateColumns = false;
                foreach (var boost in result)
                {
                    dgvBoostList.Rows.Add(boost.BoostID, boost.Player.FullName, boost.Dungeon.Name, boost.Gold, boost.Lvl, boost.DateTime.ToString());
                }
                db.Dispose();
            }
        }

        private void frmBoostSetting_Load(object sender, EventArgs e)
        {
            frmRefresh();
        }

        private void txtfilter_TextChanged(object sender, EventArgs e)
        {
            frmRefresh();
        }

        private void btnDateFilter_Click(object sender, EventArgs e)
        {
            frmRefresh();
        }



        private void chbFromDate_CheckedChanged(object sender, EventArgs e)
        {
            dateFrom.Enabled = chbFromDate.Checked;
        }

        private void chbToDate_CheckedChanged(object sender, EventArgs e)
        {
            dateTo.Enabled = chbToDate.Checked;
        }

        private void dateFrom_ValueChanged(object sender, EventArgs e)
        {
            frmRefresh();
        }

        private void dateTo_ValueChanged(object sender, EventArgs e)
        {
            frmRefresh();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvBoostList.CurrentRow != null)
                {
                    int boostid = int.Parse(dgvBoostList.CurrentRow.Cells["BoostID"].Value.ToString());
                    using (UnitOfWork db = new UnitOfWork())
                    {

                        db.RunRepository.DeleteRuns(boostid);
                        db.Save();
                        db.Dispose();
                    }

                    using (UnitOfWork db = new UnitOfWork())
                    {

                        db.BoostRepository.DeleteBoost(boostid);
                        db.Save();
                        db.Dispose();
                    }
                    frmRefresh();
                }
            }
            catch (NullReferenceException ex)
            {
                FileLogger.Log(ex.ToString());
                MessageBox.Show("Please choose Boost");
            }

            
        }

        private void btnDetailBoost_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvBoostList.CurrentRow != null)
                {
                    int boostid = int.Parse(dgvBoostList.CurrentRow.Cells["BoostID"].Value.ToString());
                    frmBoostDetail frmedit = new frmBoostDetail();
                    frmedit.Boostid = boostid;
                    frmedit.ShowDialog();
                    frmRefresh();
                }
            }
            catch(Exception ex)
            {
                FileLogger.Log(ex.ToString());
                MessageBox.Show("Please choose Boost");
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvBoostList.CurrentRow != null)
                {
                    int boostid = int.Parse(dgvBoostList.CurrentRow.Cells["BoostID"].Value.ToString());
                    frmBoostEdit frmedit = new frmBoostEdit();
                    frmedit.Boostid = boostid;
                    frmedit.ShowDialog();
                    frmRefresh();
                }
            }
            catch (Exception ex)
            {
                if (ex.GetType().Name== "NullReferenceException")
                {
                    MessageBox.Show("Please choose Boost");
                }
                FileLogger.Log(ex.ToString());

            }
   
            
        }
    }
}
