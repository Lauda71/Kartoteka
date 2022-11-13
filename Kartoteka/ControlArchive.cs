using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Data.OleDb;
//using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kartoteka
{
    public partial class ControlArchive : UserControl
    {
        public ControlArchive()
        {
            InitializeComponent();

            SetLanguages();
            // rtb - сделать отдельный контрол с методами для редактирования(форматирования) выделенного текста
        }

        private void btnAddWord_Click(object sender, EventArgs e)
        {
            Form_Archive_AddWord aaw = new Form_Archive_AddWord();
            aaw.ShowDialog();
        }

        DataSet dataSet;

        // для отображения слов выбранного языка
        List<int> idLanguages = new List<int>();
        
        List<string> languages = new List<string>();
        private void SetLanguages()
        {
            dataSet = DBInteraction.GetLanguages();

            if(dataSet!=null)
            {
                // заполнение коллекции ID языков (для отображения всех слов языка)
                for (int i = 0; i < dataSet.Tables["Languages"].Rows.Count; i++)
                {
                    idLanguages.Add(Convert.ToInt32(dataSet.Tables["Languages"].Rows[i].ItemArray[0]));
                }

                // заполнение коллекции языков (для выбора языка)
                for (int i = 0; i < dataSet.Tables["Languages"].Rows.Count; i++)
                {
                    languages.Add(Convert.ToString(dataSet.Tables["Languages"].Rows[i].ItemArray[1]));
                }

                cbLanguages.Items.AddRange(languages.ToArray());
            }
        }
    }
}
