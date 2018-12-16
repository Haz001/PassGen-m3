namespace passgen1
{
    partial class input_num
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
            this.close_btn = new System.Windows.Forms.Button();
            this.num_tb = new System.Windows.Forms.TextBox();
            this.sub_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.ok_btn = new System.Windows.Forms.Button();
            this.sl_bool = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // close_btn
            // 
            this.close_btn.BackColor = System.Drawing.Color.Red;
            this.close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.close_btn.ForeColor = System.Drawing.Color.White;
            this.close_btn.Location = new System.Drawing.Point(200, 0);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(50, 30);
            this.close_btn.TabIndex = 0;
            this.close_btn.Text = "X";
            this.close_btn.UseVisualStyleBackColor = false;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // num_tb
            // 
            this.num_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.num_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.num_tb.Location = new System.Drawing.Point(50, 55);
            this.num_tb.Name = "num_tb";
            this.num_tb.Size = new System.Drawing.Size(150, 40);
            this.num_tb.TabIndex = 1;
            this.num_tb.Text = "8";
            this.num_tb.TextChanged += new System.EventHandler(this.num_tb_TextChanged);
            // 
            // sub_btn
            // 
            this.sub_btn.BackColor = System.Drawing.Color.DimGray;
            this.sub_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sub_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.sub_btn.ForeColor = System.Drawing.Color.White;
            this.sub_btn.Location = new System.Drawing.Point(25, 55);
            this.sub_btn.Name = "sub_btn";
            this.sub_btn.Size = new System.Drawing.Size(25, 40);
            this.sub_btn.TabIndex = 2;
            this.sub_btn.Text = "-";
            this.sub_btn.UseVisualStyleBackColor = false;
            this.sub_btn.Click += new System.EventHandler(this.sub_btn_Click);
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.Color.DimGray;
            this.add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.add_btn.ForeColor = System.Drawing.Color.White;
            this.add_btn.Location = new System.Drawing.Point(200, 55);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(25, 40);
            this.add_btn.TabIndex = 2;
            this.add_btn.Text = "+";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // ok_btn
            // 
            this.ok_btn.BackColor = System.Drawing.Color.Lime;
            this.ok_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ok_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ok_btn.ForeColor = System.Drawing.Color.White;
            this.ok_btn.Location = new System.Drawing.Point(200, 119);
            this.ok_btn.Name = "ok_btn";
            this.ok_btn.Size = new System.Drawing.Size(50, 30);
            this.ok_btn.TabIndex = 0;
            this.ok_btn.Text = "Ok";
            this.ok_btn.UseVisualStyleBackColor = false;
            this.ok_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // sl_bool
            // 
            this.sl_bool.AutoSize = true;
            this.sl_bool.ForeColor = System.Drawing.Color.White;
            this.sl_bool.Location = new System.Drawing.Point(25, 101);
            this.sl_bool.Name = "sl_bool";
            this.sl_bool.Size = new System.Drawing.Size(124, 17);
            this.sl_bool.TabIndex = 3;
            this.sl_bool.Text = "Remove Slider Limits";
            this.sl_bool.UseVisualStyleBackColor = true;
            this.sl_bool.CheckedChanged += new System.EventHandler(this.sl_bool_CheckedChanged);
            // 
            // input_num
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(250, 150);
            this.Controls.Add(this.sl_bool);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.sub_btn);
            this.Controls.Add(this.num_tb);
            this.Controls.Add(this.ok_btn);
            this.Controls.Add(this.close_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "input_num";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "input_num";
            this.Load += new System.EventHandler(this.input_num_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button close_btn;
        private System.Windows.Forms.TextBox num_tb;
        private System.Windows.Forms.Button sub_btn;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button ok_btn;
        private System.Windows.Forms.CheckBox sl_bool;
    }
}