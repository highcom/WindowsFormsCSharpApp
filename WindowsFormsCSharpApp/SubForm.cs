using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsCSharpApp
{
    public delegate void UpdateTextDelegate(string message);

    public partial class SubForm : Form
    {
        public event UpdateTextDelegate updateTextDelegate;
        public SubForm()
        {
            InitializeComponent();
        }

        private void MainUpdateBtton_Click(object sender, EventArgs e)
        {
            updateTextDelegate("Update from SubForm!");
        }
    }
}
