
namespace Kartoteka
{
    partial class ControlAddData
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
            this.btnAddFiles = new System.Windows.Forms.Button();
            this.labAddFiles = new System.Windows.Forms.Label();
            this.panAddedFiles = new System.Windows.Forms.Panel();
            this.gbForFiles = new System.Windows.Forms.GroupBox();
            this.panDragFiles = new System.Windows.Forms.Panel();
            this.btnStartExtraction = new System.Windows.Forms.Button();
            this.btnDelFiles = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.openFD = new System.Windows.Forms.OpenFileDialog();
            this.gbForFiles.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddFiles
            // 
            this.btnAddFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddFiles.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddFiles.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddFiles.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddFiles.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnAddFiles.Location = new System.Drawing.Point(635, 18);
            this.btnAddFiles.Margin = new System.Windows.Forms.Padding(10, 10, 20, 10);
            this.btnAddFiles.Name = "btnAddFiles";
            this.btnAddFiles.Size = new System.Drawing.Size(222, 45);
            this.btnAddFiles.TabIndex = 12;
            this.btnAddFiles.Text = "Обзор...";
            this.btnAddFiles.UseVisualStyleBackColor = false;
            this.btnAddFiles.Click += new System.EventHandler(this.btnAddFiles_Click);
            // 
            // labAddFiles
            // 
            this.labAddFiles.AutoSize = true;
            this.labAddFiles.Location = new System.Drawing.Point(30, 30);
            this.labAddFiles.Margin = new System.Windows.Forms.Padding(10, 10, 2, 10);
            this.labAddFiles.Name = "labAddFiles";
            this.labAddFiles.Size = new System.Drawing.Size(422, 22);
            this.labAddFiles.TabIndex = 11;
            this.labAddFiles.Text = "Выберете нужные файлы с расширением";
            // 
            // panAddedFiles
            // 
            this.panAddedFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panAddedFiles.AutoScroll = true;
            this.panAddedFiles.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panAddedFiles.Location = new System.Drawing.Point(34, 83);
            this.panAddedFiles.Margin = new System.Windows.Forms.Padding(35, 10, 35, 10);
            this.panAddedFiles.Name = "panAddedFiles";
            this.panAddedFiles.Size = new System.Drawing.Size(823, 240);
            this.panAddedFiles.TabIndex = 13;
            // 
            // gbForFiles
            // 
            this.gbForFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbForFiles.Controls.Add(this.panDragFiles);
            this.gbForFiles.Location = new System.Drawing.Point(34, 358);
            this.gbForFiles.Margin = new System.Windows.Forms.Padding(35, 25, 35, 35);
            this.gbForFiles.Name = "gbForFiles";
            this.gbForFiles.Padding = new System.Windows.Forms.Padding(0);
            this.gbForFiles.Size = new System.Drawing.Size(823, 240);
            this.gbForFiles.TabIndex = 14;
            this.gbForFiles.TabStop = false;
            this.gbForFiles.Text = "Или перетащите их в эту область:";
            // 
            // panDragFiles
            // 
            this.panDragFiles.AllowDrop = true;
            this.panDragFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panDragFiles.AutoScroll = true;
            this.panDragFiles.Location = new System.Drawing.Point(1, 24);
            this.panDragFiles.Margin = new System.Windows.Forms.Padding(0);
            this.panDragFiles.Name = "panDragFiles";
            this.panDragFiles.Size = new System.Drawing.Size(821, 214);
            this.panDragFiles.TabIndex = 0;
            this.panDragFiles.DragDrop += new System.Windows.Forms.DragEventHandler(this.panDragFiles_DragDrop);
            this.panDragFiles.DragEnter += new System.Windows.Forms.DragEventHandler(this.panDragFiles_DragEnter);
            // 
            // btnStartExtraction
            // 
            this.btnStartExtraction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStartExtraction.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnStartExtraction.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStartExtraction.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStartExtraction.ForeColor = System.Drawing.Color.Green;
            this.btnStartExtraction.Location = new System.Drawing.Point(536, 643);
            this.btnStartExtraction.Margin = new System.Windows.Forms.Padding(10, 10, 20, 10);
            this.btnStartExtraction.Name = "btnStartExtraction";
            this.btnStartExtraction.Size = new System.Drawing.Size(330, 45);
            this.btnStartExtraction.TabIndex = 15;
            this.btnStartExtraction.Text = "Начать извлечение данных";
            this.btnStartExtraction.UseVisualStyleBackColor = false;
            // 
            // btnDelFiles
            // 
            this.btnDelFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelFiles.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDelFiles.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelFiles.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelFiles.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnDelFiles.Location = new System.Drawing.Point(34, 643);
            this.btnDelFiles.Margin = new System.Windows.Forms.Padding(10, 10, 20, 10);
            this.btnDelFiles.Name = "btnDelFiles";
            this.btnDelFiles.Size = new System.Drawing.Size(330, 45);
            this.btnDelFiles.TabIndex = 16;
            this.btnDelFiles.Text = "Очистить выбранные файлы";
            this.btnDelFiles.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(512, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 10, 2, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 22);
            this.label1.TabIndex = 17;
            this.label1.Text = "или";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(456, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 10, 2, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 23);
            this.label2.TabIndex = 18;
            this.label2.Text = ".doc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(560, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 10, 2, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 23);
            this.label3.TabIndex = 19;
            this.label3.Text = ".docx";
            // 
            // openFD
            // 
            this.openFD.FileName = "openFileDialog1";
            // 
            // ControlAddData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelFiles);
            this.Controls.Add(this.btnStartExtraction);
            this.Controls.Add(this.gbForFiles);
            this.Controls.Add(this.panAddedFiles);
            this.Controls.Add(this.btnAddFiles);
            this.Controls.Add(this.labAddFiles);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "ControlAddData";
            this.Size = new System.Drawing.Size(892, 723);
            this.Load += new System.EventHandler(this.ControlAddData_Load);
            this.gbForFiles.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddFiles;
        private System.Windows.Forms.Label labAddFiles;
        private System.Windows.Forms.Panel panAddedFiles;
        private System.Windows.Forms.GroupBox gbForFiles;
        private System.Windows.Forms.Button btnStartExtraction;
        private System.Windows.Forms.Button btnDelFiles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog openFD;
        private System.Windows.Forms.Panel panDragFiles;
    }
}
