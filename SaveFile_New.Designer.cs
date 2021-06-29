
namespace HOLD_AND_WRITE
{
    partial class SaveFile_New
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaveFile_New));
            this.treeViewFiles = new System.Windows.Forms.TreeView();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCancelFIileSave = new System.Windows.Forms.Button();
            this.buttonFileSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // treeViewFiles
            // 
            this.treeViewFiles.Location = new System.Drawing.Point(37, 77);
            this.treeViewFiles.Name = "treeViewFiles";
            this.treeViewFiles.Size = new System.Drawing.Size(475, 304);
            this.treeViewFiles.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(31, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(484, 33);
            this.label2.TabIndex = 14;
            this.label2.Text = "Выберите книгу (куда сохранить файл):";
            // 
            // buttonCancelFIileSave
            // 
            this.buttonCancelFIileSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelFIileSave.Location = new System.Drawing.Point(39, 487);
            this.buttonCancelFIileSave.Name = "buttonCancelFIileSave";
            this.buttonCancelFIileSave.Size = new System.Drawing.Size(124, 49);
            this.buttonCancelFIileSave.TabIndex = 13;
            this.buttonCancelFIileSave.Text = "Закрыть";
            this.buttonCancelFIileSave.UseVisualStyleBackColor = true;
            // 
            // buttonFileSave
            // 
            this.buttonFileSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFileSave.Location = new System.Drawing.Point(368, 487);
            this.buttonFileSave.Name = "buttonFileSave";
            this.buttonFileSave.Size = new System.Drawing.Size(144, 49);
            this.buttonFileSave.TabIndex = 12;
            this.buttonFileSave.Text = "Сохранить";
            this.buttonFileSave.UseVisualStyleBackColor = true;
            this.buttonFileSave.Click += new System.EventHandler(this.buttonFileSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(31, 397);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 33);
            this.label1.TabIndex = 11;
            this.label1.Text = "Введите название файла:";
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.Location = new System.Drawing.Point(39, 448);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.Size = new System.Drawing.Size(473, 22);
            this.textBoxFileName.TabIndex = 10;
            // 
            // SaveFile_New
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(563, 566);
            this.Controls.Add(this.treeViewFiles);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonCancelFIileSave);
            this.Controls.Add(this.buttonFileSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxFileName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SaveFile_New";
            this.Text = "Сохранить файл";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewFiles;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonCancelFIileSave;
        private System.Windows.Forms.Button buttonFileSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxFileName;
    }
}