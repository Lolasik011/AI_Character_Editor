using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AI_WallDef_Editor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Fill_AI_Lords();
            this.Fill_DefUnits();
            this.trackBar_Patrols.Value = 10;
            this.trackBar_WallDef.Value = 20;
            this.txtBox_Patrols.Text = "10";
            this.txtBox_WalLDef.Text = "20";

            //var edit = new AIEdit();
            //edit.AI = Enums.AI_Lord.Rat;
            //edit.TotalDef = 100;
            //edit.WallDef = 90;
            //edit.Defenders.Add(new Defender()
            //{
            //    DefUnit = Enums.DefUnit.DefUnit1,
            //    UnitType = Enums.UnitType.Spearmen
            //});
            //edit.Defenders.Add(new Defender()
            //{
            //    DefUnit = Enums.DefUnit.DefUnit2,
            //    UnitType = Enums.UnitType.Spearmen
            //});
            //edit.Defenders.Add(new Defender()
            //{
            //    DefUnit = Enums.DefUnit.DefUnit3,
            //    UnitType = Enums.UnitType.EuropeanArcher
            //});

            //Static_Methods.CreateScript(edit);

            Static_Methods.LoadScript("Rat.aidm");
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

        private void txtBox_Patrols_TextChanged(object sender, EventArgs e) => this.trackBar_Patrols.Value = Convert.ToInt32(this.txtBox_Patrols.Text);

        private void trackBar_Patrols_Scroll(object sender, EventArgs e) => this.txtBox_Patrols.Text = Convert.ToString(this.trackBar_Patrols.Value);

        private void txtBox_Patrols_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void trackBar_WallDef_Scroll(object sender, EventArgs e) => this.txtBox_WalLDef.Text = Convert.ToString(this.trackBar_WallDef.Value);

        private void txtBox_WalLDef_TextChanged(object sender, EventArgs e) => this.trackBar_WallDef.Value = Convert.ToInt32(this.txtBox_WalLDef.Text);

        private void txtBox_WalLDef_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void CreateScript_Click(object sender, EventArgs e)
        {
            var edit = new AIEdit();
            Enum.TryParse(this.AI_Lords.GetItemText(this.AI_Lords.SelectedItem), out edit.AI);
            edit.WallDef = this.trackBar_WallDef.Value;
            edit.TotalDef = this.trackBar_WallDef.Value + this.trackBar_Patrols.Value;

            var unitType = Enums.UnitType.NONE;
            Enum.TryParse(this.DefUnit1.GetItemText(this.DefUnit1.SelectedItem), out unitType);
            edit.Defenders.Add(new Defender()
            {
                DefUnit = Enums.DefUnit.DefUnit1,
                UnitType = unitType
            });

            Enum.TryParse(this.DefUnit2.GetItemText(this.DefUnit2.SelectedItem), out unitType);
            edit.Defenders.Add(new Defender()
            {
                DefUnit = Enums.DefUnit.DefUnit2,
                UnitType = unitType
            });

            Enum.TryParse(this.DefUnit3.GetItemText(this.DefUnit3.SelectedItem), out unitType);
            edit.Defenders.Add(new Defender()
            {
                DefUnit = Enums.DefUnit.DefUnit3,
                UnitType = unitType
            });

            Enum.TryParse(this.DefUnit4.GetItemText(this.DefUnit4.SelectedItem), out unitType);
            edit.Defenders.Add(new Defender()
            {
                DefUnit = Enums.DefUnit.DefUnit4,
                UnitType = unitType
            });

            Enum.TryParse(this.DefUnit5.GetItemText(this.DefUnit5.SelectedItem), out unitType);
            edit.Defenders.Add(new Defender()
            {
                DefUnit = Enums.DefUnit.DefUnit5,
                UnitType = unitType
            });

            Enum.TryParse(this.DefUnit6.GetItemText(this.DefUnit6.SelectedItem), out unitType);
            edit.Defenders.Add(new Defender()
            {
                DefUnit = Enums.DefUnit.DefUnit6,
                UnitType = unitType
            });

            Enum.TryParse(this.DefUnit7.GetItemText(this.DefUnit7.SelectedItem), out unitType);
            edit.Defenders.Add(new Defender()
            {
                DefUnit = Enums.DefUnit.DefUnit7,
                UnitType = unitType
            });

            Enum.TryParse(this.DefUnit8.GetItemText(this.DefUnit8.SelectedItem), out unitType);
            edit.Defenders.Add(new Defender()
            {
                DefUnit = Enums.DefUnit.DefUnit8,
                UnitType = unitType
            });

            if (Static_Methods.CreateScript(edit))
            {
                MessageBox.Show("Script created successfully!");
                //open?
            }
            else
                MessageBox.Show("Script could not be created!");
        }

        private void open_Existing_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.DefaultExt = ".aidm";
            fileDialog.CheckFileExists = true;
            fileDialog.CheckPathExists = true;
            fileDialog.Title = "Select an existing ai defence mod";
            fileDialog.Multiselect = false;
            fileDialog.Filter = "ai defence mod files (*.aidm)|*.aidm";
            fileDialog.InitialDirectory = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

            if(fileDialog.ShowDialog() == DialogResult.OK)
            {
                AIEdit aiEdit = Static_Methods.LoadScript(fileDialog.FileName);
                if (aiEdit != null)
                {
                    MessageBox.Show("Script loaded successfully!");

                    this.AI_Lords.SelectedIndex = (int)aiEdit.AI;
                    this.trackBar_Patrols.Value = aiEdit.TotalDef - aiEdit.WallDef;
                    this.txtBox_Patrols.Text = Convert.ToString(aiEdit.TotalDef - aiEdit.WallDef);
                    this.trackBar_WallDef.Value = aiEdit.WallDef;
                    this.txtBox_WalLDef.Text = Convert.ToString(aiEdit.WallDef);
                    this.DefUnit1.SelectedItem = aiEdit.Defenders[0].UnitType.ToString();
                    this.DefUnit2.SelectedItem = aiEdit.Defenders[1].UnitType.ToString();
                    this.DefUnit3.SelectedItem = aiEdit.Defenders[2].UnitType.ToString();
                    this.DefUnit4.SelectedItem = aiEdit.Defenders[3].UnitType.ToString();
                    this.DefUnit5.SelectedItem = aiEdit.Defenders[4].UnitType.ToString();
                    this.DefUnit6.SelectedItem = aiEdit.Defenders[5].UnitType.ToString();
                    this.DefUnit7.SelectedItem = aiEdit.Defenders[6].UnitType.ToString();
                    this.DefUnit8.SelectedItem = aiEdit.Defenders[7].UnitType.ToString();
                }
                else
                {
                    MessageBox.Show("Could not load the specified script!");
                }
                
            }
        }
    }

}
