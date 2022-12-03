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
            this.sieben = new System.Windows.Forms.Button();
            this.acht = new System.Windows.Forms.Button();
            this.neun = new System.Windows.Forms.Button();
            this.vier = new System.Windows.Forms.Button();
            this.fuenf = new System.Windows.Forms.Button();
            this.sechs = new System.Windows.Forms.Button();
            this.eins = new System.Windows.Forms.Button();
            this.zwei = new System.Windows.Forms.Button();
            this.drei = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Display
            // 
            this.Display.Location = new System.Drawing.Point(12, 12);
            this.Display.Multiline = true;
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(321, 123);
            this.Display.TabIndex = 0;
            // 
            // sieben
            // 
            this.sieben.Location = new System.Drawing.Point(12, 141);
            this.sieben.Name = "sieben";
            this.sieben.Size = new System.Drawing.Size(60, 60);
            this.sieben.TabIndex = 1;
            this.sieben.Text = "7";
            this.sieben.UseVisualStyleBackColor = true;
            this.sieben.Click += new System.EventHandler(this.sieben_Click);
            // 
            // acht
            // 
            this.acht.Location = new System.Drawing.Point(78, 141);
            this.acht.Name = "acht";
            this.acht.Size = new System.Drawing.Size(60, 60);
            this.acht.TabIndex = 2;
            this.acht.Text = "8";
            this.acht.UseVisualStyleBackColor = true;
            this.acht.Click += new System.EventHandler(this.acht_Click);
            // 
            // neun
            // 
            this.neun.Location = new System.Drawing.Point(144, 141);
            this.neun.Name = "neun";
            this.neun.Size = new System.Drawing.Size(60, 60);
            this.neun.TabIndex = 3;
            this.neun.Text = "9";
            this.neun.UseVisualStyleBackColor = true;
            this.neun.Click += new System.EventHandler(this.neun_Click);
            // 
            // vier
            // 
            this.vier.Location = new System.Drawing.Point(12, 207);
            this.vier.Name = "vier";
            this.vier.Size = new System.Drawing.Size(60, 60);
            this.vier.TabIndex = 4;
            this.vier.Text = "4";
            this.vier.UseVisualStyleBackColor = true;
            this.vier.Click += new System.EventHandler(this.vier_Click);
            // 
            // fuenf
            // 
            this.fuenf.Location = new System.Drawing.Point(78, 207);
            this.fuenf.Name = "fuenf";
            this.fuenf.Size = new System.Drawing.Size(60, 60);
            this.fuenf.TabIndex = 5;
            this.fuenf.Text = "5";
            this.fuenf.UseVisualStyleBackColor = true;
            this.fuenf.Click += new System.EventHandler(this.fuenf_Click);
            // 
            // sechs
            // 
            this.sechs.Location = new System.Drawing.Point(144, 207);
            this.sechs.Name = "sechs";
            this.sechs.Size = new System.Drawing.Size(60, 60);
            this.sechs.TabIndex = 6;
            this.sechs.Text = "6";
            this.sechs.UseVisualStyleBackColor = true;
            this.sechs.Click += new System.EventHandler(this.sechs_Click);
            // 
            // eins
            // 
            this.eins.Location = new System.Drawing.Point(12, 273);
            this.eins.Name = "eins";
            this.eins.Size = new System.Drawing.Size(60, 60);
            this.eins.TabIndex = 7;
            this.eins.Text = "1";
            this.eins.UseVisualStyleBackColor = true;
            this.eins.Click += new System.EventHandler(this.eins_Click);
            // 
            // zwei
            // 
            this.zwei.Location = new System.Drawing.Point(78, 273);
            this.zwei.Name = "zwei";
            this.zwei.Size = new System.Drawing.Size(60, 60);
            this.zwei.TabIndex = 8;
            this.zwei.Text = "2";
            this.zwei.UseVisualStyleBackColor = true;
            this.zwei.Click += new System.EventHandler(this.zwei_Click);
            // 
            // drei
            // 
            this.drei.Location = new System.Drawing.Point(144, 273);
            this.drei.Name = "drei";
            this.drei.Size = new System.Drawing.Size(60, 60);
            this.drei.TabIndex = 9;
            this.drei.Text = "3";
            this.drei.UseVisualStyleBackColor = true;
            this.drei.Click += new System.EventHandler(this.drei_Click);
            // 
            // plus
            // 
            this.plus.Location = new System.Drawing.Point(210, 141);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(60, 60);
            this.plus.TabIndex = 10;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(210, 207);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(60, 60);
            this.minus.TabIndex = 11;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // equal
            // 
            this.equal.Location = new System.Drawing.Point(210, 273);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(60, 60);
            this.equal.TabIndex = 12;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = true;
            this.equal.Click += new System.EventHandler(this.equal_Click);
            // 
            // zero
            // 
            this.zero.Location = new System.Drawing.Point(12, 339);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(126, 60);
            this.zero.TabIndex = 13;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.zero_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(273, 141);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(60, 258);
            this.Clear.TabIndex = 14;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // multiply
            // 
            this.multiply.Location = new System.Drawing.Point(144, 339);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(60, 60);
            this.multiply.TabIndex = 15;
            this.multiply.Text = "*";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.multiply_Click);
            // 
            // divide
            // 
            this.divide.Location = new System.Drawing.Point(210, 339);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(60, 60);
            this.divide.TabIndex = 16;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.divide_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 405);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.drei);
            this.Controls.Add(this.zwei);
            this.Controls.Add(this.eins);
            this.Controls.Add(this.sechs);
            this.Controls.Add(this.fuenf);
            this.Controls.Add(this.vier);
            this.Controls.Add(this.neun);
            this.Controls.Add(this.acht);
            this.Controls.Add(this.sieben);
            this.Controls.Add(this.Display);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Calculator";
            this.Text = "Taschenrechner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox Display;
        private Button sieben;
        private Button acht;
        private Button neun;
        private Button vier;
        private Button fuenf;
        private Button sechs;
        private Button eins;
        private Button zwei;
        private Button drei;
        private Button plus;
        private Button minus;
        private Button equal;
        private Button zero;
        private Button Clear;
        private Button multiply;
        private Button divide;
    }
}