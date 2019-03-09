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
            this.AI_Lords.Items.Add(UCP.AICharacters.AICIndex.Rat.ToString());
            this.AI_Lords.Items.Add(UCP.AICharacters.AICIndex.Snake.ToString());
            this.AI_Lords.Items.Add(UCP.AICharacters.AICIndex.Pig.ToString());
            this.AI_Lords.Items.Add(UCP.AICharacters.AICIndex.Wolf.ToString());

            this.AI_Lords.Items.Add(UCP.AICharacters.AICIndex.Sultan.ToString());
            this.AI_Lords.Items.Add(UCP.AICharacters.AICIndex.Caliph.ToString());
            this.AI_Lords.Items.Add(UCP.AICharacters.AICIndex.Richard.ToString());
            this.AI_Lords.Items.Add(UCP.AICharacters.AICIndex.Saladin.ToString());

            this.AI_Lords.Items.Add(UCP.AICharacters.AICIndex.Wazir.ToString());
            this.AI_Lords.Items.Add(UCP.AICharacters.AICIndex.Emir.ToString());
            this.AI_Lords.Items.Add(UCP.AICharacters.AICIndex.Nizar.ToString());
            this.AI_Lords.Items.Add(UCP.AICharacters.AICIndex.Sheriff.ToString());
            this.AI_Lords.Items.Add(UCP.AICharacters.AICIndex.Frederick.ToString());
            this.AI_Lords.Items.Add(UCP.AICharacters.AICIndex.Philipp.ToString());
            this.AI_Lords.Items.Add(UCP.AICharacters.AICIndex.Marshal.ToString());
            this.AI_Lords.Items.Add(UCP.AICharacters.AICIndex.Abbot.ToString());

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
