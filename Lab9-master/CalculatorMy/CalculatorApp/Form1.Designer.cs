namespace CalculatorApp
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
            this.display = new System.Windows.Forms.TextBox();
            this.digit7 = new System.Windows.Forms.Button();
            this.digit8 = new System.Windows.Forms.Button();
            this.digit9 = new System.Windows.Forms.Button();
            this.operationplus = new System.Windows.Forms.Button();
            this.operationequal = new System.Windows.Forms.Button();
            this.digit6 = new System.Windows.Forms.Button();
            this.digit5 = new System.Windows.Forms.Button();
            this.digit4 = new System.Windows.Forms.Button();
            this.digit0 = new System.Windows.Forms.Button();
            this.digit3 = new System.Windows.Forms.Button();
            this.digit2 = new System.Windows.Forms.Button();
            this.digit1 = new System.Windows.Forms.Button();
            this.operationMinus = new System.Windows.Forms.Button();
            this.operationmultiplay = new System.Windows.Forms.Button();
            this.operationdivide = new System.Windows.Forms.Button();
            this.operationC = new System.Windows.Forms.Button();
            this.operationCE = new System.Windows.Forms.Button();
            this.operaionDelete = new System.Windows.Forms.Button();
            this.plusMinus = new System.Windows.Forms.Button();
            this.Sqrt = new System.Windows.Forms.Button();
            this.operationPercent = new System.Windows.Forms.Button();
            this.operationOneDivide = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.operationMminus = new System.Windows.Forms.Button();
            this.operationMplus = new System.Windows.Forms.Button();
            this.operationMS = new System.Windows.Forms.Button();
            this.operationSQR = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // display
            // 
            this.display.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display.Location = new System.Drawing.Point(43, 29);
            this.display.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.display.Multiline = true;
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(283, 57);
            this.display.TabIndex = 0;
            this.display.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // digit7
            // 
            this.digit7.Location = new System.Drawing.Point(50, 252);
            this.digit7.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.digit7.Name = "digit7";
            this.digit7.Size = new System.Drawing.Size(44, 43);
            this.digit7.TabIndex = 1;
            this.digit7.Text = "7";
            this.digit7.UseVisualStyleBackColor = true;
            this.digit7.Click += new System.EventHandler(this.digit_Click);
            // 
            // digit8
            // 
            this.digit8.Location = new System.Drawing.Point(106, 252);
            this.digit8.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.digit8.Name = "digit8";
            this.digit8.Size = new System.Drawing.Size(44, 43);
            this.digit8.TabIndex = 2;
            this.digit8.Text = "8";
            this.digit8.UseVisualStyleBackColor = true;
            this.digit8.Click += new System.EventHandler(this.digit_Click);
            // 
            // digit9
            // 
            this.digit9.Location = new System.Drawing.Point(167, 252);
            this.digit9.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.digit9.Name = "digit9";
            this.digit9.Size = new System.Drawing.Size(44, 43);
            this.digit9.TabIndex = 3;
            this.digit9.Text = "9";
            this.digit9.UseVisualStyleBackColor = true;
            this.digit9.Click += new System.EventHandler(this.digit_Click);
            // 
            // operationplus
            // 
            this.operationplus.Location = new System.Drawing.Point(226, 412);
            this.operationplus.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.operationplus.Name = "operationplus";
            this.operationplus.Size = new System.Drawing.Size(44, 43);
            this.operationplus.TabIndex = 4;
            this.operationplus.Text = "+";
            this.operationplus.UseVisualStyleBackColor = true;
            this.operationplus.Click += new System.EventHandler(this.operation_Click);
            // 
            // operationequal
            // 
            this.operationequal.Location = new System.Drawing.Point(282, 366);
            this.operationequal.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.operationequal.Name = "operationequal";
            this.operationequal.Size = new System.Drawing.Size(44, 89);
            this.operationequal.TabIndex = 8;
            this.operationequal.Text = "=";
            this.operationequal.UseVisualStyleBackColor = true;
            this.operationequal.Click += new System.EventHandler(this.operation_Click);
            // 
            // digit6
            // 
            this.digit6.Location = new System.Drawing.Point(167, 310);
            this.digit6.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.digit6.Name = "digit6";
            this.digit6.Size = new System.Drawing.Size(44, 43);
            this.digit6.TabIndex = 7;
            this.digit6.Text = "6";
            this.digit6.UseVisualStyleBackColor = true;
            this.digit6.Click += new System.EventHandler(this.digit_Click);
            // 
            // digit5
            // 
            this.digit5.Location = new System.Drawing.Point(106, 310);
            this.digit5.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.digit5.Name = "digit5";
            this.digit5.Size = new System.Drawing.Size(44, 43);
            this.digit5.TabIndex = 6;
            this.digit5.Text = "5";
            this.digit5.UseVisualStyleBackColor = true;
            this.digit5.Click += new System.EventHandler(this.digit_Click);
            // 
            // digit4
            // 
            this.digit4.Location = new System.Drawing.Point(50, 310);
            this.digit4.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.digit4.Name = "digit4";
            this.digit4.Size = new System.Drawing.Size(44, 43);
            this.digit4.TabIndex = 5;
            this.digit4.Text = "4";
            this.digit4.UseVisualStyleBackColor = true;
            this.digit4.Click += new System.EventHandler(this.digit_Click);
            // 
            // digit0
            // 
            this.digit0.Location = new System.Drawing.Point(50, 412);
            this.digit0.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.digit0.Name = "digit0";
            this.digit0.Size = new System.Drawing.Size(100, 43);
            this.digit0.TabIndex = 12;
            this.digit0.Text = "0";
            this.digit0.UseVisualStyleBackColor = true;
            this.digit0.Click += new System.EventHandler(this.digit_Click);
            // 
            // digit3
            // 
            this.digit3.Location = new System.Drawing.Point(167, 366);
            this.digit3.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.digit3.Name = "digit3";
            this.digit3.Size = new System.Drawing.Size(44, 43);
            this.digit3.TabIndex = 11;
            this.digit3.Text = "3";
            this.digit3.UseVisualStyleBackColor = true;
            this.digit3.Click += new System.EventHandler(this.digit_Click);
            // 
            // digit2
            // 
            this.digit2.Location = new System.Drawing.Point(106, 366);
            this.digit2.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.digit2.Name = "digit2";
            this.digit2.Size = new System.Drawing.Size(44, 43);
            this.digit2.TabIndex = 10;
            this.digit2.Text = "2";
            this.digit2.UseVisualStyleBackColor = true;
            this.digit2.Click += new System.EventHandler(this.digit_Click);
            // 
            // digit1
            // 
            this.digit1.Location = new System.Drawing.Point(50, 366);
            this.digit1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.digit1.Name = "digit1";
            this.digit1.Size = new System.Drawing.Size(44, 43);
            this.digit1.TabIndex = 9;
            this.digit1.Text = "1";
            this.digit1.UseVisualStyleBackColor = true;
            this.digit1.Click += new System.EventHandler(this.digit_Click);
            // 
            // operationMinus
            // 
            this.operationMinus.Location = new System.Drawing.Point(226, 366);
            this.operationMinus.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.operationMinus.Name = "operationMinus";
            this.operationMinus.Size = new System.Drawing.Size(44, 43);
            this.operationMinus.TabIndex = 13;
            this.operationMinus.Text = "-";
            this.operationMinus.UseVisualStyleBackColor = true;
            this.operationMinus.Click += new System.EventHandler(this.operation_Click);
            // 
            // operationmultiplay
            // 
            this.operationmultiplay.Location = new System.Drawing.Point(226, 310);
            this.operationmultiplay.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.operationmultiplay.Name = "operationmultiplay";
            this.operationmultiplay.Size = new System.Drawing.Size(44, 43);
            this.operationmultiplay.TabIndex = 14;
            this.operationmultiplay.Text = "*";
            this.operationmultiplay.UseVisualStyleBackColor = true;
            this.operationmultiplay.Click += new System.EventHandler(this.operation_Click);
            // 
            // operationdivide
            // 
            this.operationdivide.Location = new System.Drawing.Point(226, 252);
            this.operationdivide.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.operationdivide.Name = "operationdivide";
            this.operationdivide.Size = new System.Drawing.Size(44, 43);
            this.operationdivide.TabIndex = 15;
            this.operationdivide.Text = "/";
            this.operationdivide.UseVisualStyleBackColor = true;
            this.operationdivide.Click += new System.EventHandler(this.operation_Click);
            // 
            // operationC
            // 
            this.operationC.Location = new System.Drawing.Point(167, 197);
            this.operationC.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.operationC.Name = "operationC";
            this.operationC.Size = new System.Drawing.Size(44, 43);
            this.operationC.TabIndex = 16;
            this.operationC.Text = "C";
            this.operationC.UseVisualStyleBackColor = true;
            this.operationC.Click += new System.EventHandler(this.operationCCE_Click);
            // 
            // operationCE
            // 
            this.operationCE.Location = new System.Drawing.Point(106, 197);
            this.operationCE.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.operationCE.Name = "operationCE";
            this.operationCE.Size = new System.Drawing.Size(44, 43);
            this.operationCE.TabIndex = 17;
            this.operationCE.Text = "CE";
            this.operationCE.UseVisualStyleBackColor = true;
            this.operationCE.Click += new System.EventHandler(this.operationCCE_Click);
            // 
            // operaionDelete
            // 
            this.operaionDelete.Location = new System.Drawing.Point(50, 197);
            this.operaionDelete.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.operaionDelete.Name = "operaionDelete";
            this.operaionDelete.Size = new System.Drawing.Size(44, 43);
            this.operaionDelete.TabIndex = 18;
            this.operaionDelete.Text = "<--";
            this.operaionDelete.UseVisualStyleBackColor = true;
            this.operaionDelete.Click += new System.EventHandler(this.operaionDelete_Click);
            // 
            // plusMinus
            // 
            this.plusMinus.Location = new System.Drawing.Point(226, 197);
            this.plusMinus.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.plusMinus.Name = "plusMinus";
            this.plusMinus.Size = new System.Drawing.Size(44, 43);
            this.plusMinus.TabIndex = 19;
            this.plusMinus.Text = "+/-";
            this.plusMinus.UseVisualStyleBackColor = true;
            this.plusMinus.Click += new System.EventHandler(this.plusMinus_Click);
            // 
            // Sqrt
            // 
            this.Sqrt.Location = new System.Drawing.Point(282, 197);
            this.Sqrt.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Sqrt.Name = "Sqrt";
            this.Sqrt.Size = new System.Drawing.Size(44, 43);
            this.Sqrt.TabIndex = 20;
            this.Sqrt.Text = "sqrt";
            this.Sqrt.UseVisualStyleBackColor = true;
            this.Sqrt.Click += new System.EventHandler(this.operation_Sqrt);
            // 
            // operationPercent
            // 
            this.operationPercent.Location = new System.Drawing.Point(282, 254);
            this.operationPercent.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.operationPercent.Name = "operationPercent";
            this.operationPercent.Size = new System.Drawing.Size(44, 43);
            this.operationPercent.TabIndex = 21;
            this.operationPercent.Text = "%";
            this.operationPercent.UseVisualStyleBackColor = true;
            this.operationPercent.Click += new System.EventHandler(this.operation_Percent);
            // 
            // operationOneDivide
            // 
            this.operationOneDivide.Location = new System.Drawing.Point(282, 310);
            this.operationOneDivide.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.operationOneDivide.Name = "operationOneDivide";
            this.operationOneDivide.Size = new System.Drawing.Size(44, 43);
            this.operationOneDivide.TabIndex = 22;
            this.operationOneDivide.Text = "1/x";
            this.operationOneDivide.UseVisualStyleBackColor = true;
            this.operationOneDivide.Click += new System.EventHandler(this.operationOneDivide_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(167, 412);
            this.button1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 43);
            this.button1.TabIndex = 23;
            this.button1.Text = ",";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.operationDot);
            // 
            // operationMminus
            // 
            this.operationMminus.Location = new System.Drawing.Point(282, 102);
            this.operationMminus.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.operationMminus.Name = "operationMminus";
            this.operationMminus.Size = new System.Drawing.Size(44, 43);
            this.operationMminus.TabIndex = 24;
            this.operationMminus.Text = "M-";
            this.operationMminus.UseVisualStyleBackColor = true;
            this.operationMminus.Click += new System.EventHandler(this.memory_minus_click);
            // 
            // operationMplus
            // 
            this.operationMplus.Location = new System.Drawing.Point(221, 102);
            this.operationMplus.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.operationMplus.Name = "operationMplus";
            this.operationMplus.Size = new System.Drawing.Size(44, 43);
            this.operationMplus.TabIndex = 25;
            this.operationMplus.Text = "M+";
            this.operationMplus.UseVisualStyleBackColor = true;
            this.operationMplus.Click += new System.EventHandler(this.memory_plus_click);
            // 
            // operationMS
            // 
            this.operationMS.Location = new System.Drawing.Point(165, 102);
            this.operationMS.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.operationMS.Name = "operationMS";
            this.operationMS.Size = new System.Drawing.Size(44, 43);
            this.operationMS.TabIndex = 26;
            this.operationMS.Text = "MS";
            this.operationMS.UseVisualStyleBackColor = true;
            this.operationMS.Click += new System.EventHandler(this.memory_save_click);
            // 
            // operationSQR
            // 
            this.operationSQR.Location = new System.Drawing.Point(282, 152);
            this.operationSQR.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.operationSQR.Name = "operationSQR";
            this.operationSQR.Size = new System.Drawing.Size(44, 43);
            this.operationSQR.TabIndex = 27;
            this.operationSQR.Text = "sqr";
            this.operationSQR.UseVisualStyleBackColor = true;
            this.operationSQR.Click += new System.EventHandler(this.operation_sqr);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(50, 102);
            this.button2.Margin = new System.Windows.Forms.Padding(1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(44, 43);
            this.button2.TabIndex = 28;
            this.button2.Text = "MC";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.memory_clear_click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(106, 102);
            this.button3.Margin = new System.Windows.Forms.Padding(1);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(44, 43);
            this.button3.TabIndex = 29;
            this.button3.Text = "MR";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.memory_read_click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 537);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.operationSQR);
            this.Controls.Add(this.operationMS);
            this.Controls.Add(this.operationMplus);
            this.Controls.Add(this.operationMminus);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.operationOneDivide);
            this.Controls.Add(this.operationPercent);
            this.Controls.Add(this.Sqrt);
            this.Controls.Add(this.plusMinus);
            this.Controls.Add(this.operaionDelete);
            this.Controls.Add(this.operationCE);
            this.Controls.Add(this.operationC);
            this.Controls.Add(this.operationdivide);
            this.Controls.Add(this.operationmultiplay);
            this.Controls.Add(this.operationMinus);
            this.Controls.Add(this.digit0);
            this.Controls.Add(this.digit3);
            this.Controls.Add(this.digit2);
            this.Controls.Add(this.digit1);
            this.Controls.Add(this.operationequal);
            this.Controls.Add(this.digit6);
            this.Controls.Add(this.digit5);
            this.Controls.Add(this.digit4);
            this.Controls.Add(this.operationplus);
            this.Controls.Add(this.digit9);
            this.Controls.Add(this.digit8);
            this.Controls.Add(this.digit7);
            this.Controls.Add(this.display);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "ZhanelDerzach";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox display;
        private System.Windows.Forms.Button digit7;
        private System.Windows.Forms.Button digit8;
        private System.Windows.Forms.Button digit9;
        private System.Windows.Forms.Button operationplus;
        private System.Windows.Forms.Button operationequal;
        private System.Windows.Forms.Button digit6;
        private System.Windows.Forms.Button digit5;
        private System.Windows.Forms.Button digit4;
        private System.Windows.Forms.Button digit0;
        private System.Windows.Forms.Button digit3;
        private System.Windows.Forms.Button digit2;
        private System.Windows.Forms.Button digit1;
        private System.Windows.Forms.Button operationMinus;
        private System.Windows.Forms.Button operationmultiplay;
        private System.Windows.Forms.Button operationdivide;
        private System.Windows.Forms.Button operationC;
        private System.Windows.Forms.Button operationCE;
        private System.Windows.Forms.Button operaionDelete;
        private System.Windows.Forms.Button plusMinus;
        private System.Windows.Forms.Button Sqrt;
        private System.Windows.Forms.Button operationPercent;
        private System.Windows.Forms.Button operationOneDivide;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button operationMminus;
        private System.Windows.Forms.Button operationMplus;
        private System.Windows.Forms.Button operationMS;
        private System.Windows.Forms.Button operationSQR;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

