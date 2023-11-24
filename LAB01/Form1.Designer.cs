namespace LAB01
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonAdd = new Button();
            textBoxInput = new TextBox();
            buttonCLear = new Button();
            label1 = new Label();
            num1 = new Button();
            num2 = new Button();
            num3 = new Button();
            num4 = new Button();
            num5 = new Button();
            num6 = new Button();
            num7 = new Button();
            num8 = new Button();
            num9 = new Button();
            num0 = new Button();
            plusBottom = new Button();
            negativeBottom = new Button();
            multiplyBottom = new Button();
            divisionBottom = new Button();
            answerBottom = new Button();
            SuspendLayout();
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(48, 172);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(75, 23);
            buttonAdd.TabIndex = 0;
            buttonAdd.Text = "ADD";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += button1_Click;
            // 
            // textBoxInput
            // 
            textBoxInput.Location = new Point(48, 143);
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(156, 23);
            textBoxInput.TabIndex = 1;
            textBoxInput.TextAlign = HorizontalAlignment.Center;
            textBoxInput.TextChanged += textBox1_TextChanged;
            // 
            // buttonCLear
            // 
            buttonCLear.Location = new Point(129, 172);
            buttonCLear.Name = "buttonCLear";
            buttonCLear.Size = new Size(75, 23);
            buttonCLear.TabIndex = 2;
            buttonCLear.Text = "CLEAR";
            buttonCLear.UseVisualStyleBackColor = true;
            buttonCLear.Click += buttonCLear_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MV Boli", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(72, 78);
            label1.Name = "label1";
            label1.Size = new Size(110, 46);
            label1.TabIndex = 3;
            label1.Text = "TEST";
            label1.UseMnemonic = false;
            label1.Click += label1_Click;
            // 
            // num1
            // 
            num1.Location = new Point(129, 217);
            num1.Name = "num1";
            num1.Size = new Size(75, 23);
            num1.TabIndex = 4;
            num1.Text = "1";
            num1.UseVisualStyleBackColor = true;
            num1.Click += num1_Click;
            // 
            // num2
            // 
            num2.Location = new Point(210, 217);
            num2.Name = "num2";
            num2.Size = new Size(75, 23);
            num2.TabIndex = 5;
            num2.Text = "2";
            num2.UseVisualStyleBackColor = true;
            num2.Click += num2_Click;
            // 
            // num3
            // 
            num3.Location = new Point(291, 217);
            num3.Name = "num3";
            num3.Size = new Size(75, 23);
            num3.TabIndex = 6;
            num3.Text = "3";
            num3.UseVisualStyleBackColor = true;
            num3.Click += num3_Click;
            // 
            // num4
            // 
            num4.Location = new Point(372, 217);
            num4.Name = "num4";
            num4.Size = new Size(75, 23);
            num4.TabIndex = 7;
            num4.Text = "4";
            num4.UseVisualStyleBackColor = true;
            num4.Click += button4_Click;
            // 
            // num5
            // 
            num5.Location = new Point(48, 246);
            num5.Name = "num5";
            num5.Size = new Size(75, 23);
            num5.TabIndex = 8;
            num5.Text = "5";
            num5.UseVisualStyleBackColor = true;
            num5.Click += button5_Click;
            // 
            // num6
            // 
            num6.Location = new Point(129, 246);
            num6.Name = "num6";
            num6.Size = new Size(75, 23);
            num6.TabIndex = 9;
            num6.Text = "6";
            num6.UseVisualStyleBackColor = true;
            num6.Click += num6_Click;
            // 
            // num7
            // 
            num7.Location = new Point(210, 246);
            num7.Name = "num7";
            num7.Size = new Size(75, 23);
            num7.TabIndex = 10;
            num7.Text = "7";
            num7.UseVisualStyleBackColor = true;
            num7.Click += num7_Click;
            // 
            // num8
            // 
            num8.Location = new Point(291, 246);
            num8.Name = "num8";
            num8.Size = new Size(75, 23);
            num8.TabIndex = 11;
            num8.Text = "8";
            num8.UseVisualStyleBackColor = true;
            num8.Click += num8_Click;
            // 
            // num9
            // 
            num9.Location = new Point(372, 246);
            num9.Name = "num9";
            num9.Size = new Size(75, 23);
            num9.TabIndex = 12;
            num9.Text = "9";
            num9.UseVisualStyleBackColor = true;
            num9.Click += num9_Click;
            // 
            // num0
            // 
            num0.Location = new Point(48, 217);
            num0.Name = "num0";
            num0.Size = new Size(75, 23);
            num0.TabIndex = 13;
            num0.Text = "0";
            num0.UseVisualStyleBackColor = true;
            num0.Click += button1_Click_2;
            // 
            // plusBottom
            // 
            plusBottom.Location = new Point(210, 142);
            plusBottom.Name = "plusBottom";
            plusBottom.Size = new Size(75, 53);
            plusBottom.TabIndex = 14;
            plusBottom.Text = "+";
            plusBottom.UseVisualStyleBackColor = true;
            plusBottom.Click += button1_Click_3;
            // 
            // negativeBottom
            // 
            negativeBottom.Location = new Point(291, 142);
            negativeBottom.Name = "negativeBottom";
            negativeBottom.Size = new Size(75, 53);
            negativeBottom.TabIndex = 15;
            negativeBottom.Text = "-";
            negativeBottom.UseVisualStyleBackColor = true;
            negativeBottom.Click += button1_Click_4;
            // 
            // multiplyBottom
            // 
            multiplyBottom.Location = new Point(372, 142);
            multiplyBottom.Name = "multiplyBottom";
            multiplyBottom.Size = new Size(75, 53);
            multiplyBottom.TabIndex = 16;
            multiplyBottom.Text = "*";
            multiplyBottom.UseVisualStyleBackColor = true;
            multiplyBottom.Click += button1_Click_5;
            // 
            // divisionBottom
            // 
            divisionBottom.Location = new Point(453, 142);
            divisionBottom.Name = "divisionBottom";
            divisionBottom.Size = new Size(75, 53);
            divisionBottom.TabIndex = 17;
            divisionBottom.Text = "/";
            divisionBottom.UseVisualStyleBackColor = true;
            divisionBottom.Click += divisionBottom_Click;
            // 
            // answerBottom
            // 
            answerBottom.Location = new Point(453, 216);
            answerBottom.Name = "answerBottom";
            answerBottom.Size = new Size(75, 53);
            answerBottom.TabIndex = 18;
            answerBottom.Text = "=";
            answerBottom.UseVisualStyleBackColor = true;
            answerBottom.Click += answerBottom_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(answerBottom);
            Controls.Add(divisionBottom);
            Controls.Add(multiplyBottom);
            Controls.Add(negativeBottom);
            Controls.Add(plusBottom);
            Controls.Add(num0);
            Controls.Add(num9);
            Controls.Add(num8);
            Controls.Add(num7);
            Controls.Add(num6);
            Controls.Add(num5);
            Controls.Add(num4);
            Controls.Add(num3);
            Controls.Add(num2);
            Controls.Add(num1);
            Controls.Add(label1);
            Controls.Add(buttonCLear);
            Controls.Add(textBoxInput);
            Controls.Add(buttonAdd);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAdd;
        private TextBox textBoxInput;
        private Button buttonCLear;
        private Label label1;
        private Button num1;
        private Button num2;
        private Button num3;
        private Button num4;
        private Button num5;
        private Button num6;
        private Button num7;
        private Button num8;
        private Button num9;
        private Button num0;
        private Button plusBottom;
        private Button negativeBottom;
        private Button multiplyBottom;
        private Button divisionBottom;
        private Button answerBottom;
    }
}
