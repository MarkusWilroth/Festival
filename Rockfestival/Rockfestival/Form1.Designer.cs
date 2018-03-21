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
            this.bt_band = new System.Windows.Forms.Button();
            this.lbx_band = new System.Windows.Forms.ListBox();
            this.bt_medlem = new System.Windows.Forms.Button();
            this.lbx_medlem = new System.Windows.Forms.ListBox();
            this.bt_ltb = new System.Windows.Forms.Button();
            this.tbx_ltb = new System.Windows.Forms.TextBox();
            this.lb_ltb = new System.Windows.Forms.Label();
            this.bt_Next = new System.Windows.Forms.Button();
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
            this.lbx_info.Size = new System.Drawing.Size(146, 108);
            this.lbx_info.TabIndex = 1;
            // 
            // tbx_cmd
            // 
            this.tbx_cmd.Location = new System.Drawing.Point(13, 482);
            this.tbx_cmd.Name = "tbx_cmd";
            this.tbx_cmd.Size = new System.Drawing.Size(350, 20);
            this.tbx_cmd.TabIndex = 2;
            this.tbx_cmd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx_cmd.TextChanged += new System.EventHandler(this.tbx_cmd_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.2F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(13, 442);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Write Command HERE!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bt_band
            // 
            this.bt_band.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bt_band.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.bt_band.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_band.Location = new System.Drawing.Point(13, 124);
            this.bt_band.Name = "bt_band";
            this.bt_band.Size = new System.Drawing.Size(194, 80);
            this.bt_band.TabIndex = 4;
            this.bt_band.Text = "Bandet";
            this.bt_band.UseVisualStyleBackColor = false;
            this.bt_band.Click += new System.EventHandler(this.bt_band_Click);
            // 
            // lbx_band
            // 
            this.lbx_band.FormattingEnabled = true;
            this.lbx_band.Location = new System.Drawing.Point(214, 127);
            this.lbx_band.Name = "lbx_band";
            this.lbx_band.Size = new System.Drawing.Size(145, 82);
            this.lbx_band.TabIndex = 5;
            // 
            // bt_medlem
            // 
            this.bt_medlem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bt_medlem.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.bt_medlem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_medlem.Location = new System.Drawing.Point(13, 211);
            this.bt_medlem.Name = "bt_medlem";
            this.bt_medlem.Size = new System.Drawing.Size(194, 72);
            this.bt_medlem.TabIndex = 6;
            this.bt_medlem.Text = "Medlem";
            this.bt_medlem.UseVisualStyleBackColor = false;
            this.bt_medlem.Click += new System.EventHandler(this.bt_medlem_Click);
            // 
            // lbx_medlem
            // 
            this.lbx_medlem.FormattingEnabled = true;
            this.lbx_medlem.Location = new System.Drawing.Point(214, 216);
            this.lbx_medlem.Name = "lbx_medlem";
            this.lbx_medlem.Size = new System.Drawing.Size(145, 69);
            this.lbx_medlem.TabIndex = 7;
            // 
            // bt_ltb
            // 
            this.bt_ltb.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bt_ltb.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.bt_ltb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_ltb.Location = new System.Drawing.Point(377, 13);
            this.bt_ltb.Name = "bt_ltb";
            this.bt_ltb.Size = new System.Drawing.Size(148, 104);
            this.bt_ltb.TabIndex = 8;
            this.bt_ltb.Text = "Lägg till Band";
            this.bt_ltb.UseVisualStyleBackColor = false;
            this.bt_ltb.Click += new System.EventHandler(this.bt_ltb_Click);
            // 
            // tbx_ltb
            // 
            this.tbx_ltb.Location = new System.Drawing.Point(531, 41);
            this.tbx_ltb.Name = "tbx_ltb";
            this.tbx_ltb.Size = new System.Drawing.Size(215, 20);
            this.tbx_ltb.TabIndex = 9;
            // 
            // lb_ltb
            // 
            this.lb_ltb.AutoSize = true;
            this.lb_ltb.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lb_ltb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lb_ltb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_ltb.Location = new System.Drawing.Point(547, 13);
            this.lb_ltb.Name = "lb_ltb";
            this.lb_ltb.Size = new System.Drawing.Size(176, 25);
            this.lb_ltb.TabIndex = 10;
            this.lb_ltb.Text = "Skriv in Bandnamn";
            // 
            // bt_Next
            // 
            this.bt_Next.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bt_Next.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.bt_Next.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_Next.Location = new System.Drawing.Point(752, 12);
            this.bt_Next.Name = "bt_Next";
            this.bt_Next.Size = new System.Drawing.Size(104, 49);
            this.bt_Next.TabIndex = 11;
            this.bt_Next.Text = "Nästa";
            this.bt_Next.UseVisualStyleBackColor = false;
            this.bt_Next.Click += new System.EventHandler(this.bt_Next_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 604);
            this.Controls.Add(this.bt_Next);
            this.Controls.Add(this.lb_ltb);
            this.Controls.Add(this.tbx_ltb);
            this.Controls.Add(this.bt_ltb);
            this.Controls.Add(this.lbx_medlem);
            this.Controls.Add(this.bt_medlem);
            this.Controls.Add(this.lbx_band);
            this.Controls.Add(this.bt_band);
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
        private System.Windows.Forms.Button bt_band;
        private System.Windows.Forms.ListBox lbx_band;
        private System.Windows.Forms.Button bt_medlem;
        private System.Windows.Forms.ListBox lbx_medlem;
        private System.Windows.Forms.Button bt_ltb;
        private System.Windows.Forms.TextBox tbx_ltb;
        private System.Windows.Forms.Label lb_ltb;
        private System.Windows.Forms.Button bt_Next;
    }
}

