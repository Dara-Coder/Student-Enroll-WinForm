namespace Student_Enroll_WindowForm.Forms
{
    partial class NewEnrollStudentForm
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
            this.btnNewEnroll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNewEnroll
            // 
            this.btnNewEnroll.AutoSize = true;
            this.btnNewEnroll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(104)))), ((int)(((byte)(224)))));
            this.btnNewEnroll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewEnroll.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(104)))), ((int)(((byte)(224)))));
            this.btnNewEnroll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewEnroll.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnNewEnroll.ForeColor = System.Drawing.Color.White;
            this.btnNewEnroll.Location = new System.Drawing.Point(12, 12);
            this.btnNewEnroll.Name = "btnNewEnroll";
            this.btnNewEnroll.Size = new System.Drawing.Size(118, 31);
            this.btnNewEnroll.TabIndex = 0;
            this.btnNewEnroll.Text = "New Enrollment";
            this.btnNewEnroll.UseVisualStyleBackColor = false;
            // 
            // NewEnrollStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNewEnroll);
            this.Name = "NewEnrollStudent";
            this.Text = "NewEnrollStudent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewEnroll;
    }
}