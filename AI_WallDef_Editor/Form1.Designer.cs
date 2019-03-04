namespace AI_WallDef_Editor
{
    partial class Form1
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
            this.AI_Lords = new System.Windows.Forms.ComboBox();
            this.lbl_AI_Lord = new System.Windows.Forms.Label();
            this.lbl_Patrols = new System.Windows.Forms.Label();
            this.lbl_WallDefence = new System.Windows.Forms.Label();
            this.trackBar_Patrols = new System.Windows.Forms.TrackBar();
            this.trackBar_WallDef = new System.Windows.Forms.TrackBar();
            this.txtBox_Patrols = new System.Windows.Forms.TextBox();
            this.txtBox_WalLDef = new System.Windows.Forms.TextBox();
            this.CreateScript = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Patrols)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_WallDef)).BeginInit();
            this.SuspendLayout();
            // 
            // AI_Lords
            // 
            this.AI_Lords.FormattingEnabled = true;
            this.AI_Lords.Location = new System.Drawing.Point(83, 12);
            this.AI_Lords.Name = "AI_Lords";
            this.AI_Lords.Size = new System.Drawing.Size(121, 21);
            this.AI_Lords.TabIndex = 0;
            // 
            // lbl_AI_Lord
            // 
            this.lbl_AI_Lord.AutoSize = true;
            this.lbl_AI_Lord.Location = new System.Drawing.Point(12, 15);
            this.lbl_AI_Lord.Name = "lbl_AI_Lord";
            this.lbl_AI_Lord.Size = new System.Drawing.Size(41, 13);
            this.lbl_AI_Lord.TabIndex = 1;
            this.lbl_AI_Lord.Text = "AI Lord";
            // 
            // lbl_Patrols
            // 
            this.lbl_Patrols.AutoSize = true;
            this.lbl_Patrols.Location = new System.Drawing.Point(12, 52);
            this.lbl_Patrols.Name = "lbl_Patrols";
            this.lbl_Patrols.Size = new System.Drawing.Size(39, 13);
            this.lbl_Patrols.TabIndex = 2;
            this.lbl_Patrols.Text = "Patrols";
            // 
            // lbl_WallDefence
            // 
            this.lbl_WallDefence.AutoSize = true;
            this.lbl_WallDefence.Location = new System.Drawing.Point(12, 126);
            this.lbl_WallDefence.Name = "lbl_WallDefence";
            this.lbl_WallDefence.Size = new System.Drawing.Size(72, 13);
            this.lbl_WallDefence.TabIndex = 3;
            this.lbl_WallDefence.Text = "Wall Defence";
            // 
            // trackBar_Patrols
            // 
            this.trackBar_Patrols.Location = new System.Drawing.Point(83, 52);
            this.trackBar_Patrols.Maximum = 300;
            this.trackBar_Patrols.Minimum = 1;
            this.trackBar_Patrols.Name = "trackBar_Patrols";
            this.trackBar_Patrols.Size = new System.Drawing.Size(408, 45);
            this.trackBar_Patrols.TabIndex = 4;
            this.trackBar_Patrols.TickFrequency = 5;
            this.trackBar_Patrols.Value = 20;
            this.trackBar_Patrols.Scroll += new System.EventHandler(this.trackBar_Patrols_Scroll);
            // 
            // trackBar_WallDef
            // 
            this.trackBar_WallDef.Location = new System.Drawing.Point(83, 126);
            this.trackBar_WallDef.Maximum = 300;
            this.trackBar_WallDef.Minimum = 1;
            this.trackBar_WallDef.Name = "trackBar_WallDef";
            this.trackBar_WallDef.Size = new System.Drawing.Size(408, 45);
            this.trackBar_WallDef.TabIndex = 5;
            this.trackBar_WallDef.TickFrequency = 5;
            this.trackBar_WallDef.Value = 20;
            this.trackBar_WallDef.Scroll += new System.EventHandler(this.trackBar_WallDef_Scroll);
            // 
            // txtBox_Patrols
            // 
            this.txtBox_Patrols.Location = new System.Drawing.Point(245, 87);
            this.txtBox_Patrols.Name = "txtBox_Patrols";
            this.txtBox_Patrols.Size = new System.Drawing.Size(77, 20);
            this.txtBox_Patrols.TabIndex = 6;
            this.txtBox_Patrols.Text = "1";
            this.txtBox_Patrols.TextChanged += new System.EventHandler(this.txtBox_Patrols_TextChanged);
            this.txtBox_Patrols.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_Patrols_KeyPress);
            // 
            // txtBox_WalLDef
            // 
            this.txtBox_WalLDef.Location = new System.Drawing.Point(245, 164);
            this.txtBox_WalLDef.Name = "txtBox_WalLDef";
            this.txtBox_WalLDef.Size = new System.Drawing.Size(77, 20);
            this.txtBox_WalLDef.TabIndex = 7;
            this.txtBox_WalLDef.Text = "1";
            this.txtBox_WalLDef.TextChanged += new System.EventHandler(this.txtBox_WalLDef_TextChanged);
            this.txtBox_WalLDef.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_WalLDef_KeyPress);
            // 
            // CreateScript
            // 
            this.CreateScript.Location = new System.Drawing.Point(569, 404);
            this.CreateScript.Name = "CreateScript";
            this.CreateScript.Size = new System.Drawing.Size(75, 23);
            this.CreateScript.TabIndex = 8;
            this.CreateScript.Text = "Create";
            this.CreateScript.UseVisualStyleBackColor = true;
            this.CreateScript.Click += new System.EventHandler(this.CreateScript_Click);
            // 
            // DefUnit1
            // 
            this.DefUnit1.FormattingEnabled = true;
            this.DefUnit1.Location = new System.Drawing.Point(15, 227);
            this.DefUnit1.Name = "DefUnit1";
            this.DefUnit1.Size = new System.Drawing.Size(121, 21);
            this.DefUnit1.TabIndex = 9;
            // 
            // lbl_DefUnit1
            // 
            this.lbl_DefUnit1.AutoSize = true;
            this.lbl_DefUnit1.Location = new System.Drawing.Point(43, 211);
            this.lbl_DefUnit1.Name = "lbl_DefUnit1";
            this.lbl_DefUnit1.Size = new System.Drawing.Size(49, 13);
            this.lbl_DefUnit1.TabIndex = 10;
            this.lbl_DefUnit1.Text = "DefUnit1";
            // 
            // lbl_DefUnit2
            // 
            this.lbl_DefUnit2.AutoSize = true;
            this.lbl_DefUnit2.Location = new System.Drawing.Point(181, 211);
            this.lbl_DefUnit2.Name = "lbl_DefUnit2";
            this.lbl_DefUnit2.Size = new System.Drawing.Size(49, 13);
            this.lbl_DefUnit2.TabIndex = 12;
            this.lbl_DefUnit2.Text = "DefUnit2";
            // 
            // DefUnit2
            // 
            this.DefUnit2.FormattingEnabled = true;
            this.DefUnit2.Location = new System.Drawing.Point(156, 227);
            this.DefUnit2.Name = "DefUnit2";
            this.DefUnit2.Size = new System.Drawing.Size(121, 21);
            this.DefUnit2.TabIndex = 11;
            // 
            // lbl_DefUnit3
            // 
            this.lbl_DefUnit3.AutoSize = true;
            this.lbl_DefUnit3.Location = new System.Drawing.Point(321, 211);
            this.lbl_DefUnit3.Name = "lbl_DefUnit3";
            this.lbl_DefUnit3.Size = new System.Drawing.Size(49, 13);
            this.lbl_DefUnit3.TabIndex = 14;
            this.lbl_DefUnit3.Text = "DefUnit3";
            // 
            // DefUnit3
            // 
            this.DefUnit3.FormattingEnabled = true;
            this.DefUnit3.Location = new System.Drawing.Point(293, 227);
            this.DefUnit3.Name = "DefUnit3";
            this.DefUnit3.Size = new System.Drawing.Size(121, 21);
            this.DefUnit3.TabIndex = 13;
            // 
            // lbl_DefUnit4
            // 
            this.lbl_DefUnit4.AutoSize = true;
            this.lbl_DefUnit4.Location = new System.Drawing.Point(466, 211);
            this.lbl_DefUnit4.Name = "lbl_DefUnit4";
            this.lbl_DefUnit4.Size = new System.Drawing.Size(49, 13);
            this.lbl_DefUnit4.TabIndex = 16;
            this.lbl_DefUnit4.Text = "DefUnit4";
            // 
            // DefUnit4
            // 
            this.DefUnit4.FormattingEnabled = true;
            this.DefUnit4.Location = new System.Drawing.Point(438, 227);
            this.DefUnit4.Name = "DefUnit4";
            this.DefUnit4.Size = new System.Drawing.Size(121, 21);
            this.DefUnit4.TabIndex = 15;
            // 
            // lbl_DefUnit5
            // 
            this.lbl_DefUnit5.AutoSize = true;
            this.lbl_DefUnit5.Location = new System.Drawing.Point(43, 251);
            this.lbl_DefUnit5.Name = "lbl_DefUnit5";
            this.lbl_DefUnit5.Size = new System.Drawing.Size(49, 13);
            this.lbl_DefUnit5.TabIndex = 18;
            this.lbl_DefUnit5.Text = "DefUnit5";
            // 
            // DefUnit5
            // 
            this.DefUnit5.FormattingEnabled = true;
            this.DefUnit5.Location = new System.Drawing.Point(15, 267);
            this.DefUnit5.Name = "DefUnit5";
            this.DefUnit5.Size = new System.Drawing.Size(121, 21);
            this.DefUnit5.TabIndex = 17;
            // 
            // lbl_DefUnit6
            // 
            this.lbl_DefUnit6.AutoSize = true;
            this.lbl_DefUnit6.Location = new System.Drawing.Point(184, 251);
            this.lbl_DefUnit6.Name = "lbl_DefUnit6";
            this.lbl_DefUnit6.Size = new System.Drawing.Size(49, 13);
            this.lbl_DefUnit6.TabIndex = 20;
            this.lbl_DefUnit6.Text = "DefUnit6";
            // 
            // DefUnit6
            // 
            this.DefUnit6.FormattingEnabled = true;
            this.DefUnit6.Location = new System.Drawing.Point(156, 267);
            this.DefUnit6.Name = "DefUnit6";
            this.DefUnit6.Size = new System.Drawing.Size(121, 21);
            this.DefUnit6.TabIndex = 19;
            // 
            // lbl_DefUnit7
            // 
            this.lbl_DefUnit7.AutoSize = true;
            this.lbl_DefUnit7.Location = new System.Drawing.Point(321, 251);
            this.lbl_DefUnit7.Name = "lbl_DefUnit7";
            this.lbl_DefUnit7.Size = new System.Drawing.Size(49, 13);
            this.lbl_DefUnit7.TabIndex = 22;
            this.lbl_DefUnit7.Text = "DefUnit7";
            // 
            // DefUnit7
            // 
            this.DefUnit7.FormattingEnabled = true;
            this.DefUnit7.Location = new System.Drawing.Point(293, 267);
            this.DefUnit7.Name = "DefUnit7";
            this.DefUnit7.Size = new System.Drawing.Size(121, 21);
            this.DefUnit7.TabIndex = 21;
            // 
            // lbl_DefUnit8
            // 
            this.lbl_DefUnit8.AutoSize = true;
            this.lbl_DefUnit8.Location = new System.Drawing.Point(466, 251);
            this.lbl_DefUnit8.Name = "lbl_DefUnit8";
            this.lbl_DefUnit8.Size = new System.Drawing.Size(49, 13);
            this.lbl_DefUnit8.TabIndex = 24;
            this.lbl_DefUnit8.Text = "DefUnit8";
            // 
            // DefUnit8
            // 
            this.DefUnit8.FormattingEnabled = true;
            this.DefUnit8.Location = new System.Drawing.Point(438, 267);
            this.DefUnit8.Name = "DefUnit8";
            this.DefUnit8.Size = new System.Drawing.Size(121, 21);
            this.DefUnit8.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 450);
            this.Controls.Add(this.lbl_DefUnit8);
            this.Controls.Add(this.DefUnit8);
            this.Controls.Add(this.lbl_DefUnit7);
            this.Controls.Add(this.DefUnit7);
            this.Controls.Add(this.lbl_DefUnit6);
            this.Controls.Add(this.DefUnit6);
            this.Controls.Add(this.lbl_DefUnit5);
            this.Controls.Add(this.DefUnit5);
            this.Controls.Add(this.lbl_DefUnit4);
            this.Controls.Add(this.DefUnit4);
            this.Controls.Add(this.lbl_DefUnit3);
            this.Controls.Add(this.DefUnit3);
            this.Controls.Add(this.lbl_DefUnit2);
            this.Controls.Add(this.DefUnit2);
            this.Controls.Add(this.lbl_DefUnit1);
            this.Controls.Add(this.DefUnit1);
            this.Controls.Add(this.CreateScript);
            this.Controls.Add(this.txtBox_WalLDef);
            this.Controls.Add(this.txtBox_Patrols);
            this.Controls.Add(this.trackBar_WallDef);
            this.Controls.Add(this.trackBar_Patrols);
            this.Controls.Add(this.lbl_WallDefence);
            this.Controls.Add(this.lbl_Patrols);
            this.Controls.Add(this.lbl_AI_Lord);
            this.Controls.Add(this.AI_Lords);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Patrols)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_WallDef)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox AI_Lords;
        private System.Windows.Forms.Label lbl_AI_Lord;
        private System.Windows.Forms.Label lbl_Patrols;
        private System.Windows.Forms.Label lbl_WallDefence;
        private System.Windows.Forms.TrackBar trackBar_Patrols;
        private System.Windows.Forms.TrackBar trackBar_WallDef;
        private System.Windows.Forms.TextBox txtBox_Patrols;
        private System.Windows.Forms.TextBox txtBox_WalLDef;
        private System.Windows.Forms.Button CreateScript;
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
    }
}

