namespace feet_inches
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
            this.num1_box = new System.Windows.Forms.TextBox();
            this.num1 = new System.Windows.Forms.Label();
            this.output = new System.Windows.Forms.Label();
            this.num2 = new System.Windows.Forms.Label();
            this.num2_box = new System.Windows.Forms.TextBox();
            this.Addition = new System.Windows.Forms.Button();
            this.Substraction = new System.Windows.Forms.Button();
            this.Multiplication = new System.Windows.Forms.Button();
            this.Division = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // num1_box
            // 
            this.num1_box.Location = new System.Drawing.Point(330, 77);
            this.num1_box.Name = "num1_box";
            this.num1_box.Size = new System.Drawing.Size(71, 22);
            this.num1_box.TabIndex = 0;
            this.num1_box.Tag = "";
            this.num1_box.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // num1
            // 
            this.num1.AutoSize = true;
            this.num1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num1.Location = new System.Drawing.Point(99, 77);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(123, 25);
            this.num1.TabIndex = 1;
            this.num1.Text = "First Number";
            this.num1.Click += new System.EventHandler(this.label1_Click);
            // 
            // output
            // 
            this.output.AutoSize = true;
            this.output.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output.Location = new System.Drawing.Point(253, 327);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(0, 25);
            this.output.TabIndex = 2;
            // 
            // num2
            // 
            this.num2.AutoSize = true;
            this.num2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num2.Location = new System.Drawing.Point(99, 130);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(154, 25);
            this.num2.TabIndex = 4;
            this.num2.Text = "Second Number";
            // 
            // num2_box
            // 
            this.num2_box.Location = new System.Drawing.Point(330, 133);
            this.num2_box.Name = "num2_box";
            this.num2_box.Size = new System.Drawing.Size(71, 22);
            this.num2_box.TabIndex = 5;
            // 
            // Addition
            // 
            this.Addition.Location = new System.Drawing.Point(137, 184);
            this.Addition.Name = "Addition";
            this.Addition.Size = new System.Drawing.Size(75, 23);
            this.Addition.TabIndex = 6;
            this.Addition.Text = "Addition";
            this.Addition.UseVisualStyleBackColor = true;
            this.Addition.Click += new System.EventHandler(this.Addition_Click);
            // 
            // Substraction
            // 
            this.Substraction.Location = new System.Drawing.Point(245, 184);
            this.Substraction.Name = "Substraction";
            this.Substraction.Size = new System.Drawing.Size(101, 23);
            this.Substraction.TabIndex = 7;
            this.Substraction.Tag = "j";
            this.Substraction.Text = "Substraction";
            this.Substraction.UseVisualStyleBackColor = true;
            this.Substraction.Click += new System.EventHandler(this.button2_Click);
            // 
            // Multiplication
            // 
            this.Multiplication.Location = new System.Drawing.Point(368, 184);
            this.Multiplication.Name = "Multiplication";
            this.Multiplication.Size = new System.Drawing.Size(95, 23);
            this.Multiplication.TabIndex = 8;
            this.Multiplication.Text = "Multiplication";
            this.Multiplication.UseVisualStyleBackColor = true;
            this.Multiplication.Click += new System.EventHandler(this.Multiplication_Click);
            // 
            // Division
            // 
            this.Division.Location = new System.Drawing.Point(483, 184);
            this.Division.Name = "Division";
            this.Division.Size = new System.Drawing.Size(75, 23);
            this.Division.TabIndex = 9;
            this.Division.Text = "Division";
            this.Division.UseVisualStyleBackColor = true;
            this.Division.Click += new System.EventHandler(this.Division_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Division);
            this.Controls.Add(this.Multiplication);
            this.Controls.Add(this.Substraction);
            this.Controls.Add(this.Addition);
            this.Controls.Add(this.num2_box);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.output);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.num1_box);
            this.Name = "Form1";
            this.Tag = "";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox num1_box;
        private System.Windows.Forms.Label num1;
        private System.Windows.Forms.Label output;
        private System.Windows.Forms.Label num2;
        private System.Windows.Forms.TextBox num2_box;
        private System.Windows.Forms.Button Addition;
        private System.Windows.Forms.Button Substraction;
        private System.Windows.Forms.Button Multiplication;
        private System.Windows.Forms.Button Division;
    }
}

