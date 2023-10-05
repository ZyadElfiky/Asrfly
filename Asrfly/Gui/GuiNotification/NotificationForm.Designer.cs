namespace Asrfly.Gui.GuiNotification
{
    partial class NotificationForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelNotificationTitle = new System.Windows.Forms.Label();
            this.timerNotification = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::Asrfly.Properties.Resources.Notification_2;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelNotificationTitle
            // 
            this.labelNotificationTitle.BackColor = System.Drawing.Color.DarkOrange;
            this.labelNotificationTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelNotificationTitle.ForeColor = System.Drawing.Color.White;
            this.labelNotificationTitle.Location = new System.Drawing.Point(100, 0);
            this.labelNotificationTitle.Name = "labelNotificationTitle";
            this.labelNotificationTitle.Size = new System.Drawing.Size(341, 69);
            this.labelNotificationTitle.TabIndex = 1;
            this.labelNotificationTitle.Text = "تفاصيل الاشعار";
            this.labelNotificationTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelNotificationTitle.Click += new System.EventHandler(this.labelNotificationTitle_Click);
            // 
            // timerNotification
            // 
            this.timerNotification.Enabled = true;
            this.timerNotification.Interval = 3000;
            this.timerNotification.Tick += new System.EventHandler(this.timerNotification_Tick);
            // 
            // NotificationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 69);
            this.Controls.Add(this.labelNotificationTitle);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "NotificationForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "NotificationForm";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox1;
        public Label labelNotificationTitle;
        private System.Windows.Forms.Timer timerNotification;
    }
}