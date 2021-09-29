namespace T9Spelling
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.gb_message = new System.Windows.Forms.GroupBox();
            this.tb_Output = new System.Windows.Forms.TextBox();
            this.tb_message = new System.Windows.Forms.TextBox();
            this.btn_Ok = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_message.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_message
            // 
            this.gb_message.Controls.Add(this.tb_Output);
            this.gb_message.Controls.Add(this.tb_message);
            this.gb_message.Controls.Add(this.btn_Ok);
            this.gb_message.Controls.Add(this.label1);
            this.gb_message.Location = new System.Drawing.Point(12, 12);
            this.gb_message.Name = "gb_message";
            this.gb_message.Size = new System.Drawing.Size(540, 403);
            this.gb_message.TabIndex = 0;
            this.gb_message.TabStop = false;
            // 
            // tb_Output
            // 
            this.tb_Output.Location = new System.Drawing.Point(25, 203);
            this.tb_Output.Multiline = true;
            this.tb_Output.Name = "tb_Output";
            this.tb_Output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_Output.Size = new System.Drawing.Size(481, 194);
            this.tb_Output.TabIndex = 5;
            // 
            // tb_message
            // 
            this.tb_message.Location = new System.Drawing.Point(25, 62);
            this.tb_message.Multiline = true;
            this.tb_message.Name = "tb_message";
            this.tb_message.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_message.Size = new System.Drawing.Size(481, 106);
            this.tb_message.TabIndex = 0;
            // 
            // btn_Ok
            // 
            this.btn_Ok.Location = new System.Drawing.Point(25, 174);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(481, 23);
            this.btn_Ok.TabIndex = 2;
            this.btn_Ok.Text = "Ok";
            this.btn_Ok.UseVisualStyleBackColor = true;
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(22, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input message";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 446);
            this.Controls.Add(this.gb_message);
            this.Name = "Form1";
            this.Text = "T9Spelling";
            this.gb_message.ResumeLayout(false);
            this.gb_message.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_message;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Ok;
        private System.Windows.Forms.TextBox tb_message;
        private System.Windows.Forms.TextBox tb_Output;
    }
}

