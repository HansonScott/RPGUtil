namespace RPGUtil
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
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.btnD6 = new System.Windows.Forms.Button();
            this.btnD4 = new System.Windows.Forms.Button();
            this.btnD8 = new System.Windows.Forms.Button();
            this.btnD10 = new System.Windows.Forms.Button();
            this.btnD12 = new System.Windows.Forms.Button();
            this.btnD20 = new System.Windows.Forms.Button();
            this.btnDxDy = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.btnAbilities = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAbilitiesX6 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblChaBonus = new System.Windows.Forms.Label();
            this.nud_Cha = new System.Windows.Forms.NumericUpDown();
            this.lblCha = new System.Windows.Forms.Label();
            this.lblWisBonus = new System.Windows.Forms.Label();
            this.nud_Wis = new System.Windows.Forms.NumericUpDown();
            this.lblWis = new System.Windows.Forms.Label();
            this.lblIntBonus = new System.Windows.Forms.Label();
            this.nud_Int = new System.Windows.Forms.NumericUpDown();
            this.lblInt = new System.Windows.Forms.Label();
            this.lblConBonus = new System.Windows.Forms.Label();
            this.nud_Con = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.lblDexBonus = new System.Windows.Forms.Label();
            this.nud_Dex = new System.Windows.Forms.NumericUpDown();
            this.lblDex = new System.Windows.Forms.Label();
            this.lblStrBonus = new System.Windows.Forms.Label();
            this.nud_Str = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSet = new System.Windows.Forms.Button();
            this.cbClasses = new System.Windows.Forms.ComboBox();
            this.btnRandChar = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnConflictRandom = new System.Windows.Forms.Button();
            this.btnConflict = new System.Windows.Forms.Button();
            this.cbConflict = new System.Windows.Forms.ComboBox();
            this.lblConflict = new System.Windows.Forms.Label();
            this.btnRandomRequest = new System.Windows.Forms.Button();
            this.btnQuestDisplay = new System.Windows.Forms.Button();
            this.cbQuantity = new System.Windows.Forms.ComboBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.cbAntagonists = new System.Windows.Forms.ComboBox();
            this.lblAntagonist = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Cha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Wis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Int)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Con)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Dex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Str)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbOutput
            // 
            this.tbOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbOutput.BackColor = System.Drawing.Color.Black;
            this.tbOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOutput.ForeColor = System.Drawing.Color.White;
            this.tbOutput.Location = new System.Drawing.Point(548, 12);
            this.tbOutput.Multiline = true;
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbOutput.Size = new System.Drawing.Size(371, 499);
            this.tbOutput.TabIndex = 0;
            // 
            // btnD6
            // 
            this.btnD6.Location = new System.Drawing.Point(68, 6);
            this.btnD6.Name = "btnD6";
            this.btnD6.Size = new System.Drawing.Size(53, 50);
            this.btnD6.TabIndex = 1;
            this.btnD6.Text = "D6";
            this.btnD6.UseVisualStyleBackColor = true;
            this.btnD6.Click += new System.EventHandler(this.btnD6_Click);
            // 
            // btnD4
            // 
            this.btnD4.Location = new System.Drawing.Point(9, 6);
            this.btnD4.Name = "btnD4";
            this.btnD4.Size = new System.Drawing.Size(53, 50);
            this.btnD4.TabIndex = 2;
            this.btnD4.Text = "D4";
            this.btnD4.UseVisualStyleBackColor = true;
            this.btnD4.Click += new System.EventHandler(this.btnD4_Click);
            // 
            // btnD8
            // 
            this.btnD8.Location = new System.Drawing.Point(127, 6);
            this.btnD8.Name = "btnD8";
            this.btnD8.Size = new System.Drawing.Size(53, 50);
            this.btnD8.TabIndex = 4;
            this.btnD8.Text = "D8";
            this.btnD8.UseVisualStyleBackColor = true;
            this.btnD8.Click += new System.EventHandler(this.btnD8_Click);
            // 
            // btnD10
            // 
            this.btnD10.Location = new System.Drawing.Point(186, 6);
            this.btnD10.Name = "btnD10";
            this.btnD10.Size = new System.Drawing.Size(53, 50);
            this.btnD10.TabIndex = 3;
            this.btnD10.Text = "D10";
            this.btnD10.UseVisualStyleBackColor = true;
            this.btnD10.Click += new System.EventHandler(this.btnD10_Click);
            // 
            // btnD12
            // 
            this.btnD12.Location = new System.Drawing.Point(245, 6);
            this.btnD12.Name = "btnD12";
            this.btnD12.Size = new System.Drawing.Size(53, 50);
            this.btnD12.TabIndex = 6;
            this.btnD12.Text = "D12";
            this.btnD12.UseVisualStyleBackColor = true;
            this.btnD12.Click += new System.EventHandler(this.btnD12_Click);
            // 
            // btnD20
            // 
            this.btnD20.Location = new System.Drawing.Point(304, 6);
            this.btnD20.Name = "btnD20";
            this.btnD20.Size = new System.Drawing.Size(53, 50);
            this.btnD20.TabIndex = 5;
            this.btnD20.Text = "D20";
            this.btnD20.UseVisualStyleBackColor = true;
            this.btnD20.Click += new System.EventHandler(this.btnD20_Click);
            // 
            // btnDxDy
            // 
            this.btnDxDy.Location = new System.Drawing.Point(404, 6);
            this.btnDxDy.Name = "btnDxDy";
            this.btnDxDy.Size = new System.Drawing.Size(112, 50);
            this.btnDxDy.TabIndex = 7;
            this.btnDxDy.Text = "DxDy";
            this.btnDxDy.UseVisualStyleBackColor = true;
            this.btnDxDy.Click += new System.EventHandler(this.btnDxDy_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(404, 62);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(53, 20);
            this.numericUpDown1.TabIndex = 8;
            this.numericUpDown1.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(463, 62);
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(53, 20);
            this.numericUpDown2.TabIndex = 9;
            this.numericUpDown2.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // btnAbilities
            // 
            this.btnAbilities.Location = new System.Drawing.Point(9, 75);
            this.btnAbilities.Name = "btnAbilities";
            this.btnAbilities.Size = new System.Drawing.Size(112, 50);
            this.btnAbilities.TabIndex = 10;
            this.btnAbilities.Text = "Ability";
            this.btnAbilities.UseVisualStyleBackColor = true;
            this.btnAbilities.Click += new System.EventHandler(this.btnAbilities_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClear.Location = new System.Drawing.Point(548, 517);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(68, 26);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAbilitiesX6
            // 
            this.btnAbilitiesX6.Location = new System.Drawing.Point(127, 75);
            this.btnAbilitiesX6.Name = "btnAbilitiesX6";
            this.btnAbilitiesX6.Size = new System.Drawing.Size(112, 50);
            this.btnAbilitiesX6.TabIndex = 12;
            this.btnAbilitiesX6.Text = "6 Abilities";
            this.btnAbilitiesX6.UseVisualStyleBackColor = true;
            this.btnAbilitiesX6.Click += new System.EventHandler(this.btnAbilitiesX6_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblChaBonus);
            this.groupBox1.Controls.Add(this.nud_Cha);
            this.groupBox1.Controls.Add(this.lblCha);
            this.groupBox1.Controls.Add(this.lblWisBonus);
            this.groupBox1.Controls.Add(this.nud_Wis);
            this.groupBox1.Controls.Add(this.lblWis);
            this.groupBox1.Controls.Add(this.lblIntBonus);
            this.groupBox1.Controls.Add(this.nud_Int);
            this.groupBox1.Controls.Add(this.lblInt);
            this.groupBox1.Controls.Add(this.lblConBonus);
            this.groupBox1.Controls.Add(this.nud_Con);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblDexBonus);
            this.groupBox1.Controls.Add(this.nud_Dex);
            this.groupBox1.Controls.Add(this.lblDex);
            this.groupBox1.Controls.Add(this.lblStrBonus);
            this.groupBox1.Controls.Add(this.nud_Str);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(9, 259);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(193, 235);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Character Abilities";
            // 
            // lblChaBonus
            // 
            this.lblChaBonus.AutoSize = true;
            this.lblChaBonus.Location = new System.Drawing.Point(135, 177);
            this.lblChaBonus.Name = "lblChaBonus";
            this.lblChaBonus.Size = new System.Drawing.Size(13, 13);
            this.lblChaBonus.TabIndex = 17;
            this.lblChaBonus.Text = "0";
            // 
            // nud_Cha
            // 
            this.nud_Cha.Location = new System.Drawing.Point(59, 175);
            this.nud_Cha.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nud_Cha.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nud_Cha.Name = "nud_Cha";
            this.nud_Cha.Size = new System.Drawing.Size(44, 20);
            this.nud_Cha.TabIndex = 16;
            this.nud_Cha.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nud_Cha.ValueChanged += new System.EventHandler(this.nud_Cha_ValueChanged);
            // 
            // lblCha
            // 
            this.lblCha.AutoSize = true;
            this.lblCha.Location = new System.Drawing.Point(18, 177);
            this.lblCha.Name = "lblCha";
            this.lblCha.Size = new System.Drawing.Size(26, 13);
            this.lblCha.TabIndex = 15;
            this.lblCha.Text = "Cha";
            // 
            // lblWisBonus
            // 
            this.lblWisBonus.AutoSize = true;
            this.lblWisBonus.Location = new System.Drawing.Point(135, 151);
            this.lblWisBonus.Name = "lblWisBonus";
            this.lblWisBonus.Size = new System.Drawing.Size(13, 13);
            this.lblWisBonus.TabIndex = 14;
            this.lblWisBonus.Text = "0";
            // 
            // nud_Wis
            // 
            this.nud_Wis.Location = new System.Drawing.Point(59, 149);
            this.nud_Wis.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nud_Wis.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nud_Wis.Name = "nud_Wis";
            this.nud_Wis.Size = new System.Drawing.Size(44, 20);
            this.nud_Wis.TabIndex = 13;
            this.nud_Wis.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nud_Wis.ValueChanged += new System.EventHandler(this.nud_Wis_ValueChanged);
            // 
            // lblWis
            // 
            this.lblWis.AutoSize = true;
            this.lblWis.Location = new System.Drawing.Point(18, 151);
            this.lblWis.Name = "lblWis";
            this.lblWis.Size = new System.Drawing.Size(25, 13);
            this.lblWis.TabIndex = 12;
            this.lblWis.Text = "Wis";
            // 
            // lblIntBonus
            // 
            this.lblIntBonus.AutoSize = true;
            this.lblIntBonus.Location = new System.Drawing.Point(135, 125);
            this.lblIntBonus.Name = "lblIntBonus";
            this.lblIntBonus.Size = new System.Drawing.Size(13, 13);
            this.lblIntBonus.TabIndex = 11;
            this.lblIntBonus.Text = "0";
            // 
            // nud_Int
            // 
            this.nud_Int.Location = new System.Drawing.Point(59, 123);
            this.nud_Int.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nud_Int.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nud_Int.Name = "nud_Int";
            this.nud_Int.Size = new System.Drawing.Size(44, 20);
            this.nud_Int.TabIndex = 10;
            this.nud_Int.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nud_Int.ValueChanged += new System.EventHandler(this.nud_Int_ValueChanged);
            // 
            // lblInt
            // 
            this.lblInt.AutoSize = true;
            this.lblInt.Location = new System.Drawing.Point(18, 125);
            this.lblInt.Name = "lblInt";
            this.lblInt.Size = new System.Drawing.Size(19, 13);
            this.lblInt.TabIndex = 9;
            this.lblInt.Text = "Int";
            // 
            // lblConBonus
            // 
            this.lblConBonus.AutoSize = true;
            this.lblConBonus.Location = new System.Drawing.Point(135, 99);
            this.lblConBonus.Name = "lblConBonus";
            this.lblConBonus.Size = new System.Drawing.Size(13, 13);
            this.lblConBonus.TabIndex = 8;
            this.lblConBonus.Text = "0";
            // 
            // nud_Con
            // 
            this.nud_Con.Location = new System.Drawing.Point(59, 97);
            this.nud_Con.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nud_Con.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nud_Con.Name = "nud_Con";
            this.nud_Con.Size = new System.Drawing.Size(44, 20);
            this.nud_Con.TabIndex = 7;
            this.nud_Con.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nud_Con.ValueChanged += new System.EventHandler(this.nud_Con_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Con";
            // 
            // lblDexBonus
            // 
            this.lblDexBonus.AutoSize = true;
            this.lblDexBonus.Location = new System.Drawing.Point(135, 73);
            this.lblDexBonus.Name = "lblDexBonus";
            this.lblDexBonus.Size = new System.Drawing.Size(13, 13);
            this.lblDexBonus.TabIndex = 5;
            this.lblDexBonus.Text = "0";
            // 
            // nud_Dex
            // 
            this.nud_Dex.Location = new System.Drawing.Point(59, 71);
            this.nud_Dex.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nud_Dex.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nud_Dex.Name = "nud_Dex";
            this.nud_Dex.Size = new System.Drawing.Size(44, 20);
            this.nud_Dex.TabIndex = 4;
            this.nud_Dex.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nud_Dex.ValueChanged += new System.EventHandler(this.nud_Dex_ValueChanged);
            // 
            // lblDex
            // 
            this.lblDex.AutoSize = true;
            this.lblDex.Location = new System.Drawing.Point(18, 73);
            this.lblDex.Name = "lblDex";
            this.lblDex.Size = new System.Drawing.Size(26, 13);
            this.lblDex.TabIndex = 3;
            this.lblDex.Text = "Dex";
            // 
            // lblStrBonus
            // 
            this.lblStrBonus.AutoSize = true;
            this.lblStrBonus.Location = new System.Drawing.Point(135, 47);
            this.lblStrBonus.Name = "lblStrBonus";
            this.lblStrBonus.Size = new System.Drawing.Size(13, 13);
            this.lblStrBonus.TabIndex = 2;
            this.lblStrBonus.Text = "0";
            // 
            // nud_Str
            // 
            this.nud_Str.Location = new System.Drawing.Point(59, 45);
            this.nud_Str.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nud_Str.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nud_Str.Name = "nud_Str";
            this.nud_Str.Size = new System.Drawing.Size(44, 20);
            this.nud_Str.TabIndex = 1;
            this.nud_Str.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nud_Str.ValueChanged += new System.EventHandler(this.nud_Str_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Str";
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(245, 75);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(112, 50);
            this.btnSet.TabIndex = 14;
            this.btnSet.Text = "Set Character Abilities";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // cbClasses
            // 
            this.cbClasses.FormattingEnabled = true;
            this.cbClasses.Location = new System.Drawing.Point(208, 428);
            this.cbClasses.Name = "cbClasses";
            this.cbClasses.Size = new System.Drawing.Size(143, 21);
            this.cbClasses.TabIndex = 15;
            // 
            // btnRandChar
            // 
            this.btnRandChar.Location = new System.Drawing.Point(208, 454);
            this.btnRandChar.Name = "btnRandChar";
            this.btnRandChar.Size = new System.Drawing.Size(143, 37);
            this.btnRandChar.TabIndex = 17;
            this.btnRandChar.Text = "Generate Random Character";
            this.btnRandChar.UseVisualStyleBackColor = true;
            this.btnRandChar.Click += new System.EventHandler(this.btnRandChar_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(530, 526);
            this.tabControl1.TabIndex = 18;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.btnAbilitiesX6);
            this.tabPage1.Controls.Add(this.btnD12);
            this.tabPage1.Controls.Add(this.btnSet);
            this.tabPage1.Controls.Add(this.btnD20);
            this.tabPage1.Controls.Add(this.btnAbilities);
            this.tabPage1.Controls.Add(this.btnD8);
            this.tabPage1.Controls.Add(this.btnRandChar);
            this.tabPage1.Controls.Add(this.btnD10);
            this.tabPage1.Controls.Add(this.cbClasses);
            this.tabPage1.Controls.Add(this.btnD4);
            this.tabPage1.Controls.Add(this.btnDxDy);
            this.tabPage1.Controls.Add(this.btnD6);
            this.tabPage1.Controls.Add(this.numericUpDown1);
            this.tabPage1.Controls.Add(this.numericUpDown2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(522, 500);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dice Rolls";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnConflictRandom);
            this.tabPage2.Controls.Add(this.btnConflict);
            this.tabPage2.Controls.Add(this.cbConflict);
            this.tabPage2.Controls.Add(this.lblConflict);
            this.tabPage2.Controls.Add(this.btnRandomRequest);
            this.tabPage2.Controls.Add(this.btnQuestDisplay);
            this.tabPage2.Controls.Add(this.cbQuantity);
            this.tabPage2.Controls.Add(this.lblQuantity);
            this.tabPage2.Controls.Add(this.cbAntagonists);
            this.tabPage2.Controls.Add(this.lblAntagonist);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(522, 500);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Quests";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnConflictRandom
            // 
            this.btnConflictRandom.Location = new System.Drawing.Point(299, 22);
            this.btnConflictRandom.Name = "btnConflictRandom";
            this.btnConflictRandom.Size = new System.Drawing.Size(75, 22);
            this.btnConflictRandom.TabIndex = 9;
            this.btnConflictRandom.Text = "Random";
            this.btnConflictRandom.UseVisualStyleBackColor = true;
            this.btnConflictRandom.Click += new System.EventHandler(this.btnConflictRandom_Click);
            // 
            // btnConflict
            // 
            this.btnConflict.Location = new System.Drawing.Point(218, 22);
            this.btnConflict.Name = "btnConflict";
            this.btnConflict.Size = new System.Drawing.Size(75, 22);
            this.btnConflict.TabIndex = 8;
            this.btnConflict.Text = "Display";
            this.btnConflict.UseVisualStyleBackColor = true;
            this.btnConflict.Click += new System.EventHandler(this.btnConflict_Click);
            // 
            // cbConflict
            // 
            this.cbConflict.FormattingEnabled = true;
            this.cbConflict.Location = new System.Drawing.Point(82, 22);
            this.cbConflict.Name = "cbConflict";
            this.cbConflict.Size = new System.Drawing.Size(121, 21);
            this.cbConflict.TabIndex = 7;
            // 
            // lblConflict
            // 
            this.lblConflict.AutoSize = true;
            this.lblConflict.Location = new System.Drawing.Point(19, 25);
            this.lblConflict.Name = "lblConflict";
            this.lblConflict.Size = new System.Drawing.Size(42, 13);
            this.lblConflict.TabIndex = 6;
            this.lblConflict.Text = "Conflict";
            // 
            // btnRandomRequest
            // 
            this.btnRandomRequest.Location = new System.Drawing.Point(299, 67);
            this.btnRandomRequest.Name = "btnRandomRequest";
            this.btnRandomRequest.Size = new System.Drawing.Size(75, 50);
            this.btnRandomRequest.TabIndex = 5;
            this.btnRandomRequest.Text = "Display Random";
            this.btnRandomRequest.UseVisualStyleBackColor = true;
            this.btnRandomRequest.Click += new System.EventHandler(this.btnRandomRequest_Click);
            // 
            // btnQuestDisplay
            // 
            this.btnQuestDisplay.Location = new System.Drawing.Point(218, 67);
            this.btnQuestDisplay.Name = "btnQuestDisplay";
            this.btnQuestDisplay.Size = new System.Drawing.Size(75, 50);
            this.btnQuestDisplay.TabIndex = 4;
            this.btnQuestDisplay.Text = "Display";
            this.btnQuestDisplay.UseVisualStyleBackColor = true;
            this.btnQuestDisplay.Click += new System.EventHandler(this.btnQuestDisplay_Click);
            // 
            // cbQuantity
            // 
            this.cbQuantity.FormattingEnabled = true;
            this.cbQuantity.Location = new System.Drawing.Point(82, 96);
            this.cbQuantity.Name = "cbQuantity";
            this.cbQuantity.Size = new System.Drawing.Size(121, 21);
            this.cbQuantity.TabIndex = 3;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(19, 99);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(49, 13);
            this.lblQuantity.TabIndex = 2;
            this.lblQuantity.Text = "Quantity:";
            // 
            // cbAntagonists
            // 
            this.cbAntagonists.FormattingEnabled = true;
            this.cbAntagonists.Location = new System.Drawing.Point(82, 69);
            this.cbAntagonists.Name = "cbAntagonists";
            this.cbAntagonists.Size = new System.Drawing.Size(121, 21);
            this.cbAntagonists.TabIndex = 1;
            // 
            // lblAntagonist
            // 
            this.lblAntagonist.AutoSize = true;
            this.lblAntagonist.Location = new System.Drawing.Point(19, 72);
            this.lblAntagonist.Name = "lblAntagonist";
            this.lblAntagonist.Size = new System.Drawing.Size(57, 13);
            this.lblAntagonist.TabIndex = 0;
            this.lblAntagonist.Text = "Antagonist";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 547);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.tbOutput);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "RPG Util";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Cha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Wis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Int)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Con)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Dex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Str)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.Button btnD6;
        private System.Windows.Forms.Button btnD4;
        private System.Windows.Forms.Button btnD8;
        private System.Windows.Forms.Button btnD10;
        private System.Windows.Forms.Button btnD12;
        private System.Windows.Forms.Button btnD20;
        private System.Windows.Forms.Button btnDxDy;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Button btnAbilities;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAbilitiesX6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblChaBonus;
        private System.Windows.Forms.NumericUpDown nud_Cha;
        private System.Windows.Forms.Label lblCha;
        private System.Windows.Forms.Label lblWisBonus;
        private System.Windows.Forms.Label lblWis;
        private System.Windows.Forms.Label lblIntBonus;
        private System.Windows.Forms.NumericUpDown nud_Int;
        private System.Windows.Forms.Label lblInt;
        private System.Windows.Forms.Label lblConBonus;
        private System.Windows.Forms.NumericUpDown nud_Con;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblDexBonus;
        private System.Windows.Forms.NumericUpDown nud_Dex;
        private System.Windows.Forms.Label lblDex;
        private System.Windows.Forms.Label lblStrBonus;
        private System.Windows.Forms.NumericUpDown nud_Str;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.ComboBox cbClasses;
        private System.Windows.Forms.Button btnRandChar;
        private System.Windows.Forms.NumericUpDown nud_Wis;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox cbAntagonists;
        private System.Windows.Forms.Label lblAntagonist;
        private System.Windows.Forms.ComboBox cbQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Button btnQuestDisplay;
        private System.Windows.Forms.Button btnRandomRequest;
        private System.Windows.Forms.ComboBox cbConflict;
        private System.Windows.Forms.Label lblConflict;
        private System.Windows.Forms.Button btnConflict;
        private System.Windows.Forms.Button btnConflictRandom;
    }
}

