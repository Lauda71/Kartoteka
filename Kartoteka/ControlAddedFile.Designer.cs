
namespace Kartoteka
{
    partial class ControlAddedFile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlAddedFile));
            this.pb = new System.Windows.Forms.PictureBox();
            this.labFileName = new System.Windows.Forms.Label();
            this.btnDelFile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).BeginInit();
            this.SuspendLayout();
            // 
            // pb
            // 
            this.pb.Image = ((System.Drawing.Image)(resources.GetObject("pb.Image")));
            this.pb.Location = new System.Drawing.Point(80, 12);
            this.pb.Margin = new System.Windows.Forms.Padding(5);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(38, 40);
            this.pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb.TabIndex = 0;
            this.pb.TabStop = false;
            // 
            // labFileName
            // 
            this.labFileName.AutoSize = true;
            this.labFileName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labFileName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labFileName.Location = new System.Drawing.Point(129, 22);
            this.labFileName.Name = "labFileName";
            this.labFileName.Size = new System.Drawing.Size(133, 21);
            this.labFileName.TabIndex = 1;
            this.labFileName.Text = "ИмяФайла.doc";
            // 
            // btnDelFile
            // 
            this.btnDelFile.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelFile.ForeColor = System.Drawing.Color.DarkRed;
            this.btnDelFile.Location = new System.Drawing.Point(5, 5);
            this.btnDelFile.Margin = new System.Windows.Forms.Padding(5);
            this.btnDelFile.Name = "btnDelFile";
            this.btnDelFile.Size = new System.Drawing.Size(56, 56);
            this.btnDelFile.TabIndex = 2;
            this.btnDelFile.Text = "X";
            this.btnDelFile.UseVisualStyleBackColor = true;
            this.btnDelFile.Click += new System.EventHandler(this.btnDelFile_Click);
            // 
            // ControlAddedFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDelFile);
            this.Controls.Add(this.labFileName);
            this.Controls.Add(this.pb);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "ControlAddedFile";
            this.Size = new System.Drawing.Size(792, 66);
            this.Load += new System.EventHandler(this.ControlAddedFile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb;
        private System.Windows.Forms.Label labFileName;
        private System.Windows.Forms.Button btnDelFile;
    }
}
