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

        Panel pan;
        public ControlAddedFile(string fileName, int serialNumber, Panel pan)
        {
            InitializeComponent();
            // для удаления компонента
            this.mySerialNumber = serialNumber;
            this.pan = pan;

            labFileName.Text = fileName;
        }

        public void SetNewSerialNumber()
        {
            mySerialNumber--;
        }

        private void ControlAddedFile_Load(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(btnDelFile, "Удалить выбранный файл");
            tt.SetToolTip(labFileName, "Нажмите, чтобы открыть выбранный файл");
        }

        public int mySerialNumber;

        private void btnDelFile_Click(object sender, EventArgs e)
        {
            // если были добавлены еще файлы после удаляемого файла
            if (pan.Controls.Count - 1 > mySerialNumber)
            {
                for (int i = 0; i < pan.Controls.Count; i++)
                {
                    // смещение файлов вверх на место удаленного файла
                    if(i > mySerialNumber)
                    {
                        pan.Controls[i].Location = new Point(pan.Controls[i].Location.X, pan.Controls[i].Location.Y - 71);
                    }
                }
            }

            // установка новых (корректных после удаления контрола) номеров для удаления контролов
            StaticInfoClass.SettingNewSerialNumbers(mySerialNumber);

            pan.Controls[mySerialNumber].Dispose();
            pan.Update();
        }
    }
}
