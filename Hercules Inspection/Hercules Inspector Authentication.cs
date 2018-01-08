using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hercules_Inspection
{
    public partial class Hercules_Inspector_Authentication : Form
    {
        public Hercules_Inspector_Authentication()
        {
            InitializeComponent();
        }

        public bool loginSuccessfull = false;

        private void Hercules_Inspector_Authentication_Load(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            loginSuccessfull = true;
            this.Close();
        }
    }
}
