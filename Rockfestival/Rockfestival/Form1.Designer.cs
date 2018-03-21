namespace Rockfestival {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.bt_info = new System.Windows.Forms.Button();
            this.lbx_info = new System.Windows.Forms.ListBox();
            this.tbx_cmd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_info
            // 
            this.bt_info.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bt_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.bt_info.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_info.Location = new System.Drawing.Point(13, 13);
            this.bt_info.Name = "bt_info";
            this.bt_info.Size = new System.Drawing.Size(194, 104);
            this.bt_info.TabIndex = 0;
            this.bt_info.Text = "Info";
            this.bt_info.UseVisualStyleBackColor = false;
            this.bt_info.Click += new System.EventHandler(this.bt_info_Click);
            // 
            // lbx_info
            // 
            this.lbx_info.FormattingEnabled = true;
            this.lbx_info.Location = new System.Drawing.Point(213, 12);
            this.lbx_info.Name = "lbx_info";
            this.lbx_info.Size = new System.Drawing.Size(456, 108);
            this.lbx_info.TabIndex = 1;
            // 
            // tbx_cmd
            // 
            this.tbx_cmd.Location = new System.Drawing.Point(213, 564);
            this.tbx_cmd.Name = "tbx_cmd";
            this.tbx_cmd.Size = new System.Drawing.Size(583, 20);
            this.tbx_cmd.TabIndex = 2;
            this.tbx_cmd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(368, 528);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "Write Command HERE!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 596);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbx_cmd);
            this.Controls.Add(this.lbx_info);
            this.Controls.Add(this.bt_info);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_info;
        private System.Windows.Forms.ListBox lbx_info;
        private System.Windows.Forms.TextBox tbx_cmd;
        private System.Windows.Forms.Label label1;
    }
}

