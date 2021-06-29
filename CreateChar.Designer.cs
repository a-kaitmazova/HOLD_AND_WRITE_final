
namespace HOLD_AND_WRITE
{
    partial class CreateChar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateChar));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.textBoxAbout = new System.Windows.Forms.TextBox();
            this.buttonCancelSaveChar = new System.Windows.Forms.Button();
            this.buttonSaveChar = new System.Windows.Forms.Button();
            this.checkGenFem = new System.Windows.Forms.CheckBox();
            this.checkGenMale = new System.Windows.Forms.CheckBox();
            this.checkOther = new System.Windows.Forms.CheckBox();
            this.checkMain = new System.Windows.Forms.CheckBox();
            this.checkSecond = new System.Windows.Forms.CheckBox();
            this.checkMent = new System.Windows.Forms.CheckBox();
            this.checkCameo = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(40, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label2.Location = new System.Drawing.Point(40, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Пол:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label3.Location = new System.Drawing.Point(40, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Возраст:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label4.Location = new System.Drawing.Point(40, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Роль:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label5.Location = new System.Drawing.Point(40, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "О персонаже:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(115, 39);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(291, 22);
            this.textBoxName.TabIndex = 5;
            // 
            // textBoxAge
            // 
            this.textBoxAge.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxAge.Location = new System.Drawing.Point(115, 142);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(100, 27);
            this.textBoxAge.TabIndex = 6;
            // 
            // textBoxAbout
            // 
            this.textBoxAbout.Location = new System.Drawing.Point(43, 310);
            this.textBoxAbout.Multiline = true;
            this.textBoxAbout.Name = "textBoxAbout";
            this.textBoxAbout.Size = new System.Drawing.Size(363, 173);
            this.textBoxAbout.TabIndex = 7;
            // 
            // buttonCancelSaveChar
            // 
            this.buttonCancelSaveChar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonCancelSaveChar.Location = new System.Drawing.Point(43, 502);
            this.buttonCancelSaveChar.Name = "buttonCancelSaveChar";
            this.buttonCancelSaveChar.Size = new System.Drawing.Size(117, 51);
            this.buttonCancelSaveChar.TabIndex = 14;
            this.buttonCancelSaveChar.Text = "Закрыть";
            this.buttonCancelSaveChar.UseVisualStyleBackColor = true;
            this.buttonCancelSaveChar.Click += new System.EventHandler(this.CancelSaveChar_Click);
            // 
            // buttonSaveChar
            // 
            this.buttonSaveChar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonSaveChar.Location = new System.Drawing.Point(276, 502);
            this.buttonSaveChar.Name = "buttonSaveChar";
            this.buttonSaveChar.Size = new System.Drawing.Size(130, 51);
            this.buttonSaveChar.TabIndex = 15;
            this.buttonSaveChar.Text = "Сохранить";
            this.buttonSaveChar.UseVisualStyleBackColor = true;
            this.buttonSaveChar.Click += new System.EventHandler(this.SaveChar_Click);
            // 
            // checkGenFem
            // 
            this.checkGenFem.AutoSize = true;
            this.checkGenFem.Location = new System.Drawing.Point(118, 93);
            this.checkGenFem.Name = "checkGenFem";
            this.checkGenFem.Size = new System.Drawing.Size(85, 21);
            this.checkGenFem.TabIndex = 17;
            this.checkGenFem.Text = "женский";
            this.checkGenFem.UseVisualStyleBackColor = true;
            this.checkGenFem.Click += new System.EventHandler(this.GenFem_CheckedChanged);
            // 
            // checkGenMale
            // 
            this.checkGenMale.AutoSize = true;
            this.checkGenMale.Location = new System.Drawing.Point(217, 93);
            this.checkGenMale.Name = "checkGenMale";
            this.checkGenMale.Size = new System.Drawing.Size(85, 21);
            this.checkGenMale.TabIndex = 18;
            this.checkGenMale.Text = "мужской";
            this.checkGenMale.UseVisualStyleBackColor = true;
            this.checkGenMale.Click += new System.EventHandler(this.GenMale_CheckedChanged);
            // 
            // checkOther
            // 
            this.checkOther.AutoSize = true;
            this.checkOther.Location = new System.Drawing.Point(316, 93);
            this.checkOther.Name = "checkOther";
            this.checkOther.Size = new System.Drawing.Size(74, 21);
            this.checkOther.TabIndex = 20;
            this.checkOther.Text = "другое";
            this.checkOther.UseVisualStyleBackColor = true;
            this.checkOther.Click += new System.EventHandler(this.Other_CheckedChanged);
            // 
            // checkMain
            // 
            this.checkMain.AutoSize = true;
            this.checkMain.Location = new System.Drawing.Point(111, 192);
            this.checkMain.Name = "checkMain";
            this.checkMain.Size = new System.Drawing.Size(87, 21);
            this.checkMain.TabIndex = 21;
            this.checkMain.Text = "Главный";
            this.checkMain.UseVisualStyleBackColor = true;
            this.checkMain.Click += new System.EventHandler(this.Main_CheckedChanged);
            // 
            // checkSecond
            // 
            this.checkSecond.AutoSize = true;
            this.checkSecond.Location = new System.Drawing.Point(111, 231);
            this.checkSecond.Name = "checkSecond";
            this.checkSecond.Size = new System.Drawing.Size(142, 21);
            this.checkSecond.TabIndex = 22;
            this.checkSecond.Text = "Второстепенный";
            this.checkSecond.UseVisualStyleBackColor = true;
            this.checkSecond.Click += new System.EventHandler(this.Second_CheckedChanged);
            // 
            // checkMent
            // 
            this.checkMent.AutoSize = true;
            this.checkMent.Location = new System.Drawing.Point(268, 231);
            this.checkMent.Name = "checkMent";
            this.checkMent.Size = new System.Drawing.Size(118, 21);
            this.checkMent.TabIndex = 23;
            this.checkMent.Text = "Упоминается";
            this.checkMent.UseVisualStyleBackColor = true;
            this.checkMent.Click += new System.EventHandler(this.Ment_CheckedChanged);
            // 
            // checkCameo
            // 
            this.checkCameo.AutoSize = true;
            this.checkCameo.Location = new System.Drawing.Point(268, 192);
            this.checkCameo.Name = "checkCameo";
            this.checkCameo.Size = new System.Drawing.Size(132, 21);
            this.checkCameo.TabIndex = 24;
            this.checkCameo.Text = "Эпизодический";
            this.checkCameo.UseVisualStyleBackColor = true;
            this.checkCameo.Click += new System.EventHandler(this.Cameo_CheckedChanged);
            // 
            // CreateChar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(449, 591);
            this.Controls.Add(this.checkCameo);
            this.Controls.Add(this.checkMent);
            this.Controls.Add(this.checkSecond);
            this.Controls.Add(this.checkMain);
            this.Controls.Add(this.checkOther);
            this.Controls.Add(this.checkGenMale);
            this.Controls.Add(this.checkGenFem);
            this.Controls.Add(this.buttonSaveChar);
            this.Controls.Add(this.buttonCancelSaveChar);
            this.Controls.Add(this.textBoxAbout);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CreateChar";
            this.Text = "Создать карточку персонажа";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.TextBox textBoxAbout;
        private System.Windows.Forms.Button buttonCancelSaveChar;
        private System.Windows.Forms.Button buttonSaveChar;
        private System.Windows.Forms.CheckBox checkGenFem;
        private System.Windows.Forms.CheckBox checkGenMale;
        private System.Windows.Forms.CheckBox checkOther;
        private System.Windows.Forms.CheckBox checkMain;
        private System.Windows.Forms.CheckBox checkSecond;
        private System.Windows.Forms.CheckBox checkMent;
        private System.Windows.Forms.CheckBox checkCameo;
    }
}