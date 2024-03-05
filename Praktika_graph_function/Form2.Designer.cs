namespace Praktika_graph_function
{
    partial class Font_
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
            this.radioBtn_Modern = new System.Windows.Forms.RadioButton();
            this.lbl_select_font = new System.Windows.Forms.Label();
            this.radioBtn_Palatino_Linotype = new System.Windows.Forms.RadioButton();
            this.radioBtn_Tahoma = new System.Windows.Forms.RadioButton();
            this.btn_OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radioBtn_Modern
            // 
            this.radioBtn_Modern.AutoSize = true;
            this.radioBtn_Modern.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtn_Modern.Location = new System.Drawing.Point(38, 77);
            this.radioBtn_Modern.Name = "radioBtn_Modern";
            this.radioBtn_Modern.Size = new System.Drawing.Size(76, 22);
            this.radioBtn_Modern.TabIndex = 0;
            this.radioBtn_Modern.TabStop = true;
            this.radioBtn_Modern.Text = "Modern";
            this.radioBtn_Modern.UseVisualStyleBackColor = true;
            // 
            // lbl_select_font
            // 
            this.lbl_select_font.AutoSize = true;
            this.lbl_select_font.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_select_font.Location = new System.Drawing.Point(35, 27);
            this.lbl_select_font.Name = "lbl_select_font";
            this.lbl_select_font.Size = new System.Drawing.Size(136, 16);
            this.lbl_select_font.TabIndex = 1;
            this.lbl_select_font.Text = "Выберите шрифт:";
            // 
            // radioBtn_Palatino_Linotype
            // 
            this.radioBtn_Palatino_Linotype.AutoSize = true;
            this.radioBtn_Palatino_Linotype.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioBtn_Palatino_Linotype.Location = new System.Drawing.Point(38, 122);
            this.radioBtn_Palatino_Linotype.Name = "radioBtn_Palatino_Linotype";
            this.radioBtn_Palatino_Linotype.Size = new System.Drawing.Size(148, 26);
            this.radioBtn_Palatino_Linotype.TabIndex = 2;
            this.radioBtn_Palatino_Linotype.TabStop = true;
            this.radioBtn_Palatino_Linotype.Text = "Palatino Linotype";
            this.radioBtn_Palatino_Linotype.UseVisualStyleBackColor = true;
            // 
            // radioBtn_Tahoma
            // 
            this.radioBtn_Tahoma.AutoSize = true;
            this.radioBtn_Tahoma.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioBtn_Tahoma.Location = new System.Drawing.Point(38, 168);
            this.radioBtn_Tahoma.Name = "radioBtn_Tahoma";
            this.radioBtn_Tahoma.Size = new System.Drawing.Size(85, 23);
            this.radioBtn_Tahoma.TabIndex = 3;
            this.radioBtn_Tahoma.TabStop = true;
            this.radioBtn_Tahoma.Text = "Tahoma";
            this.radioBtn_Tahoma.UseVisualStyleBackColor = true;
            // 
            // btn_OK
            // 
            this.btn_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_OK.Location = new System.Drawing.Point(200, 225);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_OK.TabIndex = 4;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            // 
            // Font_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 260);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.radioBtn_Tahoma);
            this.Controls.Add(this.radioBtn_Palatino_Linotype);
            this.Controls.Add(this.lbl_select_font);
            this.Controls.Add(this.radioBtn_Modern);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(303, 299);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(303, 299);
            this.Name = "Font_";
            this.Text = "New_font";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioBtn_Modern;
        private System.Windows.Forms.Label lbl_select_font;
        private System.Windows.Forms.RadioButton radioBtn_Palatino_Linotype;
        private System.Windows.Forms.RadioButton radioBtn_Tahoma;
        private System.Windows.Forms.Button btn_OK;
    }
}