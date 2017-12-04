using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KirbyBlowoutBlastSaveEditor
{
    public partial class Warning : Form
    {
        public Warning()
        {
            InitializeComponent();
        }

        Warning warningWindow = new Warning();

        private void button1_Click(object sender, EventArgs e)
        {
            warningWindow.Close();
        }
    }
}
