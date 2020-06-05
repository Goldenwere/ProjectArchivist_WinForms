using System;
using System.Windows.Forms;
using System.Media;

namespace ProjectArchivist
{
    /// <summary>
    /// The general message form is used primarily for notifying of successful script creation
    /// </summary>
    public partial class GeneralMessageForm : Form
    {
        /// <summary>
        /// Constructs the general message form with a message
        /// </summary>
        /// <param name="text">The message to display in the form</param>
        public GeneralMessageForm(string text)
        {
            InitializeComponent();
            Label_Status.Text = text;
            SoundPlayer sound = new SoundPlayer("sounds\\gabrielaraujo_powerup-success.wav");
            sound.Play();
        }

        /// <summary>
        /// The close button closes the window
        /// </summary>
        private void Button_Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
