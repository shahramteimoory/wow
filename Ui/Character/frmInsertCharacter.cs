using DataLayer.Context;
using System;
using System.Windows.Forms;
using ValidationComponents;

namespace Fury.Character
{
    public partial class frmInsertCharacter : Form
    {
        public string playerName;
        public int PlayerID;
        public int CharacterID = 0;
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
            if (CharacterID == 0)
            {

                cbRegion.SelectedIndex = 0;
            }
            else
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    DataLayer.Character character = new DataLayer.Character();
                    character = db.CharacterRepository.GetCharacterByCharacterID(CharacterID);
                    cbRegion.Text = character.Region;
                    txtCharacterName.Text = character.Name;
                    txtRealm.Text = character.Realm;
                    btnSave.Text = "Edit";
                    this.Text = "Character Edit";
                }
            }
            lblPlayerName.Text = playerName;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components))
            {
                if (CharacterID == 0)
                {
                    using (UnitOfWork db = new UnitOfWork())
                    {
                        int count = db.CharacterRepository.GetCount(txtCharacterName.Text, txtRealm.Text, cbRegion.Text);

                        if (count > 0)
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
                                Name = txtCharacterName.Text
                            };
                            db.CharacterRepository.InsertCharachter(character);
                            db.Save();
                            txtCharacterName.Clear();
                            txtRealm.Clear();
                        }

                    }

                }
                else
                {
                    using (UnitOfWork db=new UnitOfWork()) 
                    {
                        int count = db.CharacterRepository.GetCount(txtCharacterName.Text, txtRealm.Text, cbRegion.Text);

                        if (count > 0)
                        {
                            MessageBox.Show("Character Already Exict");
                            return;
                        }
                        else
                        {
                            DataLayer.Character character = new DataLayer.Character()
                            {
                                CharacterID = CharacterID,
                                PlayerID = PlayerID,
                                Region = cbRegion.Text,
                                Realm = txtRealm.Text,
                                Name = txtCharacterName.Text
                            };
                            db.CharacterRepository.UpdateCharachter(character);
                            db.Save();
                            this.Close();
                        }
                    }
                }
            }
        }
    }
}
