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
        Form_main mainForm;
        public ControlAddData()
        {
            InitializeComponent();
        }
        public ControlAddData(Form_main mainForm)
        {
            InitializeComponent();

            this.mainForm = mainForm;

            
        }

        private void ControlAddData_Load(object sender, EventArgs e)
        {
            // okay...
        }


        List<string>
            filesPaths = StaticInfoClass.filesPaths,
            filesNames = StaticInfoClass.filesNames,
            alreadyAddedFiles = StaticInfoClass.alreadyAddedFiles;  
        

        // добавление новых файлов
        int
            controlsCountPanAdd,
            controlsCountPanDrag;

        private void btnStartExtraction_Click(object sender, EventArgs e)
        {
            Form_AnalysisDataFiles form = new Form_AnalysisDataFiles();
            form.ShowDialog();
        }

        private void btnAddFiles_Click(object sender, EventArgs e)
        {
            openFD = new OpenFileDialog();
            openFD.Filter = "Documents (*.doc, *.docx) | *.doc; *.docx";
            openFD.Title = "Выбор файла с данными...";
            openFD.Multiselect = true;

            if (openFD.ShowDialog(this) == DialogResult.OK)
            {
                alreadyAddedFiles.Clear();

                foreach (string file in openFD.FileNames)
                {
                    if (!filesPaths.Contains(file))
                    {
                        // добавление в List 
                        filesPaths.Add(file);   // имен файлов
                        filesNames.Add(file.Substring(file.LastIndexOf('\\') + 1)); // путей файлов

                        // добавление на панель
                        panAddedFiles.Controls.Add(new ControlAddedFile(filesNames[filesNames.Count - 1], filesNames.Count - 1, panAddedFiles));
                        StaticInfoClass.controlsFiles.Add( (ControlAddedFile)panAddedFiles.Controls[panAddedFiles.Controls.Count - 1]);
                        // немного магии, чтобы контрол добавлялся в нужное место...
                        if (controlsCountPanAdd == 0)
                            panAddedFiles.Controls[controlsCountPanAdd].Location = new Point(2, 5);
                        else
                            panAddedFiles.Controls[controlsCountPanAdd].Location = new Point(2, panAddedFiles.Controls[controlsCountPanAdd - 1].Location.Y + 71);
                        // конец магии
                        controlsCountPanAdd++;
                    }
                    else
                    {
                        alreadyAddedFiles.Add(file.Substring(file.LastIndexOf('\\') + 1));
                    }
                }

                if (alreadyAddedFiles.Count > 0)
                {
                    string temp = null;
                    foreach (string fileName in alreadyAddedFiles)
                    {
                        temp += fileName + "\n";
                    }
                    MessageBox.Show(
                    "Эти файлы уже выбраны:" + "\n\n" + temp,
                    "Дублирование файлов",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
                }
                mainForm.Activate();
            }
        }

        // перетаскивание файлов в область для добавления источников данных
        private void panDragFiles_DragDrop(object sender, DragEventArgs e)
        {
            alreadyAddedFiles.Clear();

            foreach (string wordFile in (string[])e.Data.GetData(DataFormats.FileDrop))
            {

                // провекра на то, является лифайла word-документом
                string temp = wordFile.Substring(wordFile.LastIndexOf('.') + 1);
                if ( temp == "doc" || temp == "docx")
                {
                    // проверка на то, добавлен ли уже файл (через OpenFileDialog)
                    if(!filesPaths.Contains(wordFile))
                    {
                        // файлы добавляются в списки
                        filesPaths.Add(wordFile);
                        filesNames.Add(wordFile.Substring(wordFile.LastIndexOf('\\') + 1));

                        // добавление на панель
                        panDragFiles.Controls.Add(new ControlAddedFile(filesNames[filesNames.Count - 1], filesNames.Count - 1, panDragFiles));
                        // немного магии, чтобы контрол добавлялся в нужное место...
                        if (controlsCountPanDrag == 0)
                            panDragFiles.Controls[controlsCountPanDrag].Location = new Point(2, 5);
                        else
                            panDragFiles.Controls[controlsCountPanDrag].Location = new Point(2, panDragFiles.Controls[controlsCountPanDrag - 1].Location.Y + 71);
                        // конец магии
                        controlsCountPanDrag++;
                    }
                    else
                    {
                        alreadyAddedFiles.Add(wordFile.Substring(wordFile.LastIndexOf('\\') + 1));
                    }
                }
            }

            if(alreadyAddedFiles.Count > 0)
            {
                string temp = null;
                foreach(string fileName in alreadyAddedFiles)
                {
                    temp += fileName + "\n";
                }
                MessageBox.Show(
                "Эти файлы уже выбраны:" + "\n\n" + temp,
                "Дублирование файлов",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
            }
            mainForm.Activate();

        }

        // эффект копирования на курсоре при перетаскивании фалойв
        private void panDragFiles_DragEnter(object sender, DragEventArgs e)
        {
            // 
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }


    }
}
