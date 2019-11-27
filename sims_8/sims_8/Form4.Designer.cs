namespace sims_8
{
    partial class Form4
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_r = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_p = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.numericUpDown_r = new System.Windows.Forms.NumericUpDown();
            this.numeric_p = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_r)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_p)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_r);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label_p);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.numericUpDown_r);
            this.panel1.Controls.Add(this.numeric_p);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 128);
            this.panel1.TabIndex = 0;
            // 
            // label_r
            // 
            this.label_r.AutoSize = true;
            this.label_r.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_r.Location = new System.Drawing.Point(28, 67);
            this.label_r.Name = "label_r";
            this.label_r.Size = new System.Drawing.Size(19, 13);
            this.label_r.TabIndex = 19;
            this.label_r.Text = "r =";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 23);
            this.label1.TabIndex = 17;
            this.label1.Text = "Specify parameters:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_p
            // 
            this.label_p.AutoSize = true;
            this.label_p.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_p.Location = new System.Drawing.Point(28, 37);
            this.label_p.Name = "label_p";
            this.label_p.Size = new System.Drawing.Size(22, 13);
            this.label_p.TabIndex = 18;
            this.label_p.Text = "p =";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(76, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numericUpDown_r
            // 
            this.numericUpDown_r.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown_r.Location = new System.Drawing.Point(68, 65);
            this.numericUpDown_r.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_r.Name = "numericUpDown_r";
            this.numericUpDown_r.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_r.TabIndex = 15;
            this.numericUpDown_r.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // numeric_p
            // 
            this.numeric_p.DecimalPlaces = 2;
            this.numeric_p.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numeric_p.Location = new System.Drawing.Point(68, 33);
            this.numeric_p.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric_p.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numeric_p.Name = "numeric_p";
            this.numeric_p.Size = new System.Drawing.Size(120, 20);
            this.numeric_p.TabIndex = 14;
            this.numeric_p.Value = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 128);
            this.Controls.Add(this.panel1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_r)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_p)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown numericUpDown_r;
        private System.Windows.Forms.NumericUpDown numeric_p;
        private System.Windows.Forms.Label label_r;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_p;
        private System.Windows.Forms.Button button1;
    }
}