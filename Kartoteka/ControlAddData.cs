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

        List<string> 
            filesPaths = new List<string>(),
            filesNames = new List<string>();

        // добавление новых файлов
        int controlsCount;
        private void btnAddFiles_Click(object sender, EventArgs e)
        {
            openFD = new OpenFileDialog();
            openFD.Filter = "Documents (*.doc, *.docx) | *.doc; *.docx";
            openFD.Title = "Выбор файла с данными...";
            openFD.Multiselect = true;

            if (openFD.ShowDialog(this) == DialogResult.OK)
            {
                foreach (string file in openFD.FileNames)
                {
                    // добавление в List 
                    filesPaths.Add(file);   // имен файлов
                    filesNames.Add(file.Substring(file.LastIndexOf('\\') + 1)); // путей файлов

                    panAddedFiles.Controls.Add(new ControlAddedFile(filesNames[controlsCount]));
                    // немного магии, чтобы контрол добавлялся в нужное место...
                    if (controlsCount == 0)
                        panAddedFiles.Controls[controlsCount].Location = new Point(2, 5);
                    else
                        panAddedFiles.Controls[controlsCount].Location = new Point(2, panAddedFiles.Controls[controlsCount - 1].Location.Y + 71);
                    // конец магии
                    controlsCount++;
                }
            }
        }

        private void panDragFiles_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }
    }
}
