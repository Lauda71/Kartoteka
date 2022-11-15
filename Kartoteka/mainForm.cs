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
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
            this.Width = 305;
            panMenu.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right| AnchorStyles.Bottom;
        }

        // для графических эффектов нажания на кнопки главного меню
        bool[] activePan;
        Button[] btns;

        private void mainForm_Load(object sender, EventArgs e)
        {
            btns = new Button[panMenu.Controls.Count];
            for (int i = 0; i < btns.Length; i++)
            {
                btns[i] = (Button)panMenu.Controls[i];
            }

            activePan = new bool[panMenu.Controls.Count];
            panMain.Visible = false;


            SetToolTips();
            this.Location = new Point(this.Location.X - 400, this.Location.Y);
            Logs.RegularLog("Запуск программы.");
        }

        // эффект нажатия кнопки
        private void BtnPress(object sender)
        {
            Button btn = (Button)sender;

            if(btn.BackColor == Color.Gainsboro)
            {
                for (int i = 0; i < btns.Length; i++)
                {
                    // 4 верхние кнопки главного меню
                    if (btns[i].BackColor != Color.Gainsboro && btns[i].TabIndex < 5)
                    {
                        btns[i].BackColor = Color.Gainsboro;
                        btns[i].ForeColor = Color.Black;
                    }
                    // Настройки
                    else if(btns[i].BackColor != Color.Gainsboro && btns[i].TabIndex == 5)
                    {
                        btns[i].BackColor = Color.Gainsboro;
                        btns[i].ForeColor = Color.DarkOrange;
                    }
                    // Выход
                    else if(btns[i].BackColor != Color.Gainsboro && btns[i].TabIndex == 6)
                    {
                        btns[i].BackColor = Color.Gainsboro;
                        btns[i].ForeColor = Color.Red;
                    }
                }

                Color
                    backColor = btn.BackColor,
                    foreColor = btn.ForeColor;

                btn.ForeColor = backColor;
                btn.BackColor = foreColor;
            }

            panMenu.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom;
            panMain.Visible = true;
        }

        #region [Нажатие кнопок]

        private void MainMenuBtn_Click(object sender, EventArgs e)
        {
            BtnPress(sender);

            if (activePan[((Button)sender).TabIndex] == false)
            {
                for (int i = 0; i < activePan.Length; i++)
                {
                    activePan[i] = false;
                }
                activePan[((Button)sender).TabIndex] = true;

                panMain.Controls.Clear();

                switch (((Button)sender).TabIndex)
                {
                    // Главный архив
                    case 0:
                        panMain.Controls.Add(new ControlArchive());
                        this.Width = 305 + StaticInfoClass.archiveControlWidth + 25;
                        break;

                    // Добавить источники
                    case 1:
                        panMain.Controls.Add(new ControlAddData());
                        this.Width = 305 + StaticInfoClass.addDataControlWidth + 25;
                        break;

                    // Выгрузить материал
                    case 2:

                        break;

                    // Статистика
                    case 3:

                        break;

                    // Помощь
                    case 4:

                        break;

                    // Настройки
                    case 5:

                        break;

                    // Выход
                    case 6:
                        Exit();
                        break;

                }
                if(panMain.Controls.Count>0)
                    panMain.Controls[0].Location = new Point(-1, -1);

                //this.CenterToScreen();
            }

            // для корректного отображения контролов
            if (panMain.Controls.Count > 0)
            {
                panMain.Controls[0].Size = panMain.Size;
            }
        }
        
        #endregion  

        // изменение размера панели на главной форме
        private void mainForm_SizeChanged(object sender, EventArgs e)
        {
            if(panMain.Controls.Count > 0)
            {
                panMain.Controls[0].Size = panMain.Size;
            }
        }

        // добавление подсказок
        private void SetToolTips()
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(btnDictionary, "Все добавленные слова");
            tt.SetToolTip(btnAddSources, "Добавление новых слова из внешних источников");
            tt.SetToolTip(btnExportStuff, "Выгрузка добавленных слова");
            tt.SetToolTip(btnStats, "Просмотр статистики работы с картотекой");
            tt.SetToolTip(btnHelp, "Вспомогательные сведения для работы с программой");

            tt.SetToolTip(btnSettings, "Настройки работы программы");
            tt.SetToolTip(btnExit, "Выход из приложения");
        }

        // безопасный выход из программы
        private void Exit()
        {
            this.Enabled = false;

            DialogResult result = MessageBox.Show(
                "Выйти из программы?",
                "Внимание!",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2,
                MessageBoxOptions.DefaultDesktopOnly);

            if (result == DialogResult.Yes)
            {
                // завершение всех процессов...

                Logs.RegularLog("Завершение работы.\n\n");
                Application.Exit();
            }
            else
            {
                // возврат кнопки в первоначальное состояние
                for (int i = 0; i < activePan.Length; i++)
                {
                    activePan[i] = false;
                }
                btns[2].BackColor = Color.Gainsboro;
                btns[2].ForeColor = Color.Red;
                
                this.Enabled = true;
                this.Activate();
            }
        }
    }
}
