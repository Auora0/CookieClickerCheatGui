namespace WindowsFormsApp2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.materialTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.Currency = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.cookiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lumpsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.heavenlyChipsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Stacked = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.noneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materialButton3 = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialTextBox2 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.chromiumWebBrowser1 = new CefSharp.WinForms.ChromiumWebBrowser();
            this.Execute = new MaterialSkin.Controls.MaterialButton();
            this.Save = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton4 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton5 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton6 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton7 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton8 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton9 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton10 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton11 = new MaterialSkin.Controls.MaterialButton();
            this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialButton12 = new MaterialSkin.Controls.MaterialButton();
            this.bunifuSeparator2 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.bunifuSeparator3 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.Currency.SuspendLayout();
            this.Stacked.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTextBox1
            // 
            this.materialTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox1.Depth = 0;
            this.materialTextBox1.Font = new System.Drawing.Font("Roboto", 12F);
            this.materialTextBox1.Location = new System.Drawing.Point(95, 127);
            this.materialTextBox1.MaxLength = 50;
            this.materialTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox1.Multiline = false;
            this.materialTextBox1.Name = "materialTextBox1";
            this.materialTextBox1.Size = new System.Drawing.Size(194, 50);
            this.materialTextBox1.TabIndex = 0;
            this.materialTextBox1.Text = "5";
            this.materialTextBox1.TextChanged += new System.EventHandler(this.materialTextBox1_TextChanged);
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Depth = 0;
            this.materialButton1.DrawShadows = true;
            this.materialButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(126, 186);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.Size = new System.Drawing.Size(126, 36);
            this.materialButton1.TabIndex = 1;
            this.materialButton1.Text = "Set Currency";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(137, 92);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(108, 19);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "Currency Editor";
            // 
            // Currency
            // 
            this.Currency.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.Currency.Depth = 0;
            this.Currency.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cookiesToolStripMenuItem,
            this.lumpsToolStripMenuItem,
            this.heavenlyChipsToolStripMenuItem});
            this.Currency.MouseState = MaterialSkin.MouseState.HOVER;
            this.Currency.Name = "Currency";
            this.Currency.Size = new System.Drawing.Size(157, 70);
            // 
            // cookiesToolStripMenuItem
            // 
            this.cookiesToolStripMenuItem.Name = "cookiesToolStripMenuItem";
            this.cookiesToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.cookiesToolStripMenuItem.Text = "Cookies";
            this.cookiesToolStripMenuItem.Click += new System.EventHandler(this.cookiesToolStripMenuItem_Click);
            // 
            // lumpsToolStripMenuItem
            // 
            this.lumpsToolStripMenuItem.Name = "lumpsToolStripMenuItem";
            this.lumpsToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.lumpsToolStripMenuItem.Text = "Lumps";
            this.lumpsToolStripMenuItem.Click += new System.EventHandler(this.lumpsToolStripMenuItem_Click);
            // 
            // heavenlyChipsToolStripMenuItem
            // 
            this.heavenlyChipsToolStripMenuItem.Name = "heavenlyChipsToolStripMenuItem";
            this.heavenlyChipsToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.heavenlyChipsToolStripMenuItem.Text = "Heavenly Chips";
            this.heavenlyChipsToolStripMenuItem.Click += new System.EventHandler(this.heavenlyChipsToolStripMenuItem_Click);
            // 
            // Stacked
            // 
            this.Stacked.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.Stacked.Depth = 0;
            this.Stacked.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noneToolStripMenuItem,
            this.kToolStripMenuItem,
            this.mToolStripMenuItem,
            this.bToolStripMenuItem,
            this.tToolStripMenuItem,
            this.qaToolStripMenuItem,
            this.qdToolStripMenuItem});
            this.Stacked.MouseState = MaterialSkin.MouseState.HOVER;
            this.Stacked.Name = "Stacked";
            this.Stacked.Size = new System.Drawing.Size(104, 158);
            // 
            // noneToolStripMenuItem
            // 
            this.noneToolStripMenuItem.Name = "noneToolStripMenuItem";
            this.noneToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.noneToolStripMenuItem.Text = "None";
            this.noneToolStripMenuItem.Click += new System.EventHandler(this.noneToolStripMenuItem_Click);
            // 
            // kToolStripMenuItem
            // 
            this.kToolStripMenuItem.Name = "kToolStripMenuItem";
            this.kToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.kToolStripMenuItem.Text = "K";
            this.kToolStripMenuItem.Click += new System.EventHandler(this.kToolStripMenuItem_Click);
            // 
            // mToolStripMenuItem
            // 
            this.mToolStripMenuItem.Name = "mToolStripMenuItem";
            this.mToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.mToolStripMenuItem.Text = "M";
            this.mToolStripMenuItem.Click += new System.EventHandler(this.mToolStripMenuItem_Click);
            // 
            // bToolStripMenuItem
            // 
            this.bToolStripMenuItem.Name = "bToolStripMenuItem";
            this.bToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.bToolStripMenuItem.Text = "B";
            this.bToolStripMenuItem.Click += new System.EventHandler(this.bToolStripMenuItem_Click);
            // 
            // tToolStripMenuItem
            // 
            this.tToolStripMenuItem.Name = "tToolStripMenuItem";
            this.tToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.tToolStripMenuItem.Text = "T";
            this.tToolStripMenuItem.Click += new System.EventHandler(this.tToolStripMenuItem_Click);
            // 
            // qaToolStripMenuItem
            // 
            this.qaToolStripMenuItem.Name = "qaToolStripMenuItem";
            this.qaToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.qaToolStripMenuItem.Text = "Qa";
            this.qaToolStripMenuItem.Click += new System.EventHandler(this.qaToolStripMenuItem_Click);
            // 
            // qdToolStripMenuItem
            // 
            this.qdToolStripMenuItem.Name = "qdToolStripMenuItem";
            this.qdToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.qdToolStripMenuItem.Text = "Qd";
            this.qdToolStripMenuItem.Click += new System.EventHandler(this.qdToolStripMenuItem_Click);
            // 
            // materialButton3
            // 
            this.materialButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton3.Depth = 0;
            this.materialButton3.DrawShadows = true;
            this.materialButton3.HighEmphasis = true;
            this.materialButton3.Icon = null;
            this.materialButton3.Location = new System.Drawing.Point(296, 127);
            this.materialButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton3.MaximumSize = new System.Drawing.Size(100, 50);
            this.materialButton3.MinimumSize = new System.Drawing.Size(100, 50);
            this.materialButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton3.Name = "materialButton3";
            this.materialButton3.Size = new System.Drawing.Size(100, 50);
            this.materialButton3.TabIndex = 6;
            this.materialButton3.Text = "Suffix";
            this.materialButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton3.UseAccentColor = false;
            this.materialButton3.UseVisualStyleBackColor = true;
            this.materialButton3.Click += new System.EventHandler(this.materialButton3_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(260, 195);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(55, 19);
            this.materialLabel2.TabIndex = 7;
            this.materialLabel2.Text = "cookies";
            // 
            // materialTextBox2
            // 
            this.materialTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox2.Depth = 0;
            this.materialTextBox2.Font = new System.Drawing.Font("Roboto", 12F);
            this.materialTextBox2.Location = new System.Drawing.Point(21, 266);
            this.materialTextBox2.MaxLength = 50;
            this.materialTextBox2.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox2.Multiline = false;
            this.materialTextBox2.Name = "materialTextBox2";
            this.materialTextBox2.Size = new System.Drawing.Size(405, 50);
            this.materialTextBox2.TabIndex = 8;
            this.materialTextBox2.Text = "";
            this.materialTextBox2.TextChanged += new System.EventHandler(this.materialTextBox2_TextChanged);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(321, 102);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(38, 19);
            this.materialLabel3.TabIndex = 9;
            this.materialLabel3.Text = "None";
            // 
            // chromiumWebBrowser1
            // 
            this.chromiumWebBrowser1.ActivateBrowserOnCreation = false;
            this.chromiumWebBrowser1.Location = new System.Drawing.Point(476, 78);
            this.chromiumWebBrowser1.Name = "chromiumWebBrowser1";
            this.chromiumWebBrowser1.Size = new System.Drawing.Size(971, 724);
            this.chromiumWebBrowser1.TabIndex = 10;
            this.chromiumWebBrowser1.LoadingStateChanged += new System.EventHandler<CefSharp.LoadingStateChangedEventArgs>(this.chromiumWebBrowser1_LoadingStateChanged_1);
            // 
            // Execute
            // 
            this.Execute.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Execute.Depth = 0;
            this.Execute.DrawShadows = true;
            this.Execute.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Execute.HighEmphasis = true;
            this.Execute.Icon = null;
            this.Execute.Location = new System.Drawing.Point(63, 325);
            this.Execute.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Execute.MaximumSize = new System.Drawing.Size(310, 36);
            this.Execute.MinimumSize = new System.Drawing.Size(310, 36);
            this.Execute.MouseState = MaterialSkin.MouseState.HOVER;
            this.Execute.Name = "Execute";
            this.Execute.Size = new System.Drawing.Size(310, 36);
            this.Execute.TabIndex = 11;
            this.Execute.Text = "Execute Command";
            this.Execute.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Execute.UseAccentColor = false;
            this.Execute.UseVisualStyleBackColor = true;
            this.Execute.Click += new System.EventHandler(this.Execute_Click);
            // 
            // Save
            // 
            this.Save.AutoSize = true;
            this.Save.Depth = 0;
            this.Save.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Save.Location = new System.Drawing.Point(2, 810);
            this.Save.MouseState = MaterialSkin.MouseState.HOVER;
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(10, 19);
            this.Save.TabIndex = 12;
            this.Save.Text = "1";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(209, 384);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(53, 19);
            this.materialLabel4.TabIndex = 13;
            this.materialLabel4.Text = "Special";
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Depth = 0;
            this.materialButton2.DrawShadows = true;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = global::WindowsFormsApp2.Properties.Resources.autoclicktr;
            this.materialButton2.Location = new System.Drawing.Point(5, 497);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MaximumSize = new System.Drawing.Size(217, 36);
            this.materialButton2.MinimumSize = new System.Drawing.Size(217, 36);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.Size = new System.Drawing.Size(217, 36);
            this.materialButton2.TabIndex = 14;
            this.materialButton2.Text = "AutoClicker";
            this.materialButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            this.materialButton2.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // materialButton4
            // 
            this.materialButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton4.Depth = 0;
            this.materialButton4.DrawShadows = true;
            this.materialButton4.HighEmphasis = true;
            this.materialButton4.Icon = global::WindowsFormsApp2.Properties.Resources.Golden_cookie2;
            this.materialButton4.Location = new System.Drawing.Point(5, 545);
            this.materialButton4.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton4.Name = "materialButton4";
            this.materialButton4.Size = new System.Drawing.Size(217, 36);
            this.materialButton4.TabIndex = 15;
            this.materialButton4.Text = "Spawn Golden Cookie";
            this.materialButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.materialButton4.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton4.UseAccentColor = false;
            this.materialButton4.UseVisualStyleBackColor = true;
            this.materialButton4.Click += new System.EventHandler(this.materialButton4_Click);
            // 
            // materialButton5
            // 
            this.materialButton5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton5.Depth = 0;
            this.materialButton5.DrawShadows = true;
            this.materialButton5.HighEmphasis = true;
            this.materialButton5.Icon = global::WindowsFormsApp2.Properties.Resources.autoclicktr;
            this.materialButton5.Location = new System.Drawing.Point(253, 497);
            this.materialButton5.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton5.MaximumSize = new System.Drawing.Size(217, 36);
            this.materialButton5.MinimumSize = new System.Drawing.Size(217, 36);
            this.materialButton5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton5.Name = "materialButton5";
            this.materialButton5.Size = new System.Drawing.Size(217, 36);
            this.materialButton5.TabIndex = 16;
            this.materialButton5.Text = "Stop AutoClicker";
            this.materialButton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.materialButton5.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton5.UseAccentColor = false;
            this.materialButton5.UseVisualStyleBackColor = true;
            this.materialButton5.Click += new System.EventHandler(this.materialButton5_Click);
            // 
            // materialButton6
            // 
            this.materialButton6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton6.Depth = 0;
            this.materialButton6.DrawShadows = true;
            this.materialButton6.HighEmphasis = true;
            this.materialButton6.Icon = global::WindowsFormsApp2.Properties.Resources.Raindeer;
            this.materialButton6.Location = new System.Drawing.Point(253, 545);
            this.materialButton6.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton6.MaximumSize = new System.Drawing.Size(217, 36);
            this.materialButton6.MinimumSize = new System.Drawing.Size(217, 36);
            this.materialButton6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton6.Name = "materialButton6";
            this.materialButton6.Size = new System.Drawing.Size(217, 36);
            this.materialButton6.TabIndex = 17;
            this.materialButton6.Text = "Spawn Rein Deer";
            this.materialButton6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.materialButton6.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton6.UseAccentColor = false;
            this.materialButton6.UseVisualStyleBackColor = true;
            this.materialButton6.Click += new System.EventHandler(this.materialButton6_Click);
            // 
            // materialButton7
            // 
            this.materialButton7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton7.Depth = 0;
            this.materialButton7.DrawShadows = true;
            this.materialButton7.HighEmphasis = true;
            this.materialButton7.Icon = global::WindowsFormsApp2.Properties.Resources.Golden_cookie2;
            this.materialButton7.Location = new System.Drawing.Point(5, 593);
            this.materialButton7.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton7.MaximumSize = new System.Drawing.Size(217, 36);
            this.materialButton7.MinimumSize = new System.Drawing.Size(217, 36);
            this.materialButton7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton7.Name = "materialButton7";
            this.materialButton7.Size = new System.Drawing.Size(217, 36);
            this.materialButton7.TabIndex = 18;
            this.materialButton7.Text = "Autoclick golden";
            this.materialButton7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.materialButton7.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton7.UseAccentColor = false;
            this.materialButton7.UseVisualStyleBackColor = true;
            this.materialButton7.Click += new System.EventHandler(this.materialButton7_Click);
            // 
            // materialButton8
            // 
            this.materialButton8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton8.Depth = 0;
            this.materialButton8.DrawShadows = true;
            this.materialButton8.HighEmphasis = true;
            this.materialButton8.Icon = global::WindowsFormsApp2.Properties.Resources.Golden_cookie2;
            this.materialButton8.Location = new System.Drawing.Point(251, 593);
            this.materialButton8.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton8.MaximumSize = new System.Drawing.Size(217, 36);
            this.materialButton8.MinimumSize = new System.Drawing.Size(217, 36);
            this.materialButton8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton8.Name = "materialButton8";
            this.materialButton8.Size = new System.Drawing.Size(217, 36);
            this.materialButton8.TabIndex = 19;
            this.materialButton8.Text = "Cancel auto golden";
            this.materialButton8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.materialButton8.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton8.UseAccentColor = false;
            this.materialButton8.UseVisualStyleBackColor = true;
            this.materialButton8.Click += new System.EventHandler(this.materialButton8_Click);
            // 
            // materialButton9
            // 
            this.materialButton9.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton9.Depth = 0;
            this.materialButton9.DrawShadows = true;
            this.materialButton9.HighEmphasis = true;
            this.materialButton9.Icon = global::WindowsFormsApp2.Properties.Resources.Raindeer;
            this.materialButton9.Location = new System.Drawing.Point(5, 641);
            this.materialButton9.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton9.MaximumSize = new System.Drawing.Size(217, 36);
            this.materialButton9.MinimumSize = new System.Drawing.Size(217, 36);
            this.materialButton9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton9.Name = "materialButton9";
            this.materialButton9.Size = new System.Drawing.Size(217, 36);
            this.materialButton9.TabIndex = 20;
            this.materialButton9.Text = "Autoclick Deer";
            this.materialButton9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.materialButton9.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton9.UseAccentColor = false;
            this.materialButton9.UseVisualStyleBackColor = true;
            this.materialButton9.Click += new System.EventHandler(this.materialButton9_Click);
            // 
            // materialButton10
            // 
            this.materialButton10.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton10.Depth = 0;
            this.materialButton10.DrawShadows = true;
            this.materialButton10.HighEmphasis = true;
            this.materialButton10.Icon = global::WindowsFormsApp2.Properties.Resources.Raindeer;
            this.materialButton10.Location = new System.Drawing.Point(252, 641);
            this.materialButton10.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton10.MaximumSize = new System.Drawing.Size(217, 36);
            this.materialButton10.MinimumSize = new System.Drawing.Size(217, 36);
            this.materialButton10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton10.Name = "materialButton10";
            this.materialButton10.Size = new System.Drawing.Size(217, 36);
            this.materialButton10.TabIndex = 21;
            this.materialButton10.Text = "cancel auto Deer";
            this.materialButton10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.materialButton10.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton10.UseAccentColor = false;
            this.materialButton10.UseVisualStyleBackColor = true;
            this.materialButton10.Click += new System.EventHandler(this.materialButton10_Click);
            // 
            // materialButton11
            // 
            this.materialButton11.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton11.Depth = 0;
            this.materialButton11.DrawShadows = true;
            this.materialButton11.HighEmphasis = true;
            this.materialButton11.Icon = global::WindowsFormsApp2.Properties.Resources.PerfectCookie__1_;
            this.materialButton11.Location = new System.Drawing.Point(13, 763);
            this.materialButton11.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton11.MaximumSize = new System.Drawing.Size(199, 36);
            this.materialButton11.MinimumSize = new System.Drawing.Size(199, 36);
            this.materialButton11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton11.Name = "materialButton11";
            this.materialButton11.Size = new System.Drawing.Size(199, 36);
            this.materialButton11.TabIndex = 22;
            this.materialButton11.Text = "Unlock Everything";
            this.materialButton11.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton11.UseAccentColor = false;
            this.materialButton11.UseVisualStyleBackColor = true;
            this.materialButton11.Click += new System.EventHandler(this.materialButton11_Click);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator1.BackgroundImage")));
            this.bunifuSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator1.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.Silver;
            this.bunifuSeparator1.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(3, 370);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator1.Size = new System.Drawing.Size(465, 11);
            this.bunifuSeparator1.TabIndex = 23;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(186, 700);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(92, 19);
            this.materialLabel5.TabIndex = 24;
            this.materialLabel5.Text = "Danger Zone";
            // 
            // materialButton12
            // 
            this.materialButton12.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton12.Depth = 0;
            this.materialButton12.DrawShadows = true;
            this.materialButton12.HighEmphasis = true;
            this.materialButton12.Icon = global::WindowsFormsApp2.Properties.Resources.broken;
            this.materialButton12.Location = new System.Drawing.Point(251, 763);
            this.materialButton12.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton12.MaximumSize = new System.Drawing.Size(199, 36);
            this.materialButton12.MinimumSize = new System.Drawing.Size(199, 36);
            this.materialButton12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton12.Name = "materialButton12";
            this.materialButton12.Size = new System.Drawing.Size(199, 36);
            this.materialButton12.TabIndex = 25;
            this.materialButton12.Text = "Wipe Save Data";
            this.materialButton12.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton12.UseAccentColor = false;
            this.materialButton12.UseVisualStyleBackColor = true;
            this.materialButton12.Click += new System.EventHandler(this.materialButton12_Click);
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator2.BackgroundImage")));
            this.bunifuSeparator2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator2.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.Silver;
            this.bunifuSeparator2.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(5, 686);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator2.Size = new System.Drawing.Size(465, 11);
            this.bunifuSeparator2.TabIndex = 26;
            // 
            // bunifuSeparator3
            // 
            this.bunifuSeparator3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator3.BackgroundImage")));
            this.bunifuSeparator3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator3.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator3.LineColor = System.Drawing.Color.Silver;
            this.bunifuSeparator3.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.bunifuSeparator3.LineThickness = 1;
            this.bunifuSeparator3.Location = new System.Drawing.Point(5, 78);
            this.bunifuSeparator3.Name = "bunifuSeparator3";
            this.bunifuSeparator3.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator3.Size = new System.Drawing.Size(465, 11);
            this.bunifuSeparator3.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1459, 814);
            this.Controls.Add(this.bunifuSeparator3);
            this.Controls.Add(this.bunifuSeparator2);
            this.Controls.Add(this.materialButton12);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.materialButton11);
            this.Controls.Add(this.materialButton10);
            this.Controls.Add(this.materialButton9);
            this.Controls.Add(this.materialButton8);
            this.Controls.Add(this.materialButton7);
            this.Controls.Add(this.materialButton6);
            this.Controls.Add(this.materialButton5);
            this.Controls.Add(this.materialButton4);
            this.Controls.Add(this.materialButton2);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Execute);
            this.Controls.Add(this.chromiumWebBrowser1);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialTextBox2);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialButton3);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.materialTextBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Cookie Clicker Cheat";
            this.Currency.ResumeLayout(false);
            this.Stacked.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox materialTextBox1;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialContextMenuStrip Currency;
        private System.Windows.Forms.ToolStripMenuItem cookiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lumpsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem heavenlyChipsToolStripMenuItem;
        private MaterialSkin.Controls.MaterialContextMenuStrip Stacked;
        private System.Windows.Forms.ToolStripMenuItem noneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qdToolStripMenuItem;
        private MaterialSkin.Controls.MaterialButton materialButton3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private CefSharp.WinForms.ChromiumWebBrowser chromiumWebBrowser1;
        private MaterialSkin.Controls.MaterialButton Execute;
        private MaterialSkin.Controls.MaterialLabel Save;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialButton materialButton4;
        private MaterialSkin.Controls.MaterialButton materialButton5;
        private MaterialSkin.Controls.MaterialButton materialButton6;
        private MaterialSkin.Controls.MaterialButton materialButton7;
        private MaterialSkin.Controls.MaterialButton materialButton8;
        private MaterialSkin.Controls.MaterialButton materialButton9;
        private MaterialSkin.Controls.MaterialButton materialButton10;
        private MaterialSkin.Controls.MaterialButton materialButton11;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialButton materialButton12;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator2;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator3;
    }
}

