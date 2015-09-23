namespace Calculator_app
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
            this.onButton = new System.Windows.Forms.Button();
            this.offButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.multiplyButton = new System.Windows.Forms.Button();
            this.numButton7 = new System.Windows.Forms.Button();
            this.numButton8 = new System.Windows.Forms.Button();
            this.numButton9 = new System.Windows.Forms.Button();
            this.minusButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.plusButton = new System.Windows.Forms.Button();
            this.numButton6 = new System.Windows.Forms.Button();
            this.numButton5 = new System.Windows.Forms.Button();
            this.numButton4 = new System.Windows.Forms.Button();
            this.divideButton = new System.Windows.Forms.Button();
            this.numButton3 = new System.Windows.Forms.Button();
            this.numButton2 = new System.Windows.Forms.Button();
            this.numButton1 = new System.Windows.Forms.Button();
            this.equalButton = new System.Windows.Forms.Button();
            this.dotButton = new System.Windows.Forms.Button();
            this.numButton0 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(207, 27);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // onButton
            // 
            this.onButton.Location = new System.Drawing.Point(13, 55);
            this.onButton.Name = "onButton";
            this.onButton.Size = new System.Drawing.Size(47, 27);
            this.onButton.TabIndex = 1;
            this.onButton.Text = "ON";
            this.onButton.UseVisualStyleBackColor = true;
            this.onButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // offButton
            // 
            this.offButton.Location = new System.Drawing.Point(12, 55);
            this.offButton.Name = "offButton";
            this.offButton.Size = new System.Drawing.Size(47, 27);
            this.offButton.TabIndex = 2;
            this.offButton.Text = "OFF";
            this.offButton.UseVisualStyleBackColor = true;
            this.offButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(66, 55);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(47, 27);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "<-";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(119, 55);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(47, 27);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // multiplyButton
            // 
            this.multiplyButton.Location = new System.Drawing.Point(172, 121);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.Size = new System.Drawing.Size(47, 27);
            this.multiplyButton.TabIndex = 5;
            this.multiplyButton.Text = "*";
            this.multiplyButton.UseVisualStyleBackColor = true;
            this.multiplyButton.Click += new System.EventHandler(this.button5_Click);
            // 
            // numButton7
            // 
            this.numButton7.Location = new System.Drawing.Point(12, 88);
            this.numButton7.Name = "numButton7";
            this.numButton7.Size = new System.Drawing.Size(47, 27);
            this.numButton7.TabIndex = 6;
            this.numButton7.Text = "7";
            this.numButton7.UseVisualStyleBackColor = true;
            this.numButton7.Click += new System.EventHandler(this.button6_Click);
            // 
            // numButton8
            // 
            this.numButton8.Location = new System.Drawing.Point(66, 88);
            this.numButton8.Name = "numButton8";
            this.numButton8.Size = new System.Drawing.Size(47, 27);
            this.numButton8.TabIndex = 7;
            this.numButton8.Text = "8";
            this.numButton8.UseVisualStyleBackColor = true;
            this.numButton8.Click += new System.EventHandler(this.button7_Click);
            // 
            // numButton9
            // 
            this.numButton9.Location = new System.Drawing.Point(119, 88);
            this.numButton9.Name = "numButton9";
            this.numButton9.Size = new System.Drawing.Size(47, 27);
            this.numButton9.TabIndex = 8;
            this.numButton9.Text = "9";
            this.numButton9.UseVisualStyleBackColor = true;
            this.numButton9.Click += new System.EventHandler(this.button8_Click);
            // 
            // minusButton
            // 
            this.minusButton.Location = new System.Drawing.Point(172, 88);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(47, 27);
            this.minusButton.TabIndex = 9;
            this.minusButton.Text = "-";
            this.minusButton.UseVisualStyleBackColor = true;
            this.minusButton.Click += new System.EventHandler(this.button9_Click);
            // 
            // plusButton
            // 
            this.plusButton.Location = new System.Drawing.Point(172, 55);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(47, 27);
            this.plusButton.TabIndex = 13;
            this.plusButton.Text = "+";
            this.plusButton.UseVisualStyleBackColor = true;
            this.plusButton.Click += new System.EventHandler(this.button10_Click);
            // 
            // numButton6
            // 
            this.numButton6.Location = new System.Drawing.Point(119, 121);
            this.numButton6.Name = "numButton6";
            this.numButton6.Size = new System.Drawing.Size(47, 27);
            this.numButton6.TabIndex = 12;
            this.numButton6.Text = "6";
            this.numButton6.UseVisualStyleBackColor = true;
            this.numButton6.Click += new System.EventHandler(this.button11_Click);
            // 
            // numButton5
            // 
            this.numButton5.Location = new System.Drawing.Point(66, 121);
            this.numButton5.Name = "numButton5";
            this.numButton5.Size = new System.Drawing.Size(47, 27);
            this.numButton5.TabIndex = 11;
            this.numButton5.Text = "5";
            this.numButton5.UseVisualStyleBackColor = true;
            this.numButton5.Click += new System.EventHandler(this.button12_Click);
            // 
            // numButton4
            // 
            this.numButton4.Location = new System.Drawing.Point(12, 121);
            this.numButton4.Name = "numButton4";
            this.numButton4.Size = new System.Drawing.Size(47, 27);
            this.numButton4.TabIndex = 10;
            this.numButton4.Text = "4";
            this.numButton4.UseVisualStyleBackColor = true;
            this.numButton4.Click += new System.EventHandler(this.button13_Click);
            // 
            // divideButton
            // 
            this.divideButton.Location = new System.Drawing.Point(172, 155);
            this.divideButton.Name = "divideButton";
            this.divideButton.Size = new System.Drawing.Size(47, 27);
            this.divideButton.TabIndex = 17;
            this.divideButton.Text = "/";
            this.divideButton.UseVisualStyleBackColor = true;
            this.divideButton.Click += new System.EventHandler(this.button14_Click);
            // 
            // numButton3
            // 
            this.numButton3.Location = new System.Drawing.Point(119, 155);
            this.numButton3.Name = "numButton3";
            this.numButton3.Size = new System.Drawing.Size(47, 27);
            this.numButton3.TabIndex = 16;
            this.numButton3.Text = "3";
            this.numButton3.UseVisualStyleBackColor = true;
            this.numButton3.Click += new System.EventHandler(this.button15_Click);
            // 
            // numButton2
            // 
            this.numButton2.Location = new System.Drawing.Point(66, 155);
            this.numButton2.Name = "numButton2";
            this.numButton2.Size = new System.Drawing.Size(47, 27);
            this.numButton2.TabIndex = 15;
            this.numButton2.Text = "2";
            this.numButton2.UseVisualStyleBackColor = true;
            this.numButton2.Click += new System.EventHandler(this.button16_Click);
            // 
            // numButton1
            // 
            this.numButton1.Location = new System.Drawing.Point(12, 155);
            this.numButton1.Name = "numButton1";
            this.numButton1.Size = new System.Drawing.Size(47, 27);
            this.numButton1.TabIndex = 14;
            this.numButton1.Text = "1";
            this.numButton1.UseVisualStyleBackColor = true;
            this.numButton1.Click += new System.EventHandler(this.button17_Click);
            // 
            // equalButton
            // 
            this.equalButton.Location = new System.Drawing.Point(119, 188);
            this.equalButton.Name = "equalButton";
            this.equalButton.Size = new System.Drawing.Size(100, 27);
            this.equalButton.TabIndex = 21;
            this.equalButton.Text = "=";
            this.equalButton.UseVisualStyleBackColor = true;
            this.equalButton.Click += new System.EventHandler(this.button18_Click);
            // 
            // dotButton
            // 
            this.dotButton.Location = new System.Drawing.Point(66, 188);
            this.dotButton.Name = "dotButton";
            this.dotButton.Size = new System.Drawing.Size(47, 27);
            this.dotButton.TabIndex = 19;
            this.dotButton.Text = ".";
            this.dotButton.UseVisualStyleBackColor = true;
            this.dotButton.Click += new System.EventHandler(this.button20_Click);
            // 
            // numButton0
            // 
            this.numButton0.Location = new System.Drawing.Point(12, 188);
            this.numButton0.Name = "numButton0";
            this.numButton0.Size = new System.Drawing.Size(47, 27);
            this.numButton0.TabIndex = 18;
            this.numButton0.Text = "0";
            this.numButton0.UseVisualStyleBackColor = true;
            this.numButton0.Click += new System.EventHandler(this.button21_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 226);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.equalButton);
            this.Controls.Add(this.dotButton);
            this.Controls.Add(this.numButton0);
            this.Controls.Add(this.divideButton);
            this.Controls.Add(this.numButton3);
            this.Controls.Add(this.numButton2);
            this.Controls.Add(this.numButton1);
            this.Controls.Add(this.plusButton);
            this.Controls.Add(this.numButton6);
            this.Controls.Add(this.numButton5);
            this.Controls.Add(this.numButton4);
            this.Controls.Add(this.minusButton);
            this.Controls.Add(this.numButton9);
            this.Controls.Add(this.numButton8);
            this.Controls.Add(this.numButton7);
            this.Controls.Add(this.multiplyButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.offButton);
            this.Controls.Add(this.onButton);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button onButton;
        private System.Windows.Forms.Button offButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button multiplyButton;
        private System.Windows.Forms.Button numButton7;
        private System.Windows.Forms.Button numButton8;
        private System.Windows.Forms.Button numButton9;
        private System.Windows.Forms.Button minusButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button plusButton;
        private System.Windows.Forms.Button numButton6;
        private System.Windows.Forms.Button numButton5;
        private System.Windows.Forms.Button numButton4;
        private System.Windows.Forms.Button divideButton;
        private System.Windows.Forms.Button numButton3;
        private System.Windows.Forms.Button numButton2;
        private System.Windows.Forms.Button numButton1;
        private System.Windows.Forms.Button equalButton;
        private System.Windows.Forms.Button dotButton;
        private System.Windows.Forms.Button numButton0;
        private System.Windows.Forms.Label label1;
    }
}

