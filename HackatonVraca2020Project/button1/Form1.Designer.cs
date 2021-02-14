namespace button1
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
            this.button7 = new System.Windows.Forms.Button();
            this.buuton = new System.Windows.Forms.Button();
            this.lblX = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.super = new System.Windows.Forms.CheckBox();
            this.biva = new System.Windows.Forms.CheckBox();
            this.zle = new System.Windows.Forms.CheckBox();
            this.lblPoints = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(628, 435);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(115, 25);
            this.button7.TabIndex = 6;
            this.button7.Text = "Close";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // buuton
            // 
            this.buuton.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buuton.Location = new System.Drawing.Point(204, 147);
            this.buuton.Name = "buuton";
            this.buuton.Size = new System.Drawing.Size(143, 63);
            this.buuton.TabIndex = 9;
            this.buuton.Text = "ДА";
            this.buuton.UseVisualStyleBackColor = true;
            this.buuton.Click += new System.EventHandler(this.button9_Click);
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblX.Location = new System.Drawing.Point(122, 295);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(0, 16);
            this.lblX.TabIndex = 11;
            this.lblX.Click += new System.EventHandler(this.lblX_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(204, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(373, 129);
            this.textBox1.TabIndex = 12;
            this.textBox1.Text = "Пушиш ли?";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(434, 147);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 63);
            this.button2.TabIndex = 13;
            this.button2.Text = "НЕ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(59, 291);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Точки:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // super
            // 
            this.super.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.super.Location = new System.Drawing.Point(68, 323);
            this.super.Name = "super";
            this.super.Size = new System.Drawing.Size(104, 24);
            this.super.TabIndex = 15;
            this.super.Text = "от 0 - 3";
            this.super.UseVisualStyleBackColor = true;
            this.super.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // biva
            // 
            this.biva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.biva.Location = new System.Drawing.Point(68, 359);
            this.biva.Name = "biva";
            this.biva.Size = new System.Drawing.Size(80, 17);
            this.biva.TabIndex = 16;
            this.biva.Text = "от 4 - 7";
            this.biva.UseVisualStyleBackColor = true;
            this.biva.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // zle
            // 
            this.zle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.zle.Location = new System.Drawing.Point(68, 394);
            this.zle.Name = "zle";
            this.zle.Size = new System.Drawing.Size(80, 17);
            this.zle.TabIndex = 17;
            this.zle.Text = "от 8 - 10";
            this.zle.UseVisualStyleBackColor = true;
            this.zle.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // lblPoints
            // 
            this.lblPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPoints.Location = new System.Drawing.Point(366, 230);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(377, 170);
            this.lblPoints.TabIndex = 18;
            this.lblPoints.Click += new System.EventHandler(this.label2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(154, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Нашият съвет към теб е: ";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(765, 472);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.zle);
            this.Controls.Add(this.biva);
            this.Controls.Add(this.super);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.buuton);
            this.Controls.Add(this.button7);
            this.MinimumSize = new System.Drawing.Size(688, 468);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button buuton;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox super;
        private System.Windows.Forms.CheckBox biva;
        private System.Windows.Forms.CheckBox zle;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.Label label2;
    }
}

