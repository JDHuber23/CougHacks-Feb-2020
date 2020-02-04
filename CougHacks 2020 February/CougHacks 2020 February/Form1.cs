using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;
using System.IO;
using ReachOutdev;

namespace CougHacks_2020_February
{
    public partial class MainGUI : Form
    {
        SoundPlayer playerClick = new SoundPlayer(Properties.Resources.Click);
        SoundPlayer playerPop = new SoundPlayer(Properties.Resources.Pop);
        List<Graphics> graphicsList = new List<Graphics>();
        bool signedIn;
        AccountDriver accountDriver = new AccountDriver();
        EventDriver eventDriver = new EventDriver();
        int xPos;
        int yPos;


        public MainGUI()
        {
            InitializeComponent();
            
        }

        private void MainGUI_Load(object sender, EventArgs e)
        {
            accountDriver.ReadFromFile();
            eventDriver.ReadFromFile();
            signedIn = false;
        }

        private void ClickBoop()
        {

            playerClick.Play();

        }

        private void PopBoop()
        {
            playerPop.Play();
        }

        private void SignIn(Account account)
        {
            signedIn = true;
            mainLabelKudos.Text = Convert.ToString(account.Kudos);
            mainLabelUserPROMPT.Text = account.UserName;
        }

        //submit new account
        private void mainButtonSubmitAccount_Click(object sender, EventArgs e)
        {
            ClickBoop();
            BackToMainMenu();
            //signing in
            if (mainTextPasswordConfirm.Text.Equals(""))
            {
                Account signedInAccount = accountDriver.LogIn(mainTextUsername.Text, mainTextPassword.Text);
                mainTextUsername.Text = null;
                mainTextPassword.Text = null;
                mainTextPasswordConfirm.Text = null;
                SignIn(signedInAccount);
            }
            else
            {
                //creating account
                if (mainTextPassword.Text.Equals(mainTextPasswordConfirm.Text))
                {
                    //create account(username, password, kudo)
                    Account newAccount = new Account(mainTextUsername.Text, mainTextPassword.Text, 0);
                    mainTextUsername.Text = null;
                    mainTextPassword.Text = null;
                    mainTextPasswordConfirm.Text = null;
                    accountDriver.Insert(newAccount);
                    accountDriver.WriteToFile();
                }
            }
           
            //mainPicIcon.ImageLocation = @"Images\" + "ReachOUTlogo.png";
        }

        //brings to sign in screen
        private void mainLabelSignIn_Click(object sender, EventArgs e)
        {
            ClickBoop();
            SignInMenu();
        }

        private void mainButtonSignUp_Click(object sender, EventArgs e)
        {
            ClickBoop();
            SignInMenu();
            mainTextPasswordConfirm.Visible = true;
            mainTextPasswordConfirm.Enabled = true;
            mainLabelPasswordConfirm.Enabled = true;
            mainLabelPasswordConfirm.Visible = true;

        }

        private void mainPicEvent1_Click(object sender, EventArgs e)
        {
            PopBoop();
            EventInfoMenu(false);
        }

        private void mainPicEvent2_Click(object sender, EventArgs e)
        {
            PopBoop();
            EventInfoMenu(false);
        }

        private void mainPicEvent3_Click(object sender, EventArgs e)
        {
            PopBoop();
            EventInfoMenu(false);
        }

        private void mainButtonApply_Click(object sender, EventArgs e)
        {
            ClickBoop();
            BackToMainMenu();
        }

        private void mainButtonCancelApply_Click(object sender, EventArgs e)
        {
            ClickBoop();
            BackToMainMenu();
        }

        private void mainButtonCancelLogin_Click(object sender, EventArgs e)
        {
            ClickBoop();
            BackToMainMenu();
        }

        private void BackToMainMenu()
        {
            mainSplitContainerCategoryViewer.Visible = true;
            mainSplitContainerCategoryViewer.Enabled = true;
            mainPanelLogin.Enabled = false;
            mainPanelLogin.Visible = false;
            mainLabelPasswordConfirm.Enabled = false;
            mainLabelPasswordConfirm.Visible = false;
            mainTextPasswordConfirm.Visible = false;
            mainTextPasswordConfirm.Enabled = false;
            mainPanelEvent.Visible = false;
            mainPanelEvent.Enabled = false;
        }

        private void SignInMenu()
        {
            mainPanelEvent.Visible = false;
            mainPanelEvent.Enabled = false;
            mainPanelLogin.Visible = true;
            mainPanelLogin.Enabled = true;
            mainLabelPasswordConfirm.Enabled = false;
            mainLabelPasswordConfirm.Visible = false;
            mainTextPasswordConfirm.Visible = false;
            mainTextPasswordConfirm.Enabled = false;
            mainSplitContainerCategoryViewer.Visible = false;
            mainSplitContainerCategoryViewer.Enabled = false;
        }

        public void EventInfoMenu(bool isCreating)
        {
            mainPanelEvent.Visible = true;
            mainPanelEvent.Enabled = true;
            mainPanelLogin.Visible = false;
            mainPanelLogin.Enabled = false;
            mainSplitContainerCategoryViewer.Visible = false;
            mainSplitContainerCategoryViewer.Enabled = false;
        }

        public static System.Drawing.Point Position
        {
            get; set;
        }


        private void mainButtonExit_Click(object sender, EventArgs e)
        {
            accountDriver.WriteToFile();
            eventDriver.WriteToFile();
            Application.Exit();
        }

        private void mainButtonEventsBack_Click(object sender, EventArgs e)
        {
            ClickBoop();
            mainPanelEventsMenu.Enabled = false;
            mainPanelEventsMenu.Visible = false;
        }

        private void mainButtonEvents_Click(object sender, EventArgs e)
        {
            PopBoop();
            mainPanelEventsMenu.Enabled = true;
            mainPanelEventsMenu.Visible = true;
        }

        private void mainButtonCreateEvent_Click(object sender, EventArgs e)
        {
            ClickBoop();
            //make box
            CreateEvent newEventBox = new CreateEvent(new Tuple<int, int> (xPos, yPos), eventDriver);
            
            //brings us back
            EventInfoMenu(true);

            //show it
            newEventBox.Show();

            
        }

        private void mainPicBoxMap_MouseClick(object sender, MouseEventArgs e)
        {
            PopBoop();
            Point p = new Point(e.X, e.Y);
            xPos = p.X;
            yPos = p.Y;

        }
    }
}
