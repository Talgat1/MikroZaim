namespace MikroZaim
{
    partial class MikroZaim
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
            this.money = new System.Windows.Forms.TextBox();
            this.day = new System.Windows.Forms.TextBox();
            this.prot = new System.Windows.Forms.TextBox();
            this.sum = new System.Windows.Forms.Button();
            this.All_money = new System.Windows.Forms.TextBox();
            this.Sum_prot = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // money
            // 
            this.money.Location = new System.Drawing.Point(12, 26);
            this.money.Name = "money";
            this.money.Size = new System.Drawing.Size(424, 20);
            this.money.TabIndex = 0;
            this.money.Text = "Введите сумму";
            this.money.TextChanged += new System.EventHandler(this.money_TextChanged);
            // 
            // day
            // 
            this.day.Location = new System.Drawing.Point(12, 63);
            this.day.Name = "day";
            this.day.Size = new System.Drawing.Size(424, 20);
            this.day.TabIndex = 1;
            this.day.Text = "Введите количество дней";
            this.day.TextChanged += new System.EventHandler(this.day_TextChanged);
            // 
            // prot
            // 
            this.prot.Location = new System.Drawing.Point(12, 101);
            this.prot.Name = "prot";
            this.prot.Size = new System.Drawing.Size(424, 20);
            this.prot.TabIndex = 2;
            this.prot.Text = "Введите процентные ставки";
            this.prot.TextChanged += new System.EventHandler(this.prot_TextChanged);
            // 
            // sum
            // 
            this.sum.Location = new System.Drawing.Point(12, 137);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(116, 57);
            this.sum.TabIndex = 3;
            this.sum.Text = "sum";
            this.sum.UseVisualStyleBackColor = true;
            this.sum.Click += new System.EventHandler(this.sum_Click);
            // 
            // All_money
            // 
            this.All_money.Location = new System.Drawing.Point(12, 215);
            this.All_money.Name = "All_money";
            this.All_money.Size = new System.Drawing.Size(424, 20);
            this.All_money.TabIndex = 4;
            // 
            // Sum_prot
            // 
            this.Sum_prot.Location = new System.Drawing.Point(12, 252);
            this.Sum_prot.Name = "Sum_prot";
            this.Sum_prot.Size = new System.Drawing.Size(424, 20);
            this.Sum_prot.TabIndex = 5;
            // 
            // MikroZaim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Sum_prot);
            this.Controls.Add(this.All_money);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.prot);
            this.Controls.Add(this.day);
            this.Controls.Add(this.money);
            this.Name = "MikroZaim";
            this.Text = "MikroZaim";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox prot;
        public System.Windows.Forms.TextBox money;
        public System.Windows.Forms.TextBox day;
        private System.Windows.Forms.Button sum;
        private System.Windows.Forms.TextBox All_money;
        private System.Windows.Forms.TextBox Sum_prot;
    }
}

