namespace Kasseapparat
{
    partial class Form1
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
            this.tbPris = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSum = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblDagsTotal = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblMoms = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblByttepenge = new System.Windows.Forms.Label();
            this.tbModtaget = new System.Windows.Forms.TextBox();
            this.btnByttepenge = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbPris
            // 
            this.tbPris.Location = new System.Drawing.Point(107, 46);
            this.tbPris.Margin = new System.Windows.Forms.Padding(2);
            this.tbPris.Name = "tbPris";
            this.tbPris.Size = new System.Drawing.Size(68, 20);
            this.tbPris.TabIndex = 0;
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(201, 46);
            this.btnEnter.Margin = new System.Windows.Forms.Padding(2);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(50, 36);
            this.btnEnter.TabIndex = 1;
            this.btnEnter.Text = "E";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(105, 69);
            this.lblSubtotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(35, 13);
            this.lblSubtotal.TabIndex = 2;
            this.lblSubtotal.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Subtotal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pris";
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(201, 86);
            this.btnSum.Margin = new System.Windows.Forms.Padding(2);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(50, 54);
            this.btnSum.TabIndex = 5;
            this.btnSum.Text = "Sum";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 100);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Total";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 270);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Dags Total";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(105, 100);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(35, 13);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = "label5";
            // 
            // lblDagsTotal
            // 
            this.lblDagsTotal.AutoSize = true;
            this.lblDagsTotal.Location = new System.Drawing.Point(108, 270);
            this.lblDagsTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDagsTotal.Name = "lblDagsTotal";
            this.lblDagsTotal.Size = new System.Drawing.Size(35, 13);
            this.lblDagsTotal.TabIndex = 9;
            this.lblDagsTotal.Text = "label5";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(325, 46);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Moms";
            // 
            // lblMoms
            // 
            this.lblMoms.AutoSize = true;
            this.lblMoms.Location = new System.Drawing.Point(104, 128);
            this.lblMoms.Name = "lblMoms";
            this.lblMoms.Size = new System.Drawing.Size(35, 13);
            this.lblMoms.TabIndex = 12;
            this.lblMoms.Text = "label6";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Modtaget";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Byttepenge";
            // 
            // lblByttepenge
            // 
            this.lblByttepenge.AutoSize = true;
            this.lblByttepenge.Location = new System.Drawing.Point(108, 204);
            this.lblByttepenge.Name = "lblByttepenge";
            this.lblByttepenge.Size = new System.Drawing.Size(35, 13);
            this.lblByttepenge.TabIndex = 16;
            this.lblByttepenge.Text = "label9";
            // 
            // tbModtaget
            // 
            this.tbModtaget.Location = new System.Drawing.Point(107, 167);
            this.tbModtaget.Name = "tbModtaget";
            this.tbModtaget.Size = new System.Drawing.Size(68, 20);
            this.tbModtaget.TabIndex = 17;
            // 
            // btnByttepenge
            // 
            this.btnByttepenge.Location = new System.Drawing.Point(201, 167);
            this.btnByttepenge.Name = "btnByttepenge";
            this.btnByttepenge.Size = new System.Drawing.Size(74, 50);
            this.btnByttepenge.TabIndex = 18;
            this.btnByttepenge.Text = "Byttepenge";
            this.btnByttepenge.UseVisualStyleBackColor = true;
            this.btnByttepenge.Click += new System.EventHandler(this.btnByttepenge_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 329);
            this.Controls.Add(this.btnByttepenge);
            this.Controls.Add(this.tbModtaget);
            this.Controls.Add(this.lblByttepenge);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblMoms);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lblDagsTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.tbPris);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Kasseapparat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPris;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblDagsTotal;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblMoms;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblByttepenge;
        private System.Windows.Forms.TextBox tbModtaget;
        private System.Windows.Forms.Button btnByttepenge;
    }
}

