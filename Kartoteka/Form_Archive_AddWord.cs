using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kartoteka
{
    public partial class Form_Archive_AddWord : Form
    {
        public Form_Archive_AddWord()
        {
            InitializeComponent();
        }

        Color textColor = Color.Black;
        private void panTextColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                textColor = colorDialog.Color;
                panTextColor.BackColor = textColor;
            }
        }
    }
}
