
namespace HOLD_AND_WRITE
{
    partial class ChangeChar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeChar));
            this.buttonSaveChar = new System.Windows.Forms.Button();
            this.buttonCancelSaveChar = new System.Windows.Forms.Button();
            this.textBoxAbout = new System.Windows.Forms.TextBox();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listCharacters = new System.Windows.Forms.ListBox();
            this.pictureWithoutCard = new System.Windows.Forms.PictureBox();
            this.checkOther = new System.Windows.Forms.CheckBox();
            this.checkGenMale = new System.Windows.Forms.CheckBox();
            this.checkGenFem = new System.Windows.Forms.CheckBox();
            this.checkCameo = new System.Windows.Forms.CheckBox();
            this.checkMent = new System.Windows.Forms.CheckBox();
            this.checkSecond = new System.Windows.Forms.CheckBox();
            this.checkMain = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureWithoutCard)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSaveChar
            // 
            this.buttonSaveChar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonSaveChar.Location = new System.Drawing.Point(784, 511);
            this.buttonSaveChar.Name = "buttonSaveChar";
            this.buttonSaveChar.Size = new System.Drawing.Size(130, 51);
            this.buttonSaveChar.TabIndex = 32;
            this.buttonSaveChar.Text = "Сохранить";
            this.buttonSaveChar.UseVisualStyleBackColor = true;
            this.buttonSaveChar.Click += new System.EventHandler(this.ChangeChar_Click);
            // 
            // buttonCancelSaveChar
            // 
            this.buttonCancelSaveChar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonCancelSaveChar.Location = new System.Drawing.Point(462, 511);
            this.buttonCancelSaveChar.Name = "buttonCancelSaveChar";
            this.buttonCancelSaveChar.Size = new System.Drawing.Size(117, 51);
            this.buttonCancelSaveChar.TabIndex = 31;
            this.buttonCancelSaveChar.Text = "Закрыть";
            this.buttonCancelSaveChar.UseVisualStyleBackColor = true;
            this.buttonCancelSaveChar.Click += new System.EventHandler(this.CancelChangeChar_Click);
            // 
            // textBoxAbout
            // 
            this.textBoxAbout.Location = new System.Drawing.Point(462, 319);
            this.textBoxAbout.Multiline = true;
            this.textBoxAbout.Name = "textBoxAbout";
            this.textBoxAbout.Size = new System.Drawing.Size(452, 173);
            this.textBoxAbout.TabIndex = 24;
            // 
            // textBoxAge
            // 
            this.textBoxAge.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxAge.Location = new System.Drawing.Point(593, 147);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(100, 27);
            this.textBoxAge.TabIndex = 23;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(593, 53);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(321, 22);
            this.textBoxName.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label5.Location = new System.Drawing.Point(459, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "О персонаже:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label4.Location = new System.Drawing.Point(459, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Роль:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label3.Location = new System.Drawing.Point(459, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Возраст:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label2.Location = new System.Drawing.Point(459, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Пол:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(459, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Имя:";
            // 
            // listCharacters
            // 
            this.listCharacters.FormattingEnabled = true;
            this.listCharacters.ItemHeight = 16;
            this.listCharacters.Location = new System.Drawing.Point(25, 30);
            this.listCharacters.Name = "listCharacters";
            this.listCharacters.Size = new System.Drawing.Size(391, 532);
            this.listCharacters.TabIndex = 34;
            this.listCharacters.SelectedIndexChanged += new System.EventHandler(this.listCharacters_SelectedIndexChanged);
            // 
            // pictureWithoutCard
            // 
            this.pictureWithoutCard.Location = new System.Drawing.Point(457, 30);
            this.pictureWithoutCard.Name = "pictureWithoutCard";
            this.pictureWithoutCard.Size = new System.Drawing.Size(464, 532);
            this.pictureWithoutCard.TabIndex = 35;
            this.pictureWithoutCard.TabStop = false;
            // 
            // checkOther
            // 
            this.checkOther.AutoSize = true;
            this.checkOther.Location = new System.Drawing.Point(840, 102);
            this.checkOther.Name = "checkOther";
            this.checkOther.Size = new System.Drawing.Size(74, 21);
            this.checkOther.TabIndex = 38;
            this.checkOther.Text = "другое";
            this.checkOther.UseVisualStyleBackColor = true;
            this.checkOther.Click += new System.EventHandler(this.Other_CheckedChanged);
            // 
            // checkGenMale
            // 
            this.checkGenMale.AutoSize = true;
            this.checkGenMale.Location = new System.Drawing.Point(717, 102);
            this.checkGenMale.Name = "checkGenMale";
            this.checkGenMale.Size = new System.Drawing.Size(85, 21);
            this.checkGenMale.TabIndex = 37;
            this.checkGenMale.Text = "мужской";
            this.checkGenMale.UseVisualStyleBackColor = true;
            this.checkGenMale.Click += new System.EventHandler(this.GenMale_CheckedChanged);
            // 
            // checkGenFem
            // 
            this.checkGenFem.AutoSize = true;
            this.checkGenFem.Location = new System.Drawing.Point(594, 102);
            this.checkGenFem.Name = "checkGenFem";
            this.checkGenFem.Size = new System.Drawing.Size(85, 21);
            this.checkGenFem.TabIndex = 36;
            this.checkGenFem.Text = "женский";
            this.checkGenFem.UseVisualStyleBackColor = true;
            this.checkGenFem.Click += new System.EventHandler(this.GenFem_CheckedChanged);
            // 
            // checkCameo
            // 
            this.checkCameo.AutoSize = true;
            this.checkCameo.Location = new System.Drawing.Point(782, 201);
            this.checkCameo.Name = "checkCameo";
            this.checkCameo.Size = new System.Drawing.Size(132, 21);
            this.checkCameo.TabIndex = 42;
            this.checkCameo.Text = "Эпизодический";
            this.checkCameo.UseVisualStyleBackColor = true;
            this.checkCameo.Click += new System.EventHandler(this.Cameo_CheckedChanged);
            // 
            // checkMent
            // 
            this.checkMent.AutoSize = true;
            this.checkMent.Location = new System.Drawing.Point(782, 240);
            this.checkMent.Name = "checkMent";
            this.checkMent.Size = new System.Drawing.Size(118, 21);
            this.checkMent.TabIndex = 41;
            this.checkMent.Text = "Упоминается";
            this.checkMent.UseVisualStyleBackColor = true;
            this.checkMent.Click += new System.EventHandler(this.Ment_CheckedChanged);
            // 
            // checkSecond
            // 
            this.checkSecond.AutoSize = true;
            this.checkSecond.Location = new System.Drawing.Point(593, 243);
            this.checkSecond.Name = "checkSecond";
            this.checkSecond.Size = new System.Drawing.Size(142, 21);
            this.checkSecond.TabIndex = 40;
            this.checkSecond.Text = "Второстепенный";
            this.checkSecond.UseVisualStyleBackColor = true;
            this.checkSecond.Click += new System.EventHandler(this.Second_CheckedChanged);
            // 
            // checkMain
            // 
            this.checkMain.AutoSize = true;
            this.checkMain.Location = new System.Drawing.Point(593, 204);
            this.checkMain.Name = "checkMain";
            this.checkMain.Size = new System.Drawing.Size(87, 21);
            this.checkMain.TabIndex = 39;
            this.checkMain.Text = "Главный";
            this.checkMain.UseVisualStyleBackColor = true;
            this.checkMain.Click += new System.EventHandler(this.Main_CheckedChanged);
            // 
            // ChangeChar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(945, 588);
            this.Controls.Add(this.pictureWithoutCard);
            this.Controls.Add(this.checkCameo);
            this.Controls.Add(this.checkMent);
            this.Controls.Add(this.checkSecond);
            this.Controls.Add(this.checkMain);
            this.Controls.Add(this.checkOther);
            this.Controls.Add(this.checkGenMale);
            this.Controls.Add(this.checkGenFem);
            this.Controls.Add(this.listCharacters);
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
            this.Name = "ChangeChar";
            this.Text = "Изменить карточку персонажа";
            ((System.ComponentModel.ISupportInitialize)(this.pictureWithoutCard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonSaveChar;
        private System.Windows.Forms.Button buttonCancelSaveChar;
        private System.Windows.Forms.TextBox textBoxAbout;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listCharacters;
        private System.Windows.Forms.PictureBox pictureWithoutCard;
        private System.Windows.Forms.CheckBox checkOther;
        private System.Windows.Forms.CheckBox checkGenMale;
        private System.Windows.Forms.CheckBox checkGenFem;
        private System.Windows.Forms.CheckBox checkCameo;
        private System.Windows.Forms.CheckBox checkMent;
        private System.Windows.Forms.CheckBox checkSecond;
        private System.Windows.Forms.CheckBox checkMain;
    }
}