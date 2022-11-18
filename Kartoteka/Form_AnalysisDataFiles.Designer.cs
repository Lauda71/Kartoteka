namespace Kartoteka
{
    partial class Form_AnalysisDataFiles
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_AnalysisDataFiles));
            this.progBar = new System.Windows.Forms.ProgressBar();
            this.mainLab = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progBar
            // 
            this.progBar.Location = new System.Drawing.Point(15, 64);
            this.progBar.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.progBar.Name = "progBar";
            this.progBar.Size = new System.Drawing.Size(448, 41);
            this.progBar.TabIndex = 0;
            // 
            // mainLab
            // 
            this.mainLab.AutoSize = true;
            this.mainLab.Location = new System.Drawing.Point(161, 23);
            this.mainLab.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.mainLab.Name = "mainLab";
            this.mainLab.Size = new System.Drawing.Size(168, 22);
            this.mainLab.TabIndex = 1;
            this.mainLab.Text = "Анализ данных...";
            // 
            // Form_AnalysisDataFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(478, 119);
            this.Controls.Add(this.mainLab);
            this.Controls.Add(this.progBar);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "Form_AnalysisDataFiles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Анализ данных..";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progBar;
        private System.Windows.Forms.Label mainLab;
    }
}