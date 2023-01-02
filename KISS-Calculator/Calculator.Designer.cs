namespace KISS_Calculator
{
    partial class Calculator
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
            this.Display = new System.Windows.Forms.TextBox();
            this.roundbracketleft = new System.Windows.Forms.Button();
            this.roundbracketright = new System.Windows.Forms.Button();
            this.modulo = new System.Windows.Forms.Button();
            this.AC = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.point = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Display
            // 
            this.Display.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Display.Location = new System.Drawing.Point(12, 12);
            this.Display.Multiline = true;
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(298, 142);
            this.Display.TabIndex = 0;
            // 
            // roundbracketleft
            // 
            this.roundbracketleft.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.roundbracketleft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundbracketleft.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.roundbracketleft.Location = new System.Drawing.Point(12, 160);
            this.roundbracketleft.Name = "roundbracketleft";
            this.roundbracketleft.Size = new System.Drawing.Size(70, 70);
            this.roundbracketleft.TabIndex = 1;
            this.roundbracketleft.Text = "(";
            this.roundbracketleft.UseVisualStyleBackColor = false;
            this.roundbracketleft.Click += new System.EventHandler(this.Button_Click);
            // 
            // roundbracketright
            // 
            this.roundbracketright.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.roundbracketright.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundbracketright.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.roundbracketright.Location = new System.Drawing.Point(88, 160);
            this.roundbracketright.Name = "roundbracketright";
            this.roundbracketright.Size = new System.Drawing.Size(70, 70);
            this.roundbracketright.TabIndex = 3;
            this.roundbracketright.Text = ")";
            this.roundbracketright.UseVisualStyleBackColor = false;
            this.roundbracketright.Click += new System.EventHandler(this.Button_Click);
            // 
            // modulo
            // 
            this.modulo.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.modulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.modulo.Location = new System.Drawing.Point(164, 160);
            this.modulo.Name = "modulo";
            this.modulo.Size = new System.Drawing.Size(70, 70);
            this.modulo.TabIndex = 4;
            this.modulo.Text = "%";
            this.modulo.UseVisualStyleBackColor = false;
            this.modulo.Click += new System.EventHandler(this.Button_Click);
            // 
            // AC
            // 
            this.AC.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.AC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AC.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AC.Location = new System.Drawing.Point(240, 160);
            this.AC.Name = "AC";
            this.AC.Size = new System.Drawing.Size(70, 70);
            this.AC.TabIndex = 5;
            this.AC.Text = "AC";
            this.AC.UseVisualStyleBackColor = false;
            this.AC.Click += new System.EventHandler(this.AC_Click);
            // 
            // seven
            // 
            this.seven.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.seven.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.seven.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.seven.Location = new System.Drawing.Point(12, 236);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(70, 70);
            this.seven.TabIndex = 7;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = false;
            this.seven.Click += new System.EventHandler(this.Button_Click);
            // 
            // eight
            // 
            this.eight.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.eight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eight.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.eight.Location = new System.Drawing.Point(88, 236);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(70, 70);
            this.eight.TabIndex = 8;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = false;
            this.eight.Click += new System.EventHandler(this.Button_Click);
            // 
            // nine
            // 
            this.nine.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.nine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nine.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nine.Location = new System.Drawing.Point(164, 236);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(70, 70);
            this.nine.TabIndex = 9;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = false;
            this.nine.Click += new System.EventHandler(this.Button_Click);
            // 
            // divide
            // 
            this.divide.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.divide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.divide.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.divide.Location = new System.Drawing.Point(240, 236);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(70, 70);
            this.divide.TabIndex = 10;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = false;
            this.divide.Click += new System.EventHandler(this.Button_Click);
            // 
            // four
            // 
            this.four.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.four.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.four.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.four.Location = new System.Drawing.Point(12, 312);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(70, 70);
            this.four.TabIndex = 12;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = false;
            this.four.Click += new System.EventHandler(this.Button_Click);
            // 
            // five
            // 
            this.five.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.five.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.five.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.five.Location = new System.Drawing.Point(88, 312);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(70, 70);
            this.five.TabIndex = 13;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = false;
            this.five.Click += new System.EventHandler(this.Button_Click);
            // 
            // six
            // 
            this.six.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.six.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.six.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.six.Location = new System.Drawing.Point(164, 312);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(70, 70);
            this.six.TabIndex = 14;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = false;
            this.six.Click += new System.EventHandler(this.Button_Click);
            // 
            // multiply
            // 
            this.multiply.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.multiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.multiply.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.multiply.Location = new System.Drawing.Point(240, 312);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(70, 70);
            this.multiply.TabIndex = 15;
            this.multiply.Text = "*";
            this.multiply.UseVisualStyleBackColor = false;
            this.multiply.Click += new System.EventHandler(this.Button_Click);
            // 
            // one
            // 
            this.one.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.one.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.one.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.one.Location = new System.Drawing.Point(12, 388);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(70, 70);
            this.one.TabIndex = 17;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = false;
            this.one.Click += new System.EventHandler(this.Button_Click);
            // 
            // zero
            // 
            this.zero.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.zero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zero.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.zero.Location = new System.Drawing.Point(88, 464);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(70, 70);
            this.zero.TabIndex = 18;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = false;
            this.zero.Click += new System.EventHandler(this.Button_Click);
            // 
            // two
            // 
            this.two.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.two.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.two.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.two.Location = new System.Drawing.Point(88, 388);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(70, 70);
            this.two.TabIndex = 19;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = false;
            this.two.Click += new System.EventHandler(this.Button_Click);
            // 
            // three
            // 
            this.three.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.three.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.three.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.three.Location = new System.Drawing.Point(164, 388);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(70, 70);
            this.three.TabIndex = 20;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = false;
            this.three.Click += new System.EventHandler(this.Button_Click);
            // 
            // minus
            // 
            this.minus.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.minus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minus.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.minus.Location = new System.Drawing.Point(240, 388);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(70, 70);
            this.minus.TabIndex = 21;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = false;
            this.minus.Click += new System.EventHandler(this.Button_Click);
            // 
            // point
            // 
            this.point.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.point.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.point.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.point.Location = new System.Drawing.Point(12, 465);
            this.point.Name = "point";
            this.point.Size = new System.Drawing.Size(70, 70);
            this.point.TabIndex = 23;
            this.point.Text = ",";
            this.point.UseVisualStyleBackColor = false;
            this.point.Click += new System.EventHandler(this.Button_Click);
            // 
            // equal
            // 
            this.equal.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.equal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.equal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.equal.Location = new System.Drawing.Point(240, 464);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(70, 70);
            this.equal.TabIndex = 24;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = false;
            this.equal.Click += new System.EventHandler(this.Equal_Click);
            // 
            // plus
            // 
            this.plus.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.plus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plus.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.plus.Location = new System.Drawing.Point(164, 465);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(70, 70);
            this.plus.TabIndex = 25;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = false;
            this.plus.Click += new System.EventHandler(this.Button_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(322, 547);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.point);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.three);
            this.Controls.Add(this.two);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.one);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.six);
            this.Controls.Add(this.five);
            this.Controls.Add(this.four);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.AC);
            this.Controls.Add(this.modulo);
            this.Controls.Add(this.roundbracketright);
            this.Controls.Add(this.roundbracketleft);
            this.Controls.Add(this.Display);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Calculator";
            this.Text = "Taschenrechner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox Display;
        private Button roundbracketleft;
        private Button roundbracketright;
        private Button modulo;
        private Button AC;
        private Button seven;
        private Button eight;
        private Button nine;
        private Button divide;
        private Button four;
        private Button five;
        private Button six;
        private Button multiply;
        private Button one;
        private Button zero;
        private Button two;
        private Button three;
        private Button minus;
        private Button point;
        private Button equal;
        private Button plus;
    }
}