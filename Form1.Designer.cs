namespace Student_Enroll_WindowForm
{
    partial class StudentForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentForm));
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuTitle = new System.Windows.Forms.Label();
            this.menuButton = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.NewStudentBtn = new System.Windows.Forms.Button();
            this.EnrollStudentBtn = new System.Windows.Forms.Button();
            this.SubjectBtn = new System.Windows.Forms.Button();
            this.SectionBtn = new System.Windows.Forms.Button();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.navbarContainer = new System.Windows.Forms.Panel();
            this.titleLb = new System.Windows.Forms.Label();
            this.containerRender = new System.Windows.Forms.Panel();
            this.sidebar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).BeginInit();
            this.panel2.SuspendLayout();
            this.navbarContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.sidebar.Controls.Add(this.panel1);
            this.sidebar.Controls.Add(this.panel2);
            this.sidebar.Controls.Add(this.EnrollStudentBtn);
            this.sidebar.Controls.Add(this.SubjectBtn);
            this.sidebar.Controls.Add(this.SectionBtn);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.MaximumSize = new System.Drawing.Size(200, 0);
            this.sidebar.MinimumSize = new System.Drawing.Size(46, 450);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(200, 450);
            this.sidebar.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.menuTitle);
            this.panel1.Controls.Add(this.menuButton);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(197, 30);
            this.panel1.TabIndex = 0;
            // 
            // menuTitle
            // 
            this.menuTitle.AutoSize = true;
            this.menuTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuTitle.ForeColor = System.Drawing.Color.White;
            this.menuTitle.Location = new System.Drawing.Point(40, 6);
            this.menuTitle.Name = "menuTitle";
            this.menuTitle.Size = new System.Drawing.Size(50, 21);
            this.menuTitle.TabIndex = 1;
            this.menuTitle.Text = "Menu";
            // 
            // menuButton
            // 
            this.menuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuButton.Image = ((System.Drawing.Image)(resources.GetObject("menuButton.Image")));
            this.menuButton.Location = new System.Drawing.Point(9, 9);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(25, 15);
            this.menuButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.menuButton.TabIndex = 0;
            this.menuButton.TabStop = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.NewStudentBtn);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel2.Location = new System.Drawing.Point(3, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(197, 41);
            this.panel2.TabIndex = 1;
            // 
            // NewStudentBtn
            // 
            this.NewStudentBtn.FlatAppearance.BorderSize = 0;
            this.NewStudentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewStudentBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewStudentBtn.ForeColor = System.Drawing.Color.White;
            this.NewStudentBtn.Image = ((System.Drawing.Image)(resources.GetObject("NewStudentBtn.Image")));
            this.NewStudentBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NewStudentBtn.Location = new System.Drawing.Point(0, 0);
            this.NewStudentBtn.Name = "NewStudentBtn";
            this.NewStudentBtn.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.NewStudentBtn.Size = new System.Drawing.Size(197, 41);
            this.NewStudentBtn.TabIndex = 2;
            this.NewStudentBtn.Text = "         New Student";
            this.NewStudentBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NewStudentBtn.UseVisualStyleBackColor = true;
            this.NewStudentBtn.Click += new System.EventHandler(this.NewStudentBtn_Click);
            // 
            // EnrollStudentBtn
            // 
            this.EnrollStudentBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EnrollStudentBtn.FlatAppearance.BorderSize = 0;
            this.EnrollStudentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EnrollStudentBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnrollStudentBtn.ForeColor = System.Drawing.Color.White;
            this.EnrollStudentBtn.Image = ((System.Drawing.Image)(resources.GetObject("EnrollStudentBtn.Image")));
            this.EnrollStudentBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EnrollStudentBtn.Location = new System.Drawing.Point(3, 86);
            this.EnrollStudentBtn.Name = "EnrollStudentBtn";
            this.EnrollStudentBtn.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.EnrollStudentBtn.Size = new System.Drawing.Size(197, 41);
            this.EnrollStudentBtn.TabIndex = 3;
            this.EnrollStudentBtn.Text = "         Enroll Student";
            this.EnrollStudentBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EnrollStudentBtn.UseVisualStyleBackColor = true;
            this.EnrollStudentBtn.Click += new System.EventHandler(this.EnrollStudentBtn_Click);
            // 
            // SubjectBtn
            // 
            this.SubjectBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SubjectBtn.FlatAppearance.BorderSize = 0;
            this.SubjectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubjectBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubjectBtn.ForeColor = System.Drawing.Color.White;
            this.SubjectBtn.Image = ((System.Drawing.Image)(resources.GetObject("SubjectBtn.Image")));
            this.SubjectBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SubjectBtn.Location = new System.Drawing.Point(3, 133);
            this.SubjectBtn.Name = "SubjectBtn";
            this.SubjectBtn.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.SubjectBtn.Size = new System.Drawing.Size(197, 41);
            this.SubjectBtn.TabIndex = 4;
            this.SubjectBtn.Text = "         Subject";
            this.SubjectBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SubjectBtn.UseVisualStyleBackColor = true;
            this.SubjectBtn.Click += new System.EventHandler(this.SubjectBtn_Click);
            // 
            // SectionBtn
            // 
            this.SectionBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SectionBtn.FlatAppearance.BorderSize = 0;
            this.SectionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SectionBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SectionBtn.ForeColor = System.Drawing.Color.White;
            this.SectionBtn.Image = ((System.Drawing.Image)(resources.GetObject("SectionBtn.Image")));
            this.SectionBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SectionBtn.Location = new System.Drawing.Point(3, 180);
            this.SectionBtn.Name = "SectionBtn";
            this.SectionBtn.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.SectionBtn.Size = new System.Drawing.Size(197, 41);
            this.SectionBtn.TabIndex = 5;
            this.SectionBtn.Text = "         Section";
            this.SectionBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SectionBtn.UseVisualStyleBackColor = true;
            this.SectionBtn.Click += new System.EventHandler(this.SectionBtn_Click);
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 10;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick);
            // 
            // navbarContainer
            // 
            this.navbarContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(192)))), ((int)(((byte)(254)))));
            this.navbarContainer.Controls.Add(this.titleLb);
            this.navbarContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.navbarContainer.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navbarContainer.Location = new System.Drawing.Point(200, 0);
            this.navbarContainer.Name = "navbarContainer";
            this.navbarContainer.Size = new System.Drawing.Size(712, 40);
            this.navbarContainer.TabIndex = 0;
            // 
            // titleLb
            // 
            this.titleLb.AutoSize = true;
            this.titleLb.BackColor = System.Drawing.Color.Transparent;
            this.titleLb.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLb.ForeColor = System.Drawing.Color.White;
            this.titleLb.Location = new System.Drawing.Point(29, 10);
            this.titleLb.Name = "titleLb";
            this.titleLb.Size = new System.Drawing.Size(89, 21);
            this.titleLb.TabIndex = 0;
            this.titleLb.Text = "Dashboard";
            // 
            // containerRender
            // 
            this.containerRender.BackColor = System.Drawing.Color.White;
            this.containerRender.Dock = System.Windows.Forms.DockStyle.Fill;
            this.containerRender.Location = new System.Drawing.Point(200, 40);
            this.containerRender.Name = "containerRender";
            this.containerRender.Size = new System.Drawing.Size(712, 410);
            this.containerRender.TabIndex = 0;
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 450);
            this.Controls.Add(this.containerRender);
            this.Controls.Add(this.navbarContainer);
            this.Controls.Add(this.sidebar);
            this.Name = "StudentForm";
            this.Text = "Student Enrollment";
            this.sidebar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).EndInit();
            this.panel2.ResumeLayout(false);
            this.navbarContainer.ResumeLayout(false);
            this.navbarContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button NewStudentBtn;
        private System.Windows.Forms.Button EnrollStudentBtn;
        private System.Windows.Forms.Button SubjectBtn;
        private System.Windows.Forms.Button SectionBtn;
        private System.Windows.Forms.PictureBox menuButton;
        private System.Windows.Forms.Label menuTitle;
        private System.Windows.Forms.Timer sidebarTimer;
        private System.Windows.Forms.Panel navbarContainer;
        private System.Windows.Forms.Label titleLb;
        private System.Windows.Forms.Panel containerRender;
    }
}

