namespace passgen1
{
    partial class FormM
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
            this.main = new System.Windows.Forms.Panel();
            this.opt_btn = new System.Windows.Forms.Label();
            this.size_btn = new System.Windows.Forms.Label();
            this.status_lb = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.close_btn = new System.Windows.Forms.Button();
            this.pv_tb = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cp_btn = new System.Windows.Forms.Button();
            this.gp_btn = new System.Windows.Forms.Button();
            this.length_sb = new System.Windows.Forms.HScrollBar();
            this.options_pnl = new passgen1.options();
            this.main.SuspendLayout();
            this.SuspendLayout();
            // 
            // main
            // 
            this.main.Controls.Add(this.options_pnl);
            this.main.Controls.Add(this.opt_btn);
            this.main.Controls.Add(this.size_btn);
            this.main.Controls.Add(this.status_lb);
            this.main.Controls.Add(this.label1);
            this.main.Controls.Add(this.button3);
            this.main.Controls.Add(this.close_btn);
            this.main.Controls.Add(this.pv_tb);
            this.main.Controls.Add(this.button1);
            this.main.Controls.Add(this.cp_btn);
            this.main.Controls.Add(this.gp_btn);
            this.main.Controls.Add(this.length_sb);
            this.main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main.Location = new System.Drawing.Point(0, 0);
            this.main.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.main.Name = "main";
            this.main.Size = new System.Drawing.Size(500, 300);
            this.main.TabIndex = 0;
            // 
            // opt_btn
            // 
            this.opt_btn.AutoSize = true;
            this.opt_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.opt_btn.ForeColor = System.Drawing.Color.White;
            this.opt_btn.Location = new System.Drawing.Point(421, 280);
            this.opt_btn.Name = "opt_btn";
            this.opt_btn.Size = new System.Drawing.Size(79, 20);
            this.opt_btn.TabIndex = 6;
            this.opt_btn.Text = "Options ⋁";
            this.opt_btn.Visible = false;
            this.opt_btn.Click += new System.EventHandler(this.opt_btn_Click);
            // 
            // size_btn
            // 
            this.size_btn.AutoSize = true;
            this.size_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.size_btn.ForeColor = System.Drawing.Color.White;
            this.size_btn.Location = new System.Drawing.Point(50, 185);
            this.size_btn.Margin = new System.Windows.Forms.Padding(0);
            this.size_btn.Name = "size_btn";
            this.size_btn.Size = new System.Drawing.Size(34, 25);
            this.size_btn.TabIndex = 5;
            this.size_btn.Text = "16";
            this.size_btn.Click += new System.EventHandler(this.size_btn_Click);
            this.size_btn.DoubleClick += new System.EventHandler(this.size_btn_DoubleClick);
            // 
            // status_lb
            // 
            this.status_lb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.status_lb.AutoSize = true;
            this.status_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.status_lb.ForeColor = System.Drawing.Color.White;
            this.status_lb.Location = new System.Drawing.Point(0, 287);
            this.status_lb.Margin = new System.Windows.Forms.Padding(0);
            this.status_lb.Name = "status_lb";
            this.status_lb.Size = new System.Drawing.Size(37, 13);
            this.status_lb.TabIndex = 4;
            this.status_lb.Text = "Status";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pass Gen m";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gray;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(400, 0);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 30);
            this.button3.TabIndex = 3;
            this.button3.Text = "_";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // close_btn
            // 
            this.close_btn.BackColor = System.Drawing.Color.Red;
            this.close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.close_btn.ForeColor = System.Drawing.Color.White;
            this.close_btn.Location = new System.Drawing.Point(450, 0);
            this.close_btn.Margin = new System.Windows.Forms.Padding(0);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(50, 30);
            this.close_btn.TabIndex = 3;
            this.close_btn.Text = "X";
            this.close_btn.UseVisualStyleBackColor = false;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // pv_tb
            // 
            this.pv_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pv_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.pv_tb.Location = new System.Drawing.Point(175, 115);
            this.pv_tb.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pv_tb.MaxLength = 1695;
            this.pv_tb.Name = "pv_tb";
            this.pv_tb.Size = new System.Drawing.Size(275, 40);
            this.pv_tb.TabIndex = 2;
            this.pv_tb.TextChanged += new System.EventHandler(this.pv_tb_TextChanged);
            this.pv_tb.DoubleClick += new System.EventHandler(this.pv_tb_DoubleClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(330, 155);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // cp_btn
            // 
            this.cp_btn.BackColor = System.Drawing.Color.Gray;
            this.cp_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cp_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.cp_btn.ForeColor = System.Drawing.Color.White;
            this.cp_btn.Location = new System.Drawing.Point(390, 155);
            this.cp_btn.Margin = new System.Windows.Forms.Padding(0);
            this.cp_btn.Name = "cp_btn";
            this.cp_btn.Size = new System.Drawing.Size(60, 30);
            this.cp_btn.TabIndex = 1;
            this.cp_btn.Text = "Copy";
            this.cp_btn.UseVisualStyleBackColor = false;
            this.cp_btn.Click += new System.EventHandler(this.cp_btn_Click);
            // 
            // gp_btn
            // 
            this.gp_btn.BackColor = System.Drawing.Color.Lime;
            this.gp_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gp_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.gp_btn.ForeColor = System.Drawing.Color.White;
            this.gp_btn.Location = new System.Drawing.Point(50, 115);
            this.gp_btn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gp_btn.Name = "gp_btn";
            this.gp_btn.Size = new System.Drawing.Size(125, 40);
            this.gp_btn.TabIndex = 1;
            this.gp_btn.Text = "Genorate";
            this.gp_btn.UseVisualStyleBackColor = false;
            this.gp_btn.Click += new System.EventHandler(this.gp_btn_Click);
            // 
            // length_sb
            // 
            this.length_sb.LargeChange = 1;
            this.length_sb.Location = new System.Drawing.Point(50, 155);
            this.length_sb.Maximum = 128;
            this.length_sb.Minimum = 8;
            this.length_sb.Name = "length_sb";
            this.length_sb.Size = new System.Drawing.Size(280, 30);
            this.length_sb.TabIndex = 0;
            this.length_sb.Value = 16;
            this.length_sb.Scroll += new System.Windows.Forms.ScrollEventHandler(this.length_sb_Scroll);
            this.length_sb.ValueChanged += new System.EventHandler(this.length_sb_ValueChanged);
            // 
            // options_pnl
            // 
            this.options_pnl.BackColor = System.Drawing.Color.Gray;
            this.options_pnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.options_pnl.Enabled = false;
            this.options_pnl.Location = new System.Drawing.Point(0, 300);
            this.options_pnl.Name = "options_pnl";
            this.options_pnl.Size = new System.Drawing.Size(500, 0);
            this.options_pnl.TabIndex = 7;
            this.options_pnl.Visible = false;
            // 
            // FormM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(500, 300);
            this.Controls.Add(this.main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "FormM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Milli Password Genorator V1";
            this.main.ResumeLayout(false);
            this.main.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel main;
        private System.Windows.Forms.TextBox pv_tb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button cp_btn;
        private System.Windows.Forms.Button gp_btn;
        private System.Windows.Forms.HScrollBar length_sb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button close_btn;
        private System.Windows.Forms.Label size_btn;
        private System.Windows.Forms.Label status_lb;
        private System.Windows.Forms.Label opt_btn;
        private options options_pnl;
    }
}

