using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace getQR
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            var hkey_open = new HotKey(Keys.Home, KeyModifiers.None);
            hkey_open.Pressed += (o, ev) => { new Form1().Show(); ev.Handled = true; };
            hkey_open.Register(this);

            var hkey_close = new HotKey(Keys.Home, KeyModifiers.Shift);
            hkey_close.Pressed += (o, ev) => { Application.Exit(); ev.Handled = true; };
            hkey_close.Register(this);
        }
    }
}
