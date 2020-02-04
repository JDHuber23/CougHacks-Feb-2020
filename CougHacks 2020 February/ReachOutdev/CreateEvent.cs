using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReachOutdev;
using System.Media;
using System.IO;

namespace CougHacks_2020_February
{
    public partial class CreateEvent : Form
    {
        SoundPlayer playerClick = new SoundPlayer(Properties.Resources.Click);
        SoundPlayer playerPop = new SoundPlayer(Properties.Resources.Pop);
        public Event myEvent { get; set; }
        public EventDriver eventDriver;
        public Tuple<int, int> Location;
        public CreateEvent(Tuple<int,int> location, EventDriver eventDriver)
        {
            this.eventDriver = eventDriver;
            this.Location = location;
            InitializeComponent();

        }

        private void CreateEvent_Load(object sender, EventArgs e)
        {

        }

        private void ClickBoop()
        {

            playerClick.Play();

        }

        private void PopBoop()
        {
            playerPop.Play();
        }

        private void createButtonCont_Click(object sender, EventArgs e)
        {
            PopBoop();
            string name = createTextboxEventName.Text;
            DateTime dateTime = new DateTime(Convert.ToInt32(createComboYear.Text), Convert.ToInt32(createComboMonth.Text), 
                Convert.ToInt32(createComboDay.Text));
            string description = createTextboxDesc.Text;
            myEvent = new Event(name, dateTime, Location, "Dummy");
            myEvent.Description = description;
            eventDriver.Insert(myEvent);

            this.Close();
        }
    }
}
