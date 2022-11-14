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
    public partial class ControlAddData : UserControl
    {
        public ControlAddData()
        {
            InitializeComponent();
        }

        private void ControlAddData_Load(object sender, EventArgs e)
        {
            // okay...
        }

        // добавление новых файлов
        private void btnAddFiles_Click(object sender, EventArgs e)
        {
            openFD = new OpenFileDialog();
            openFD.Filter = "Documents (*.doc, *.docx) | *.doc; *.docx";
            openFD.Title = "Выбор файла с данными...";

            if (openFD.ShowDialog(this) == DialogResult.OK)
            {
                // code...
            }
        }

        private void panDragFiles_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }
    }
}
