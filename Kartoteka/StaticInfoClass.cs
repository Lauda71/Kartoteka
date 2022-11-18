using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kartoteka
{
    public static class StaticInfoClass
    {
        // для корректного изменения ширины главной формы
        static ControlArchive arch = new ControlArchive();
        static ControlAddData add = new ControlAddData();
        
        public static int 
            archiveControlWidth = arch.Width,
            addDataControlWidth = add.Width;


        // для корректного отображения контролов после удаления word-файлоф
        public static List<ControlAddedFile> controlsFiles = new List<ControlAddedFile>();

        public static List<string>
            filesPaths = new List<string>(),    // полные пути файлов
            filesNames = new List<string>(),    // названия файлов
            alreadyAddedFiles = new List<string>(); // уже выбранные файлы

        public static void SettingNewSerialNumbers(int delSerNum)
        {
            for (int i = 0; i < controlsFiles.Count; i++)
            {
                if (i > delSerNum)
                    controlsFiles[i].SetNewSerialNumber();
            }
            // удаление ???
            //controlsFiles[delSerNum].del
        }


    }
}
