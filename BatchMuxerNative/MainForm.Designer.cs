namespace BatchMuxerNative
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
            this.txtFolderPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnMux = new System.Windows.Forms.Button();
            this.btnCleanUp = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFolderPath
            // 
            this.txtFolderPath.Location = new System.Drawing.Point(74, 13);
            this.txtFolderPath.Name = "txtFolderPath";
            this.txtFolderPath.Size = new System.Drawing.Size(287, 20);
            this.txtFolderPath.TabIndex = 0;
            this.txtFolderPath.TextChanged += new System.EventHandler(this.txtFolderPath_TextChanged);
            this.txtFolderPath.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtFolderPath_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Path:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::BatchMuxerNative.Properties.Resources.settings;
            this.button1.Location = new System.Drawing.Point(12, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 38);
            this.button1.TabIndex = 2;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMux
            // 
            this.btnMux.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMux.Font = new System.Drawing.Font("Mistral", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMux.Location = new System.Drawing.Point(195, 72);
            this.btnMux.Name = "btnMux";
            this.btnMux.Size = new System.Drawing.Size(66, 31);
            this.btnMux.TabIndex = 3;
            this.btnMux.Text = "MUX";
            this.btnMux.UseVisualStyleBackColor = true;
            this.btnMux.Click += new System.EventHandler(this.btnMux_Click);
            // 
            // btnCleanUp
            // 
            this.btnCleanUp.AutoSize = true;
            this.btnCleanUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCleanUp.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCleanUp.Location = new System.Drawing.Point(189, 110);
            this.btnCleanUp.Name = "btnCleanUp";
            this.btnCleanUp.Size = new System.Drawing.Size(80, 32);
            this.btnCleanUp.TabIndex = 4;
            this.btnCleanUp.Text = "Clean up";
            this.btnCleanUp.UseVisualStyleBackColor = true;
            this.btnCleanUp.Click += new System.EventHandler(this.btnCleanUp_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(74, 40);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(317, 23);
            this.progressBar1.TabIndex = 5;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(362, 12);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(30, 23);
            this.btnBrowse.TabIndex = 6;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 153);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnCleanUp);
            this.Controls.Add(this.btnMux);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFolderPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(419, 192);
            this.MinimumSize = new System.Drawing.Size(419, 147);
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Batch Muxer(Subtitle)";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFolderPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnMux;
        private System.Windows.Forms.Button btnCleanUp;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnBrowse;

    }
}

