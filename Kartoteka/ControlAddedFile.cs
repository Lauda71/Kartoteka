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
    public partial class ControlAddedFile : UserControl
    {
        public ControlAddedFile()
        {
            InitializeComponent();
        }

        public ControlAddedFile(string fileName)
        {
            InitializeComponent();

            labFileName.Text = fileName;
        }

        private void ControlAddedFile_Load(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(btnDelFile, "Удалить выбранный файл");
            tt.SetToolTip(labFileName, "Нажмите, чтобы открыть выбранный файл");
        }
    }
}
