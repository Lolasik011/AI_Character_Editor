﻿namespace AI_Character_Editor
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.AI_Lords = new AI_Character_Editor.CustomComboBox();
            this.lbl_AI_Lord = new System.Windows.Forms.Label();
            this.lbl_Patrols = new System.Windows.Forms.Label();
            this.lbl_WallDefence = new System.Windows.Forms.Label();
            this.trackBar_Patrols = new System.Windows.Forms.TrackBar();
            this.trackBar_WallDef = new System.Windows.Forms.TrackBar();
            this.txtBox_Patrols = new System.Windows.Forms.TextBox();
            this.txtBox_WalLDef = new System.Windows.Forms.TextBox();
            this.CreateAICharacter = new System.Windows.Forms.Button();
            this.DefUnit1 = new System.Windows.Forms.ComboBox();
            this.lbl_DefUnit1 = new System.Windows.Forms.Label();
            this.lbl_DefUnit2 = new System.Windows.Forms.Label();
            this.DefUnit2 = new System.Windows.Forms.ComboBox();
            this.lbl_DefUnit3 = new System.Windows.Forms.Label();
            this.DefUnit3 = new System.Windows.Forms.ComboBox();
            this.lbl_DefUnit4 = new System.Windows.Forms.Label();
            this.DefUnit4 = new System.Windows.Forms.ComboBox();
            this.lbl_DefUnit5 = new System.Windows.Forms.Label();
            this.DefUnit5 = new System.Windows.Forms.ComboBox();
            this.lbl_DefUnit6 = new System.Windows.Forms.Label();
            this.DefUnit6 = new System.Windows.Forms.ComboBox();
            this.lbl_DefUnit7 = new System.Windows.Forms.Label();
            this.DefUnit7 = new System.Windows.Forms.ComboBox();
            this.lbl_DefUnit8 = new System.Windows.Forms.Label();
            this.DefUnit8 = new System.Windows.Forms.ComboBox();
            this.open_Existing = new System.Windows.Forms.Button();
            this.pnl_Defence = new System.Windows.Forms.Panel();
            this.lbl_Defence = new System.Windows.Forms.Label();
            this.pnl_Offence = new System.Windows.Forms.Panel();
            this.lbl_AttackForceIncreaseMultiplier = new System.Windows.Forms.Label();
            this.txtBox_AttackForceIncreaseMultiplier = new System.Windows.Forms.TextBox();
            this.lbl_OffUnit8 = new System.Windows.Forms.Label();
            this.lbl_FirstAttackForceSize = new System.Windows.Forms.Label();
            this.OffUnit8 = new System.Windows.Forms.ComboBox();
            this.lbl_AttackForceIncreaseStatic = new System.Windows.Forms.Label();
            this.lbl_OffUnit7 = new System.Windows.Forms.Label();
            this.trackBar_FirstAttackForceSize = new System.Windows.Forms.TrackBar();
            this.OffUnit7 = new System.Windows.Forms.ComboBox();
            this.trackBar_AttackForceIncreaseStatic = new System.Windows.Forms.TrackBar();
            this.lbl_OffUnit6 = new System.Windows.Forms.Label();
            this.txtBox_FirstAttackForceSize = new System.Windows.Forms.TextBox();
            this.OffUnit6 = new System.Windows.Forms.ComboBox();
            this.txtBox_AttackForceIncreaseStatic = new System.Windows.Forms.TextBox();
            this.lbl_OffUnit5 = new System.Windows.Forms.Label();
            this.OffUnit1 = new System.Windows.Forms.ComboBox();
            this.OffUnit5 = new System.Windows.Forms.ComboBox();
            this.lbl_OffUnit1 = new System.Windows.Forms.Label();
            this.lbl_OffUnit4 = new System.Windows.Forms.Label();
            this.OffUnit2 = new System.Windows.Forms.ComboBox();
            this.OffUnit4 = new System.Windows.Forms.ComboBox();
            this.lbl_OffUnit2 = new System.Windows.Forms.Label();
            this.lbl_OffUnit3 = new System.Windows.Forms.Label();
            this.OffUnit3 = new System.Windows.Forms.ComboBox();
            this.lbl_Offence = new System.Windows.Forms.Label();
            this.lbl_DefRecruitAffinity = new System.Windows.Forms.Label();
            this.trackBar_DefRecruitAffinity = new System.Windows.Forms.TrackBar();
            this.txtBox_DefRecruitAffinity = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Patrols)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_WallDef)).BeginInit();
            this.pnl_Defence.SuspendLayout();
            this.pnl_Offence.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_FirstAttackForceSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_AttackForceIncreaseStatic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_DefRecruitAffinity)).BeginInit();
            this.SuspendLayout();
            // 
            // AI_Lords
            // 
            this.AI_Lords.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AI_Lords.FormattingEnabled = true;
            this.AI_Lords.Location = new System.Drawing.Point(622, 19);
            this.AI_Lords.Name = "AI_Lords";
            this.AI_Lords.Size = new System.Drawing.Size(121, 21);
            this.AI_Lords.TabIndex = 0;
            this.AI_Lords.BeforeUpdate += new System.ComponentModel.CancelEventHandler(this.AI_Lords_BeforeUpdate);
            this.AI_Lords.SelectedIndexChanged += new System.EventHandler(this.AI_Lords_SelectedIndexChanged);
            // 
            // lbl_AI_Lord
            // 
            this.lbl_AI_Lord.AutoSize = true;
            this.lbl_AI_Lord.Location = new System.Drawing.Point(551, 22);
            this.lbl_AI_Lord.Name = "lbl_AI_Lord";
            this.lbl_AI_Lord.Size = new System.Drawing.Size(41, 13);
            this.lbl_AI_Lord.TabIndex = 1;
            this.lbl_AI_Lord.Text = "AI Lord";
            // 
            // lbl_Patrols
            // 
            this.lbl_Patrols.AutoSize = true;
            this.lbl_Patrols.Location = new System.Drawing.Point(9, 16);
            this.lbl_Patrols.Name = "lbl_Patrols";
            this.lbl_Patrols.Size = new System.Drawing.Size(39, 13);
            this.lbl_Patrols.TabIndex = 2;
            this.lbl_Patrols.Text = "Patrols";
            // 
            // lbl_WallDefence
            // 
            this.lbl_WallDefence.AutoSize = true;
            this.lbl_WallDefence.Location = new System.Drawing.Point(9, 90);
            this.lbl_WallDefence.Name = "lbl_WallDefence";
            this.lbl_WallDefence.Size = new System.Drawing.Size(72, 13);
            this.lbl_WallDefence.TabIndex = 3;
            this.lbl_WallDefence.Text = "Wall Defence";
            // 
            // trackBar_Patrols
            // 
            this.trackBar_Patrols.Location = new System.Drawing.Point(80, 16);
            this.trackBar_Patrols.Maximum = 300;
            this.trackBar_Patrols.Name = "trackBar_Patrols";
            this.trackBar_Patrols.Size = new System.Drawing.Size(408, 45);
            this.trackBar_Patrols.TabIndex = 4;
            this.trackBar_Patrols.TickFrequency = 5;
            this.trackBar_Patrols.Value = 20;
            this.trackBar_Patrols.Scroll += new System.EventHandler(this.trackBar_Patrols_Scroll);
            // 
            // trackBar_WallDef
            // 
            this.trackBar_WallDef.Location = new System.Drawing.Point(80, 90);
            this.trackBar_WallDef.Maximum = 300;
            this.trackBar_WallDef.Name = "trackBar_WallDef";
            this.trackBar_WallDef.Size = new System.Drawing.Size(408, 45);
            this.trackBar_WallDef.TabIndex = 5;
            this.trackBar_WallDef.TickFrequency = 5;
            this.trackBar_WallDef.Value = 20;
            this.trackBar_WallDef.Scroll += new System.EventHandler(this.trackBar_WallDef_Scroll);
            // 
            // txtBox_Patrols
            // 
            this.txtBox_Patrols.Location = new System.Drawing.Point(242, 62);
            this.txtBox_Patrols.Name = "txtBox_Patrols";
            this.txtBox_Patrols.Size = new System.Drawing.Size(77, 20);
            this.txtBox_Patrols.TabIndex = 6;
            this.txtBox_Patrols.Text = "1";
            this.txtBox_Patrols.TextChanged += new System.EventHandler(this.txtBox_Patrols_TextChanged);
            this.txtBox_Patrols.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_Patrols_KeyPress);
            // 
            // txtBox_WalLDef
            // 
            this.txtBox_WalLDef.Location = new System.Drawing.Point(242, 135);
            this.txtBox_WalLDef.Name = "txtBox_WalLDef";
            this.txtBox_WalLDef.Size = new System.Drawing.Size(77, 20);
            this.txtBox_WalLDef.TabIndex = 7;
            this.txtBox_WalLDef.Text = "1";
            this.txtBox_WalLDef.TextChanged += new System.EventHandler(this.txtBox_WalLDef_TextChanged);
            this.txtBox_WalLDef.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_WalLDef_KeyPress);
            // 
            // CreateAICharacter
            // 
            this.CreateAICharacter.Location = new System.Drawing.Point(90, 12);
            this.CreateAICharacter.Name = "CreateAICharacter";
            this.CreateAICharacter.Size = new System.Drawing.Size(75, 23);
            this.CreateAICharacter.TabIndex = 8;
            this.CreateAICharacter.Text = "Create";
            this.CreateAICharacter.UseVisualStyleBackColor = true;
            this.CreateAICharacter.Click += new System.EventHandler(this.CreateAICharacter_Click);
            // 
            // DefUnit1
            // 
            this.DefUnit1.FormattingEnabled = true;
            this.DefUnit1.Location = new System.Drawing.Point(12, 191);
            this.DefUnit1.Name = "DefUnit1";
            this.DefUnit1.Size = new System.Drawing.Size(121, 21);
            this.DefUnit1.TabIndex = 9;
            // 
            // lbl_DefUnit1
            // 
            this.lbl_DefUnit1.AutoSize = true;
            this.lbl_DefUnit1.Location = new System.Drawing.Point(40, 175);
            this.lbl_DefUnit1.Name = "lbl_DefUnit1";
            this.lbl_DefUnit1.Size = new System.Drawing.Size(49, 13);
            this.lbl_DefUnit1.TabIndex = 10;
            this.lbl_DefUnit1.Text = "DefUnit1";
            // 
            // lbl_DefUnit2
            // 
            this.lbl_DefUnit2.AutoSize = true;
            this.lbl_DefUnit2.Location = new System.Drawing.Point(178, 175);
            this.lbl_DefUnit2.Name = "lbl_DefUnit2";
            this.lbl_DefUnit2.Size = new System.Drawing.Size(49, 13);
            this.lbl_DefUnit2.TabIndex = 12;
            this.lbl_DefUnit2.Text = "DefUnit2";
            // 
            // DefUnit2
            // 
            this.DefUnit2.FormattingEnabled = true;
            this.DefUnit2.Location = new System.Drawing.Point(153, 191);
            this.DefUnit2.Name = "DefUnit2";
            this.DefUnit2.Size = new System.Drawing.Size(121, 21);
            this.DefUnit2.TabIndex = 11;
            // 
            // lbl_DefUnit3
            // 
            this.lbl_DefUnit3.AutoSize = true;
            this.lbl_DefUnit3.Location = new System.Drawing.Point(318, 175);
            this.lbl_DefUnit3.Name = "lbl_DefUnit3";
            this.lbl_DefUnit3.Size = new System.Drawing.Size(49, 13);
            this.lbl_DefUnit3.TabIndex = 14;
            this.lbl_DefUnit3.Text = "DefUnit3";
            // 
            // DefUnit3
            // 
            this.DefUnit3.FormattingEnabled = true;
            this.DefUnit3.Location = new System.Drawing.Point(290, 191);
            this.DefUnit3.Name = "DefUnit3";
            this.DefUnit3.Size = new System.Drawing.Size(121, 21);
            this.DefUnit3.TabIndex = 13;
            // 
            // lbl_DefUnit4
            // 
            this.lbl_DefUnit4.AutoSize = true;
            this.lbl_DefUnit4.Location = new System.Drawing.Point(463, 175);
            this.lbl_DefUnit4.Name = "lbl_DefUnit4";
            this.lbl_DefUnit4.Size = new System.Drawing.Size(49, 13);
            this.lbl_DefUnit4.TabIndex = 16;
            this.lbl_DefUnit4.Text = "DefUnit4";
            // 
            // DefUnit4
            // 
            this.DefUnit4.FormattingEnabled = true;
            this.DefUnit4.Location = new System.Drawing.Point(435, 191);
            this.DefUnit4.Name = "DefUnit4";
            this.DefUnit4.Size = new System.Drawing.Size(121, 21);
            this.DefUnit4.TabIndex = 15;
            // 
            // lbl_DefUnit5
            // 
            this.lbl_DefUnit5.AutoSize = true;
            this.lbl_DefUnit5.Location = new System.Drawing.Point(40, 215);
            this.lbl_DefUnit5.Name = "lbl_DefUnit5";
            this.lbl_DefUnit5.Size = new System.Drawing.Size(49, 13);
            this.lbl_DefUnit5.TabIndex = 18;
            this.lbl_DefUnit5.Text = "DefUnit5";
            // 
            // DefUnit5
            // 
            this.DefUnit5.FormattingEnabled = true;
            this.DefUnit5.Location = new System.Drawing.Point(12, 231);
            this.DefUnit5.Name = "DefUnit5";
            this.DefUnit5.Size = new System.Drawing.Size(121, 21);
            this.DefUnit5.TabIndex = 17;
            // 
            // lbl_DefUnit6
            // 
            this.lbl_DefUnit6.AutoSize = true;
            this.lbl_DefUnit6.Location = new System.Drawing.Point(181, 215);
            this.lbl_DefUnit6.Name = "lbl_DefUnit6";
            this.lbl_DefUnit6.Size = new System.Drawing.Size(49, 13);
            this.lbl_DefUnit6.TabIndex = 20;
            this.lbl_DefUnit6.Text = "DefUnit6";
            // 
            // DefUnit6
            // 
            this.DefUnit6.FormattingEnabled = true;
            this.DefUnit6.Location = new System.Drawing.Point(153, 231);
            this.DefUnit6.Name = "DefUnit6";
            this.DefUnit6.Size = new System.Drawing.Size(121, 21);
            this.DefUnit6.TabIndex = 19;
            // 
            // lbl_DefUnit7
            // 
            this.lbl_DefUnit7.AutoSize = true;
            this.lbl_DefUnit7.Location = new System.Drawing.Point(318, 215);
            this.lbl_DefUnit7.Name = "lbl_DefUnit7";
            this.lbl_DefUnit7.Size = new System.Drawing.Size(49, 13);
            this.lbl_DefUnit7.TabIndex = 22;
            this.lbl_DefUnit7.Text = "DefUnit7";
            // 
            // DefUnit7
            // 
            this.DefUnit7.FormattingEnabled = true;
            this.DefUnit7.Location = new System.Drawing.Point(290, 231);
            this.DefUnit7.Name = "DefUnit7";
            this.DefUnit7.Size = new System.Drawing.Size(121, 21);
            this.DefUnit7.TabIndex = 21;
            // 
            // lbl_DefUnit8
            // 
            this.lbl_DefUnit8.AutoSize = true;
            this.lbl_DefUnit8.Location = new System.Drawing.Point(463, 215);
            this.lbl_DefUnit8.Name = "lbl_DefUnit8";
            this.lbl_DefUnit8.Size = new System.Drawing.Size(49, 13);
            this.lbl_DefUnit8.TabIndex = 24;
            this.lbl_DefUnit8.Text = "DefUnit8";
            // 
            // DefUnit8
            // 
            this.DefUnit8.FormattingEnabled = true;
            this.DefUnit8.Location = new System.Drawing.Point(435, 231);
            this.DefUnit8.Name = "DefUnit8";
            this.DefUnit8.Size = new System.Drawing.Size(121, 21);
            this.DefUnit8.TabIndex = 23;
            // 
            // open_Existing
            // 
            this.open_Existing.Location = new System.Drawing.Point(9, 12);
            this.open_Existing.Name = "open_Existing";
            this.open_Existing.Size = new System.Drawing.Size(75, 23);
            this.open_Existing.TabIndex = 25;
            this.open_Existing.Text = "Open";
            this.open_Existing.UseVisualStyleBackColor = true;
            this.open_Existing.Click += new System.EventHandler(this.open_Existing_Click);
            // 
            // pnl_Defence
            // 
            this.pnl_Defence.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Defence.Controls.Add(this.lbl_DefRecruitAffinity);
            this.pnl_Defence.Controls.Add(this.trackBar_DefRecruitAffinity);
            this.pnl_Defence.Controls.Add(this.txtBox_DefRecruitAffinity);
            this.pnl_Defence.Controls.Add(this.lbl_DefUnit8);
            this.pnl_Defence.Controls.Add(this.lbl_Patrols);
            this.pnl_Defence.Controls.Add(this.DefUnit8);
            this.pnl_Defence.Controls.Add(this.lbl_WallDefence);
            this.pnl_Defence.Controls.Add(this.lbl_DefUnit7);
            this.pnl_Defence.Controls.Add(this.trackBar_Patrols);
            this.pnl_Defence.Controls.Add(this.DefUnit7);
            this.pnl_Defence.Controls.Add(this.trackBar_WallDef);
            this.pnl_Defence.Controls.Add(this.lbl_DefUnit6);
            this.pnl_Defence.Controls.Add(this.txtBox_Patrols);
            this.pnl_Defence.Controls.Add(this.DefUnit6);
            this.pnl_Defence.Controls.Add(this.txtBox_WalLDef);
            this.pnl_Defence.Controls.Add(this.lbl_DefUnit5);
            this.pnl_Defence.Controls.Add(this.DefUnit1);
            this.pnl_Defence.Controls.Add(this.DefUnit5);
            this.pnl_Defence.Controls.Add(this.lbl_DefUnit1);
            this.pnl_Defence.Controls.Add(this.lbl_DefUnit4);
            this.pnl_Defence.Controls.Add(this.DefUnit2);
            this.pnl_Defence.Controls.Add(this.DefUnit4);
            this.pnl_Defence.Controls.Add(this.lbl_DefUnit2);
            this.pnl_Defence.Controls.Add(this.lbl_DefUnit3);
            this.pnl_Defence.Controls.Add(this.DefUnit3);
            this.pnl_Defence.Location = new System.Drawing.Point(9, 69);
            this.pnl_Defence.Name = "pnl_Defence";
            this.pnl_Defence.Size = new System.Drawing.Size(613, 345);
            this.pnl_Defence.TabIndex = 26;
            // 
            // lbl_Defence
            // 
            this.lbl_Defence.AutoSize = true;
            this.lbl_Defence.Location = new System.Drawing.Point(280, 53);
            this.lbl_Defence.Name = "lbl_Defence";
            this.lbl_Defence.Size = new System.Drawing.Size(48, 13);
            this.lbl_Defence.TabIndex = 27;
            this.lbl_Defence.Text = "Defence";
            // 
            // pnl_Offence
            // 
            this.pnl_Offence.Controls.Add(this.lbl_AttackForceIncreaseMultiplier);
            this.pnl_Offence.Controls.Add(this.txtBox_AttackForceIncreaseMultiplier);
            this.pnl_Offence.Controls.Add(this.lbl_OffUnit8);
            this.pnl_Offence.Controls.Add(this.lbl_FirstAttackForceSize);
            this.pnl_Offence.Controls.Add(this.OffUnit8);
            this.pnl_Offence.Controls.Add(this.lbl_AttackForceIncreaseStatic);
            this.pnl_Offence.Controls.Add(this.lbl_OffUnit7);
            this.pnl_Offence.Controls.Add(this.trackBar_FirstAttackForceSize);
            this.pnl_Offence.Controls.Add(this.OffUnit7);
            this.pnl_Offence.Controls.Add(this.trackBar_AttackForceIncreaseStatic);
            this.pnl_Offence.Controls.Add(this.lbl_OffUnit6);
            this.pnl_Offence.Controls.Add(this.txtBox_FirstAttackForceSize);
            this.pnl_Offence.Controls.Add(this.OffUnit6);
            this.pnl_Offence.Controls.Add(this.txtBox_AttackForceIncreaseStatic);
            this.pnl_Offence.Controls.Add(this.lbl_OffUnit5);
            this.pnl_Offence.Controls.Add(this.OffUnit1);
            this.pnl_Offence.Controls.Add(this.OffUnit5);
            this.pnl_Offence.Controls.Add(this.lbl_OffUnit1);
            this.pnl_Offence.Controls.Add(this.lbl_OffUnit4);
            this.pnl_Offence.Controls.Add(this.OffUnit2);
            this.pnl_Offence.Controls.Add(this.OffUnit4);
            this.pnl_Offence.Controls.Add(this.lbl_OffUnit2);
            this.pnl_Offence.Controls.Add(this.lbl_OffUnit3);
            this.pnl_Offence.Controls.Add(this.OffUnit3);
            this.pnl_Offence.Location = new System.Drawing.Point(668, 70);
            this.pnl_Offence.Name = "pnl_Offence";
            this.pnl_Offence.Size = new System.Drawing.Size(620, 335);
            this.pnl_Offence.TabIndex = 28;
            this.pnl_Offence.Visible = false;
            // 
            // lbl_AttackForceIncreaseMultiplier
            // 
            this.lbl_AttackForceIncreaseMultiplier.AutoSize = true;
            this.lbl_AttackForceIncreaseMultiplier.Location = new System.Drawing.Point(23, 161);
            this.lbl_AttackForceIncreaseMultiplier.Name = "lbl_AttackForceIncreaseMultiplier";
            this.lbl_AttackForceIncreaseMultiplier.Size = new System.Drawing.Size(91, 13);
            this.lbl_AttackForceIncreaseMultiplier.TabIndex = 47;
            this.lbl_AttackForceIncreaseMultiplier.Text = "Multiplier increase";
            // 
            // txtBox_AttackForceIncreaseMultiplier
            // 
            this.txtBox_AttackForceIncreaseMultiplier.Location = new System.Drawing.Point(129, 161);
            this.txtBox_AttackForceIncreaseMultiplier.Name = "txtBox_AttackForceIncreaseMultiplier";
            this.txtBox_AttackForceIncreaseMultiplier.Size = new System.Drawing.Size(77, 20);
            this.txtBox_AttackForceIncreaseMultiplier.TabIndex = 49;
            this.txtBox_AttackForceIncreaseMultiplier.Text = "1";
            this.txtBox_AttackForceIncreaseMultiplier.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // lbl_OffUnit8
            // 
            this.lbl_OffUnit8.AutoSize = true;
            this.lbl_OffUnit8.Location = new System.Drawing.Point(491, 279);
            this.lbl_OffUnit8.Name = "lbl_OffUnit8";
            this.lbl_OffUnit8.Size = new System.Drawing.Size(46, 13);
            this.lbl_OffUnit8.TabIndex = 46;
            this.lbl_OffUnit8.Text = "OffUnit8";
            // 
            // lbl_FirstAttackForceSize
            // 
            this.lbl_FirstAttackForceSize.AutoSize = true;
            this.lbl_FirstAttackForceSize.Location = new System.Drawing.Point(23, 15);
            this.lbl_FirstAttackForceSize.Name = "lbl_FirstAttackForceSize";
            this.lbl_FirstAttackForceSize.Size = new System.Drawing.Size(86, 13);
            this.lbl_FirstAttackForceSize.TabIndex = 25;
            this.lbl_FirstAttackForceSize.Text = "First attack force";
            // 
            // OffUnit8
            // 
            this.OffUnit8.FormattingEnabled = true;
            this.OffUnit8.Location = new System.Drawing.Point(463, 295);
            this.OffUnit8.Name = "OffUnit8";
            this.OffUnit8.Size = new System.Drawing.Size(121, 21);
            this.OffUnit8.TabIndex = 45;
            // 
            // lbl_AttackForceIncreaseStatic
            // 
            this.lbl_AttackForceIncreaseStatic.AutoSize = true;
            this.lbl_AttackForceIncreaseStatic.Location = new System.Drawing.Point(23, 89);
            this.lbl_AttackForceIncreaseStatic.Name = "lbl_AttackForceIncreaseStatic";
            this.lbl_AttackForceIncreaseStatic.Size = new System.Drawing.Size(77, 13);
            this.lbl_AttackForceIncreaseStatic.TabIndex = 26;
            this.lbl_AttackForceIncreaseStatic.Text = "Static increase";
            // 
            // lbl_OffUnit7
            // 
            this.lbl_OffUnit7.AutoSize = true;
            this.lbl_OffUnit7.Location = new System.Drawing.Point(346, 279);
            this.lbl_OffUnit7.Name = "lbl_OffUnit7";
            this.lbl_OffUnit7.Size = new System.Drawing.Size(46, 13);
            this.lbl_OffUnit7.TabIndex = 44;
            this.lbl_OffUnit7.Text = "OffUnit7";
            // 
            // trackBar_FirstAttackForceSize
            // 
            this.trackBar_FirstAttackForceSize.Location = new System.Drawing.Point(145, 16);
            this.trackBar_FirstAttackForceSize.Maximum = 300;
            this.trackBar_FirstAttackForceSize.Name = "trackBar_FirstAttackForceSize";
            this.trackBar_FirstAttackForceSize.Size = new System.Drawing.Size(408, 45);
            this.trackBar_FirstAttackForceSize.TabIndex = 27;
            this.trackBar_FirstAttackForceSize.TickFrequency = 5;
            this.trackBar_FirstAttackForceSize.Value = 20;
            this.trackBar_FirstAttackForceSize.Scroll += new System.EventHandler(this.trackB_FirstAttackForceSize_Scroll);
            // 
            // OffUnit7
            // 
            this.OffUnit7.FormattingEnabled = true;
            this.OffUnit7.Location = new System.Drawing.Point(318, 295);
            this.OffUnit7.Name = "OffUnit7";
            this.OffUnit7.Size = new System.Drawing.Size(121, 21);
            this.OffUnit7.TabIndex = 43;
            // 
            // trackBar_AttackForceIncreaseStatic
            // 
            this.trackBar_AttackForceIncreaseStatic.Location = new System.Drawing.Point(145, 89);
            this.trackBar_AttackForceIncreaseStatic.Maximum = 300;
            this.trackBar_AttackForceIncreaseStatic.Name = "trackBar_AttackForceIncreaseStatic";
            this.trackBar_AttackForceIncreaseStatic.Size = new System.Drawing.Size(408, 45);
            this.trackBar_AttackForceIncreaseStatic.TabIndex = 28;
            this.trackBar_AttackForceIncreaseStatic.TickFrequency = 5;
            this.trackBar_AttackForceIncreaseStatic.Value = 20;
            this.trackBar_AttackForceIncreaseStatic.Scroll += new System.EventHandler(this.trackB_AttackForceIncrease_Scroll);
            // 
            // lbl_OffUnit6
            // 
            this.lbl_OffUnit6.AutoSize = true;
            this.lbl_OffUnit6.Location = new System.Drawing.Point(209, 279);
            this.lbl_OffUnit6.Name = "lbl_OffUnit6";
            this.lbl_OffUnit6.Size = new System.Drawing.Size(46, 13);
            this.lbl_OffUnit6.TabIndex = 42;
            this.lbl_OffUnit6.Text = "OffUnit6";
            // 
            // txtBox_FirstAttackForceSize
            // 
            this.txtBox_FirstAttackForceSize.Location = new System.Drawing.Point(296, 62);
            this.txtBox_FirstAttackForceSize.Name = "txtBox_FirstAttackForceSize";
            this.txtBox_FirstAttackForceSize.Size = new System.Drawing.Size(77, 20);
            this.txtBox_FirstAttackForceSize.TabIndex = 29;
            this.txtBox_FirstAttackForceSize.Text = "1";
            this.txtBox_FirstAttackForceSize.TextChanged += new System.EventHandler(this.txtBox_FirstAttackForceSize_TextChanged);
            this.txtBox_FirstAttackForceSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_FirstAttackForceSize_KeyPress);
            // 
            // OffUnit6
            // 
            this.OffUnit6.FormattingEnabled = true;
            this.OffUnit6.Location = new System.Drawing.Point(181, 295);
            this.OffUnit6.Name = "OffUnit6";
            this.OffUnit6.Size = new System.Drawing.Size(121, 21);
            this.OffUnit6.TabIndex = 41;
            // 
            // txtBox_AttackForceIncreaseStatic
            // 
            this.txtBox_AttackForceIncreaseStatic.Location = new System.Drawing.Point(296, 135);
            this.txtBox_AttackForceIncreaseStatic.Name = "txtBox_AttackForceIncreaseStatic";
            this.txtBox_AttackForceIncreaseStatic.Size = new System.Drawing.Size(77, 20);
            this.txtBox_AttackForceIncreaseStatic.TabIndex = 30;
            this.txtBox_AttackForceIncreaseStatic.Text = "1";
            this.txtBox_AttackForceIncreaseStatic.TextChanged += new System.EventHandler(this.txtBox_AttackForceIncrease_TextChanged);
            this.txtBox_AttackForceIncreaseStatic.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_AttackForceIncrease_KeyPress);
            // 
            // lbl_OffUnit5
            // 
            this.lbl_OffUnit5.AutoSize = true;
            this.lbl_OffUnit5.Location = new System.Drawing.Point(68, 279);
            this.lbl_OffUnit5.Name = "lbl_OffUnit5";
            this.lbl_OffUnit5.Size = new System.Drawing.Size(46, 13);
            this.lbl_OffUnit5.TabIndex = 40;
            this.lbl_OffUnit5.Text = "OffUnit5";
            // 
            // OffUnit1
            // 
            this.OffUnit1.FormattingEnabled = true;
            this.OffUnit1.Location = new System.Drawing.Point(40, 255);
            this.OffUnit1.Name = "OffUnit1";
            this.OffUnit1.Size = new System.Drawing.Size(121, 21);
            this.OffUnit1.TabIndex = 31;
            // 
            // OffUnit5
            // 
            this.OffUnit5.FormattingEnabled = true;
            this.OffUnit5.Location = new System.Drawing.Point(40, 295);
            this.OffUnit5.Name = "OffUnit5";
            this.OffUnit5.Size = new System.Drawing.Size(121, 21);
            this.OffUnit5.TabIndex = 39;
            // 
            // lbl_OffUnit1
            // 
            this.lbl_OffUnit1.AutoSize = true;
            this.lbl_OffUnit1.Location = new System.Drawing.Point(68, 239);
            this.lbl_OffUnit1.Name = "lbl_OffUnit1";
            this.lbl_OffUnit1.Size = new System.Drawing.Size(46, 13);
            this.lbl_OffUnit1.TabIndex = 32;
            this.lbl_OffUnit1.Text = "OffUnit1";
            // 
            // lbl_OffUnit4
            // 
            this.lbl_OffUnit4.AutoSize = true;
            this.lbl_OffUnit4.Location = new System.Drawing.Point(491, 239);
            this.lbl_OffUnit4.Name = "lbl_OffUnit4";
            this.lbl_OffUnit4.Size = new System.Drawing.Size(46, 13);
            this.lbl_OffUnit4.TabIndex = 38;
            this.lbl_OffUnit4.Text = "OffUnit4";
            // 
            // OffUnit2
            // 
            this.OffUnit2.FormattingEnabled = true;
            this.OffUnit2.Location = new System.Drawing.Point(181, 255);
            this.OffUnit2.Name = "OffUnit2";
            this.OffUnit2.Size = new System.Drawing.Size(121, 21);
            this.OffUnit2.TabIndex = 33;
            // 
            // OffUnit4
            // 
            this.OffUnit4.FormattingEnabled = true;
            this.OffUnit4.Location = new System.Drawing.Point(463, 255);
            this.OffUnit4.Name = "OffUnit4";
            this.OffUnit4.Size = new System.Drawing.Size(121, 21);
            this.OffUnit4.TabIndex = 37;
            // 
            // lbl_OffUnit2
            // 
            this.lbl_OffUnit2.AutoSize = true;
            this.lbl_OffUnit2.Location = new System.Drawing.Point(206, 239);
            this.lbl_OffUnit2.Name = "lbl_OffUnit2";
            this.lbl_OffUnit2.Size = new System.Drawing.Size(46, 13);
            this.lbl_OffUnit2.TabIndex = 34;
            this.lbl_OffUnit2.Text = "OffUnit2";
            // 
            // lbl_OffUnit3
            // 
            this.lbl_OffUnit3.AutoSize = true;
            this.lbl_OffUnit3.Location = new System.Drawing.Point(346, 239);
            this.lbl_OffUnit3.Name = "lbl_OffUnit3";
            this.lbl_OffUnit3.Size = new System.Drawing.Size(46, 13);
            this.lbl_OffUnit3.TabIndex = 36;
            this.lbl_OffUnit3.Text = "OffUnit3";
            // 
            // OffUnit3
            // 
            this.OffUnit3.FormattingEnabled = true;
            this.OffUnit3.Location = new System.Drawing.Point(318, 255);
            this.OffUnit3.Name = "OffUnit3";
            this.OffUnit3.Size = new System.Drawing.Size(121, 21);
            this.OffUnit3.TabIndex = 35;
            // 
            // lbl_Offence
            // 
            this.lbl_Offence.AutoSize = true;
            this.lbl_Offence.Location = new System.Drawing.Point(945, 53);
            this.lbl_Offence.Name = "lbl_Offence";
            this.lbl_Offence.Size = new System.Drawing.Size(45, 13);
            this.lbl_Offence.TabIndex = 29;
            this.lbl_Offence.Text = "Offence";
            this.lbl_Offence.Visible = false;
            // 
            // lbl_DefRecruitAffinity
            // 
            this.lbl_DefRecruitAffinity.AutoSize = true;
            this.lbl_DefRecruitAffinity.Location = new System.Drawing.Point(9, 271);
            this.lbl_DefRecruitAffinity.Name = "lbl_DefRecruitAffinity";
            this.lbl_DefRecruitAffinity.Size = new System.Drawing.Size(74, 13);
            this.lbl_DefRecruitAffinity.TabIndex = 25;
            this.lbl_DefRecruitAffinity.Text = "Recruit affinity";
            // 
            // trackBar_DefRecruitAffinity
            // 
            this.trackBar_DefRecruitAffinity.Location = new System.Drawing.Point(80, 271);
            this.trackBar_DefRecruitAffinity.Maximum = 100;
            this.trackBar_DefRecruitAffinity.Name = "trackBar_DefRecruitAffinity";
            this.trackBar_DefRecruitAffinity.Size = new System.Drawing.Size(408, 45);
            this.trackBar_DefRecruitAffinity.TabIndex = 26;
            this.trackBar_DefRecruitAffinity.TickFrequency = 5;
            this.trackBar_DefRecruitAffinity.Value = 20;
            this.trackBar_DefRecruitAffinity.Scroll += new System.EventHandler(this.trackBar_DefRecruitAffinity_Scroll);
            // 
            // txtBox_DefRecruitAffinity
            // 
            this.txtBox_DefRecruitAffinity.Location = new System.Drawing.Point(242, 317);
            this.txtBox_DefRecruitAffinity.Name = "txtBox_DefRecruitAffinity";
            this.txtBox_DefRecruitAffinity.Size = new System.Drawing.Size(77, 20);
            this.txtBox_DefRecruitAffinity.TabIndex = 27;
            this.txtBox_DefRecruitAffinity.Text = "1";
            this.txtBox_DefRecruitAffinity.TextChanged += new System.EventHandler(this.txtBox_DefRecruitAffinity_TextChanged);
            this.txtBox_DefRecruitAffinity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_DefRecruitAffinity_KeyPress);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1462, 640);
            this.Controls.Add(this.lbl_Offence);
            this.Controls.Add(this.lbl_AI_Lord);
            this.Controls.Add(this.AI_Lords);
            this.Controls.Add(this.pnl_Offence);
            this.Controls.Add(this.lbl_Defence);
            this.Controls.Add(this.pnl_Defence);
            this.Controls.Add(this.open_Existing);
            this.Controls.Add(this.CreateAICharacter);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "AI_Character_Editor";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Patrols)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_WallDef)).EndInit();
            this.pnl_Defence.ResumeLayout(false);
            this.pnl_Defence.PerformLayout();
            this.pnl_Offence.ResumeLayout(false);
            this.pnl_Offence.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_FirstAttackForceSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_AttackForceIncreaseStatic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_DefRecruitAffinity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomComboBox AI_Lords;
        private System.Windows.Forms.Label lbl_AI_Lord;
        private System.Windows.Forms.Label lbl_Patrols;
        private System.Windows.Forms.Label lbl_WallDefence;
        private System.Windows.Forms.TrackBar trackBar_Patrols;
        private System.Windows.Forms.TrackBar trackBar_WallDef;
        private System.Windows.Forms.TextBox txtBox_Patrols;
        private System.Windows.Forms.TextBox txtBox_WalLDef;
        private System.Windows.Forms.Button CreateAICharacter;
        private System.Windows.Forms.ComboBox DefUnit1;
        private System.Windows.Forms.Label lbl_DefUnit1;
        private System.Windows.Forms.Label lbl_DefUnit2;
        private System.Windows.Forms.ComboBox DefUnit2;
        private System.Windows.Forms.Label lbl_DefUnit3;
        private System.Windows.Forms.ComboBox DefUnit3;
        private System.Windows.Forms.Label lbl_DefUnit4;
        private System.Windows.Forms.ComboBox DefUnit4;
        private System.Windows.Forms.Label lbl_DefUnit5;
        private System.Windows.Forms.ComboBox DefUnit5;
        private System.Windows.Forms.Label lbl_DefUnit6;
        private System.Windows.Forms.ComboBox DefUnit6;
        private System.Windows.Forms.Label lbl_DefUnit7;
        private System.Windows.Forms.ComboBox DefUnit7;
        private System.Windows.Forms.Label lbl_DefUnit8;
        private System.Windows.Forms.ComboBox DefUnit8;
        private System.Windows.Forms.Button open_Existing;
        private System.Windows.Forms.Panel pnl_Defence;
        private System.Windows.Forms.Label lbl_Defence;
        private System.Windows.Forms.Panel pnl_Offence;
        private System.Windows.Forms.Label lbl_OffUnit8;
        private System.Windows.Forms.Label lbl_FirstAttackForceSize;
        private System.Windows.Forms.ComboBox OffUnit8;
        private System.Windows.Forms.Label lbl_AttackForceIncreaseStatic;
        private System.Windows.Forms.Label lbl_OffUnit7;
        private System.Windows.Forms.TrackBar trackBar_FirstAttackForceSize;
        private System.Windows.Forms.ComboBox OffUnit7;
        private System.Windows.Forms.TrackBar trackBar_AttackForceIncreaseStatic;
        private System.Windows.Forms.Label lbl_OffUnit6;
        private System.Windows.Forms.TextBox txtBox_FirstAttackForceSize;
        private System.Windows.Forms.ComboBox OffUnit6;
        private System.Windows.Forms.TextBox txtBox_AttackForceIncreaseStatic;
        private System.Windows.Forms.Label lbl_OffUnit5;
        private System.Windows.Forms.ComboBox OffUnit1;
        private System.Windows.Forms.ComboBox OffUnit5;
        private System.Windows.Forms.Label lbl_OffUnit1;
        private System.Windows.Forms.Label lbl_OffUnit4;
        private System.Windows.Forms.ComboBox OffUnit2;
        private System.Windows.Forms.ComboBox OffUnit4;
        private System.Windows.Forms.Label lbl_OffUnit2;
        private System.Windows.Forms.Label lbl_OffUnit3;
        private System.Windows.Forms.ComboBox OffUnit3;
        private System.Windows.Forms.Label lbl_AttackForceIncreaseMultiplier;
        private System.Windows.Forms.TextBox txtBox_AttackForceIncreaseMultiplier;
        private System.Windows.Forms.Label lbl_Offence;
        private System.Windows.Forms.Label lbl_DefRecruitAffinity;
        private System.Windows.Forms.TrackBar trackBar_DefRecruitAffinity;
        private System.Windows.Forms.TextBox txtBox_DefRecruitAffinity;
    }
}

