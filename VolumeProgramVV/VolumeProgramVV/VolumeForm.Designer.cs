namespace VolumeProgramVV
{
    partial class frmVolume
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
            this.lblRadius = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.txtRadius = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.btnVolume = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRadius
            // 
            this.lblRadius.AutoSize = true;
            this.lblRadius.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRadius.Location = new System.Drawing.Point(32, 38);
            this.lblRadius.Name = "lblRadius";
            this.lblRadius.Size = new System.Drawing.Size(67, 25);
            this.lblRadius.TabIndex = 0;
            this.lblRadius.Text = "Radius";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHeight.Location = new System.Drawing.Point(32, 79);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(64, 25);
            this.lblHeight.TabIndex = 1;
            this.lblHeight.Text = "Height";
            // 
            // txtRadius
            // 
            this.txtRadius.Location = new System.Drawing.Point(118, 43);
            this.txtRadius.Name = "txtRadius";
            this.txtRadius.Size = new System.Drawing.Size(100, 20);
            this.txtRadius.TabIndex = 2;
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(118, 84);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(100, 20);
            this.txtHeight.TabIndex = 3;
            // 
            // btnVolume
            // 
            this.btnVolume.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnVolume.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnVolume.Location = new System.Drawing.Point(75, 129);
            this.btnVolume.Name = "btnVolume";
            this.btnVolume.Size = new System.Drawing.Size(111, 39);
            this.btnVolume.TabIndex = 4;
            this.btnVolume.Text = "Calculate";
            this.btnVolume.UseVisualStyleBackColor = true;
            this.btnVolume.Click += new System.EventHandler(this.btnVolume_Click);
            // 
            // frmVolume
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 193);
            this.Controls.Add(this.btnVolume);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.txtRadius);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.lblRadius);
            this.Name = "frmVolume";
            this.Text = "Volume Program by Valeria V";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRadius;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.TextBox txtRadius;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Button btnVolume;
    }
}

