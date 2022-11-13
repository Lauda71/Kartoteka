namespace Kartoteka
{
    partial class ControlArchive
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panMain = new System.Windows.Forms.Panel();
            this.gbAllSearchWords = new System.Windows.Forms.GroupBox();
            this.btnShowAllWords = new System.Windows.Forms.Button();
            this.panAllWords = new System.Windows.Forms.Panel();
            this.labSearchWord = new System.Windows.Forms.Label();
            this.tbSearchWord = new System.Windows.Forms.TextBox();
            this.gbWordWork = new System.Windows.Forms.GroupBox();
            this.btnEditWord = new System.Windows.Forms.Button();
            this.btnDelWord = new System.Windows.Forms.Button();
            this.btnShareWord = new System.Windows.Forms.Button();
            this.labLanguage = new System.Windows.Forms.Label();
            this.cbLanguages = new System.Windows.Forms.ComboBox();
            this.btnAddWord = new System.Windows.Forms.Button();
            this.panMain.SuspendLayout();
            this.gbAllSearchWords.SuspendLayout();
            this.gbWordWork.SuspendLayout();
            this.SuspendLayout();
            // 
            // panMain
            // 
            this.panMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panMain.BackColor = System.Drawing.Color.Honeydew;
            this.panMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panMain.Controls.Add(this.gbAllSearchWords);
            this.panMain.Controls.Add(this.gbWordWork);
            this.panMain.Controls.Add(this.labLanguage);
            this.panMain.Controls.Add(this.cbLanguages);
            this.panMain.Controls.Add(this.btnAddWord);
            this.panMain.Location = new System.Drawing.Point(0, 0);
            this.panMain.Margin = new System.Windows.Forms.Padding(0);
            this.panMain.Name = "panMain";
            this.panMain.Size = new System.Drawing.Size(892, 723);
            this.panMain.TabIndex = 2;
            // 
            // gbAllSearchWords
            // 
            this.gbAllSearchWords.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbAllSearchWords.Controls.Add(this.btnShowAllWords);
            this.gbAllSearchWords.Controls.Add(this.panAllWords);
            this.gbAllSearchWords.Controls.Add(this.labSearchWord);
            this.gbAllSearchWords.Controls.Add(this.tbSearchWord);
            this.gbAllSearchWords.Location = new System.Drawing.Point(545, 10);
            this.gbAllSearchWords.Margin = new System.Windows.Forms.Padding(10);
            this.gbAllSearchWords.Name = "gbAllSearchWords";
            this.gbAllSearchWords.Size = new System.Drawing.Size(335, 601);
            this.gbAllSearchWords.TabIndex = 3;
            this.gbAllSearchWords.TabStop = false;
            this.gbAllSearchWords.Text = "Все слова";
            // 
            // btnShowAllWords
            // 
            this.btnShowAllWords.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowAllWords.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnShowAllWords.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShowAllWords.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnShowAllWords.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnShowAllWords.Location = new System.Drawing.Point(13, 521);
            this.btnShowAllWords.Margin = new System.Windows.Forms.Padding(10);
            this.btnShowAllWords.Name = "btnShowAllWords";
            this.btnShowAllWords.Size = new System.Drawing.Size(309, 67);
            this.btnShowAllWords.TabIndex = 10;
            this.btnShowAllWords.Text = "Смотреть все слова";
            this.btnShowAllWords.UseVisualStyleBackColor = false;
            // 
            // panAllWords
            // 
            this.panAllWords.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panAllWords.AutoScroll = true;
            this.panAllWords.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panAllWords.Location = new System.Drawing.Point(13, 87);
            this.panAllWords.Margin = new System.Windows.Forms.Padding(10);
            this.panAllWords.Name = "panAllWords";
            this.panAllWords.Size = new System.Drawing.Size(309, 408);
            this.panAllWords.TabIndex = 9;
            // 
            // labSearchWord
            // 
            this.labSearchWord.AutoSize = true;
            this.labSearchWord.Location = new System.Drawing.Point(11, 35);
            this.labSearchWord.Margin = new System.Windows.Forms.Padding(10);
            this.labSearchWord.Name = "labSearchWord";
            this.labSearchWord.Size = new System.Drawing.Size(74, 22);
            this.labSearchWord.TabIndex = 8;
            this.labSearchWord.Text = "Поиск:";
            // 
            // tbSearchWord
            // 
            this.tbSearchWord.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearchWord.Location = new System.Drawing.Point(105, 32);
            this.tbSearchWord.Margin = new System.Windows.Forms.Padding(10);
            this.tbSearchWord.Name = "tbSearchWord";
            this.tbSearchWord.Size = new System.Drawing.Size(217, 31);
            this.tbSearchWord.TabIndex = 7;
            // 
            // gbWordWork
            // 
            this.gbWordWork.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbWordWork.Controls.Add(this.btnEditWord);
            this.gbWordWork.Controls.Add(this.btnDelWord);
            this.gbWordWork.Controls.Add(this.btnShareWord);
            this.gbWordWork.Location = new System.Drawing.Point(10, 97);
            this.gbWordWork.Margin = new System.Windows.Forms.Padding(10);
            this.gbWordWork.Name = "gbWordWork";
            this.gbWordWork.Size = new System.Drawing.Size(515, 614);
            this.gbWordWork.TabIndex = 2;
            this.gbWordWork.TabStop = false;
            this.gbWordWork.Text = "Слово";
            // 
            // btnEditWord
            // 
            this.btnEditWord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditWord.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnEditWord.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditWord.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEditWord.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnEditWord.Location = new System.Drawing.Point(12, 551);
            this.btnEditWord.Margin = new System.Windows.Forms.Padding(10);
            this.btnEditWord.Name = "btnEditWord";
            this.btnEditWord.Size = new System.Drawing.Size(150, 50);
            this.btnEditWord.TabIndex = 4;
            this.btnEditWord.Text = "Изменить";
            this.btnEditWord.UseVisualStyleBackColor = false;
            // 
            // btnDelWord
            // 
            this.btnDelWord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelWord.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDelWord.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelWord.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelWord.ForeColor = System.Drawing.Color.Crimson;
            this.btnDelWord.Location = new System.Drawing.Point(352, 551);
            this.btnDelWord.Margin = new System.Windows.Forms.Padding(10);
            this.btnDelWord.Name = "btnDelWord";
            this.btnDelWord.Size = new System.Drawing.Size(150, 50);
            this.btnDelWord.TabIndex = 6;
            this.btnDelWord.Text = "Удалить";
            this.btnDelWord.UseVisualStyleBackColor = false;
            // 
            // btnShareWord
            // 
            this.btnShareWord.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShareWord.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnShareWord.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShareWord.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnShareWord.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnShareWord.Location = new System.Drawing.Point(182, 551);
            this.btnShareWord.Margin = new System.Windows.Forms.Padding(10);
            this.btnShareWord.Name = "btnShareWord";
            this.btnShareWord.Size = new System.Drawing.Size(150, 50);
            this.btnShareWord.TabIndex = 5;
            this.btnShareWord.Text = "Поделиться";
            this.btnShareWord.UseVisualStyleBackColor = false;
            // 
            // labLanguage
            // 
            this.labLanguage.AutoSize = true;
            this.labLanguage.Location = new System.Drawing.Point(10, 32);
            this.labLanguage.Margin = new System.Windows.Forms.Padding(10);
            this.labLanguage.Name = "labLanguage";
            this.labLanguage.Size = new System.Drawing.Size(152, 22);
            this.labLanguage.TabIndex = 1;
            this.labLanguage.Text = "Выберете язык:";
            // 
            // cbLanguages
            // 
            this.cbLanguages.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbLanguages.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLanguages.FormattingEnabled = true;
            this.cbLanguages.Location = new System.Drawing.Point(175, 29);
            this.cbLanguages.Name = "cbLanguages";
            this.cbLanguages.Size = new System.Drawing.Size(350, 30);
            this.cbLanguages.TabIndex = 0;
            // 
            // btnAddWord
            // 
            this.btnAddWord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddWord.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddWord.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddWord.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddWord.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnAddWord.Location = new System.Drawing.Point(545, 644);
            this.btnAddWord.Margin = new System.Windows.Forms.Padding(10);
            this.btnAddWord.Name = "btnAddWord";
            this.btnAddWord.Size = new System.Drawing.Size(335, 67);
            this.btnAddWord.TabIndex = 6;
            this.btnAddWord.Text = "Добавить новое слово";
            this.btnAddWord.UseVisualStyleBackColor = false;
            this.btnAddWord.Click += new System.EventHandler(this.btnAddWord_Click);
            // 
            // ControlArchive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.panMain);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "ControlArchive";
            this.Size = new System.Drawing.Size(892, 723);
            this.panMain.ResumeLayout(false);
            this.panMain.PerformLayout();
            this.gbAllSearchWords.ResumeLayout(false);
            this.gbAllSearchWords.PerformLayout();
            this.gbWordWork.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panMain;
        private System.Windows.Forms.GroupBox gbAllSearchWords;
        private System.Windows.Forms.Panel panAllWords;
        private System.Windows.Forms.Label labSearchWord;
        private System.Windows.Forms.TextBox tbSearchWord;
        private System.Windows.Forms.GroupBox gbWordWork;
        private System.Windows.Forms.Button btnEditWord;
        private System.Windows.Forms.Button btnDelWord;
        private System.Windows.Forms.Button btnShareWord;
        private System.Windows.Forms.Label labLanguage;
        private System.Windows.Forms.ComboBox cbLanguages;
        private System.Windows.Forms.Button btnAddWord;
        private System.Windows.Forms.Button btnShowAllWords;
    }
}
