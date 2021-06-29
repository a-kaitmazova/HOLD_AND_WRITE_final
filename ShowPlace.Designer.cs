
namespace HOLD_AND_WRITE
{
    partial class ShowPlace
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowPlace));
            this.textBoxPlaceName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPlace = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCancelCreatePlace = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxPlaceName
            // 
            this.textBoxPlaceName.Location = new System.Drawing.Point(28, 80);
            this.textBoxPlaceName.Name = "textBoxPlaceName";
            this.textBoxPlaceName.ReadOnly = true;
            this.textBoxPlaceName.Size = new System.Drawing.Size(498, 22);
            this.textBoxPlaceName.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(23, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 27);
            this.label2.TabIndex = 9;
            this.label2.Text = "Название места:";
            // 
            // textBoxPlace
            // 
            this.textBoxPlace.Location = new System.Drawing.Point(26, 173);
            this.textBoxPlace.Multiline = true;
            this.textBoxPlace.Name = "textBoxPlace";
            this.textBoxPlace.ReadOnly = true;
            this.textBoxPlace.Size = new System.Drawing.Size(500, 190);
            this.textBoxPlace.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(23, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 27);
            this.label1.TabIndex = 7;
            this.label1.Text = "Описание места:";
            // 
            // buttonCancelCreatePlace
            // 
            this.buttonCancelCreatePlace.Location = new System.Drawing.Point(196, 383);
            this.buttonCancelCreatePlace.Name = "buttonCancelCreatePlace";
            this.buttonCancelCreatePlace.Size = new System.Drawing.Size(133, 46);
            this.buttonCancelCreatePlace.TabIndex = 6;
            this.buttonCancelCreatePlace.Text = "Закрыть";
            this.buttonCancelCreatePlace.UseVisualStyleBackColor = true;
            this.buttonCancelCreatePlace.Click += new System.EventHandler(this.buttonCancelShowPlace_Click);
            // 
            // ShowPlace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(549, 450);
            this.Controls.Add(this.textBoxPlaceName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPlace);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCancelCreatePlace);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ShowPlace";
            this.Text = "Место";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPlaceName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPlace;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCancelCreatePlace;
    }
}