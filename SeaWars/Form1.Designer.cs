
namespace SeaWars
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Igrat = new System.Windows.Forms.Button();
            this.oprog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Igrat
            // 
            this.Igrat.Location = new System.Drawing.Point(214, 28);
            this.Igrat.Name = "Igrat";
            this.Igrat.Size = new System.Drawing.Size(425, 126);
            this.Igrat.TabIndex = 2;
            this.Igrat.Text = "Начать игру";
            this.Igrat.UseVisualStyleBackColor = true;
            this.Igrat.Click += new System.EventHandler(this.Igrat_Click);
            // 
            // oprog
            // 
            this.oprog.Location = new System.Drawing.Point(214, 160);
            this.oprog.Name = "oprog";
            this.oprog.Size = new System.Drawing.Size(425, 126);
            this.oprog.TabIndex = 3;
            this.oprog.Text = "О программе";
            this.oprog.UseVisualStyleBackColor = true;
            this.oprog.Click += new System.EventHandler(this.oprog_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(801, 348);
            this.Controls.Add(this.oprog);
            this.Controls.Add(this.Igrat);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Морской Бой";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Igrat;
        private System.Windows.Forms.Button oprog;
    }
}

