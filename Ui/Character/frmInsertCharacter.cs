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
using ValidationComponents;

namespace Fury.Character
{
    public partial class frmInsertCharacter : Form
    {
        public string playerName;
        public int PlayerID;
        public frmInsertCharacter()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmInsertCharacter_Load(object sender, EventArgs e)
        {
            lblPlayerName.Text = playerName;
            cbRegion.SelectedIndex = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components))
            {
                using(UnitOfWork db = new UnitOfWork())
                {
                    int count = db.CharacterRepository.GetCount(txtCharacterName.Text,txtRealm.Text,cbRegion.Text);

                    if (count>0)
                    {
                        MessageBox.Show("Character Already Exict");
                        return;
                    }
                    else
                    {
                        DataLayer.Character character = new DataLayer.Character()
                        {
                            PlayerID = PlayerID,
                            Region = cbRegion.Text,
                            Realm = txtRealm.Text,
                            Name = txtCharacterName.Text,
                        };
                        db.CharacterRepository.InsertCharachter(character);
                        db.Save();
                        txtCharacterName.Clear();
                        txtRealm.Clear();
                    }

                }
            }
        }
    }
}
