using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PUP_V2
{
    public partial class PUPGUI : Form
    {
        public PUPGUI()
        {
            InitializeComponent();
            // Set to true when deploying on the Raspberry Pi screen, or one of 1280x1080
            goFullscreen(false);
        }

        private Form activeForm = null;
        public void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            groupBox1.Controls.Add(childForm);
            groupBox1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        public void goFullscreen(bool fullscreen)
        {
            if (fullscreen)
            {
                this.WindowState = FormWindowState.Normal;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                this.Bounds = Screen.PrimaryScreen.Bounds;
            }
            else
            {
                // Leaving this part uncommented for now. When testing on the final screen, re-enable
                //this.WindowState = FormWindowState.Maximized;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                this.Size = new Size(1280,1080);
            }
        }

        private void buttonCharge_Click(object sender, EventArgs e)
        {
            openChildForm(new Charge());
        }

        private void buttonSatComm_Click(object sender, EventArgs e)
        {
            openChildForm(new SatelliteCommunication());
        }

        private void buttonTransport_Click(object sender, EventArgs e)
        {
            openChildForm(new TransportMode());
        }

        private void buttonDiagnostics_Click(object sender, EventArgs e)
        {
            openChildForm(new Diagnostics());
        }

        private void buttonEmergency_Click(object sender, EventArgs e)
        {
            openChildForm(new Emergency());
        }
    }
}
