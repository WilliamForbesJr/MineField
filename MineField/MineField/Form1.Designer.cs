namespace MineField
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_file_newGame = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_file_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_options_easy = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_options_medium = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_options_hard = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_about = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lblWins = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblWinPercent = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(495, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_file_newGame,
            this.menu_file_exit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // menu_file_newGame
            // 
            this.menu_file_newGame.Name = "menu_file_newGame";
            this.menu_file_newGame.Size = new System.Drawing.Size(152, 22);
            this.menu_file_newGame.Text = "&New Game";
            this.menu_file_newGame.Click += new System.EventHandler(this.menu_file_newGame_Click);
            // 
            // menu_file_exit
            // 
            this.menu_file_exit.Name = "menu_file_exit";
            this.menu_file_exit.Size = new System.Drawing.Size(152, 22);
            this.menu_file_exit.Text = "E&xit";
            this.menu_file_exit.Click += new System.EventHandler(this.menu_file_exit_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.CheckOnClick = true;
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_options_easy,
            this.menu_options_medium,
            this.menu_options_hard});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // menu_options_easy
            // 
            this.menu_options_easy.CheckOnClick = true;
            this.menu_options_easy.Name = "menu_options_easy";
            this.menu_options_easy.Size = new System.Drawing.Size(216, 22);
            this.menu_options_easy.Text = "Easy: 5 squares to win";
            this.menu_options_easy.Click += new System.EventHandler(this.menu_options_easy_Click);
            // 
            // menu_options_medium
            // 
            this.menu_options_medium.Checked = true;
            this.menu_options_medium.CheckOnClick = true;
            this.menu_options_medium.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menu_options_medium.DoubleClickEnabled = true;
            this.menu_options_medium.Name = "menu_options_medium";
            this.menu_options_medium.Size = new System.Drawing.Size(216, 22);
            this.menu_options_medium.Text = "Medium: 10 squares to win";
            this.menu_options_medium.Click += new System.EventHandler(this.menu_options_medium_Click);
            // 
            // menu_options_hard
            // 
            this.menu_options_hard.CheckOnClick = true;
            this.menu_options_hard.Name = "menu_options_hard";
            this.menu_options_hard.Size = new System.Drawing.Size(216, 22);
            this.menu_options_hard.Text = "Hard: 15 squares to win";
            this.menu_options_hard.Click += new System.EventHandler(this.menu_options_hard_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_about});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // menu_about
            // 
            this.menu_about.Name = "menu_about";
            this.menu_about.Size = new System.Drawing.Size(107, 22);
            this.menu_about.Text = "&About";
            this.menu_about.Click += new System.EventHandler(this.menu_about_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label7, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label8, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label9, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label10, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label12, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label13, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label14, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.label15, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.label16, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label17, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label18, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label19, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.label20, 4, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(25, 27);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(443, 347);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Blue;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(8, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 79);
            this.label1.TabIndex = 1;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.MineLabel_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Blue;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(94, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 79);
            this.label2.TabIndex = 2;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.MineLabel_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Blue;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(180, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 79);
            this.label3.TabIndex = 3;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.MineLabel_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Blue;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(266, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 79);
            this.label4.TabIndex = 4;
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.MineLabel_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Blue;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(352, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 79);
            this.label5.TabIndex = 5;
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.MineLabel_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Blue;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Location = new System.Drawing.Point(8, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 79);
            this.label6.TabIndex = 6;
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Click += new System.EventHandler(this.MineLabel_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Blue;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Location = new System.Drawing.Point(94, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 79);
            this.label7.TabIndex = 7;
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.Click += new System.EventHandler(this.MineLabel_Click);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Blue;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Location = new System.Drawing.Point(180, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 79);
            this.label8.TabIndex = 8;
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label8.Click += new System.EventHandler(this.MineLabel_Click);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Blue;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Location = new System.Drawing.Point(266, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 79);
            this.label9.TabIndex = 9;
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label9.Click += new System.EventHandler(this.MineLabel_Click);
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Blue;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Location = new System.Drawing.Point(352, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 79);
            this.label10.TabIndex = 10;
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label10.Click += new System.EventHandler(this.MineLabel_Click);
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Blue;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Location = new System.Drawing.Point(8, 173);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 79);
            this.label11.TabIndex = 11;
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label11.Click += new System.EventHandler(this.MineLabel_Click);
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Blue;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Location = new System.Drawing.Point(94, 173);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 79);
            this.label12.TabIndex = 12;
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label12.Click += new System.EventHandler(this.MineLabel_Click);
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Blue;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Location = new System.Drawing.Point(180, 173);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 79);
            this.label13.TabIndex = 13;
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label13.Click += new System.EventHandler(this.MineLabel_Click);
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.Blue;
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label14.Location = new System.Drawing.Point(266, 173);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 79);
            this.label14.TabIndex = 14;
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label14.Click += new System.EventHandler(this.MineLabel_Click);
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.Blue;
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label15.Location = new System.Drawing.Point(352, 173);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(79, 79);
            this.label15.TabIndex = 15;
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label15.Click += new System.EventHandler(this.MineLabel_Click);
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.Blue;
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label16.Location = new System.Drawing.Point(8, 257);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(79, 79);
            this.label16.TabIndex = 16;
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label16.Click += new System.EventHandler(this.MineLabel_Click);
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.Blue;
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label17.Location = new System.Drawing.Point(94, 257);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(79, 79);
            this.label17.TabIndex = 17;
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label17.Click += new System.EventHandler(this.MineLabel_Click);
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.Blue;
            this.label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label18.Location = new System.Drawing.Point(180, 257);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(79, 79);
            this.label18.TabIndex = 18;
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label18.Click += new System.EventHandler(this.MineLabel_Click);
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.Blue;
            this.label19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label19.Location = new System.Drawing.Point(266, 257);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(79, 79);
            this.label19.TabIndex = 19;
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label19.Click += new System.EventHandler(this.MineLabel_Click);
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.Color.Blue;
            this.label20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label20.Location = new System.Drawing.Point(352, 257);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(79, 79);
            this.label20.TabIndex = 20;
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label20.Click += new System.EventHandler(this.MineLabel_Click);
            // 
            // lblWins
            // 
            this.lblWins.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblWins.Location = new System.Drawing.Point(6, 13);
            this.lblWins.Name = "lblWins";
            this.lblWins.Size = new System.Drawing.Size(94, 23);
            this.lblWins.TabIndex = 2;
            this.lblWins.Text = "Wins: 0 out of 0";
            this.lblWins.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblWinPercent);
            this.groupBox1.Controls.Add(this.lblWins);
            this.groupBox1.Location = new System.Drawing.Point(12, 380);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.groupBox1.Size = new System.Drawing.Size(471, 45);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // lblWinPercent
            // 
            this.lblWinPercent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblWinPercent.Location = new System.Drawing.Point(112, 13);
            this.lblWinPercent.Name = "lblWinPercent";
            this.lblWinPercent.Size = new System.Drawing.Size(46, 23);
            this.lblWinPercent.TabIndex = 2;
            this.lblWinPercent.Text = "0%";
            this.lblWinPercent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 441);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "MineField";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_file_exit;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_options_easy;
        private System.Windows.Forms.ToolStripMenuItem menu_options_medium;
        private System.Windows.Forms.ToolStripMenuItem menu_options_hard;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_about;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lblWins;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblWinPercent;
        private System.Windows.Forms.ToolStripMenuItem menu_file_newGame;
    }
}

