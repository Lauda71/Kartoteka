namespace Kartoteka
{
    partial class mainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.panMenu = new System.Windows.Forms.Panel();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnStats = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnExportStuff = new System.Windows.Forms.Button();
            this.btnAddSources = new System.Windows.Forms.Button();
            this.btnDictionary = new System.Windows.Forms.Button();
            this.panMain = new System.Windows.Forms.Panel();
            this.panMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panMenu
            // 
            this.panMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panMenu.BackColor = System.Drawing.Color.OldLace;
            this.panMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panMenu.Controls.Add(this.btnHelp);
            this.panMenu.Controls.Add(this.btnStats);
            this.panMenu.Controls.Add(this.btnExit);
            this.panMenu.Controls.Add(this.btnSettings);
            this.panMenu.Controls.Add(this.btnExportStuff);
            this.panMenu.Controls.Add(this.btnAddSources);
            this.panMenu.Controls.Add(this.btnDictionary);
            this.panMenu.Location = new System.Drawing.Point(19, 19);
            this.panMenu.Margin = new System.Windows.Forms.Padding(10);
            this.panMenu.Name = "panMenu";
            this.panMenu.Size = new System.Drawing.Size(250, 723);
            this.panMenu.TabIndex = 0;
            // 
            // btnHelp
            // 
            this.btnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHelp.BackColor = System.Drawing.Color.Gainsboro;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHelp.ForeColor = System.Drawing.Color.Black;
            this.btnHelp.Location = new System.Drawing.Point(10, 358);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(10);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(228, 67);
            this.btnHelp.TabIndex = 4;
            this.btnHelp.Text = "Помощь";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.MainMenuBtn_Click);
            // 
            // btnStats
            // 
            this.btnStats.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStats.BackColor = System.Drawing.Color.Gainsboro;
            this.btnStats.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStats.ForeColor = System.Drawing.Color.Black;
            this.btnStats.Location = new System.Drawing.Point(10, 271);
            this.btnStats.Margin = new System.Windows.Forms.Padding(10);
            this.btnStats.Name = "btnStats";
            this.btnStats.Size = new System.Drawing.Size(228, 67);
            this.btnStats.TabIndex = 3;
            this.btnStats.Text = "Статистика";
            this.btnStats.UseVisualStyleBackColor = false;
            this.btnStats.Click += new System.EventHandler(this.MainMenuBtn_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.Gainsboro;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(10, 644);
            this.btnExit.Margin = new System.Windows.Forms.Padding(10);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(228, 67);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.MainMenuBtn_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSettings.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSettings.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnSettings.Location = new System.Drawing.Point(10, 557);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(10);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(228, 67);
            this.btnSettings.TabIndex = 5;
            this.btnSettings.Text = "Настройки";
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.MainMenuBtn_Click);
            // 
            // btnExportStuff
            // 
            this.btnExportStuff.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportStuff.BackColor = System.Drawing.Color.Gainsboro;
            this.btnExportStuff.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExportStuff.ForeColor = System.Drawing.Color.Black;
            this.btnExportStuff.Location = new System.Drawing.Point(10, 184);
            this.btnExportStuff.Margin = new System.Windows.Forms.Padding(10);
            this.btnExportStuff.Name = "btnExportStuff";
            this.btnExportStuff.Size = new System.Drawing.Size(228, 67);
            this.btnExportStuff.TabIndex = 2;
            this.btnExportStuff.Text = "Выгрузить материал";
            this.btnExportStuff.UseVisualStyleBackColor = false;
            this.btnExportStuff.Click += new System.EventHandler(this.MainMenuBtn_Click);
            // 
            // btnAddSources
            // 
            this.btnAddSources.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddSources.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAddSources.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddSources.ForeColor = System.Drawing.Color.Black;
            this.btnAddSources.Location = new System.Drawing.Point(10, 97);
            this.btnAddSources.Margin = new System.Windows.Forms.Padding(10);
            this.btnAddSources.Name = "btnAddSources";
            this.btnAddSources.Size = new System.Drawing.Size(228, 67);
            this.btnAddSources.TabIndex = 1;
            this.btnAddSources.Text = "Добавить источники";
            this.btnAddSources.UseVisualStyleBackColor = false;
            this.btnAddSources.Click += new System.EventHandler(this.MainMenuBtn_Click);
            // 
            // btnDictionary
            // 
            this.btnDictionary.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDictionary.BackColor = System.Drawing.Color.Gainsboro;
            this.btnDictionary.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDictionary.ForeColor = System.Drawing.Color.Black;
            this.btnDictionary.Location = new System.Drawing.Point(10, 10);
            this.btnDictionary.Margin = new System.Windows.Forms.Padding(10);
            this.btnDictionary.Name = "btnDictionary";
            this.btnDictionary.Size = new System.Drawing.Size(228, 67);
            this.btnDictionary.TabIndex = 0;
            this.btnDictionary.Text = "Главный архив";
            this.btnDictionary.UseVisualStyleBackColor = false;
            this.btnDictionary.Click += new System.EventHandler(this.MainMenuBtn_Click);
            // 
            // panMain
            // 
            this.panMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panMain.BackColor = System.Drawing.Color.White;
            this.panMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panMain.Location = new System.Drawing.Point(288, 19);
            this.panMain.Margin = new System.Windows.Forms.Padding(10);
            this.panMain.Name = "panMain";
            this.panMain.Size = new System.Drawing.Size(943, 723);
            this.panMain.TabIndex = 1;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1250, 761);
            this.Controls.Add(this.panMain);
            this.Controls.Add(this.panMenu);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О Т О В А Л Ь Н Я";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.SizeChanged += new System.EventHandler(this.mainForm_SizeChanged);
            this.panMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panMenu;
        private System.Windows.Forms.Button btnExportStuff;
        private System.Windows.Forms.Button btnAddSources;
        private System.Windows.Forms.Button btnDictionary;
        private System.Windows.Forms.Panel panMain;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnStats;
        private System.Windows.Forms.Button btnHelp;
    }
}

