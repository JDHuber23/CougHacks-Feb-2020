namespace CougHacks_2020_February
{
    partial class MainGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainGUI));
            this.mainPicBoxMap = new System.Windows.Forms.PictureBox();
            this.main = new System.Windows.Forms.CheckedListBox();
            this.mainButtonAddAll = new System.Windows.Forms.Button();
            this.mainButtonRemALl = new System.Windows.Forms.Button();
            this.mainButtonSignIn = new System.Windows.Forms.Button();
            this.mainButtonSignUp = new System.Windows.Forms.Button();
            this.mainSplitContainerCategoryViewer = new System.Windows.Forms.SplitContainer();
            this.mainPanelLogin = new System.Windows.Forms.Panel();
            this.mainButtonCancelLogin = new System.Windows.Forms.Button();
            this.mainButtonSubmitAccount = new System.Windows.Forms.Button();
            this.mainLabelPasswordConfirm = new System.Windows.Forms.Label();
            this.mainTextPasswordConfirm = new System.Windows.Forms.TextBox();
            this.mainTextPassword = new System.Windows.Forms.TextBox();
            this.mainLabelPassword = new System.Windows.Forms.Label();
            this.mainLabelUsernamePrompt = new System.Windows.Forms.Label();
            this.mainTextUsername = new System.Windows.Forms.TextBox();
            this.mainPanelEvent = new System.Windows.Forms.Panel();
            this.mainLstBoxEventName = new System.Windows.Forms.ListBox();
            this.mainLstBoxInfo = new System.Windows.Forms.ListBox();
            this.mainButtonCancelApply = new System.Windows.Forms.Button();
            this.mainButtonApply = new System.Windows.Forms.Button();
            this.mainLabelInfoPROMPT = new System.Windows.Forms.Label();
            this.mainLabelEventPROMPT = new System.Windows.Forms.Label();
            this.mainPicIcon = new System.Windows.Forms.PictureBox();
            this.mainLabelUserPROMPT = new System.Windows.Forms.Label();
            this.mainLabelKudosPROMPT = new System.Windows.Forms.Label();
            this.mainLabelKudos = new System.Windows.Forms.Label();
            this.mainPictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.mainPanelHeader = new System.Windows.Forms.Panel();
            this.mainButtonEvents = new System.Windows.Forms.PictureBox();
            this.mainButtonExit = new System.Windows.Forms.Button();
            this.mainPicEvent1 = new System.Windows.Forms.PictureBox();
            this.mainPicEvent2 = new System.Windows.Forms.PictureBox();
            this.mainPicEvent3 = new System.Windows.Forms.PictureBox();
            this.mainPanelEventsMenu = new System.Windows.Forms.Panel();
            this.mainButtonEventsBack = new System.Windows.Forms.Button();
            this.mainButtonCreateEvent = new System.Windows.Forms.PictureBox();
            this.mainButtonMyApplications = new System.Windows.Forms.PictureBox();
            this.mainButtonMyEvents = new System.Windows.Forms.PictureBox();
            this.event5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.mainPicBoxMap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainerCategoryViewer)).BeginInit();
            this.mainSplitContainerCategoryViewer.Panel1.SuspendLayout();
            this.mainSplitContainerCategoryViewer.Panel2.SuspendLayout();
            this.mainSplitContainerCategoryViewer.SuspendLayout();
            this.mainPanelLogin.SuspendLayout();
            this.mainPanelEvent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainPicIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBoxLogo)).BeginInit();
            this.mainPanelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainButtonEvents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPicEvent1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPicEvent2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPicEvent3)).BeginInit();
            this.mainPanelEventsMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainButtonCreateEvent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainButtonMyApplications)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainButtonMyEvents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.event5)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPicBoxMap
            // 
            this.mainPicBoxMap.BackColor = System.Drawing.Color.Transparent;
            this.mainPicBoxMap.Image = ((System.Drawing.Image)(resources.GetObject("mainPicBoxMap.Image")));
            this.mainPicBoxMap.InitialImage = ((System.Drawing.Image)(resources.GetObject("mainPicBoxMap.InitialImage")));
            this.mainPicBoxMap.Location = new System.Drawing.Point(384, 208);
            this.mainPicBoxMap.Name = "mainPicBoxMap";
            this.mainPicBoxMap.Size = new System.Drawing.Size(1099, 652);
            this.mainPicBoxMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mainPicBoxMap.TabIndex = 0;
            this.mainPicBoxMap.TabStop = false;
            this.mainPicBoxMap.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mainPicBoxMap_MouseClick);
            // 
            // main
            // 
            this.main.BackColor = System.Drawing.Color.LightCyan;
            this.main.FormattingEnabled = true;
            this.main.Items.AddRange(new object[] {
            "Sports",
            "Music",
            "Gaming",
            "Hangout"});
            this.main.Location = new System.Drawing.Point(46, 53);
            this.main.Name = "main";
            this.main.Size = new System.Drawing.Size(280, 480);
            this.main.TabIndex = 0;
            this.main.Visible = false;
            // 
            // mainButtonAddAll
            // 
            this.mainButtonAddAll.BackColor = System.Drawing.Color.LightCyan;
            this.mainButtonAddAll.Location = new System.Drawing.Point(46, 20);
            this.mainButtonAddAll.Name = "mainButtonAddAll";
            this.mainButtonAddAll.Size = new System.Drawing.Size(280, 50);
            this.mainButtonAddAll.TabIndex = 0;
            this.mainButtonAddAll.Text = "Add All";
            this.mainButtonAddAll.UseVisualStyleBackColor = false;
            this.mainButtonAddAll.Visible = false;
            // 
            // mainButtonRemALl
            // 
            this.mainButtonRemALl.BackColor = System.Drawing.Color.LightCyan;
            this.mainButtonRemALl.Location = new System.Drawing.Point(46, 76);
            this.mainButtonRemALl.Name = "mainButtonRemALl";
            this.mainButtonRemALl.Size = new System.Drawing.Size(280, 50);
            this.mainButtonRemALl.TabIndex = 1;
            this.mainButtonRemALl.Text = "Remove All";
            this.mainButtonRemALl.UseVisualStyleBackColor = false;
            this.mainButtonRemALl.Visible = false;
            // 
            // mainButtonSignIn
            // 
            this.mainButtonSignIn.BackColor = System.Drawing.Color.LightCyan;
            this.mainButtonSignIn.Location = new System.Drawing.Point(46, 20);
            this.mainButtonSignIn.Name = "mainButtonSignIn";
            this.mainButtonSignIn.Size = new System.Drawing.Size(280, 50);
            this.mainButtonSignIn.TabIndex = 2;
            this.mainButtonSignIn.Text = "Log In";
            this.mainButtonSignIn.UseVisualStyleBackColor = false;
            this.mainButtonSignIn.Click += new System.EventHandler(this.mainLabelSignIn_Click);
            // 
            // mainButtonSignUp
            // 
            this.mainButtonSignUp.BackColor = System.Drawing.Color.LightCyan;
            this.mainButtonSignUp.Location = new System.Drawing.Point(46, 76);
            this.mainButtonSignUp.Name = "mainButtonSignUp";
            this.mainButtonSignUp.Size = new System.Drawing.Size(280, 50);
            this.mainButtonSignUp.TabIndex = 3;
            this.mainButtonSignUp.Text = "Sign Up";
            this.mainButtonSignUp.UseVisualStyleBackColor = false;
            this.mainButtonSignUp.Click += new System.EventHandler(this.mainButtonSignUp_Click);
            // 
            // mainSplitContainerCategoryViewer
            // 
            this.mainSplitContainerCategoryViewer.Location = new System.Drawing.Point(-2, 155);
            this.mainSplitContainerCategoryViewer.Name = "mainSplitContainerCategoryViewer";
            this.mainSplitContainerCategoryViewer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // mainSplitContainerCategoryViewer.Panel1
            // 
            this.mainSplitContainerCategoryViewer.Panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.mainSplitContainerCategoryViewer.Panel1.Controls.Add(this.mainButtonSignUp);
            this.mainSplitContainerCategoryViewer.Panel1.Controls.Add(this.mainButtonSignIn);
            this.mainSplitContainerCategoryViewer.Panel1.Controls.Add(this.mainButtonRemALl);
            this.mainSplitContainerCategoryViewer.Panel1.Controls.Add(this.mainButtonAddAll);
            // 
            // mainSplitContainerCategoryViewer.Panel2
            // 
            this.mainSplitContainerCategoryViewer.Panel2.BackColor = System.Drawing.Color.SkyBlue;
            this.mainSplitContainerCategoryViewer.Panel2.Controls.Add(this.main);
            this.mainSplitContainerCategoryViewer.Size = new System.Drawing.Size(380, 705);
            this.mainSplitContainerCategoryViewer.SplitterDistance = 125;
            this.mainSplitContainerCategoryViewer.TabIndex = 1;
            // 
            // mainPanelLogin
            // 
            this.mainPanelLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mainPanelLogin.BackgroundImage")));
            this.mainPanelLogin.Controls.Add(this.mainButtonCancelLogin);
            this.mainPanelLogin.Controls.Add(this.mainButtonSubmitAccount);
            this.mainPanelLogin.Controls.Add(this.mainLabelPasswordConfirm);
            this.mainPanelLogin.Controls.Add(this.mainTextPasswordConfirm);
            this.mainPanelLogin.Controls.Add(this.mainTextPassword);
            this.mainPanelLogin.Controls.Add(this.mainLabelPassword);
            this.mainPanelLogin.Controls.Add(this.mainLabelUsernamePrompt);
            this.mainPanelLogin.Controls.Add(this.mainTextUsername);
            this.mainPanelLogin.Location = new System.Drawing.Point(1, 152);
            this.mainPanelLogin.Name = "mainPanelLogin";
            this.mainPanelLogin.Size = new System.Drawing.Size(377, 708);
            this.mainPanelLogin.TabIndex = 3;
            this.mainPanelLogin.Visible = false;
            // 
            // mainButtonCancelLogin
            // 
            this.mainButtonCancelLogin.BackColor = System.Drawing.Color.LightCyan;
            this.mainButtonCancelLogin.Location = new System.Drawing.Point(195, 400);
            this.mainButtonCancelLogin.Name = "mainButtonCancelLogin";
            this.mainButtonCancelLogin.Size = new System.Drawing.Size(131, 48);
            this.mainButtonCancelLogin.TabIndex = 10;
            this.mainButtonCancelLogin.Text = "Cancel";
            this.mainButtonCancelLogin.UseVisualStyleBackColor = false;
            this.mainButtonCancelLogin.Click += new System.EventHandler(this.mainButtonCancelLogin_Click);
            // 
            // mainButtonSubmitAccount
            // 
            this.mainButtonSubmitAccount.BackColor = System.Drawing.Color.LightCyan;
            this.mainButtonSubmitAccount.Location = new System.Drawing.Point(46, 400);
            this.mainButtonSubmitAccount.Name = "mainButtonSubmitAccount";
            this.mainButtonSubmitAccount.Size = new System.Drawing.Size(131, 48);
            this.mainButtonSubmitAccount.TabIndex = 9;
            this.mainButtonSubmitAccount.Text = "Submit";
            this.mainButtonSubmitAccount.UseVisualStyleBackColor = false;
            this.mainButtonSubmitAccount.Click += new System.EventHandler(this.mainButtonSubmitAccount_Click);
            // 
            // mainLabelPasswordConfirm
            // 
            this.mainLabelPasswordConfirm.AutoSize = true;
            this.mainLabelPasswordConfirm.BackColor = System.Drawing.Color.Transparent;
            this.mainLabelPasswordConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainLabelPasswordConfirm.ForeColor = System.Drawing.Color.LightCyan;
            this.mainLabelPasswordConfirm.Location = new System.Drawing.Point(45, 301);
            this.mainLabelPasswordConfirm.Name = "mainLabelPasswordConfirm";
            this.mainLabelPasswordConfirm.Size = new System.Drawing.Size(296, 37);
            this.mainLabelPasswordConfirm.TabIndex = 8;
            this.mainLabelPasswordConfirm.Text = "Confirm Password";
            this.mainLabelPasswordConfirm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mainTextPasswordConfirm
            // 
            this.mainTextPasswordConfirm.Location = new System.Drawing.Point(46, 341);
            this.mainTextPasswordConfirm.Name = "mainTextPasswordConfirm";
            this.mainTextPasswordConfirm.PasswordChar = '*';
            this.mainTextPasswordConfirm.Size = new System.Drawing.Size(280, 31);
            this.mainTextPasswordConfirm.TabIndex = 7;
            // 
            // mainTextPassword
            // 
            this.mainTextPassword.Location = new System.Drawing.Point(46, 249);
            this.mainTextPassword.Name = "mainTextPassword";
            this.mainTextPassword.PasswordChar = '*';
            this.mainTextPassword.Size = new System.Drawing.Size(280, 31);
            this.mainTextPassword.TabIndex = 2;
            // 
            // mainLabelPassword
            // 
            this.mainLabelPassword.AutoSize = true;
            this.mainLabelPassword.BackColor = System.Drawing.Color.Transparent;
            this.mainLabelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainLabelPassword.ForeColor = System.Drawing.Color.LightCyan;
            this.mainLabelPassword.Location = new System.Drawing.Point(39, 209);
            this.mainLabelPassword.Name = "mainLabelPassword";
            this.mainLabelPassword.Size = new System.Drawing.Size(166, 37);
            this.mainLabelPassword.TabIndex = 6;
            this.mainLabelPassword.Text = "Password";
            this.mainLabelPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mainLabelUsernamePrompt
            // 
            this.mainLabelUsernamePrompt.AutoSize = true;
            this.mainLabelUsernamePrompt.BackColor = System.Drawing.Color.Transparent;
            this.mainLabelUsernamePrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainLabelUsernamePrompt.ForeColor = System.Drawing.Color.LightCyan;
            this.mainLabelUsernamePrompt.Location = new System.Drawing.Point(39, 118);
            this.mainLabelUsernamePrompt.Name = "mainLabelUsernamePrompt";
            this.mainLabelUsernamePrompt.Size = new System.Drawing.Size(172, 37);
            this.mainLabelUsernamePrompt.TabIndex = 5;
            this.mainLabelUsernamePrompt.Text = "Username";
            this.mainLabelUsernamePrompt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mainTextUsername
            // 
            this.mainTextUsername.Location = new System.Drawing.Point(46, 158);
            this.mainTextUsername.Name = "mainTextUsername";
            this.mainTextUsername.Size = new System.Drawing.Size(280, 31);
            this.mainTextUsername.TabIndex = 1;
            // 
            // mainPanelEvent
            // 
            this.mainPanelEvent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mainPanelEvent.BackgroundImage")));
            this.mainPanelEvent.Controls.Add(this.mainLstBoxEventName);
            this.mainPanelEvent.Controls.Add(this.mainLstBoxInfo);
            this.mainPanelEvent.Controls.Add(this.mainButtonCancelApply);
            this.mainPanelEvent.Controls.Add(this.mainButtonApply);
            this.mainPanelEvent.Controls.Add(this.mainLabelInfoPROMPT);
            this.mainPanelEvent.Controls.Add(this.mainLabelEventPROMPT);
            this.mainPanelEvent.Location = new System.Drawing.Point(1, 155);
            this.mainPanelEvent.Name = "mainPanelEvent";
            this.mainPanelEvent.Size = new System.Drawing.Size(374, 708);
            this.mainPanelEvent.TabIndex = 11;
            this.mainPanelEvent.Visible = false;
            // 
            // mainLstBoxEventName
            // 
            this.mainLstBoxEventName.FormattingEnabled = true;
            this.mainLstBoxEventName.ItemHeight = 25;
            this.mainLstBoxEventName.Location = new System.Drawing.Point(37, 79);
            this.mainLstBoxEventName.Name = "mainLstBoxEventName";
            this.mainLstBoxEventName.Size = new System.Drawing.Size(283, 104);
            this.mainLstBoxEventName.TabIndex = 12;
            // 
            // mainLstBoxInfo
            // 
            this.mainLstBoxInfo.FormattingEnabled = true;
            this.mainLstBoxInfo.ItemHeight = 25;
            this.mainLstBoxInfo.Location = new System.Drawing.Point(43, 268);
            this.mainLstBoxInfo.Name = "mainLstBoxInfo";
            this.mainLstBoxInfo.Size = new System.Drawing.Size(289, 354);
            this.mainLstBoxInfo.TabIndex = 11;
            // 
            // mainButtonCancelApply
            // 
            this.mainButtonCancelApply.BackColor = System.Drawing.Color.LightCyan;
            this.mainButtonCancelApply.Location = new System.Drawing.Point(207, 637);
            this.mainButtonCancelApply.Name = "mainButtonCancelApply";
            this.mainButtonCancelApply.Size = new System.Drawing.Size(131, 48);
            this.mainButtonCancelApply.TabIndex = 10;
            this.mainButtonCancelApply.Text = "Cancel";
            this.mainButtonCancelApply.UseVisualStyleBackColor = false;
            this.mainButtonCancelApply.Click += new System.EventHandler(this.mainButtonCancelApply_Click);
            // 
            // mainButtonApply
            // 
            this.mainButtonApply.BackColor = System.Drawing.Color.LightCyan;
            this.mainButtonApply.Location = new System.Drawing.Point(43, 637);
            this.mainButtonApply.Name = "mainButtonApply";
            this.mainButtonApply.Size = new System.Drawing.Size(131, 48);
            this.mainButtonApply.TabIndex = 9;
            this.mainButtonApply.Text = "Apply";
            this.mainButtonApply.UseVisualStyleBackColor = false;
            this.mainButtonApply.Click += new System.EventHandler(this.mainButtonApply_Click);
            // 
            // mainLabelInfoPROMPT
            // 
            this.mainLabelInfoPROMPT.AutoSize = true;
            this.mainLabelInfoPROMPT.BackColor = System.Drawing.Color.Transparent;
            this.mainLabelInfoPROMPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainLabelInfoPROMPT.ForeColor = System.Drawing.Color.LightCyan;
            this.mainLabelInfoPROMPT.Location = new System.Drawing.Point(30, 209);
            this.mainLabelInfoPROMPT.Name = "mainLabelInfoPROMPT";
            this.mainLabelInfoPROMPT.Size = new System.Drawing.Size(84, 37);
            this.mainLabelInfoPROMPT.TabIndex = 6;
            this.mainLabelInfoPROMPT.Text = "Info:";
            this.mainLabelInfoPROMPT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mainLabelEventPROMPT
            // 
            this.mainLabelEventPROMPT.AutoSize = true;
            this.mainLabelEventPROMPT.BackColor = System.Drawing.Color.Transparent;
            this.mainLabelEventPROMPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainLabelEventPROMPT.ForeColor = System.Drawing.Color.LightCyan;
            this.mainLabelEventPROMPT.Location = new System.Drawing.Point(30, 36);
            this.mainLabelEventPROMPT.Name = "mainLabelEventPROMPT";
            this.mainLabelEventPROMPT.Size = new System.Drawing.Size(112, 37);
            this.mainLabelEventPROMPT.TabIndex = 5;
            this.mainLabelEventPROMPT.Text = "Event:";
            this.mainLabelEventPROMPT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mainPicIcon
            // 
            this.mainPicIcon.Image = ((System.Drawing.Image)(resources.GetObject("mainPicIcon.Image")));
            this.mainPicIcon.Location = new System.Drawing.Point(14, 18);
            this.mainPicIcon.Name = "mainPicIcon";
            this.mainPicIcon.Size = new System.Drawing.Size(130, 121);
            this.mainPicIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mainPicIcon.TabIndex = 0;
            this.mainPicIcon.TabStop = false;
            // 
            // mainLabelUserPROMPT
            // 
            this.mainLabelUserPROMPT.AutoSize = true;
            this.mainLabelUserPROMPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainLabelUserPROMPT.ForeColor = System.Drawing.Color.LightCyan;
            this.mainLabelUserPROMPT.Location = new System.Drawing.Point(150, 18);
            this.mainLabelUserPROMPT.Name = "mainLabelUserPROMPT";
            this.mainLabelUserPROMPT.Size = new System.Drawing.Size(157, 55);
            this.mainLabelUserPROMPT.TabIndex = 1;
            this.mainLabelUserPROMPT.Text = "Guest";
            this.mainLabelUserPROMPT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mainLabelKudosPROMPT
            // 
            this.mainLabelKudosPROMPT.AutoSize = true;
            this.mainLabelKudosPROMPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainLabelKudosPROMPT.ForeColor = System.Drawing.Color.LightCyan;
            this.mainLabelKudosPROMPT.Location = new System.Drawing.Point(160, 75);
            this.mainLabelKudosPROMPT.Name = "mainLabelKudosPROMPT";
            this.mainLabelKudosPROMPT.Size = new System.Drawing.Size(123, 37);
            this.mainLabelKudosPROMPT.TabIndex = 2;
            this.mainLabelKudosPROMPT.Text = "Kudos:";
            this.mainLabelKudosPROMPT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mainLabelKudos
            // 
            this.mainLabelKudos.AutoSize = true;
            this.mainLabelKudos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainLabelKudos.ForeColor = System.Drawing.Color.LightCyan;
            this.mainLabelKudos.Location = new System.Drawing.Point(280, 75);
            this.mainLabelKudos.Name = "mainLabelKudos";
            this.mainLabelKudos.Size = new System.Drawing.Size(36, 37);
            this.mainLabelKudos.TabIndex = 3;
            this.mainLabelKudos.Text = "0";
            this.mainLabelKudos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mainPictureBoxLogo
            // 
            this.mainPictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("mainPictureBoxLogo.Image")));
            this.mainPictureBoxLogo.Location = new System.Drawing.Point(1016, 3);
            this.mainPictureBoxLogo.Name = "mainPictureBoxLogo";
            this.mainPictureBoxLogo.Size = new System.Drawing.Size(482, 162);
            this.mainPictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mainPictureBoxLogo.TabIndex = 4;
            this.mainPictureBoxLogo.TabStop = false;
            // 
            // mainPanelHeader
            // 
            this.mainPanelHeader.BackColor = System.Drawing.Color.RoyalBlue;
            this.mainPanelHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainPanelHeader.Controls.Add(this.mainButtonEvents);
            this.mainPanelHeader.Controls.Add(this.mainPicIcon);
            this.mainPanelHeader.Controls.Add(this.mainPictureBoxLogo);
            this.mainPanelHeader.Controls.Add(this.mainLabelKudos);
            this.mainPanelHeader.Controls.Add(this.mainLabelKudosPROMPT);
            this.mainPanelHeader.Controls.Add(this.mainLabelUserPROMPT);
            this.mainPanelHeader.Location = new System.Drawing.Point(-2, -6);
            this.mainPanelHeader.Name = "mainPanelHeader";
            this.mainPanelHeader.Size = new System.Drawing.Size(1498, 155);
            this.mainPanelHeader.TabIndex = 2;
            // 
            // mainButtonEvents
            // 
            this.mainButtonEvents.Image = ((System.Drawing.Image)(resources.GetObject("mainButtonEvents.Image")));
            this.mainButtonEvents.Location = new System.Drawing.Point(628, 18);
            this.mainButtonEvents.Name = "mainButtonEvents";
            this.mainButtonEvents.Size = new System.Drawing.Size(261, 121);
            this.mainButtonEvents.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mainButtonEvents.TabIndex = 5;
            this.mainButtonEvents.TabStop = false;
            this.mainButtonEvents.Click += new System.EventHandler(this.mainButtonEvents_Click);
            // 
            // mainButtonExit
            // 
            this.mainButtonExit.BackColor = System.Drawing.Color.LightCyan;
            this.mainButtonExit.Location = new System.Drawing.Point(12, 879);
            this.mainButtonExit.Name = "mainButtonExit";
            this.mainButtonExit.Size = new System.Drawing.Size(166, 48);
            this.mainButtonExit.TabIndex = 11;
            this.mainButtonExit.Text = "Exit";
            this.mainButtonExit.UseVisualStyleBackColor = false;
            this.mainButtonExit.Click += new System.EventHandler(this.mainButtonExit_Click);
            // 
            // mainPicEvent1
            // 
            this.mainPicEvent1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mainPicEvent1.Image = ((System.Drawing.Image)(resources.GetObject("mainPicEvent1.Image")));
            this.mainPicEvent1.Location = new System.Drawing.Point(1025, 480);
            this.mainPicEvent1.Name = "mainPicEvent1";
            this.mainPicEvent1.Size = new System.Drawing.Size(102, 99);
            this.mainPicEvent1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mainPicEvent1.TabIndex = 5;
            this.mainPicEvent1.TabStop = false;
            this.mainPicEvent1.Click += new System.EventHandler(this.mainPicEvent1_Click);
            // 
            // mainPicEvent2
            // 
            this.mainPicEvent2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mainPicEvent2.Image = ((System.Drawing.Image)(resources.GetObject("mainPicEvent2.Image")));
            this.mainPicEvent2.Location = new System.Drawing.Point(626, 540);
            this.mainPicEvent2.Name = "mainPicEvent2";
            this.mainPicEvent2.Size = new System.Drawing.Size(98, 90);
            this.mainPicEvent2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mainPicEvent2.TabIndex = 12;
            this.mainPicEvent2.TabStop = false;
            this.mainPicEvent2.Click += new System.EventHandler(this.mainPicEvent2_Click);
            // 
            // mainPicEvent3
            // 
            this.mainPicEvent3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mainPicEvent3.Image = ((System.Drawing.Image)(resources.GetObject("mainPicEvent3.Image")));
            this.mainPicEvent3.Location = new System.Drawing.Point(1187, 632);
            this.mainPicEvent3.Name = "mainPicEvent3";
            this.mainPicEvent3.Size = new System.Drawing.Size(58, 56);
            this.mainPicEvent3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mainPicEvent3.TabIndex = 13;
            this.mainPicEvent3.TabStop = false;
            this.mainPicEvent3.Click += new System.EventHandler(this.mainPicEvent3_Click);
            // 
            // mainPanelEventsMenu
            // 
            this.mainPanelEventsMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mainPanelEventsMenu.BackgroundImage")));
            this.mainPanelEventsMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainPanelEventsMenu.Controls.Add(this.event5);
            this.mainPanelEventsMenu.Controls.Add(this.mainButtonEventsBack);
            this.mainPanelEventsMenu.Controls.Add(this.mainButtonCreateEvent);
            this.mainPanelEventsMenu.Controls.Add(this.mainButtonMyApplications);
            this.mainPanelEventsMenu.Controls.Add(this.mainButtonMyEvents);
            this.mainPanelEventsMenu.Enabled = false;
            this.mainPanelEventsMenu.Location = new System.Drawing.Point(-2, 152);
            this.mainPanelEventsMenu.Name = "mainPanelEventsMenu";
            this.mainPanelEventsMenu.Size = new System.Drawing.Size(1495, 775);
            this.mainPanelEventsMenu.TabIndex = 14;
            this.mainPanelEventsMenu.Visible = false;
            // 
            // mainButtonEventsBack
            // 
            this.mainButtonEventsBack.Location = new System.Drawing.Point(14, 705);
            this.mainButtonEventsBack.Name = "mainButtonEventsBack";
            this.mainButtonEventsBack.Size = new System.Drawing.Size(172, 56);
            this.mainButtonEventsBack.TabIndex = 9;
            this.mainButtonEventsBack.Text = "Back";
            this.mainButtonEventsBack.UseVisualStyleBackColor = true;
            this.mainButtonEventsBack.Click += new System.EventHandler(this.mainButtonEventsBack_Click);
            // 
            // mainButtonCreateEvent
            // 
            this.mainButtonCreateEvent.BackColor = System.Drawing.Color.RoyalBlue;
            this.mainButtonCreateEvent.Image = ((System.Drawing.Image)(resources.GetObject("mainButtonCreateEvent.Image")));
            this.mainButtonCreateEvent.Location = new System.Drawing.Point(1098, 36);
            this.mainButtonCreateEvent.Name = "mainButtonCreateEvent";
            this.mainButtonCreateEvent.Size = new System.Drawing.Size(268, 150);
            this.mainButtonCreateEvent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mainButtonCreateEvent.TabIndex = 8;
            this.mainButtonCreateEvent.TabStop = false;
            this.mainButtonCreateEvent.Click += new System.EventHandler(this.mainButtonCreateEvent_Click);
            // 
            // mainButtonMyApplications
            // 
            this.mainButtonMyApplications.BackColor = System.Drawing.Color.RoyalBlue;
            this.mainButtonMyApplications.Image = ((System.Drawing.Image)(resources.GetObject("mainButtonMyApplications.Image")));
            this.mainButtonMyApplications.Location = new System.Drawing.Point(131, 39);
            this.mainButtonMyApplications.Name = "mainButtonMyApplications";
            this.mainButtonMyApplications.Size = new System.Drawing.Size(281, 147);
            this.mainButtonMyApplications.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mainButtonMyApplications.TabIndex = 7;
            this.mainButtonMyApplications.TabStop = false;
            // 
            // mainButtonMyEvents
            // 
            this.mainButtonMyEvents.BackColor = System.Drawing.Color.RoyalBlue;
            this.mainButtonMyEvents.Image = ((System.Drawing.Image)(resources.GetObject("mainButtonMyEvents.Image")));
            this.mainButtonMyEvents.Location = new System.Drawing.Point(612, 36);
            this.mainButtonMyEvents.Name = "mainButtonMyEvents";
            this.mainButtonMyEvents.Size = new System.Drawing.Size(277, 150);
            this.mainButtonMyEvents.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mainButtonMyEvents.TabIndex = 6;
            this.mainButtonMyEvents.TabStop = false;
            // 
            // event5
            // 
            this.event5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.event5.Image = ((System.Drawing.Image)(resources.GetObject("event5.Image")));
            this.event5.Location = new System.Drawing.Point(2000, 2000);
            this.event5.Name = "event5";
            this.event5.Size = new System.Drawing.Size(98, 90);
            this.event5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.event5.TabIndex = 13;
            this.event5.TabStop = false;
            // 
            // MainGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1495, 925);
            this.Controls.Add(this.mainPanelEventsMenu);
            this.Controls.Add(this.mainPicEvent3);
            this.Controls.Add(this.mainPicEvent2);
            this.Controls.Add(this.mainPanelEvent);
            this.Controls.Add(this.mainPicEvent1);
            this.Controls.Add(this.mainButtonExit);
            this.Controls.Add(this.mainPanelLogin);
            this.Controls.Add(this.mainPanelHeader);
            this.Controls.Add(this.mainSplitContainerCategoryViewer);
            this.Controls.Add(this.mainPicBoxMap);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1521, 996);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1521, 996);
            this.Name = "MainGUI";
            this.ShowIcon = false;
            this.Text = "ReachOut";
            this.Load += new System.EventHandler(this.MainGUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainPicBoxMap)).EndInit();
            this.mainSplitContainerCategoryViewer.Panel1.ResumeLayout(false);
            this.mainSplitContainerCategoryViewer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainerCategoryViewer)).EndInit();
            this.mainSplitContainerCategoryViewer.ResumeLayout(false);
            this.mainPanelLogin.ResumeLayout(false);
            this.mainPanelLogin.PerformLayout();
            this.mainPanelEvent.ResumeLayout(false);
            this.mainPanelEvent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainPicIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBoxLogo)).EndInit();
            this.mainPanelHeader.ResumeLayout(false);
            this.mainPanelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainButtonEvents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPicEvent1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPicEvent2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPicEvent3)).EndInit();
            this.mainPanelEventsMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainButtonCreateEvent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainButtonMyApplications)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainButtonMyEvents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.event5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox mainPicBoxMap;
        private System.Windows.Forms.CheckedListBox main;
        private System.Windows.Forms.Button mainButtonRemALl;
        private System.Windows.Forms.Button mainButtonSignIn;
        private System.Windows.Forms.Button mainButtonSignUp;
        private System.Windows.Forms.SplitContainer mainSplitContainerCategoryViewer;
        private System.Windows.Forms.Panel mainPanelLogin;
        private System.Windows.Forms.Label mainLabelUsernamePrompt;
        private System.Windows.Forms.TextBox mainTextPassword;
        private System.Windows.Forms.TextBox mainTextUsername;
        private System.Windows.Forms.PictureBox mainPicIcon;
        private System.Windows.Forms.Label mainLabelUserPROMPT;
        private System.Windows.Forms.Label mainLabelKudosPROMPT;
        private System.Windows.Forms.Label mainLabelKudos;
        private System.Windows.Forms.PictureBox mainPictureBoxLogo;
        private System.Windows.Forms.Panel mainPanelHeader;
        private System.Windows.Forms.Label mainLabelPassword;
        private System.Windows.Forms.Button mainButtonAddAll;
        private System.Windows.Forms.Label mainLabelPasswordConfirm;
        private System.Windows.Forms.TextBox mainTextPasswordConfirm;
        private System.Windows.Forms.Button mainButtonCancelLogin;
        private System.Windows.Forms.Button mainButtonSubmitAccount;
        private System.Windows.Forms.Button mainButtonExit;
        private System.Windows.Forms.Panel mainPanelEvent;
        private System.Windows.Forms.ListBox mainLstBoxEventName;
        private System.Windows.Forms.ListBox mainLstBoxInfo;
        private System.Windows.Forms.Button mainButtonCancelApply;
        private System.Windows.Forms.Button mainButtonApply;
        private System.Windows.Forms.Label mainLabelInfoPROMPT;
        private System.Windows.Forms.Label mainLabelEventPROMPT;
        private System.Windows.Forms.PictureBox mainPicEvent1;
        private System.Windows.Forms.PictureBox mainPicEvent2;
        private System.Windows.Forms.PictureBox mainPicEvent3;
        private System.Windows.Forms.PictureBox mainButtonEvents;
        private System.Windows.Forms.Panel mainPanelEventsMenu;
        private System.Windows.Forms.Button mainButtonEventsBack;
        private System.Windows.Forms.PictureBox mainButtonCreateEvent;
        private System.Windows.Forms.PictureBox mainButtonMyApplications;
        private System.Windows.Forms.PictureBox mainButtonMyEvents;
        private System.Windows.Forms.PictureBox event5;
    }
}

