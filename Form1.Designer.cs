namespace calculatorApp
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.n2 = new System.Windows.Forms.Button();
            this.n3 = new System.Windows.Forms.Button();
            this.n4 = new System.Windows.Forms.Button();
            this.n5 = new System.Windows.Forms.Button();
            this.n8 = new System.Windows.Forms.Button();
            this.n9 = new System.Windows.Forms.Button();
            this.n0 = new System.Windows.Forms.Button();
            this.n1 = new System.Windows.Forms.Button();
            this.n7 = new System.Windows.Forms.Button();
            this.n6 = new System.Windows.Forms.Button();
            this.bEqual = new System.Windows.Forms.Button();
            this.bC = new System.Windows.Forms.Button();
            this.bAdd = new System.Windows.Forms.Button();
            this.bMul = new System.Windows.Forms.Button();
            this.bDiv = new System.Windows.Forms.Button();
            this.bDot = new System.Windows.Forms.Button();
            this.bSub = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(69, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(576, 52);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // n2
            // 
            this.n2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.n2.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n2.Location = new System.Drawing.Point(228, 82);
            this.n2.Name = "n2";
            this.n2.Size = new System.Drawing.Size(99, 74);
            this.n2.TabIndex = 1;
            this.n2.Text = "2";
            this.n2.UseVisualStyleBackColor = false;
            this.n2.Click += new System.EventHandler(this.n2_Click);
            // 
            // n3
            // 
            this.n3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.n3.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n3.Location = new System.Drawing.Point(386, 82);
            this.n3.Name = "n3";
            this.n3.Size = new System.Drawing.Size(99, 74);
            this.n3.TabIndex = 1;
            this.n3.Text = "3";
            this.n3.UseVisualStyleBackColor = false;
            this.n3.Click += new System.EventHandler(this.n3_Click);
            // 
            // n4
            // 
            this.n4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.n4.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n4.Location = new System.Drawing.Point(546, 82);
            this.n4.Name = "n4";
            this.n4.Size = new System.Drawing.Size(99, 74);
            this.n4.TabIndex = 1;
            this.n4.Text = "4";
            this.n4.UseVisualStyleBackColor = false;
            this.n4.Click += new System.EventHandler(this.button3_Click);
            // 
            // n5
            // 
            this.n5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.n5.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n5.Location = new System.Drawing.Point(69, 192);
            this.n5.Name = "n5";
            this.n5.Size = new System.Drawing.Size(99, 74);
            this.n5.TabIndex = 1;
            this.n5.Text = "5";
            this.n5.UseVisualStyleBackColor = false;
            this.n5.Click += new System.EventHandler(this.n5_Click);
            // 
            // n8
            // 
            this.n8.BackColor = System.Drawing.SystemColors.ControlDark;
            this.n8.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n8.Location = new System.Drawing.Point(546, 192);
            this.n8.Name = "n8";
            this.n8.Size = new System.Drawing.Size(99, 74);
            this.n8.TabIndex = 1;
            this.n8.Text = "8";
            this.n8.UseVisualStyleBackColor = false;
            this.n8.Click += new System.EventHandler(this.n8_Click);
            // 
            // n9
            // 
            this.n9.BackColor = System.Drawing.SystemColors.ControlDark;
            this.n9.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n9.Location = new System.Drawing.Point(69, 299);
            this.n9.Name = "n9";
            this.n9.Size = new System.Drawing.Size(99, 74);
            this.n9.TabIndex = 1;
            this.n9.Text = "9";
            this.n9.UseVisualStyleBackColor = false;
            this.n9.Click += new System.EventHandler(this.n9_Click);
            // 
            // n0
            // 
            this.n0.BackColor = System.Drawing.SystemColors.ControlDark;
            this.n0.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n0.Location = new System.Drawing.Point(228, 299);
            this.n0.Name = "n0";
            this.n0.Size = new System.Drawing.Size(99, 74);
            this.n0.TabIndex = 1;
            this.n0.Text = "0";
            this.n0.UseVisualStyleBackColor = false;
            this.n0.Click += new System.EventHandler(this.n0_Click);
            // 
            // n1
            // 
            this.n1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.n1.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n1.Location = new System.Drawing.Point(69, 82);
            this.n1.Name = "n1";
            this.n1.Size = new System.Drawing.Size(99, 74);
            this.n1.TabIndex = 1;
            this.n1.Text = "1";
            this.n1.UseVisualStyleBackColor = false;
            this.n1.Click += new System.EventHandler(this.n1_Click);
            // 
            // n7
            // 
            this.n7.BackColor = System.Drawing.SystemColors.ControlDark;
            this.n7.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n7.Location = new System.Drawing.Point(385, 192);
            this.n7.Name = "n7";
            this.n7.Size = new System.Drawing.Size(99, 74);
            this.n7.TabIndex = 1;
            this.n7.Text = "7";
            this.n7.UseVisualStyleBackColor = false;
            this.n7.Click += new System.EventHandler(this.n7_Click);
            // 
            // n6
            // 
            this.n6.BackColor = System.Drawing.SystemColors.ControlDark;
            this.n6.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n6.Location = new System.Drawing.Point(228, 192);
            this.n6.Name = "n6";
            this.n6.Size = new System.Drawing.Size(99, 74);
            this.n6.TabIndex = 1;
            this.n6.Text = "6";
            this.n6.UseVisualStyleBackColor = false;
            this.n6.Click += new System.EventHandler(this.n6_Click);
            // 
            // bEqual
            // 
            this.bEqual.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bEqual.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEqual.Location = new System.Drawing.Point(546, 299);
            this.bEqual.Name = "bEqual";
            this.bEqual.Size = new System.Drawing.Size(99, 74);
            this.bEqual.TabIndex = 1;
            this.bEqual.Text = "=";
            this.bEqual.UseVisualStyleBackColor = false;
            this.bEqual.Click += new System.EventHandler(this.button12_Click);
            // 
            // bC
            // 
            this.bC.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.bC.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bC.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bC.Location = new System.Drawing.Point(386, 299);
            this.bC.Name = "bC";
            this.bC.Size = new System.Drawing.Size(99, 74);
            this.bC.TabIndex = 1;
            this.bC.Text = "C";
            this.bC.UseVisualStyleBackColor = false;
            this.bC.Click += new System.EventHandler(this.bC_Click);
            // 
            // bAdd
            // 
            this.bAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bAdd.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAdd.Location = new System.Drawing.Point(69, 405);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(99, 74);
            this.bAdd.TabIndex = 1;
            this.bAdd.Text = "+";
            this.bAdd.UseVisualStyleBackColor = false;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // bMul
            // 
            this.bMul.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bMul.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bMul.Location = new System.Drawing.Point(228, 405);
            this.bMul.Name = "bMul";
            this.bMul.Size = new System.Drawing.Size(99, 74);
            this.bMul.TabIndex = 1;
            this.bMul.Text = "*";
            this.bMul.UseVisualStyleBackColor = false;
            this.bMul.Click += new System.EventHandler(this.bMul_Click);
            // 
            // bDiv
            // 
            this.bDiv.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bDiv.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDiv.Location = new System.Drawing.Point(385, 405);
            this.bDiv.Name = "bDiv";
            this.bDiv.Size = new System.Drawing.Size(99, 74);
            this.bDiv.TabIndex = 1;
            this.bDiv.Text = "/";
            this.bDiv.UseVisualStyleBackColor = false;
            this.bDiv.Click += new System.EventHandler(this.bDiv_Click);
            // 
            // bDot
            // 
            this.bDot.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bDot.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDot.Location = new System.Drawing.Point(695, 405);
            this.bDot.Name = "bDot";
            this.bDot.Size = new System.Drawing.Size(99, 74);
            this.bDot.TabIndex = 1;
            this.bDot.Text = ".";
            this.bDot.UseVisualStyleBackColor = false;
            this.bDot.Click += new System.EventHandler(this.bDot_Click);
            // 
            // bSub
            // 
            this.bSub.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bSub.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSub.Location = new System.Drawing.Point(546, 405);
            this.bSub.Name = "bSub";
            this.bSub.Size = new System.Drawing.Size(99, 74);
            this.bSub.TabIndex = 1;
            this.bSub.Text = "-";
            this.bSub.UseVisualStyleBackColor = false;
            this.bSub.Click += new System.EventHandler(this.bSub_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(926, 491);
            this.Controls.Add(this.bEqual);
            this.Controls.Add(this.n8);
            this.Controls.Add(this.n6);
            this.Controls.Add(this.n0);
            this.Controls.Add(this.bC);
            this.Controls.Add(this.n7);
            this.Controls.Add(this.n4);
            this.Controls.Add(this.bSub);
            this.Controls.Add(this.bDot);
            this.Controls.Add(this.bDiv);
            this.Controls.Add(this.bMul);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.n9);
            this.Controls.Add(this.n5);
            this.Controls.Add(this.n1);
            this.Controls.Add(this.n3);
            this.Controls.Add(this.n2);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button n2;
        private System.Windows.Forms.Button n3;
        private System.Windows.Forms.Button n4;
        private System.Windows.Forms.Button n5;
        private System.Windows.Forms.Button n8;
        private System.Windows.Forms.Button n9;
        private System.Windows.Forms.Button n0;
        private System.Windows.Forms.Button n1;
        private System.Windows.Forms.Button n7;
        private System.Windows.Forms.Button n6;
        private System.Windows.Forms.Button bEqual;
        private System.Windows.Forms.Button bC;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Button bMul;
        private System.Windows.Forms.Button bDiv;
        private System.Windows.Forms.Button bDot;
        private System.Windows.Forms.Button bSub;
    }
}

