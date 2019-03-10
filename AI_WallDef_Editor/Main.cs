using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UCP.AICharacters;

namespace AI_Character_Editor
{
    public partial class MainForm : Form
    {
        // empty collection of characters
        AICCollection aicc = new AICCollection();

        // read .aic file from Resources/vanilla.aic into collection
        Assembly asm = Assembly.GetExecutingAssembly();

        public MainForm()
        {
            this.InitializeComponent();

            this.Fill_AI_Lords();
            this.Fill_OffUnits();
            this.Fill_DefUnits();
            this.trackBar_Patrols.Value = 10;
            this.trackBar_WallDef.Value = 20;
            this.trackBar_FirstAttackForceSize.Value = 10;
            this.trackBar_AttackForceIncreaseStatic.Value = 7;
            this.txtBox_AttackForceIncreaseMultiplier.Text = " 0.5";
            this.txtBox_Patrols.Text = "10";
            this.txtBox_WalLDef.Text = "20";
            this.txtBox_FirstAttackForceSize.Text = "10";
            this.txtBox_AttackForceIncreaseStatic.Text = "7";

            //read in original ai file
            using (Stream stream = asm.GetManifestResourceStream("AI_Character_Editor.Resources.vanilla.aic"))
                this.aicc.Read(stream);

            this.UpdateControls();
        }

        private void UpdateControls()
        {
            AICIndex lord = AICIndex.None;

            Enum.TryParse<AICIndex>(this.AI_Lords.GetItemText(this.AI_Lords.SelectedItem), out lord);

            AICharacter aiLord = this.aicc[lord];
            aiLord.Index = lord;

            this.trackBar_WallDef.Value = aiLord.Personality.DefWalls;
            this.trackBar_Patrols.Value = aiLord.Personality.DefTotal - aiLord.Personality.DefWalls;
            this.txtBox_WalLDef.Text = Convert.ToString(this.trackBar_WallDef.Value);
            this.txtBox_Patrols.Text = Convert.ToString(this.trackBar_Patrols.Value);

            this.DefUnit1.SelectedItem = aiLord.Personality.DefUnit1.ToString();
            this.DefUnit2.SelectedItem = aiLord.Personality.DefUnit2.ToString();
            this.DefUnit3.SelectedItem = aiLord.Personality.DefUnit3.ToString();
            this.DefUnit4.SelectedItem = aiLord.Personality.DefUnit4.ToString();
            this.DefUnit5.SelectedItem = aiLord.Personality.DefUnit5.ToString();
            this.DefUnit6.SelectedItem = aiLord.Personality.DefUnit6.ToString();
            this.DefUnit7.SelectedItem = aiLord.Personality.DefUnit7.ToString();
            this.DefUnit8.SelectedItem = aiLord.Personality.DefUnit8.ToString();

            this.trackBar_DefRecruitAffinity.Value = aiLord.Personality.DefRecruitAffinity;
            this.txtBox_DefRecruitAffinity.Text = Convert.ToString(this.trackBar_DefRecruitAffinity.Value);
            //aiLord.Personality.

            //Offensive stuff
        }

        private void Fill_AI_Lords()
        {
            this.AI_Lords.Items.Add(AICIndex.Rat.ToString());
            this.AI_Lords.Items.Add(AICIndex.Snake.ToString());
            this.AI_Lords.Items.Add(AICIndex.Pig.ToString());
            this.AI_Lords.Items.Add(AICIndex.Wolf.ToString());

            this.AI_Lords.Items.Add(AICIndex.Sultan.ToString());
            this.AI_Lords.Items.Add(AICIndex.Caliph.ToString());
            this.AI_Lords.Items.Add(AICIndex.Richard.ToString());
            this.AI_Lords.Items.Add(AICIndex.Saladin.ToString());

            this.AI_Lords.Items.Add(AICIndex.Wazir.ToString());
            this.AI_Lords.Items.Add(AICIndex.Emir.ToString());
            this.AI_Lords.Items.Add(AICIndex.Nizar.ToString());
            this.AI_Lords.Items.Add(AICIndex.Sheriff.ToString());
            this.AI_Lords.Items.Add(AICIndex.Frederick.ToString());
            this.AI_Lords.Items.Add(AICIndex.Philipp.ToString());
            this.AI_Lords.Items.Add(AICIndex.Marshal.ToString());
            this.AI_Lords.Items.Add(AICIndex.Abbot.ToString());

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
            //get lord from collection
            AICIndex lord = AICIndex.None;
            Enum.TryParse<AICIndex>(this.AI_Lords.GetItemText(this.AI_Lords.SelectedItem), out lord);

            this.SaveChangesIntern(lord);

            // save to file
            using (var fs = new FileStream("output.aic", FileMode.Create))
                this.aicc.Write(fs);
        }

