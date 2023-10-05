namespace Asrfly.Gui.HomeGui
{
    partial class HomeUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonAddOutcome = new System.Windows.Forms.Button();
            this.buttonAddIncome = new System.Windows.Forms.Button();
            this.buttonUser = new System.Windows.Forms.Button();
            this.buttonAddProject = new System.Windows.Forms.Button();
            this.buttonAddSupplier = new System.Windows.Forms.Button();
            this.buttonAddCustomer = new System.Windows.Forms.Button();
            this.buttonAddCategory = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.labelCompanyName = new System.Windows.Forms.Label();
            this.labelWellcome = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 405);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1264, 203);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::Asrfly.Properties.Resources.Smart_1;
            this.pictureBox1.Location = new System.Drawing.Point(480, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.buttonAddOutcome);
            this.groupBox1.Controls.Add(this.buttonAddIncome);
            this.groupBox1.Controls.Add(this.buttonUser);
            this.groupBox1.Controls.Add(this.buttonAddProject);
            this.groupBox1.Controls.Add(this.buttonAddSupplier);
            this.groupBox1.Controls.Add(this.buttonAddCustomer);
            this.groupBox1.Controls.Add(this.buttonAddCategory);
            this.groupBox1.Location = new System.Drawing.Point(53, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1175, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "اضافة  ";
            // 
            // buttonAddOutcome
            // 
            this.buttonAddOutcome.Image = global::Asrfly.Properties.Resources.Input;
            this.buttonAddOutcome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddOutcome.Location = new System.Drawing.Point(56, 38);
            this.buttonAddOutcome.Margin = new System.Windows.Forms.Padding(5);
            this.buttonAddOutcome.Name = "buttonAddOutcome";
            this.buttonAddOutcome.Size = new System.Drawing.Size(141, 46);
            this.buttonAddOutcome.TabIndex = 7;
            this.buttonAddOutcome.Text = "قبض";
            this.buttonAddOutcome.UseVisualStyleBackColor = true;
            // 
            // buttonAddIncome
            // 
            this.buttonAddIncome.Image = global::Asrfly.Properties.Resources.Output;
            this.buttonAddIncome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddIncome.Location = new System.Drawing.Point(211, 38);
            this.buttonAddIncome.Margin = new System.Windows.Forms.Padding(5);
            this.buttonAddIncome.Name = "buttonAddIncome";
            this.buttonAddIncome.Size = new System.Drawing.Size(141, 46);
            this.buttonAddIncome.TabIndex = 6;
            this.buttonAddIncome.Text = "صرف ";
            this.buttonAddIncome.UseVisualStyleBackColor = true;
            // 
            // buttonUser
            // 
            this.buttonUser.Image = global::Asrfly.Properties.Resources.Users;
            this.buttonUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUser.Location = new System.Drawing.Point(366, 38);
            this.buttonUser.Margin = new System.Windows.Forms.Padding(5);
            this.buttonUser.Name = "buttonUser";
            this.buttonUser.Size = new System.Drawing.Size(141, 46);
            this.buttonUser.TabIndex = 5;
            this.buttonUser.Text = "مستخدم";
            this.buttonUser.UseVisualStyleBackColor = true;
            // 
            // buttonAddProject
            // 
            this.buttonAddProject.Image = global::Asrfly.Properties.Resources.Project_Management;
            this.buttonAddProject.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddProject.Location = new System.Drawing.Point(521, 38);
            this.buttonAddProject.Margin = new System.Windows.Forms.Padding(5);
            this.buttonAddProject.Name = "buttonAddProject";
            this.buttonAddProject.Size = new System.Drawing.Size(141, 46);
            this.buttonAddProject.TabIndex = 4;
            this.buttonAddProject.Text = "مشروع";
            this.buttonAddProject.UseVisualStyleBackColor = true;
            // 
            // buttonAddSupplier
            // 
            this.buttonAddSupplier.Image = global::Asrfly.Properties.Resources.Conference;
            this.buttonAddSupplier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddSupplier.Location = new System.Drawing.Point(676, 38);
            this.buttonAddSupplier.Margin = new System.Windows.Forms.Padding(5);
            this.buttonAddSupplier.Name = "buttonAddSupplier";
            this.buttonAddSupplier.Size = new System.Drawing.Size(141, 46);
            this.buttonAddSupplier.TabIndex = 3;
            this.buttonAddSupplier.Text = "مورد";
            this.buttonAddSupplier.UseVisualStyleBackColor = true;
            // 
            // buttonAddCustomer
            // 
            this.buttonAddCustomer.Image = global::Asrfly.Properties.Resources.People;
            this.buttonAddCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddCustomer.Location = new System.Drawing.Point(831, 38);
            this.buttonAddCustomer.Margin = new System.Windows.Forms.Padding(5);
            this.buttonAddCustomer.Name = "buttonAddCustomer";
            this.buttonAddCustomer.Size = new System.Drawing.Size(141, 46);
            this.buttonAddCustomer.TabIndex = 2;
            this.buttonAddCustomer.Text = "عميل";
            this.buttonAddCustomer.UseVisualStyleBackColor = true;
            // 
            // buttonAddCategory
            // 
            this.buttonAddCategory.Image = global::Asrfly.Properties.Resources.Categorize_1;
            this.buttonAddCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddCategory.Location = new System.Drawing.Point(986, 38);
            this.buttonAddCategory.Margin = new System.Windows.Forms.Padding(5);
            this.buttonAddCategory.Name = "buttonAddCategory";
            this.buttonAddCategory.Size = new System.Drawing.Size(141, 46);
            this.buttonAddCategory.TabIndex = 1;
            this.buttonAddCategory.Text = "صنف";
            this.buttonAddCategory.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cairo", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(574, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "الوصول السريع";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.AutoSize = true;
            this.panel4.Controls.Add(this.pictureLogo);
            this.panel4.Controls.Add(this.labelCompanyName);
            this.panel4.Location = new System.Drawing.Point(809, 16);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(396, 137);
            this.panel4.TabIndex = 1;
            // 
            // pictureLogo
            // 
            this.pictureLogo.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureLogo.Image = global::Asrfly.Properties.Resources.Smart_1;
            this.pictureLogo.Location = new System.Drawing.Point(288, 0);
            this.pictureLogo.Margin = new System.Windows.Forms.Padding(0);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(108, 137);
            this.pictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureLogo.TabIndex = 6;
            this.pictureLogo.TabStop = false;
            // 
            // labelCompanyName
            // 
            this.labelCompanyName.Font = new System.Drawing.Font("Cairo", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCompanyName.Location = new System.Drawing.Point(1, 18);
            this.labelCompanyName.Margin = new System.Windows.Forms.Padding(0);
            this.labelCompanyName.Name = "labelCompanyName";
            this.labelCompanyName.Size = new System.Drawing.Size(287, 103);
            this.labelCompanyName.TabIndex = 5;
            this.labelCompanyName.Text = "الوصول السريع";
            this.labelCompanyName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelWellcome
            // 
            this.labelWellcome.Font = new System.Drawing.Font("Cairo", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWellcome.Location = new System.Drawing.Point(10, 16);
            this.labelWellcome.Margin = new System.Windows.Forms.Padding(0);
            this.labelWellcome.Name = "labelWellcome";
            this.labelWellcome.Size = new System.Drawing.Size(224, 121);
            this.labelWellcome.TabIndex = 6;
            this.labelWellcome.Text = "مرحبا بك زياد الفقي";
            this.labelWellcome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // HomeUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.labelWellcome);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.Name = "HomeUserControl";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(1264, 608);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAddCategory;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonAddSupplier;
        private System.Windows.Forms.Button buttonAddCustomer;
        private System.Windows.Forms.Button buttonAddOutcome;
        private System.Windows.Forms.Button buttonAddIncome;
        private System.Windows.Forms.Button buttonUser;
        private System.Windows.Forms.Button buttonAddProject;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label labelCompanyName;
        private System.Windows.Forms.PictureBox pictureLogo;
        private System.Windows.Forms.Label labelWellcome;
    }
}
