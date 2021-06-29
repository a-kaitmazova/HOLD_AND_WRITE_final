
namespace HOLD_AND_WRITE
{
    partial class ShowItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowItem));
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxItem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCancelCreateItem = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(20, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 27);
            this.label2.TabIndex = 14;
            this.label2.Text = "Название предмета:";
            // 
            // textBoxItem
            // 
            this.textBoxItem.Location = new System.Drawing.Point(23, 172);
            this.textBoxItem.Multiline = true;
            this.textBoxItem.Name = "textBoxItem";
            this.textBoxItem.ReadOnly = true;
            this.textBoxItem.Size = new System.Drawing.Size(500, 190);
            this.textBoxItem.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(20, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 27);
            this.label1.TabIndex = 12;
            this.label1.Text = "Описание предмета:";
            // 
            // buttonCancelCreateItem
            // 
            this.buttonCancelCreateItem.Location = new System.Drawing.Point(193, 385);
            this.buttonCancelCreateItem.Name = "buttonCancelCreateItem";
            this.buttonCancelCreateItem.Size = new System.Drawing.Size(133, 46);
            this.buttonCancelCreateItem.TabIndex = 16;
            this.buttonCancelCreateItem.Text = "Закрыть";
            this.buttonCancelCreateItem.UseVisualStyleBackColor = true;
            this.buttonCancelCreateItem.Click += new System.EventHandler(this.buttonCancelShowItem_Click);
            // 
            // labelName
            // 
            this.labelName.Location = new System.Drawing.Point(23, 76);
            this.labelName.Name = "labelName";
            this.labelName.ReadOnly = true;
            this.labelName.Size = new System.Drawing.Size(500, 22);
            this.labelName.TabIndex = 17;
            // 
            // ShowItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 452);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.buttonCancelCreateItem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxItem);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ShowItem";
            this.Text = "Предмет";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCancelCreateItem;
        private System.Windows.Forms.TextBox labelName;
    }
}