﻿namespace HOLD_AND_WRITE
{
    partial class HoldAndWrite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HoldAndWrite));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.книгаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.переименоватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.переименоватьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.персонажToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.местностьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.предметToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.Info = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.Synopsis = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.Notepad = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TreeView = new System.Windows.Forms.TreeView();
            this.оБНОВИТЬToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.книгаToolStripMenuItem,
            this.файлToolStripMenuItem,
            this.персонажToolStripMenuItem,
            this.местностьToolStripMenuItem,
            this.предметToolStripMenuItem,
            this.Info,
            this.оБНОВИТЬToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1741, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // книгаToolStripMenuItem
            // 
            this.книгаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem,
            this.переименоватьToolStripMenuItem,
            this.удалитьToolStripMenuItem1});
            this.книгаToolStripMenuItem.Name = "книгаToolStripMenuItem";
            this.книгаToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.книгаToolStripMenuItem.Text = "Книга";
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.создатьToolStripMenuItem.Text = "Создать";
            this.создатьToolStripMenuItem.Click += new System.EventHandler(this.CreateBook);
            // 
            // переименоватьToolStripMenuItem
            // 
            this.переименоватьToolStripMenuItem.Name = "переименоватьToolStripMenuItem";
            this.переименоватьToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.переименоватьToolStripMenuItem.Text = "Переименовать";
            this.переименоватьToolStripMenuItem.Click += new System.EventHandler(this.RenameBook);
            // 
            // удалитьToolStripMenuItem1
            // 
            this.удалитьToolStripMenuItem1.Name = "удалитьToolStripMenuItem1";
            this.удалитьToolStripMenuItem1.Size = new System.Drawing.Size(204, 26);
            this.удалитьToolStripMenuItem1.Text = "Удалить";
            this.удалитьToolStripMenuItem1.Click += new System.EventHandler(this.DeleteBook);
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem1,
            this.создатьToolStripMenuItem1,
            this.переименоватьToolStripMenuItem1,
            this.удалитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem1
            // 
            this.сохранитьToolStripMenuItem1.Name = "сохранитьToolStripMenuItem1";
            this.сохранитьToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.сохранитьToolStripMenuItem1.Text = "Сохранить";
            this.сохранитьToolStripMenuItem1.Click += new System.EventHandler(this.SaveFile);
            // 
            // создатьToolStripMenuItem1
            // 
            this.создатьToolStripMenuItem1.Name = "создатьToolStripMenuItem1";
            this.создатьToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.создатьToolStripMenuItem1.Text = "Создать";
            this.создатьToolStripMenuItem1.Click += new System.EventHandler(this.CreateFile);
            // 
            // переименоватьToolStripMenuItem1
            // 
            this.переименоватьToolStripMenuItem1.Name = "переименоватьToolStripMenuItem1";
            this.переименоватьToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.переименоватьToolStripMenuItem1.Text = "Переименовать";
            this.переименоватьToolStripMenuItem1.Click += new System.EventHandler(this.RenameFile);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.DeleteFile);
            // 
            // персонажToolStripMenuItem
            // 
            this.персонажToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem2,
            this.изменитьToolStripMenuItem,
            this.удалитьToolStripMenuItem2});
            this.персонажToolStripMenuItem.Name = "персонажToolStripMenuItem";
            this.персонажToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            this.персонажToolStripMenuItem.Text = "Персонаж";
            // 
            // создатьToolStripMenuItem2
            // 
            this.создатьToolStripMenuItem2.Name = "создатьToolStripMenuItem2";
            this.создатьToolStripMenuItem2.Size = new System.Drawing.Size(161, 26);
            this.создатьToolStripMenuItem2.Text = "Создать";
            this.создатьToolStripMenuItem2.Click += new System.EventHandler(this.CreateChar);
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.изменитьToolStripMenuItem.Text = "Изменить";
            this.изменитьToolStripMenuItem.Click += new System.EventHandler(this.ChangeChar);
            // 
            // удалитьToolStripMenuItem2
            // 
            this.удалитьToolStripMenuItem2.Name = "удалитьToolStripMenuItem2";
            this.удалитьToolStripMenuItem2.Size = new System.Drawing.Size(161, 26);
            this.удалитьToolStripMenuItem2.Text = "Удалить";
            this.удалитьToolStripMenuItem2.Click += new System.EventHandler(this.DeleteChar);
            // 
            // местностьToolStripMenuItem
            // 
            this.местностьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem3,
            this.изменитьToolStripMenuItem1,
            this.удалитьToolStripMenuItem3});
            this.местностьToolStripMenuItem.Name = "местностьToolStripMenuItem";
            this.местностьToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.местностьToolStripMenuItem.Text = "Местность";
            // 
            // создатьToolStripMenuItem3
            // 
            this.создатьToolStripMenuItem3.Name = "создатьToolStripMenuItem3";
            this.создатьToolStripMenuItem3.Size = new System.Drawing.Size(161, 26);
            this.создатьToolStripMenuItem3.Text = "Создать";
            this.создатьToolStripMenuItem3.Click += new System.EventHandler(this.CreatePlace);
            // 
            // изменитьToolStripMenuItem1
            // 
            this.изменитьToolStripMenuItem1.Name = "изменитьToolStripMenuItem1";
            this.изменитьToolStripMenuItem1.Size = new System.Drawing.Size(161, 26);
            this.изменитьToolStripMenuItem1.Text = "Изменить";
            this.изменитьToolStripMenuItem1.Click += new System.EventHandler(this.ChangePlace);
            // 
            // удалитьToolStripMenuItem3
            // 
            this.удалитьToolStripMenuItem3.Name = "удалитьToolStripMenuItem3";
            this.удалитьToolStripMenuItem3.Size = new System.Drawing.Size(161, 26);
            this.удалитьToolStripMenuItem3.Text = "Удалить";
            this.удалитьToolStripMenuItem3.Click += new System.EventHandler(this.DeletePlace);
            // 
            // предметToolStripMenuItem
            // 
            this.предметToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem4,
            this.изменитьToolStripMenuItem2,
            this.удалитьToolStripMenuItem4});
            this.предметToolStripMenuItem.Name = "предметToolStripMenuItem";
            this.предметToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.предметToolStripMenuItem.Text = "Предмет";
            // 
            // создатьToolStripMenuItem4
            // 
            this.создатьToolStripMenuItem4.Name = "создатьToolStripMenuItem4";
            this.создатьToolStripMenuItem4.Size = new System.Drawing.Size(161, 26);
            this.создатьToolStripMenuItem4.Text = "Создать";
            this.создатьToolStripMenuItem4.Click += new System.EventHandler(this.CreateItem);
            // 
            // изменитьToolStripMenuItem2
            // 
            this.изменитьToolStripMenuItem2.Name = "изменитьToolStripMenuItem2";
            this.изменитьToolStripMenuItem2.Size = new System.Drawing.Size(161, 26);
            this.изменитьToolStripMenuItem2.Text = "Изменить";
            this.изменитьToolStripMenuItem2.Click += new System.EventHandler(this.ChangeItem);
            // 
            // удалитьToolStripMenuItem4
            // 
            this.удалитьToolStripMenuItem4.Name = "удалитьToolStripMenuItem4";
            this.удалитьToolStripMenuItem4.Size = new System.Drawing.Size(161, 26);
            this.удалитьToolStripMenuItem4.Text = "Удалить";
            this.удалитьToolStripMenuItem4.Click += new System.EventHandler(this.DeleteItem);
            // 
            // Info
            // 
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(81, 24);
            this.Info.Text = "Справка";
            this.Info.Click += new System.EventHandler(this.Info_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.label3.Location = new System.Drawing.Point(1371, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(358, 38);
            this.label3.TabIndex = 13;
            this.label3.Text = "Синопсис";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Synopsis
            // 
            this.Synopsis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Synopsis.Location = new System.Drawing.Point(1372, 77);
            this.Synopsis.Multiline = true;
            this.Synopsis.Name = "Synopsis";
            this.Synopsis.Size = new System.Drawing.Size(358, 753);
            this.Synopsis.TabIndex = 12;
            // 
            // labelName
            // 
            this.labelName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelName.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.labelName.Location = new System.Drawing.Point(382, 33);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(983, 38);
            this.labelName.TabIndex = 11;
            // 
            // Notepad
            // 
            this.Notepad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Notepad.Location = new System.Drawing.Point(382, 77);
            this.Notepad.Margin = new System.Windows.Forms.Padding(4);
            this.Notepad.Name = "Notepad";
            this.Notepad.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.Notepad.Size = new System.Drawing.Size(983, 752);
            this.Notepad.TabIndex = 10;
            this.Notepad.Text = "";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 38);
            this.label1.TabIndex = 9;
            this.label1.Text = "Файловая система";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TreeView
            // 
            this.TreeView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TreeView.Location = new System.Drawing.Point(8, 77);
            this.TreeView.Margin = new System.Windows.Forms.Padding(4);
            this.TreeView.Name = "TreeView";
            this.TreeView.Size = new System.Drawing.Size(368, 752);
            this.TreeView.TabIndex = 8;
            this.TreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.OpenFile);
            // 
            // оБНОВИТЬToolStripMenuItem
            // 
            this.оБНОВИТЬToolStripMenuItem.Name = "оБНОВИТЬToolStripMenuItem";
            this.оБНОВИТЬToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            this.оБНОВИТЬToolStripMenuItem.Text = "ОБНОВИТЬ";
            this.оБНОВИТЬToolStripMenuItem.Click += new System.EventHandler(this.Refresh);
            // 
            // HoldAndWrite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1741, 853);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Synopsis);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.Notepad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TreeView);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "HoldAndWrite";
            this.Text = "Держись и пиши";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem книгаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem переименоватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem переименоватьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem персонажToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem местностьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem предметToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem Info;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Synopsis;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.RichTextBox Notepad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView TreeView;
        private System.Windows.Forms.ToolStripMenuItem оБНОВИТЬToolStripMenuItem;
    }
}

