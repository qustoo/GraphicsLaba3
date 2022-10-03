namespace lab_3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.v1 = new System.Windows.Forms.Label();
            this.coord1 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.select_1 = new System.Windows.Forms.Button();
            this.select_2 = new System.Windows.Forms.Button();
            this.coord2 = new System.Windows.Forms.Label();
            this.v2 = new System.Windows.Forms.Label();
            this.select_3 = new System.Windows.Forms.Button();
            this.coord3 = new System.Windows.Forms.Label();
            this.v3 = new System.Windows.Forms.Label();
            this.rgb1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.rgb2 = new System.Windows.Forms.Label();
            this.rgb3 = new System.Windows.Forms.Label();
            this.fill_gradient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(702, 456);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // v1
            // 
            this.v1.AutoSize = true;
            this.v1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.v1.Location = new System.Drawing.Point(732, 38);
            this.v1.Name = "v1";
            this.v1.Size = new System.Drawing.Size(71, 20);
            this.v1.TabIndex = 1;
            this.v1.Text = "Vertex 1";
            // 
            // coord1
            // 
            this.coord1.AutoSize = true;
            this.coord1.Location = new System.Drawing.Point(855, 125);
            this.coord1.Name = "coord1";
            this.coord1.Size = new System.Drawing.Size(42, 16);
            this.coord1.TabIndex = 2;
            this.coord1.Text = "X:    Y:";
            // 
            // select_1
            // 
            this.select_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.select_1.Location = new System.Drawing.Point(736, 114);
            this.select_1.Name = "select_1";
            this.select_1.Size = new System.Drawing.Size(100, 38);
            this.select_1.TabIndex = 3;
            this.select_1.Text = "Select point";
            this.select_1.UseVisualStyleBackColor = false;
            this.select_1.Click += new System.EventHandler(this.select_1_Click);
            // 
            // select_2
            // 
            this.select_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.select_2.Location = new System.Drawing.Point(736, 263);
            this.select_2.Name = "select_2";
            this.select_2.Size = new System.Drawing.Size(100, 38);
            this.select_2.TabIndex = 6;
            this.select_2.Text = "Select point";
            this.select_2.UseVisualStyleBackColor = false;
            this.select_2.Click += new System.EventHandler(this.select_2_Click);
            // 
            // coord2
            // 
            this.coord2.AutoSize = true;
            this.coord2.Location = new System.Drawing.Point(855, 274);
            this.coord2.Name = "coord2";
            this.coord2.Size = new System.Drawing.Size(42, 16);
            this.coord2.TabIndex = 5;
            this.coord2.Text = "X:    Y:";
            // 
            // v2
            // 
            this.v2.AutoSize = true;
            this.v2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.v2.Location = new System.Drawing.Point(732, 187);
            this.v2.Name = "v2";
            this.v2.Size = new System.Drawing.Size(71, 20);
            this.v2.TabIndex = 4;
            this.v2.Text = "Vertex 2";
            // 
            // select_3
            // 
            this.select_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.select_3.Location = new System.Drawing.Point(736, 394);
            this.select_3.Name = "select_3";
            this.select_3.Size = new System.Drawing.Size(100, 38);
            this.select_3.TabIndex = 9;
            this.select_3.Text = "Select point";
            this.select_3.UseVisualStyleBackColor = false;
            this.select_3.Click += new System.EventHandler(this.select_3_Click);
            // 
            // coord3
            // 
            this.coord3.AutoSize = true;
            this.coord3.Location = new System.Drawing.Point(855, 405);
            this.coord3.Name = "coord3";
            this.coord3.Size = new System.Drawing.Size(42, 16);
            this.coord3.TabIndex = 8;
            this.coord3.Text = "X:    Y:";
            // 
            // v3
            // 
            this.v3.AutoSize = true;
            this.v3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.v3.Location = new System.Drawing.Point(732, 318);
            this.v3.Name = "v3";
            this.v3.Size = new System.Drawing.Size(71, 20);
            this.v3.TabIndex = 7;
            this.v3.Text = "Vertex 3";
            // 
            // rgb1
            // 
            this.rgb1.AutoSize = true;
            this.rgb1.Location = new System.Drawing.Point(855, 81);
            this.rgb1.Name = "rgb1";
            this.rgb1.Size = new System.Drawing.Size(69, 16);
            this.rgb1.TabIndex = 14;
            this.rgb1.Text = "R:    G:    B:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(736, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 38);
            this.button1.TabIndex = 12;
            this.button1.Text = "Select color";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(736, 219);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 38);
            this.button2.TabIndex = 13;
            this.button2.Text = "Select color";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(736, 350);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 38);
            this.button3.TabIndex = 14;
            this.button3.Text = "Select color";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // rgb2
            // 
            this.rgb2.AutoSize = true;
            this.rgb2.Location = new System.Drawing.Point(855, 230);
            this.rgb2.Name = "rgb2";
            this.rgb2.Size = new System.Drawing.Size(69, 16);
            this.rgb2.TabIndex = 15;
            this.rgb2.Text = "R:    G:    B:";
            // 
            // rgb3
            // 
            this.rgb3.AutoSize = true;
            this.rgb3.Location = new System.Drawing.Point(855, 361);
            this.rgb3.Name = "rgb3";
            this.rgb3.Size = new System.Drawing.Size(69, 16);
            this.rgb3.TabIndex = 16;
            this.rgb3.Text = "R:    G:    B:";
            // 
            // fill_gradient
            // 
            this.fill_gradient.BackColor = System.Drawing.Color.Cornsilk;
            this.fill_gradient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.fill_gradient.Location = new System.Drawing.Point(956, 426);
            this.fill_gradient.Name = "fill_gradient";
            this.fill_gradient.Size = new System.Drawing.Size(139, 43);
            this.fill_gradient.TabIndex = 17;
            this.fill_gradient.Text = "Fill gradient";
            this.fill_gradient.UseVisualStyleBackColor = false;
            this.fill_gradient.Click += new System.EventHandler(this.FillGradient_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1107, 481);
            this.Controls.Add(this.fill_gradient);
            this.Controls.Add(this.rgb3);
            this.Controls.Add(this.rgb2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rgb1);
            this.Controls.Add(this.select_3);
            this.Controls.Add(this.coord3);
            this.Controls.Add(this.v3);
            this.Controls.Add(this.select_2);
            this.Controls.Add(this.coord2);
            this.Controls.Add(this.v2);
            this.Controls.Add(this.select_1);
            this.Controls.Add(this.coord1);
            this.Controls.Add(this.v1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "GradientTriangle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label v1;
        private System.Windows.Forms.Label coord1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button select_1;
        private System.Windows.Forms.Button select_2;
        private System.Windows.Forms.Label coord2;
        private System.Windows.Forms.Label v2;
        private System.Windows.Forms.Button select_3;
        private System.Windows.Forms.Label coord3;
        private System.Windows.Forms.Label v3;
        private System.Windows.Forms.Label rgb1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label rgb2;
        private System.Windows.Forms.Label rgb3;
        private System.Windows.Forms.Button fill_gradient;
    }
}

