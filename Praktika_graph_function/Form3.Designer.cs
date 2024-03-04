namespace Praktika_graph_function
{
    partial class Color_
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
            this.btn_OK = new System.Windows.Forms.Button();
            this.radioBtn_yellow = new System.Windows.Forms.RadioButton();
            this.radioBtn_blue = new System.Windows.Forms.RadioButton();
            this.lbl_select_color = new System.Windows.Forms.Label();
            this.radioBtn_green = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btn_OK
            // 
            this.btn_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_OK.Location = new System.Drawing.Point(201, 224);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_OK.TabIndex = 9;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            // 
            // radioBtn_yellow
            // 
            this.radioBtn_yellow.AutoSize = true;
            this.radioBtn_yellow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioBtn_yellow.Location = new System.Drawing.Point(39, 167);
            this.radioBtn_yellow.Name = "radioBtn_yellow";
            this.radioBtn_yellow.Size = new System.Drawing.Size(65, 20);
            this.radioBtn_yellow.TabIndex = 8;
            this.radioBtn_yellow.TabStop = true;
            this.radioBtn_yellow.Text = "Yellow";
            this.radioBtn_yellow.UseVisualStyleBackColor = true;
            // 
            // radioBtn_blue
            // 
            this.radioBtn_blue.AutoSize = true;
            this.radioBtn_blue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioBtn_blue.Location = new System.Drawing.Point(39, 121);
            this.radioBtn_blue.Name = "radioBtn_blue";
            this.radioBtn_blue.Size = new System.Drawing.Size(52, 20);
            this.radioBtn_blue.TabIndex = 7;
            this.radioBtn_blue.TabStop = true;
            this.radioBtn_blue.Text = "Blue";
            this.radioBtn_blue.UseVisualStyleBackColor = true;
            // 
            // lbl_select_color
            // 
            this.lbl_select_color.AutoSize = true;
            this.lbl_select_color.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_select_color.Location = new System.Drawing.Point(36, 26);
            this.lbl_select_color.Name = "lbl_select_color";
            this.lbl_select_color.Size = new System.Drawing.Size(123, 16);
            this.lbl_select_color.TabIndex = 6;
            this.lbl_select_color.Text = "Выберите цвет:";
            // 
            // radioBtn_green
            // 
            this.radioBtn_green.AutoSize = true;
            this.radioBtn_green.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioBtn_green.Location = new System.Drawing.Point(39, 76);
            this.radioBtn_green.Name = "radioBtn_green";
            this.radioBtn_green.Size = new System.Drawing.Size(62, 20);
            this.radioBtn_green.TabIndex = 5;
            this.radioBtn_green.TabStop = true;
            this.radioBtn_green.Text = "Green";
            this.radioBtn_green.UseVisualStyleBackColor = true;
            // 
            // Color_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 260);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.radioBtn_yellow);
            this.Controls.Add(this.radioBtn_blue);
            this.Controls.Add(this.lbl_select_color);
            this.Controls.Add(this.radioBtn_green);
            this.Name = "Color_";
            this.Text = "New_color";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.RadioButton radioBtn_yellow;
        private System.Windows.Forms.RadioButton radioBtn_blue;
        private System.Windows.Forms.Label lbl_select_color;
        private System.Windows.Forms.RadioButton radioBtn_green;
    }
}