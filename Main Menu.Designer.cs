namespace Ruzzle
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.Logo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.QuitButton = new System.Windows.Forms.Button();
            this.TimeAttackBTN = new System.Windows.Forms.Button();
            this.TenMovesBTN = new System.Windows.Forms.Button();
            this.LeaderBoardBTN = new System.Windows.Forms.Button();
            this.BackToMenuBTN = new System.Windows.Forms.Button();
            this.PointsLBL = new System.Windows.Forms.Label();
            this.TimeLBL = new System.Windows.Forms.Label();
            this.ConfirmBTN = new System.Windows.Forms.Button();
            this.WordListLBL = new System.Windows.Forms.Label();
            this.Points2LBL = new System.Windows.Forms.Label();
            this.InfoLBL = new System.Windows.Forms.Label();
            this.InsertName = new System.Windows.Forms.TextBox();
            this.InsertNameBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Logo
            // 
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(233, 12);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(236, 91);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.QuitButton);
            this.panel1.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(-3, 349);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(693, 59);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(15, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Matteo Paoli, 2017";
            // 
            // QuitButton
            // 
            this.QuitButton.BackColor = System.Drawing.Color.Red;
            this.QuitButton.FlatAppearance.BorderSize = 0;
            this.QuitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QuitButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuitButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.QuitButton.Location = new System.Drawing.Point(584, 6);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(92, 41);
            this.QuitButton.TabIndex = 7;
            this.QuitButton.Text = "Esci";
            this.QuitButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.QuitButton.UseVisualStyleBackColor = false;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // TimeAttackBTN
            // 
            this.TimeAttackBTN.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.TimeAttackBTN.FlatAppearance.BorderSize = 0;
            this.TimeAttackBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TimeAttackBTN.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeAttackBTN.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TimeAttackBTN.Location = new System.Drawing.Point(256, 124);
            this.TimeAttackBTN.Name = "TimeAttackBTN";
            this.TimeAttackBTN.Size = new System.Drawing.Size(173, 50);
            this.TimeAttackBTN.TabIndex = 5;
            this.TimeAttackBTN.Text = "Time Attack";
            this.TimeAttackBTN.UseVisualStyleBackColor = false;
            this.TimeAttackBTN.Click += new System.EventHandler(this.button1_Click);
            // 
            // TenMovesBTN
            // 
            this.TenMovesBTN.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.TenMovesBTN.FlatAppearance.BorderSize = 0;
            this.TenMovesBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TenMovesBTN.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenMovesBTN.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TenMovesBTN.Location = new System.Drawing.Point(256, 200);
            this.TenMovesBTN.Name = "TenMovesBTN";
            this.TenMovesBTN.Size = new System.Drawing.Size(173, 50);
            this.TenMovesBTN.TabIndex = 7;
            this.TenMovesBTN.Text = "10 Mosse";
            this.TenMovesBTN.UseVisualStyleBackColor = false;
            // 
            // LeaderBoardBTN
            // 
            this.LeaderBoardBTN.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.LeaderBoardBTN.FlatAppearance.BorderSize = 0;
            this.LeaderBoardBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LeaderBoardBTN.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeaderBoardBTN.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LeaderBoardBTN.Location = new System.Drawing.Point(256, 273);
            this.LeaderBoardBTN.Name = "LeaderBoardBTN";
            this.LeaderBoardBTN.Size = new System.Drawing.Size(173, 50);
            this.LeaderBoardBTN.TabIndex = 8;
            this.LeaderBoardBTN.Text = "Classifiche";
            this.LeaderBoardBTN.UseVisualStyleBackColor = false;
            this.LeaderBoardBTN.Click += new System.EventHandler(this.LeaderBoardBTN_Click);
            // 
            // BackToMenuBTN
            // 
            this.BackToMenuBTN.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackToMenuBTN.FlatAppearance.BorderSize = 0;
            this.BackToMenuBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackToMenuBTN.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackToMenuBTN.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackToMenuBTN.Location = new System.Drawing.Point(15, 259);
            this.BackToMenuBTN.Name = "BackToMenuBTN";
            this.BackToMenuBTN.Size = new System.Drawing.Size(173, 79);
            this.BackToMenuBTN.TabIndex = 9;
            this.BackToMenuBTN.Text = "Torna al menu";
            this.BackToMenuBTN.UseVisualStyleBackColor = false;
            this.BackToMenuBTN.Visible = false;
            this.BackToMenuBTN.Click += new System.EventHandler(this.BackToMenuBTN_Click);
            // 
            // PointsLBL
            // 
            this.PointsLBL.AutoSize = true;
            this.PointsLBL.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PointsLBL.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.PointsLBL.Location = new System.Drawing.Point(434, 49);
            this.PointsLBL.Name = "PointsLBL";
            this.PointsLBL.Size = new System.Drawing.Size(150, 34);
            this.PointsLBL.TabIndex = 10;
            this.PointsLBL.Text = "Punteggio:";
            // 
            // TimeLBL
            // 
            this.TimeLBL.AutoSize = true;
            this.TimeLBL.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLBL.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TimeLBL.Location = new System.Drawing.Point(499, 124);
            this.TimeLBL.Name = "TimeLBL";
            this.TimeLBL.Size = new System.Drawing.Size(49, 34);
            this.TimeLBL.TabIndex = 11;
            this.TimeLBL.Text = "60";
            // 
            // ConfirmBTN
            // 
            this.ConfirmBTN.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ConfirmBTN.FlatAppearance.BorderSize = 0;
            this.ConfirmBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConfirmBTN.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmBTN.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ConfirmBTN.Location = new System.Drawing.Point(440, 200);
            this.ConfirmBTN.Name = "ConfirmBTN";
            this.ConfirmBTN.Size = new System.Drawing.Size(173, 79);
            this.ConfirmBTN.TabIndex = 12;
            this.ConfirmBTN.Text = "Conferma!";
            this.ConfirmBTN.UseVisualStyleBackColor = false;
            this.ConfirmBTN.Click += new System.EventHandler(this.ConfirmBTN_Click);
            // 
            // WordListLBL
            // 
            this.WordListLBL.AutoSize = true;
            this.WordListLBL.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WordListLBL.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.WordListLBL.Location = new System.Drawing.Point(212, 55);
            this.WordListLBL.Name = "WordListLBL";
            this.WordListLBL.Size = new System.Drawing.Size(0, 26);
            this.WordListLBL.TabIndex = 13;
            // 
            // Points2LBL
            // 
            this.Points2LBL.AutoSize = true;
            this.Points2LBL.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Points2LBL.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Points2LBL.Location = new System.Drawing.Point(622, 49);
            this.Points2LBL.Name = "Points2LBL";
            this.Points2LBL.Size = new System.Drawing.Size(32, 34);
            this.Points2LBL.TabIndex = 14;
            this.Points2LBL.Text = "0";
            // 
            // InfoLBL
            // 
            this.InfoLBL.AutoSize = true;
            this.InfoLBL.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoLBL.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.InfoLBL.Location = new System.Drawing.Point(177, 124);
            this.InfoLBL.Name = "InfoLBL";
            this.InfoLBL.Size = new System.Drawing.Size(0, 24);
            this.InfoLBL.TabIndex = 15;
            // 
            // InsertName
            // 
            this.InsertName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InsertName.Location = new System.Drawing.Point(276, 174);
            this.InsertName.Name = "InsertName";
            this.InsertName.Size = new System.Drawing.Size(119, 20);
            this.InsertName.TabIndex = 16;
            // 
            // InsertNameBTN
            // 
            this.InsertNameBTN.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.InsertNameBTN.FlatAppearance.BorderSize = 0;
            this.InsertNameBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InsertNameBTN.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertNameBTN.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.InsertNameBTN.Location = new System.Drawing.Point(256, 217);
            this.InsertNameBTN.Name = "InsertNameBTN";
            this.InsertNameBTN.Size = new System.Drawing.Size(173, 50);
            this.InsertNameBTN.TabIndex = 17;
            this.InsertNameBTN.Text = "Conferma!";
            this.InsertNameBTN.UseVisualStyleBackColor = false;
            this.InsertNameBTN.Visible = false;
            this.InsertNameBTN.Click += new System.EventHandler(this.InsertNameBTN_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(685, 405);
            this.Controls.Add(this.InsertNameBTN);
            this.Controls.Add(this.InsertName);
            this.Controls.Add(this.InfoLBL);
            this.Controls.Add(this.Points2LBL);
            this.Controls.Add(this.WordListLBL);
            this.Controls.Add(this.ConfirmBTN);
            this.Controls.Add(this.TimeLBL);
            this.Controls.Add(this.PointsLBL);
            this.Controls.Add(this.BackToMenuBTN);
            this.Controls.Add(this.LeaderBoardBTN);
            this.Controls.Add(this.TenMovesBTN);
            this.Controls.Add(this.TimeAttackBTN);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Logo);
            this.Name = "Menu";
            this.Text = "Ruzzle";
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button QuitButton;
        private System.Windows.Forms.Button TimeAttackBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button TenMovesBTN;
        private System.Windows.Forms.Button LeaderBoardBTN;
        private System.Windows.Forms.Button BackToMenuBTN;
        private System.Windows.Forms.Label PointsLBL;
        private System.Windows.Forms.Label TimeLBL;
        private System.Windows.Forms.Button ConfirmBTN;
        private System.Windows.Forms.Label WordListLBL;
        private System.Windows.Forms.Label Points2LBL;
        private System.Windows.Forms.Label InfoLBL;
        private System.Windows.Forms.TextBox InsertName;
        private System.Windows.Forms.Button InsertNameBTN;
    }
}