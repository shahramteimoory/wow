using DataLayer;
using DataLayer.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ui.Report;

namespace Fury.Character
{
    public partial class frmCharacterPlayer : Form
    {
        public frmCharacterPlayer()
        {
            InitializeComponent();
        }
        void frmRefresh()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                dgvPlayerList.AutoGenerateColumns = false;
                dgvPlayerList.DataSource = db.PlayerRepository.GetAllPlayer();
                db.Dispose();
            }
            
             for (int i = 0; i < dgvPlayerList.Rows.Count; i++)
            {
                dgvPlayerList.Rows[i].Cells[2].Value = "View";
            }
        
    }
        private void frmCharacterPlayer_Load(object sender, EventArgs e)
        {
            frmRefresh();
        }

        private void dgvPlayerList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.RowIndex != -1)
            {
                int playerid = int.Parse(dgvPlayerList.CurrentRow.Cells["Column1"].Value.ToString());
                string playername = (dgvPlayerList.CurrentRow.Cells["Column2"].Value.ToString());
                frmCharachterManger frmCharachterManger = new frmCharachterManger();
                frmCharachterManger.Playerid = playerid;
                frmCharachterManger.PlayerName = playername;
                frmCharachterManger.ShowDialog();
            }
        }
    }
}