        private void SaveChangesIntern(AICIndex lord)
        {
            UnitType unitType = UnitType.None;

            AICharacter aiLord = this.aicc[lord];

            aiLord.Index = lord;


            aiLord.Personality.DefTotal = this.trackBar_Patrols.Value + this.trackBar_WallDef.Value;
            aiLord.Personality.DefWalls = this.trackBar_WallDef.Value;

            Enum.TryParse<UnitType>(this.DefUnit1.GetItemText(this.DefUnit1.SelectedItem), out unitType);
            aiLord.Personality.DefUnit1 = unitType;
            Enum.TryParse<UnitType>(this.DefUnit2.GetItemText(this.DefUnit2.SelectedItem), out unitType);
            aiLord.Personality.DefUnit2 = unitType;
            Enum.TryParse<UnitType>(this.DefUnit3.GetItemText(this.DefUnit3.SelectedItem), out unitType);
            aiLord.Personality.DefUnit3 = unitType;
            Enum.TryParse<UnitType>(this.DefUnit4.GetItemText(this.DefUnit4.SelectedItem), out unitType);
            aiLord.Personality.DefUnit4 = unitType;
            Enum.TryParse<UnitType>(this.DefUnit5.GetItemText(this.DefUnit5.SelectedItem), out unitType);
            aiLord.Personality.DefUnit5 = unitType;
            Enum.TryParse<UnitType>(this.DefUnit6.GetItemText(this.DefUnit6.SelectedItem), out unitType);
            aiLord.Personality.DefUnit6 = unitType;
            Enum.TryParse<UnitType>(this.DefUnit7.GetItemText(this.DefUnit7.SelectedItem), out unitType);
            aiLord.Personality.DefUnit7 = unitType;
            Enum.TryParse<UnitType>(this.DefUnit8.GetItemText(this.DefUnit8.SelectedItem), out unitType);
            aiLord.Personality.DefUnit8 = unitType;

            aiLord.Personality.DefRecruitAffinity = this.trackBar_DefRecruitAffinity.Value; 
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
            fileDialog.InitialDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            if(fileDialog.ShowDialog() == DialogResult.OK)
            {
                this.aicc.Clear();

                using (Stream stream = new FileStream(fileDialog.FileName, FileMode.Open, FileAccess.Read))
                    this.aicc.Read(stream);

                this.AI_Lords.SelectedIndex = 0;
                this.UpdateControls();
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
            if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar) &&
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

        private void AI_Lords_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.aicc.Count() == 0)
                return;
            else
                this.UpdateControls();
        }

        private void AI_Lords_BeforeUpdate(object sender, CancelEventArgs e)
        {
            if (this.aicc.Count() == 0)
                return;
            else
            {
                //Save changes
                var x = this.AI_Lords.mPrevIndex;

                AICIndex lord = AICIndex.None;
                Enum.TryParse<AICIndex>(this.AI_Lords.Items[x].ToString(), out lord);

                this.SaveChangesIntern(lord);
            }
        }

        private void trackBar_DefRecruitAffinity_Scroll(object sender, EventArgs e) => this.txtBox_DefRecruitAffinity.Text = Convert.ToString(this.trackBar_DefRecruitAffinity.Value);

        private void txtBox_DefRecruitAffinity_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.trackBar_DefRecruitAffinity.Value = Convert.ToInt32(this.txtBox_DefRecruitAffinity.Text);
            }
            catch
            {
                //User is being stupid again...
            }
        }

        private void txtBox_DefRecruitAffinity_KeyPress(object sender, KeyPressEventArgs e)
        {     
            if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }

}
