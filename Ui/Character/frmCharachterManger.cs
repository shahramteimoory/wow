using DataLayer.Context;
using System;
using System.Windows.Forms;

namespace Fury.Character
{

    public partial class frmCharachterManger : Form
    {
        public frmCharachterManger()
        {
            InitializeComponent();
        }
        public string PlayerName;
        public int Playerid;

        private void frmrefresh()
        {
            dgvCharacters.Rows.Clear();
            using (UnitOfWork db = new UnitOfWork())
            {
                var character = db.CharacterRepository.GetCharachterByPlayerID(Playerid);
                if (character.Count == 0)
                {
                    dgvCharacters.Rows.Add(null, null, "Can't Found any Character", null, null);
                }
                else
                {
                    foreach (var item in character)
                    {
                        dgvCharacters.Rows.Add(item.CharacterID, "Select", item.Name, item.Realm, item.Region, "View");
                    }

                }

            }
        }
        private void frmCharachterManger_Load(object sender, EventArgs e)
        {
            lblPlayerName.Text = PlayerName;
            frmrefresh();
        }


        private void btnInsert_Click(object sender, EventArgs e)
        {
            frmInsertCharacter frmInsertCharacter = new frmInsertCharacter();
            frmInsertCharacter.playerName = PlayerName;
            frmInsertCharacter.PlayerID = Playerid;
            frmInsertCharacter.ShowDialog();
            frmrefresh();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            string charname = dgvCharacters.CurrentRow.Cells[2].Value.ToString();

            DialogResult result = MessageBox.Show($"Are you Sure to Delete {charname} ", "Warning", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    using (UnitOfWork db = new UnitOfWork())
                    {
                        db.CharacterRepository.DeleteCharachter(Convert.ToInt32(dgvCharacters.CurrentRow.Cells[0].Value.ToString()));
                        db.Save();
                        frmrefresh();
                    }
                }

                catch (NullReferenceException)
                {
                    MessageBox.Show("Cant find Character for delete");
                    return;
                }

            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmInsertCharacter frmInsertCharacter= new frmInsertCharacter();
            frmInsertCharacter.CharacterID = Convert.ToInt32(dgvCharacters.CurrentRow.Cells[0].Value.ToString());
            frmInsertCharacter.playerName = PlayerName;
            frmInsertCharacter.PlayerID = Playerid;
            frmInsertCharacter.ShowDialog();
            frmrefresh();
        }

        private void dgvCharacters_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5 && e.RowIndex != -1)
            {
                string name= dgvCharacters.CurrentRow.Cells[2].Value.ToString();
                string realm = dgvCharacters.CurrentRow.Cells[3].Value.ToString();
                string region = dgvCharacters.CurrentRow.Cells[4].Value.ToString();
               frmDetailCharacter frmDetailCharacter = new frmDetailCharacter();
                frmDetailCharacter.realm = realm;
                frmDetailCharacter.region = region;
                frmDetailCharacter.name = name;
                frmDetailCharacter.ShowDialog();

            }
        }
    }
}

