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
    public partial class Diagnostics : Form
    {
        public Diagnostics()
        {
            InitializeComponent();
        }

        private void buttonCommBack_Click(object sender, EventArgs e)
        {

        }

        private void buttonDiagnosticsBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
