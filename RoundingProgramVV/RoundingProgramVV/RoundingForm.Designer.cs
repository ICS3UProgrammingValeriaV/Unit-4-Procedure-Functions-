namespace RoundingProgramVV
{
    partial class frmRounding
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
            this.lblEnter = new System.Windows.Forms.Label();
            this.txtDecimal = new System.Windows.Forms.TextBox();
            this.btnRound = new System.Windows.Forms.Button();
            this.lblDecimal = new System.Windows.Forms.Label();
            this.nudDecimal = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudDecimal)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEnter
            // 
            this.lblEnter.AutoSize = true;
            this.lblEnter.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnter.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblEnter.Location = new System.Drawing.Point(12, 42);
            this.lblEnter.Name = "lblEnter";
            this.lblEnter.Size = new System.Drawing.Size(206, 25);
            this.lblEnter.TabIndex = 0;
            this.lblEnter.Text = "Enter a decimal number:";
            // 
            // txtDecimal
            // 
            this.txtDecimal.BackColor = System.Drawing.Color.Sienna;
            this.txtDecimal.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDecimal.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.txtDecimal.Location = new System.Drawing.Point(248, 42);
            this.txtDecimal.Name = "txtDecimal";
            this.txtDecimal.Size = new System.Drawing.Size(100, 32);
            this.txtDecimal.TabIndex = 1;
            // 
            // btnRound
            // 
            this.btnRound.BackColor = System.Drawing.Color.White;
            this.btnRound.Font = new System.Drawing.Font("Impact", 15F);
            this.btnRound.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnRound.Location = new System.Drawing.Point(133, 151);
            this.btnRound.Name = "btnRound";
            this.btnRound.Size = new System.Drawing.Size(94, 32);
            this.btnRound.TabIndex = 2;
            this.btnRound.Text = "Round";
            this.btnRound.UseVisualStyleBackColor = false;
            this.btnRound.Click += new System.EventHandler(this.btnRound_Click);
            // 
            // lblDecimal
            // 
            this.lblDecimal.AutoSize = true;
            this.lblDecimal.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDecimal.ForeColor = System.Drawing.Color.Peru;
            this.lblDecimal.Location = new System.Drawing.Point(78, 95);
            this.lblDecimal.Name = "lblDecimal";
            this.lblDecimal.Size = new System.Drawing.Size(140, 25);
            this.lblDecimal.TabIndex = 3;
            this.lblDecimal.Text = "Decimal places:";
            // 
            // nudDecimal
            // 
            this.nudDecimal.BackColor = System.Drawing.Color.Peru;
            this.nudDecimal.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudDecimal.ForeColor = System.Drawing.Color.White;
            this.nudDecimal.Location = new System.Drawing.Point(248, 93);
            this.nudDecimal.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.nudDecimal.Name = "nudDecimal";
            this.nudDecimal.Size = new System.Drawing.Size(100, 32);
            this.nudDecimal.TabIndex = 4;
            // 
            // frmRounding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 207);
            this.Controls.Add(this.nudDecimal);
            this.Controls.Add(this.lblDecimal);
            this.Controls.Add(this.btnRound);
            this.Controls.Add(this.txtDecimal);
            this.Controls.Add(this.lblEnter);
            this.Name = "frmRounding";
            this.Text = "Rounding Program by Valeria V";
            this.Load += new System.EventHandler(this.RoundingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudDecimal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnter;
        private System.Windows.Forms.TextBox txtDecimal;
        private System.Windows.Forms.Button btnRound;
        private System.Windows.Forms.Label lblDecimal;
        private System.Windows.Forms.NumericUpDown nudDecimal;
    }
}

