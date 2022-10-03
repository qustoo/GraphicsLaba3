
namespace task1_wf
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
            this.fill = new System.Windows.Forms.Button();
            this.draw_button = new System.Windows.Forms.Button();
            this.fill_button = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.border_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // fill
            // 
            this.fill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fill.Location = new System.Drawing.Point(13, 13);
            this.fill.Name = "fill";
            this.fill.Size = new System.Drawing.Size(186, 32);
            this.fill.TabIndex = 0;
            this.fill.Text = "Загрузить изображение";
            this.fill.UseVisualStyleBackColor = true;
            this.fill.Click += new System.EventHandler(this.button1_Click);
            // 
            // draw_button
            // 
            this.draw_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.draw_button.Location = new System.Drawing.Point(205, 14);
            this.draw_button.Name = "draw_button";
            this.draw_button.Size = new System.Drawing.Size(95, 32);
            this.draw_button.TabIndex = 2;
            this.draw_button.Text = "Рисовать";
            this.draw_button.UseVisualStyleBackColor = true;
            this.draw_button.Click += new System.EventHandler(this.draw_button_Click);
            // 
            // fill_button
            // 
            this.fill_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fill_button.Location = new System.Drawing.Point(306, 14);
            this.fill_button.Name = "fill_button";
            this.fill_button.Size = new System.Drawing.Size(95, 32);
            this.fill_button.TabIndex = 4;
            this.fill_button.Text = "Залить";
            this.fill_button.UseVisualStyleBackColor = true;
            this.fill_button.Click += new System.EventHandler(this.fill_button_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox.Location = new System.Drawing.Point(13, 52);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(1131, 624);
            this.pictureBox.TabIndex = 5;
            this.pictureBox.TabStop = false;
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            // 
            // border_button
            // 
            this.border_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.border_button.Location = new System.Drawing.Point(407, 14);
            this.border_button.Name = "border_button";
            this.border_button.Size = new System.Drawing.Size(160, 32);
            this.border_button.TabIndex = 6;
            this.border_button.Text = "Выделить границы";
            this.border_button.UseVisualStyleBackColor = true;
            this.border_button.Click += new System.EventHandler(this.border_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 688);
            this.Controls.Add(this.border_button);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.fill_button);
            this.Controls.Add(this.draw_button);
            this.Controls.Add(this.fill);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button fill;
        private System.Windows.Forms.Button draw_button;
        private System.Windows.Forms.Button fill_button;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button border_button;
    }
}

