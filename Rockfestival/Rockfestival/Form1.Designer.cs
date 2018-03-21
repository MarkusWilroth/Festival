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
            this.lbx_artist = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gb_person = new System.Windows.Forms.GroupBox();
            this.bt_person = new System.Windows.Forms.Button();
            this.bt_scen = new System.Windows.Forms.Button();
            this.lb_scen = new System.Windows.Forms.Label();
            this.bt_nextScen = new System.Windows.Forms.Button();
            this.tbx_scen = new System.Windows.Forms.TextBox();
            this.gb_person.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_info
            // 
            this.bt_info.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bt_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.bt_info.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_info.Location = new System.Drawing.Point(6, 10);
            this.bt_info.Name = "bt_info";
            this.bt_info.Size = new System.Drawing.Size(194, 82);
            this.bt_info.TabIndex = 0;
            this.bt_info.Text = "Info";
            this.bt_info.UseVisualStyleBackColor = false;
            this.bt_info.Click += new System.EventHandler(this.bt_info_Click);
            // 
            // lbx_info
            // 
            this.lbx_info.FormattingEnabled = true;
            this.lbx_info.Location = new System.Drawing.Point(206, 9);
            this.lbx_info.Name = "lbx_info";
            this.lbx_info.Size = new System.Drawing.Size(158, 82);
            this.lbx_info.TabIndex = 1;
            // 
            // tbx_cmd
            // 
            this.tbx_cmd.Location = new System.Drawing.Point(8, 449);
            this.tbx_cmd.Name = "tbx_cmd";
            this.tbx_cmd.Size = new System.Drawing.Size(340, 20);
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
            this.label1.Location = new System.Drawing.Point(8, 409);
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
            this.bt_band.Location = new System.Drawing.Point(5, 98);
            this.bt_band.Name = "bt_band";
            this.bt_band.Size = new System.Drawing.Size(359, 80);
            this.bt_band.TabIndex = 4;
            this.bt_band.Text = "Bandet";
            this.bt_band.UseVisualStyleBackColor = false;
            this.bt_band.Click += new System.EventHandler(this.bt_band_Click);
            // 
            // lbx_band
            // 
            this.lbx_band.FormattingEnabled = true;
            this.lbx_band.Location = new System.Drawing.Point(5, 209);
            this.lbx_band.Name = "lbx_band";
            this.lbx_band.Size = new System.Drawing.Size(176, 82);
            this.lbx_band.TabIndex = 5;
            // 
            // bt_medlem
            // 
            this.bt_medlem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bt_medlem.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.bt_medlem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_medlem.Location = new System.Drawing.Point(6, 297);
            this.bt_medlem.Name = "bt_medlem";
            this.bt_medlem.Size = new System.Drawing.Size(175, 72);
            this.bt_medlem.TabIndex = 6;
            this.bt_medlem.Text = "Medlem";
            this.bt_medlem.UseVisualStyleBackColor = false;
            this.bt_medlem.Click += new System.EventHandler(this.bt_medlem_Click);
            // 
            // lbx_medlem
            // 
            this.lbx_medlem.FormattingEnabled = true;
            this.lbx_medlem.Location = new System.Drawing.Point(190, 300);
            this.lbx_medlem.Name = "lbx_medlem";
            this.lbx_medlem.Size = new System.Drawing.Size(174, 69);
            this.lbx_medlem.TabIndex = 7;
            // 
            // bt_ltb
            // 
            this.bt_ltb.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bt_ltb.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.bt_ltb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_ltb.Location = new System.Drawing.Point(407, 21);
            this.bt_ltb.Name = "bt_ltb";
            this.bt_ltb.Size = new System.Drawing.Size(148, 104);
            this.bt_ltb.TabIndex = 8;
            this.bt_ltb.Text = "Lägg till Band";
            this.bt_ltb.UseVisualStyleBackColor = false;
            this.bt_ltb.Click += new System.EventHandler(this.bt_ltb_Click);
            // 
            // tbx_ltb
            // 
            this.tbx_ltb.Location = new System.Drawing.Point(561, 55);
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
            this.lb_ltb.Location = new System.Drawing.Point(561, 22);
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
            this.bt_Next.Location = new System.Drawing.Point(561, 81);
            this.bt_Next.Name = "bt_Next";
            this.bt_Next.Size = new System.Drawing.Size(215, 44);
            this.bt_Next.TabIndex = 11;
            this.bt_Next.Text = "Nästa";
            this.bt_Next.UseVisualStyleBackColor = false;
            this.bt_Next.Click += new System.EventHandler(this.bt_Next_Click);
            // 
            // lbx_artist
            // 
            this.lbx_artist.FormattingEnabled = true;
            this.lbx_artist.Location = new System.Drawing.Point(187, 209);
            this.lbx_artist.Name = "lbx_artist";
            this.lbx_artist.Size = new System.Drawing.Size(177, 82);
            this.lbx_artist.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(47, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Band Info";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(201, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Artister i bandet";
            // 
            // gb_person
            // 
            this.gb_person.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.gb_person.Controls.Add(this.bt_info);
            this.gb_person.Controls.Add(this.label3);
            this.gb_person.Controls.Add(this.lbx_info);
            this.gb_person.Controls.Add(this.label2);
            this.gb_person.Controls.Add(this.tbx_cmd);
            this.gb_person.Controls.Add(this.lbx_artist);
            this.gb_person.Controls.Add(this.label1);
            this.gb_person.Controls.Add(this.bt_band);
            this.gb_person.Controls.Add(this.lbx_band);
            this.gb_person.Controls.Add(this.bt_medlem);
            this.gb_person.Controls.Add(this.lbx_medlem);
            this.gb_person.Cursor = System.Windows.Forms.Cursors.Default;
            this.gb_person.Location = new System.Drawing.Point(10, 12);
            this.gb_person.Name = "gb_person";
            this.gb_person.Size = new System.Drawing.Size(373, 479);
            this.gb_person.TabIndex = 15;
            this.gb_person.TabStop = false;
            this.gb_person.Text = "Person";
            // 
            // bt_person
            // 
            this.bt_person.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bt_person.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.bt_person.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_person.Location = new System.Drawing.Point(32, 498);
            this.bt_person.Name = "bt_person";
            this.bt_person.Size = new System.Drawing.Size(326, 94);
            this.bt_person.TabIndex = 16;
            this.bt_person.Text = "Person";
            this.bt_person.UseVisualStyleBackColor = false;
            this.bt_person.Click += new System.EventHandler(this.bt_person_Click);
            // 
            // bt_scen
            // 
            this.bt_scen.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bt_scen.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.bt_scen.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_scen.Location = new System.Drawing.Point(407, 132);
            this.bt_scen.Name = "bt_scen";
            this.bt_scen.Size = new System.Drawing.Size(148, 98);
            this.bt_scen.TabIndex = 17;
            this.bt_scen.Text = "Boka Scen";
            this.bt_scen.UseVisualStyleBackColor = false;
            this.bt_scen.Click += new System.EventHandler(this.bt_scen_Click);
            // 
            // lb_scen
            // 
            this.lb_scen.AutoSize = true;
            this.lb_scen.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lb_scen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lb_scen.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_scen.Location = new System.Drawing.Point(561, 132);
            this.lb_scen.Name = "lb_scen";
            this.lb_scen.Size = new System.Drawing.Size(176, 25);
            this.lb_scen.TabIndex = 18;
            this.lb_scen.Text = "Skriv in Bandnamn";
            // 
            // bt_nextScen
            // 
            this.bt_nextScen.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bt_nextScen.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.bt_nextScen.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_nextScen.Location = new System.Drawing.Point(561, 186);
            this.bt_nextScen.Name = "bt_nextScen";
            this.bt_nextScen.Size = new System.Drawing.Size(215, 44);
            this.bt_nextScen.TabIndex = 20;
            this.bt_nextScen.Text = "Nästa";
            this.bt_nextScen.UseVisualStyleBackColor = false;
            this.bt_nextScen.Click += new System.EventHandler(this.bt_nextScen_Click);
            // 
            // tbx_scen
            // 
            this.tbx_scen.Location = new System.Drawing.Point(561, 160);
            this.tbx_scen.Name = "tbx_scen";
            this.tbx_scen.Size = new System.Drawing.Size(215, 20);
            this.tbx_scen.TabIndex = 19;
            this.tbx_scen.TextChanged += new System.EventHandler(this.tbx_scen_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 604);
            this.Controls.Add(this.bt_nextScen);
            this.Controls.Add(this.tbx_scen);
            this.Controls.Add(this.lb_scen);
            this.Controls.Add(this.bt_scen);
            this.Controls.Add(this.bt_person);
            this.Controls.Add(this.gb_person);
            this.Controls.Add(this.bt_Next);
            this.Controls.Add(this.lb_ltb);
            this.Controls.Add(this.tbx_ltb);
            this.Controls.Add(this.bt_ltb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gb_person.ResumeLayout(false);
            this.gb_person.PerformLayout();
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
        private System.Windows.Forms.ListBox lbx_artist;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gb_person;
        private System.Windows.Forms.Button bt_person;
        private System.Windows.Forms.Button bt_scen;
        private System.Windows.Forms.Label lb_scen;
        private System.Windows.Forms.Button bt_nextScen;
        private System.Windows.Forms.TextBox tbx_scen;
    }
}

