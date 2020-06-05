namespace BatchMuxerNative
{
    partial class SettingsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMkvPath = new System.Windows.Forms.TextBox();
            this.cmbSubLanguage = new System.Windows.Forms.ComboBox();
            this.chkAC = new System.Windows.Forms.CheckBox();
            this.chkSC = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "MKV merge path : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Subtitle Language :";
            // 
            // txtMkvPath
            // 
            this.txtMkvPath.Location = new System.Drawing.Point(115, 13);
            this.txtMkvPath.Name = "txtMkvPath";
            this.txtMkvPath.Size = new System.Drawing.Size(262, 20);
            this.txtMkvPath.TabIndex = 2;
            this.txtMkvPath.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtMkvPath_MouseDoubleClick);
            // 
            // cmbSubLanguage
            // 
            this.cmbSubLanguage.DisplayMember = "Name";
            this.cmbSubLanguage.FormattingEnabled = true;
            this.cmbSubLanguage.Location = new System.Drawing.Point(119, 58);
            this.cmbSubLanguage.Name = "cmbSubLanguage";
            this.cmbSubLanguage.Size = new System.Drawing.Size(258, 21);
            this.cmbSubLanguage.TabIndex = 3;
            this.cmbSubLanguage.ValueMember = "Code";
            // 
            // chkAC
            // 
            this.chkAC.AutoSize = true;
            this.chkAC.Location = new System.Drawing.Point(115, 91);
            this.chkAC.Name = "chkAC";
            this.chkAC.Size = new System.Drawing.Size(78, 17);
            this.chkAC.TabIndex = 4;
            this.chkAC.Text = "Auto Clean";
            this.chkAC.UseVisualStyleBackColor = true;
            // 
            // chkSC
            // 
            this.chkSC.AutoSize = true;
            this.chkSC.Location = new System.Drawing.Point(237, 90);
            this.chkSC.Name = "chkSC";
            this.chkSC.Size = new System.Drawing.Size(131, 17);
            this.chkSC.TabIndex = 5;
            this.chkSC.Text = "Show CleanUp Button";
            this.chkSC.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(176, 118);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 147);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.chkSC);
            this.Controls.Add(this.chkAC);
            this.Controls.Add(this.cmbSubLanguage);
            this.Controls.Add(this.txtMkvPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(405, 186);
            this.MinimumSize = new System.Drawing.Size(405, 186);
            this.Name = "SettingsForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "SettingsForm";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMkvPath;
        private System.Windows.Forms.ComboBox cmbSubLanguage;
        private System.Windows.Forms.CheckBox chkAC;
        private System.Windows.Forms.CheckBox chkSC;
        private System.Windows.Forms.Button btnSave;
    }
}