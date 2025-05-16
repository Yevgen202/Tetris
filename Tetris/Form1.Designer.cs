namespace Tetris
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_pouse = new System.Windows.Forms.Button();
            this.btn_restart = new System.Windows.Forms.Button();
            this.btn_dovidka = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label1.Location = new System.Drawing.Point(290, 328);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.75F);
            this.label2.Location = new System.Drawing.Point(290, 380);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // button1
            // 
            this.button1.Image = global::Tetris.Properties.Resources.меню1;
            this.button1.Location = new System.Drawing.Point(255, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 43);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_pouse
            // 
            this.btn_pouse.Location = new System.Drawing.Point(310, 189);
            this.btn_pouse.Name = "btn_pouse";
            this.btn_pouse.Size = new System.Drawing.Size(75, 23);
            this.btn_pouse.TabIndex = 4;
            this.btn_pouse.Text = "Пауза";
            this.btn_pouse.UseVisualStyleBackColor = true;
            this.btn_pouse.Visible = false;
            this.btn_pouse.Click += new System.EventHandler(this.btn_pouse_Click);
            // 
            // btn_restart
            // 
            this.btn_restart.Location = new System.Drawing.Point(310, 218);
            this.btn_restart.Name = "btn_restart";
            this.btn_restart.Size = new System.Drawing.Size(91, 23);
            this.btn_restart.TabIndex = 5;
            this.btn_restart.Text = "Почати заново";
            this.btn_restart.UseVisualStyleBackColor = true;
            this.btn_restart.Visible = false;
            this.btn_restart.Click += new System.EventHandler(this.btn_restart_Click);
            // 
            // btn_dovidka
            // 
            this.btn_dovidka.Location = new System.Drawing.Point(310, 247);
            this.btn_dovidka.Name = "btn_dovidka";
            this.btn_dovidka.Size = new System.Drawing.Size(75, 23);
            this.btn_dovidka.TabIndex = 6;
            this.btn_dovidka.Text = "Довідка";
            this.btn_dovidka.UseVisualStyleBackColor = true;
            this.btn_dovidka.Visible = false;
            this.btn_dovidka.Click += new System.EventHandler(this.btn_dovidka_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(408, 473);
            this.Controls.Add(this.btn_dovidka);
            this.Controls.Add(this.btn_restart);
            this.Controls.Add(this.btn_pouse);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Tetris";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.OnPaint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_pouse;
        private System.Windows.Forms.Button btn_restart;
        private System.Windows.Forms.Button btn_dovidka;
    }
}
