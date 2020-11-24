using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace NuclearInterface
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {

            stateLabel.Text = "Reactor Meltdown";
            SoundPlayer player = new SoundPlayer(Properties.Resources.alert);
            player.Play();

            reactor1StateLabel.BackColor = Color.Red;
            reactor2StateLabel.BackColor = Color.Red;
            Refresh();
            Thread.Sleep(1000);

            reactor1StateLabel.BackColor = Color.White;
            reactor2StateLabel.BackColor = Color.White;
            Refresh();
            Thread.Sleep(1000);
        }


    }
}
