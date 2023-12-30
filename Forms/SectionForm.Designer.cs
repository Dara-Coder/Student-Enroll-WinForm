namespace Student_Enroll_WindowForm.Forms
{
    partial class SectionForm
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
            this.btnNewSection = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNewSection
            // 
            this.btnNewSection.AutoSize = true;
            this.btnNewSection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(104)))), ((int)(((byte)(224)))));
            this.btnNewSection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewSection.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(104)))), ((int)(((byte)(224)))));
            this.btnNewSection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewSection.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnNewSection.ForeColor = System.Drawing.Color.White;
            this.btnNewSection.Location = new System.Drawing.Point(13, 13);
            this.btnNewSection.Name = "btnNewSection";
            this.btnNewSection.Size = new System.Drawing.Size(96, 31);
            this.btnNewSection.TabIndex = 0;
            this.btnNewSection.Text = "New Section";
            this.btnNewSection.UseVisualStyleBackColor = false;
            // 
            // SectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNewSection);
            this.Name = "SectionForm";
            this.Text = "SectionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewSection;
    }
}