namespace PersonnelDepartment
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuMainPage = new System.Windows.Forms.MenuStrip();
            this.sessionControl = new System.Windows.Forms.ToolStripMenuItem();
            this.changeUserSession = new System.Windows.Forms.ToolStripMenuItem();
            this.exitSession = new System.Windows.Forms.ToolStripMenuItem();
            this.operPage = new System.Windows.Forms.ToolStripMenuItem();
            this.schedulePage = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutPage = new System.Windows.Forms.ToolStripMenuItem();
            this.login = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.enterBtn = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.menuMainPage.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMainPage
            // 
            this.menuMainPage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sessionControl,
            this.operPage,
            this.schedulePage,
            this.aboutPage});
            this.menuMainPage.Location = new System.Drawing.Point(0, 0);
            this.menuMainPage.Name = "menuMainPage";
            this.menuMainPage.Size = new System.Drawing.Size(1350, 24);
            this.menuMainPage.TabIndex = 1;
            this.menuMainPage.Text = "Главное меню";
            // 
            // sessionControl
            // 
            this.sessionControl.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeUserSession,
            this.exitSession});
            this.sessionControl.Name = "sessionControl";
            this.sessionControl.Size = new System.Drawing.Size(58, 20);
            this.sessionControl.Text = "Сессия";
            // 
            // changeUserSession
            // 
            this.changeUserSession.Name = "changeUserSession";
            this.changeUserSession.Size = new System.Drawing.Size(200, 22);
            this.changeUserSession.Text = "Сменить пользователя";
            this.changeUserSession.Click += new System.EventHandler(this.changeUserSession_Click);
            // 
            // exitSession
            // 
            this.exitSession.Name = "exitSession";
            this.exitSession.Size = new System.Drawing.Size(200, 22);
            this.exitSession.Text = "Выход";
            this.exitSession.Click += new System.EventHandler(this.exitSession_Click);
            // 
            // operPage
            // 
            this.operPage.Name = "operPage";
            this.operPage.Size = new System.Drawing.Size(130, 20);
            this.operPage.Text = "Кадровые операции";
            this.operPage.Click += new System.EventHandler(this.operPage_Click);
            // 
            // schedulePage
            // 
            this.schedulePage.Name = "schedulePage";
            this.schedulePage.Size = new System.Drawing.Size(84, 20);
            this.schedulePage.Text = "Расписание";
            this.schedulePage.Click += new System.EventHandler(this.schedulePage_Click);
            // 
            // aboutPage
            // 
            this.aboutPage.Name = "aboutPage";
            this.aboutPage.Size = new System.Drawing.Size(94, 20);
            this.aboutPage.Text = "О программе";
            this.aboutPage.Click += new System.EventHandler(this.aboutPage_Click);
            // 
            // login
            // 
            this.login.ForeColor = System.Drawing.SystemColors.WindowText;
            this.login.Location = new System.Drawing.Point(546, 366);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(183, 20);
            this.login.TabIndex = 0;
            this.login.Text = "Логин";
            this.login.TextChanged += new System.EventHandler(this.login_TextChanged);
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(546, 406);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(183, 20);
            this.pass.TabIndex = 1;
            this.pass.Text = "Пароль";
            // 
            // enterBtn
            // 
            this.enterBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("enterBtn.BackgroundImage")));
            this.enterBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.enterBtn.Image = ((System.Drawing.Image)(resources.GetObject("enterBtn.Image")));
            this.enterBtn.Location = new System.Drawing.Point(746, 373);
            this.enterBtn.Name = "enterBtn";
            this.enterBtn.Size = new System.Drawing.Size(46, 45);
            this.enterBtn.TabIndex = 2;
            this.enterBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.enterBtn.UseVisualStyleBackColor = true;
            this.enterBtn.Click += new System.EventHandler(this.enterBtn_Click);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.Transparent;
            this.panelMain.BackgroundImage = global::PersonnelDepartment.Properties.Resources.otdel_kadrov_linejka;
            this.panelMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelMain.Controls.Add(this.enterBtn);
            this.panelMain.Controls.Add(this.pass);
            this.panelMain.Controls.Add(this.login);
            this.panelMain.Location = new System.Drawing.Point(1, 25);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1350, 509);
            this.panelMain.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1350, 730);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.menuMainPage);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuMainPage;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "АИС \"Отдел кадров\"";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuMainPage.ResumeLayout(false);
            this.menuMainPage.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMainPage;
        private System.Windows.Forms.ToolStripMenuItem sessionControl;
        private System.Windows.Forms.ToolStripMenuItem changeUserSession;
        private System.Windows.Forms.ToolStripMenuItem exitSession;
        private System.Windows.Forms.ToolStripMenuItem schedulePage;
        private System.Windows.Forms.ToolStripMenuItem aboutPage;
        private System.Windows.Forms.ToolStripMenuItem operPage;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.Button enterBtn;
        private System.Windows.Forms.Panel panelMain;
    }
}

