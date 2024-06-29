namespace Pwned
{
    partial class PwnedApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PwnedApp));
            this.passInput = new System.Windows.Forms.TextBox();
            this.passVistoggle = new System.Windows.Forms.Button();
            this.passGen = new System.Windows.Forms.TextBox();
            this.passGenS = new System.Windows.Forms.Button();
            this.passGenlength = new System.Windows.Forms.TrackBar();
            this.passGencomplex = new System.Windows.Forms.TrackBar();
            this.passStyleholder = new System.Windows.Forms.GroupBox();
            this.passStylePhrase = new System.Windows.Forms.RadioButton();
            this.passStyleRan = new System.Windows.Forms.RadioButton();
            this.checkPwn = new System.Windows.Forms.Button();
            this.statusHolder = new System.Windows.Forms.GroupBox();
            this.statusSecure = new System.Windows.Forms.TextBox();
            this.statusPwned = new System.Windows.Forms.TextBox();
            this.statusLab = new System.Windows.Forms.Label();
            this.statusPoint = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.passGenlength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passGencomplex)).BeginInit();
            this.passStyleholder.SuspendLayout();
            this.statusHolder.SuspendLayout();
            this.SuspendLayout();
            // 
            // passInput
            // 
            this.passInput.BackColor = System.Drawing.SystemColors.Control;
            this.passInput.Cursor = System.Windows.Forms.Cursors.Hand;
            this.passInput.HideSelection = false;
            this.passInput.Location = new System.Drawing.Point(12, 12);
            this.passInput.Name = "passInput";
            this.passInput.PasswordChar = '*';
            this.passInput.Size = new System.Drawing.Size(336, 20);
            this.passInput.TabIndex = 0;
            this.passInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // passVistoggle
            // 
            this.passVistoggle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.passVistoggle.Font = new System.Drawing.Font("Wingdings 2", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.passVistoggle.Location = new System.Drawing.Point(354, 10);
            this.passVistoggle.Name = "passVistoggle";
            this.passVistoggle.Size = new System.Drawing.Size(23, 23);
            this.passVistoggle.TabIndex = 1;
            this.passVistoggle.Text = "Ù";
            this.passVistoggle.UseVisualStyleBackColor = true;
            this.passVistoggle.Click += new System.EventHandler(this.button1_Click);
            // 
            // passGen
            // 
            this.passGen.Cursor = System.Windows.Forms.Cursors.Cross;
            this.passGen.Location = new System.Drawing.Point(12, 39);
            this.passGen.Name = "passGen";
            this.passGen.ReadOnly = true;
            this.passGen.Size = new System.Drawing.Size(335, 20);
            this.passGen.TabIndex = 2;
            this.passGen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // passGenS
            // 
            this.passGenS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.passGenS.Font = new System.Drawing.Font("Wingdings 2", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.passGenS.Location = new System.Drawing.Point(354, 39);
            this.passGenS.Name = "passGenS";
            this.passGenS.Size = new System.Drawing.Size(23, 23);
            this.passGenS.TabIndex = 3;
            this.passGenS.Text = "<";
            this.passGenS.UseVisualStyleBackColor = true;
            this.passGenS.Click += new System.EventHandler(this.passGenS_Click);
            // 
            // passGenlength
            // 
            this.passGenlength.Cursor = System.Windows.Forms.Cursors.NoMoveHoriz;
            this.passGenlength.Location = new System.Drawing.Point(46, 65);
            this.passGenlength.Maximum = 35;
            this.passGenlength.Minimum = 8;
            this.passGenlength.Name = "passGenlength";
            this.passGenlength.Size = new System.Drawing.Size(102, 45);
            this.passGenlength.TabIndex = 1;
            this.passGenlength.TickStyle = System.Windows.Forms.TickStyle.None;
            this.passGenlength.Value = 8;
            // 
            // passGencomplex
            // 
            this.passGencomplex.Cursor = System.Windows.Forms.Cursors.NoMoveHoriz;
            this.passGencomplex.Location = new System.Drawing.Point(154, 65);
            this.passGencomplex.Maximum = 4;
            this.passGencomplex.Minimum = 1;
            this.passGencomplex.Name = "passGencomplex";
            this.passGencomplex.Size = new System.Drawing.Size(102, 45);
            this.passGencomplex.TabIndex = 4;
            this.passGencomplex.Value = 1;
            // 
            // passStyleholder
            // 
            this.passStyleholder.Controls.Add(this.passStylePhrase);
            this.passStyleholder.Controls.Add(this.passStyleRan);
            this.passStyleholder.Location = new System.Drawing.Point(262, 65);
            this.passStyleholder.Name = "passStyleholder";
            this.passStyleholder.Size = new System.Drawing.Size(74, 45);
            this.passStyleholder.TabIndex = 5;
            this.passStyleholder.TabStop = false;
            this.passStyleholder.Text = "passStyle";
            // 
            // passStylePhrase
            // 
            this.passStylePhrase.AutoSize = true;
            this.passStylePhrase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.passStylePhrase.Location = new System.Drawing.Point(45, 19);
            this.passStylePhrase.Name = "passStylePhrase";
            this.passStylePhrase.Size = new System.Drawing.Size(14, 13);
            this.passStylePhrase.TabIndex = 1;
            this.passStylePhrase.UseVisualStyleBackColor = true;
            this.passStylePhrase.CheckedChanged += new System.EventHandler(this.passStylePhrase_CheckedChanged);
            // 
            // passStyleRan
            // 
            this.passStyleRan.AutoSize = true;
            this.passStyleRan.Checked = true;
            this.passStyleRan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.passStyleRan.Location = new System.Drawing.Point(12, 19);
            this.passStyleRan.Name = "passStyleRan";
            this.passStyleRan.Size = new System.Drawing.Size(14, 13);
            this.passStyleRan.TabIndex = 0;
            this.passStyleRan.TabStop = true;
            this.passStyleRan.UseVisualStyleBackColor = true;
            this.passStyleRan.CheckedChanged += new System.EventHandler(this.passStyleRan_CheckedChanged);
            // 
            // checkPwn
            // 
            this.checkPwn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkPwn.Location = new System.Drawing.Point(108, 116);
            this.checkPwn.Name = "checkPwn";
            this.checkPwn.Size = new System.Drawing.Size(101, 23);
            this.checkPwn.TabIndex = 6;
            this.checkPwn.Text = "Am I \'Pwned";
            this.checkPwn.UseVisualStyleBackColor = true;
            this.checkPwn.Click += new System.EventHandler(this.checkPwn_Click);
            // 
            // statusHolder
            // 
            this.statusHolder.Controls.Add(this.statusSecure);
            this.statusHolder.Controls.Add(this.statusPwned);
            this.statusHolder.Location = new System.Drawing.Point(343, 69);
            this.statusHolder.Name = "statusHolder";
            this.statusHolder.Size = new System.Drawing.Size(57, 89);
            this.statusHolder.TabIndex = 7;
            this.statusHolder.TabStop = false;
            this.statusHolder.Text = "Status";
            // 
            // statusSecure
            // 
            this.statusSecure.BackColor = System.Drawing.Color.Beige;
            this.statusSecure.Enabled = false;
            this.statusSecure.Font = new System.Drawing.Font("Wingdings", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.statusSecure.Location = new System.Drawing.Point(17, 52);
            this.statusSecure.Name = "statusSecure";
            this.statusSecure.Size = new System.Drawing.Size(23, 25);
            this.statusSecure.TabIndex = 1;
            this.statusSecure.Text = "¹";
            this.statusSecure.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // statusPwned
            // 
            this.statusPwned.BackColor = System.Drawing.Color.Beige;
            this.statusPwned.Enabled = false;
            this.statusPwned.Font = new System.Drawing.Font("Wingdings", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.statusPwned.Location = new System.Drawing.Point(17, 15);
            this.statusPwned.Name = "statusPwned";
            this.statusPwned.Size = new System.Drawing.Size(23, 25);
            this.statusPwned.TabIndex = 0;
            this.statusPwned.Text = "¹";
            this.statusPwned.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // statusLab
            // 
            this.statusLab.AutoSize = true;
            this.statusLab.Location = new System.Drawing.Point(259, 113);
            this.statusLab.Name = "statusLab";
            this.statusLab.Size = new System.Drawing.Size(50, 39);
            this.statusLab.TabIndex = 8;
            this.statusLab.Text = "\'Pwned\r\n\r\nSecure?\r\n";
            // 
            // statusPoint
            // 
            this.statusPoint.AutoSize = true;
            this.statusPoint.Font = new System.Drawing.Font("Wingdings", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.statusPoint.Location = new System.Drawing.Point(315, 116);
            this.statusPoint.Name = "statusPoint";
            this.statusPoint.Size = new System.Drawing.Size(17, 36);
            this.statusPoint.TabIndex = 9;
            this.statusPoint.Text = "è\r\n\r\nè\r\n";
            // 
            // PwnedApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(404, 163);
            this.Controls.Add(this.statusPoint);
            this.Controls.Add(this.statusLab);
            this.Controls.Add(this.statusHolder);
            this.Controls.Add(this.checkPwn);
            this.Controls.Add(this.passStyleholder);
            this.Controls.Add(this.passGencomplex);
            this.Controls.Add(this.passGenlength);
            this.Controls.Add(this.passGenS);
            this.Controls.Add(this.passGen);
            this.Controls.Add(this.passVistoggle);
            this.Controls.Add(this.passInput);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "PwnedApp";
            this.Text = "Pwned";
            this.Load += new System.EventHandler(this.PwnedApp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.passGenlength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passGencomplex)).EndInit();
            this.passStyleholder.ResumeLayout(false);
            this.passStyleholder.PerformLayout();
            this.statusHolder.ResumeLayout(false);
            this.statusHolder.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox passInput;
        private System.Windows.Forms.Button passVistoggle;
        private System.Windows.Forms.TextBox passGen;
        private System.Windows.Forms.Button passGenS;
        private System.Windows.Forms.TrackBar passGenlength;
        private System.Windows.Forms.TrackBar passGencomplex;
        private System.Windows.Forms.GroupBox passStyleholder;
        private System.Windows.Forms.RadioButton passStyleRan;
        private System.Windows.Forms.RadioButton passStylePhrase;
        private System.Windows.Forms.Button checkPwn;
        private System.Windows.Forms.GroupBox statusHolder;
        private System.Windows.Forms.Label statusLab;
        private System.Windows.Forms.Label statusPoint;
        private System.Windows.Forms.TextBox statusPwned;
        private System.Windows.Forms.TextBox statusSecure;
    }
}

