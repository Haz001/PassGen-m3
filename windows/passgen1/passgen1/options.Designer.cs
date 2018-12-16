namespace passgen1
{
    partial class options
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.style_lst = new System.Windows.Forms.ListBox();
            this.bool_lst = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type/Style:";
            // 
            // style_lst
            // 
            this.style_lst.BackColor = System.Drawing.Color.DimGray;
            this.style_lst.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.style_lst.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.style_lst.ForeColor = System.Drawing.Color.White;
            this.style_lst.FormattingEnabled = true;
            this.style_lst.Items.AddRange(new object[] {
            "Basic",
            "Multi Word",
            "Word Number Mix"});
            this.style_lst.Location = new System.Drawing.Point(0, 20);
            this.style_lst.Name = "style_lst";
            this.style_lst.Size = new System.Drawing.Size(140, 91);
            this.style_lst.TabIndex = 2;
            this.style_lst.SelectedIndexChanged += new System.EventHandler(this.style_lst_SelectedIndexChanged);
            // 
            // bool_lst
            // 
            this.bool_lst.BackColor = System.Drawing.Color.DimGray;
            this.bool_lst.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bool_lst.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.bool_lst.ForeColor = System.Drawing.Color.White;
            this.bool_lst.FormattingEnabled = true;
            this.bool_lst.Items.AddRange(new object[] {
            "Lower Case",
            "Upper Case",
            "Numbers",
            "Symbols"});
            this.bool_lst.Location = new System.Drawing.Point(150, 20);
            this.bool_lst.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.bool_lst.Name = "bool_lst";
            this.bool_lst.Size = new System.Drawing.Size(120, 90);
            this.bool_lst.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(150, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Properties:";
            // 
            // options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.bool_lst);
            this.Controls.Add(this.style_lst);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "options";
            this.Size = new System.Drawing.Size(500, 150);
            this.Load += new System.EventHandler(this.options_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox style_lst;
        private System.Windows.Forms.CheckedListBox bool_lst;
        private System.Windows.Forms.Label label2;
    }
}
