using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AI_Character_Editor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Fill_AI_Lords();
            this.Fill_OffUnits();
            this.Fill_DefUnits();
            this.trackBar_Patrols.Value = 10;
            this.trackBar_WallDef.Value = 20;
            this.trackBar_FirstAttackForceSize.Value = 10;
            this.trackBar_AttackForceIncreaseStatic.Value = 7;
            this.txtBox_AttackForceIncreaseMultiplier.Text =" 0.5";
            this.txtBox_Patrols.Text = "10";
            this.txtBox_WalLDef.Text = "20";
            this.txtBox_FirstAttackForceSize.Text = "10";
            this.txtBox_AttackForceIncreaseStatic.Text = "7";
        }

        private void Fill_AI_Lords()
        {
            this.AI_Lords.Items.Add(Enums.AI_Lord.Rat.ToString());
            this.AI_Lords.Items.Add(Enums.AI_Lord.Snake.ToString());
            this.AI_Lords.Items.Add(Enums.AI_Lord.Pig.ToString());
            this.AI_Lords.Items.Add(Enums.AI_Lord.Wolf.ToString());

            this.AI_Lords.Items.Add(Enums.AI_Lord.Sultan.ToString());
            this.AI_Lords.Items.Add(Enums.AI_Lord.Caliph.ToString());
            this.AI_Lords.Items.Add(Enums.AI_Lord.Richard.ToString());
            this.AI_Lords.Items.Add(Enums.AI_Lord.Saladin.ToString());

            this.AI_Lords.Items.Add(Enums.AI_Lord.Wazir.ToString());
            this.AI_Lords.Items.Add(Enums.AI_Lord.Emir.ToString());
            this.AI_Lords.Items.Add(Enums.AI_Lord.Nizar.ToString());
            this.AI_Lords.Items.Add(Enums.AI_Lord.Sheriff.ToString());
            this.AI_Lords.Items.Add(Enums.AI_Lord.Frederick.ToString());
            this.AI_Lords.Items.Add(Enums.AI_Lord.Philipp.ToString());
            this.AI_Lords.Items.Add(Enums.AI_Lord.Marshall.ToString());
            this.AI_Lords.Items.Add(Enums.AI_Lord.Abbot.ToString());

            this.AI_Lords.SelectedIndex = 0;
        }

        private void Fill_DefUnits()
        {
            this.DefUnit1.Items.AddRange(Static_Methods.GetUnitTypes().ToArray());
            this.DefUnit2.Items.AddRange(Static_Methods.GetUnitTypes().ToArray());
            this.DefUnit3.Items.AddRange(Static_Methods.GetUnitTypes().ToArray());
            this.DefUnit4.Items.AddRange(Static_Methods.GetUnitTypes().ToArray());
            this.DefUnit5.Items.AddRange(Static_Methods.GetUnitTypes().ToArray());
            this.DefUnit6.Items.AddRange(Static_Methods.GetUnitTypes().ToArray());
            this.DefUnit7.Items.AddRange(Static_Methods.GetUnitTypes().ToArray());
            this.DefUnit8.Items.AddRange(Static_Methods.GetUnitTypes().ToArray());

            this.DefUnit1.SelectedIndex = 0;
            this.DefUnit2.SelectedIndex = 0;
            this.DefUnit3.SelectedIndex = 0;
            this.DefUnit4.SelectedIndex = 0;
            this.DefUnit5.SelectedIndex = 0;
            this.DefUnit6.SelectedIndex = 0;
            this.DefUnit7.SelectedIndex = 0;
            this.DefUnit8.SelectedIndex = 0;
        }
        private void Fill_OffUnits()
        {
            this.OffUnit1.Items.AddRange(Static_Methods.GetUnitTypes().ToArray());
            this.OffUnit2.Items.AddRange(Static_Methods.GetUnitTypes().ToArray());
            this.OffUnit3.Items.AddRange(Static_Methods.GetUnitTypes().ToArray());
            this.OffUnit4.Items.AddRange(Static_Methods.GetUnitTypes().ToArray());
            this.OffUnit5.Items.AddRange(Static_Methods.GetUnitTypes().ToArray());
            this.OffUnit6.Items.AddRange(Static_Methods.GetUnitTypes().ToArray());
            this.OffUnit7.Items.AddRange(Static_Methods.GetUnitTypes().ToArray());
            this.OffUnit8.Items.AddRange(Static_Methods.GetUnitTypes().ToArray());

            this.OffUnit1.SelectedIndex = 0;
            this.OffUnit2.SelectedIndex = 0;
            this.OffUnit3.SelectedIndex = 0;
            this.OffUnit4.SelectedIndex = 0;
            this.OffUnit5.SelectedIndex = 0;
            this.OffUnit6.SelectedIndex = 0;
            this.OffUnit7.SelectedIndex = 0;
            this.OffUnit8.SelectedIndex = 0;
        }

        private void txtBox_Patrols_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.trackBar_Patrols.Value = Convert.ToInt32(this.txtBox_Patrols.Text);
            }
            catch
            {
                //User being stupid again...
            }
        }

        private void trackBar_Patrols_Scroll(object sender, EventArgs e) => this.txtBox_Patrols.Text = Convert.ToString(this.trackBar_Patrols.Value);

        private void txtBox_Patrols_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void trackBar_WallDef_Scroll(object sender, EventArgs e) => this.txtBox_WalLDef.Text = Convert.ToString(this.trackBar_WallDef.Value);

        private void txtBox_WalLDef_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.trackBar_WallDef.Value = Convert.ToInt32(this.txtBox_WalLDef.Text);
            }
            catch 
            {
                //User is being stupid again...
            }
        }

        private void txtBox_WalLDef_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void CreateAICharacter_Click(object sender, EventArgs e)
        {
            var edit = new AIEdit();
            Enum.TryParse(this.AI_Lords.GetItemText(this.AI_Lords.SelectedItem), out edit.AI);
            edit.RecruitingBehaviour = new RecruitingBehaviour();

            edit.RecruitingBehaviour.WallDef = this.trackBar_WallDef.Value;
            edit.RecruitingBehaviour.TotalDef = this.trackBar_WallDef.Value + this.trackBar_Patrols.Value;
            this.LoadDefUnits(edit);


            //Until more info from Nere
            /*
            edit.RecruitingBehaviour.FirstAttackForceSize = this.trackBar_FirstAttackForceSize.Value;
            edit.RecruitingBehaviour.AttackForceIncreaseStatic = this.trackBar_AttackForceIncreaseStatic.Value;
            edit.RecruitingBehaviour.AttackForceIncreaseMultiplier = Convert.ToDouble(this.txtBox_AttackForceIncreaseMultiplier.Text); 
            this.LoadOffUnits(edit); */

            //if (Static_Methods.SaveAICharacterXML(edit))
            if (Static_Methods.SaveAICharacterJSON(edit))
            {
                MessageBox.Show("AI character created successfully!");
                //open?
            }
            else
                MessageBox.Show("AI character could not be created!");
        }

        private void LoadDefUnits(AIEdit edit)
        {
            Enums.UnitType unitType = Enums.UnitType.NONE;
            Enum.TryParse(this.DefUnit1.GetItemText(this.DefUnit1.SelectedItem), out unitType);
            edit.RecruitingBehaviour.Defenders.Add(new DefendingUnit()
            {
                DefUnit = Enums.DefUnit.DefUnit1,
                UnitType = unitType
            });

            Enum.TryParse(this.DefUnit2.GetItemText(this.DefUnit2.SelectedItem), out unitType);
            edit.RecruitingBehaviour.Defenders.Add(new DefendingUnit()
            {
                DefUnit = Enums.DefUnit.DefUnit2,
                UnitType = unitType
            });

            Enum.TryParse(this.DefUnit3.GetItemText(this.DefUnit3.SelectedItem), out unitType);
            edit.RecruitingBehaviour.Defenders.Add(new DefendingUnit()
            {
                DefUnit = Enums.DefUnit.DefUnit3,
                UnitType = unitType
            });

            Enum.TryParse(this.DefUnit4.GetItemText(this.DefUnit4.SelectedItem), out unitType);
            edit.RecruitingBehaviour.Defenders.Add(new DefendingUnit()
            {
                DefUnit = Enums.DefUnit.DefUnit4,
                UnitType = unitType
            });

            Enum.TryParse(this.DefUnit5.GetItemText(this.DefUnit5.SelectedItem), out unitType);
            edit.RecruitingBehaviour.Defenders.Add(new DefendingUnit()
            {
                DefUnit = Enums.DefUnit.DefUnit5,
                UnitType = unitType
            });

            Enum.TryParse(this.DefUnit6.GetItemText(this.DefUnit6.SelectedItem), out unitType);
            edit.RecruitingBehaviour.Defenders.Add(new DefendingUnit()
            {
                DefUnit = Enums.DefUnit.DefUnit6,
                UnitType = unitType
            });

            Enum.TryParse(this.DefUnit7.GetItemText(this.DefUnit7.SelectedItem), out unitType);
            edit.RecruitingBehaviour.Defenders.Add(new DefendingUnit()
            {
                DefUnit = Enums.DefUnit.DefUnit7,
                UnitType = unitType
            });

            Enum.TryParse(this.DefUnit8.GetItemText(this.DefUnit8.SelectedItem), out unitType);
            edit.RecruitingBehaviour.Defenders.Add(new DefendingUnit()
            {
                DefUnit = Enums.DefUnit.DefUnit8,
                UnitType = unitType
            });
        }

        private void LoadOffUnits(AIEdit edit)
        {
            Enums.UnitType unitType = Enums.UnitType.NONE;
            Enum.TryParse(this.OffUnit1.GetItemText(this.OffUnit1.SelectedItem), out unitType);
            edit.RecruitingBehaviour.Attackers.Add(new AttackingUnit()
            {
                OffUnit = Enums.OffUnit.OfffUnit1,
                UnitType = unitType
            });

            Enum.TryParse(this.OffUnit2.GetItemText(this.OffUnit2.SelectedItem), out unitType);
            edit.RecruitingBehaviour.Attackers.Add(new AttackingUnit()
            {
                OffUnit = Enums.OffUnit.OffUnit2,
                UnitType = unitType
            });

            Enum.TryParse(this.OffUnit3.GetItemText(this.OffUnit3.SelectedItem), out unitType);
            edit.RecruitingBehaviour.Attackers.Add(new AttackingUnit()
            {
                OffUnit = Enums.OffUnit.OffUnit3,
                UnitType = unitType
            });

            Enum.TryParse(this.OffUnit4.GetItemText(this.OffUnit4.SelectedItem), out unitType);
            edit.RecruitingBehaviour.Attackers.Add(new AttackingUnit()
            {
                OffUnit = Enums.OffUnit.OffUnit4,
                UnitType = unitType
            });

            Enum.TryParse(this.OffUnit5.GetItemText(this.OffUnit5.SelectedItem), out unitType);
            edit.RecruitingBehaviour.Attackers.Add(new AttackingUnit()
            {
                OffUnit = Enums.OffUnit.OffUnit5,
                UnitType = unitType
            });

            Enum.TryParse(this.OffUnit6.GetItemText(this.OffUnit6.SelectedItem), out unitType);
            edit.RecruitingBehaviour.Attackers.Add(new AttackingUnit()
            {
                OffUnit = Enums.OffUnit.OffUnit6,
                UnitType = unitType
            });

            Enum.TryParse(this.OffUnit7.GetItemText(this.OffUnit7.SelectedItem), out unitType);
            edit.RecruitingBehaviour.Attackers.Add(new AttackingUnit()
            {
                OffUnit = Enums.OffUnit.OffUnit7,
                UnitType = unitType
            });

            Enum.TryParse(this.OffUnit8.GetItemText(this.OffUnit8.SelectedItem), out unitType);
            edit.RecruitingBehaviour.Attackers.Add(new AttackingUnit()
            {
                OffUnit = Enums.OffUnit.OffUnit8,
                UnitType = unitType
            });
        }

        private void open_Existing_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.DefaultExt = ".aic";
            fileDialog.CheckFileExists = true;
            fileDialog.CheckPathExists = true;
            fileDialog.Title = "Select an existing AI profile";
            fileDialog.Multiselect = false;
            fileDialog.Filter = "AI character files (*.aic)|*.aic";
            fileDialog.InitialDirectory = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

            if(fileDialog.ShowDialog() == DialogResult.OK)
            {
                //AIEdit aiEdit = Static_Methods.LoadAIProfileXML(fileDialog.FileName);
                AIEdit aiEdit = Static_Methods.LoadAICharacterJSON(fileDialog.FileName);

                if (aiEdit != null)
                {
                    MessageBox.Show("AI character loaded successfully!");

                    this.AI_Lords.SelectedIndex = (int)aiEdit.AI;
                    this.trackBar_Patrols.Value = aiEdit.RecruitingBehaviour.TotalDef - aiEdit.RecruitingBehaviour.WallDef;
                    this.txtBox_Patrols.Text = Convert.ToString(aiEdit.RecruitingBehaviour.TotalDef - aiEdit.RecruitingBehaviour.WallDef);
                    this.trackBar_WallDef.Value = aiEdit.RecruitingBehaviour.WallDef;
                    this.txtBox_WalLDef.Text = Convert.ToString(aiEdit.RecruitingBehaviour.WallDef);
                    this.DefUnit1.SelectedItem = aiEdit.RecruitingBehaviour.Defenders[0].UnitType.ToString();
                    this.DefUnit2.SelectedItem = aiEdit.RecruitingBehaviour.Defenders[1].UnitType.ToString();
                    this.DefUnit3.SelectedItem = aiEdit.RecruitingBehaviour.Defenders[2].UnitType.ToString();
                    this.DefUnit4.SelectedItem = aiEdit.RecruitingBehaviour.Defenders[3].UnitType.ToString();
                    this.DefUnit5.SelectedItem = aiEdit.RecruitingBehaviour.Defenders[4].UnitType.ToString();
                    this.DefUnit6.SelectedItem = aiEdit.RecruitingBehaviour.Defenders[5].UnitType.ToString();
                    this.DefUnit7.SelectedItem = aiEdit.RecruitingBehaviour.Defenders[6].UnitType.ToString();
                    this.DefUnit8.SelectedItem = aiEdit.RecruitingBehaviour.Defenders[7].UnitType.ToString();
                }
                else
                {
                    MessageBox.Show("Could not load the specified AI character!");
                }
                
            }
        }

        private void trackB_FirstAttackForceSize_Scroll(object sender, EventArgs e)
        {
            this.txtBox_FirstAttackForceSize.Text = Convert.ToString(this.trackBar_FirstAttackForceSize.Value);
        }

        private void txtBox_FirstAttackForceSize_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.trackBar_FirstAttackForceSize.Value = Convert.ToInt32(this.txtBox_WalLDef.Text);
            }
            catch
            {
                //User is being stupid again...
            }
        }

        private void trackB_AttackForceIncrease_Scroll(object sender, EventArgs e) => this.txtBox_AttackForceIncreaseStatic.Text = Convert.ToString(this.trackBar_AttackForceIncreaseStatic.Value);

        private void txtBox_AttackForceIncrease_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.trackBar_AttackForceIncreaseStatic.Value = Convert.ToInt32(this.txtBox_WalLDef.Text);
            }
            catch
            {
                //User is being stupid again...
            }
        }

        private void txtBox_FirstAttackForceSize_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtBox_AttackForceIncrease_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }

}
