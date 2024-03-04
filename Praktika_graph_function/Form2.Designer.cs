namespace Praktika_graph_function
{
    partial class Font_style
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
            this.radioBtn_italic = new System.Windows.Forms.RadioButton();
            this.lbl_select_font = new System.Windows.Forms.Label();
            this.radioBtn_bold = new System.Windows.Forms.RadioButton();
            this.radioBtn_regular = new System.Windows.Forms.RadioButton();
            this.btn_OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radioBtn_italic
            // 
            this.radioBtn_italic.AutoSize = true;
            this.radioBtn_italic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioBtn_italic.Location = new System.Drawing.Point(38, 77);
            this.radioBtn_italic.Name = "radioBtn_italic";
            this.radioBtn_italic.Size = new System.Drawing.Size(52, 20);
            this.radioBtn_italic.TabIndex = 0;
            this.radioBtn_italic.TabStop = true;
            this.radioBtn_italic.Text = "Italic";
            this.radioBtn_italic.UseVisualStyleBackColor = true;
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
            // radioBtn_bold
            // 
            this.radioBtn_bold.AutoSize = true;
            this.radioBtn_bold.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioBtn_bold.Location = new System.Drawing.Point(38, 122);
            this.radioBtn_bold.Name = "radioBtn_bold";
            this.radioBtn_bold.Size = new System.Drawing.Size(57, 20);
            this.radioBtn_bold.TabIndex = 2;
            this.radioBtn_bold.TabStop = true;
            this.radioBtn_bold.Text = "Bold";
            this.radioBtn_bold.UseVisualStyleBackColor = true;
            // 
            // radioBtn_regular
            // 
            this.radioBtn_regular.AutoSize = true;
            this.radioBtn_regular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioBtn_regular.Location = new System.Drawing.Point(38, 168);
            this.radioBtn_regular.Name = "radioBtn_regular";
            this.radioBtn_regular.Size = new System.Drawing.Size(73, 20);
            this.radioBtn_regular.TabIndex = 3;
            this.radioBtn_regular.TabStop = true;
            this.radioBtn_regular.Text = "Regular";
            this.radioBtn_regular.UseVisualStyleBackColor = true;
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
            // Font_style
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 260);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.radioBtn_regular);
            this.Controls.Add(this.radioBtn_bold);
            this.Controls.Add(this.lbl_select_font);
            this.Controls.Add(this.radioBtn_italic);
            this.Name = "Font_style";
            this.Text = "New_font";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioBtn_italic;
        private System.Windows.Forms.Label lbl_select_font;
        private System.Windows.Forms.RadioButton radioBtn_bold;
        private System.Windows.Forms.RadioButton radioBtn_regular;
        private System.Windows.Forms.Button btn_OK;
    }
}