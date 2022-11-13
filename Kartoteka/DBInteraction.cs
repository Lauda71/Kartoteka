using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

namespace Kartoteka
{
    static class DBInteraction
    {
        static string connectionString = @"provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Kartoteka\LocalDB\Kartoteka.mdb";

        //OleDbConnection con;
        static OleDbDataAdapter dataAdapter;
        static OleDbCommand command;
        static DataSet dataSet;

        //??
        static public void StartConnection()
        {
            try
            {
                //OleDbConnection dbConnection = new OleDbConnection(connectionString);

                using(OleDbConnection dbCon = new OleDbConnection(connectionString))
                {
                    dataAdapter = new OleDbDataAdapter("SELECT * FROM Languages", dbCon);
                    dataSet = new DataSet();
                    dataAdapter.Fill(dataSet, "Languages");
                }
            }
            catch (Exception ex)
            {
                MessageBoxErrorShow();
                Logs.ErrorLog(ex.ToString());
            }

        }

        static public DataSet GetLanguages()
        {
            try
            {
                using (OleDbConnection dbCon = new OleDbConnection(connectionString))
                {
                    dataAdapter = new OleDbDataAdapter("SELECT * FROM Languages", dbCon);
                    dataSet = new DataSet();
                    dataAdapter.Fill(dataSet, "Languages");
                }

                return dataSet;
            }
            catch (Exception ex)
            {
                Logs.ErrorLog(ex.ToString());
                MessageBoxErrorShow();
                return null;
            }
        }

        static public void MessageBoxErrorShow()
        {
            MessageBox.Show(
                    "Сбой при работе с БД.",
                    "Ошибка!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
        }
    }
}
