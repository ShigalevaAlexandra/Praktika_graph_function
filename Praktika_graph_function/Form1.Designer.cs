namespace Praktika_graph_function
{
    partial class graph_function
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
            this.lbl_count_point = new System.Windows.Forms.Label();
            this.lbl_elasticity = new System.Windows.Forms.Label();
            this.numeric_count_point = new System.Windows.Forms.NumericUpDown();
            this.numeric_elasticity = new System.Windows.Forms.NumericUpDown();
            this.btn_create_graph = new System.Windows.Forms.Button();
            this.pictureBox_graph_func = new System.Windows.Forms.PictureBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_new_font = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_count_point)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_elasticity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_graph_func)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_count_point
            // 
            this.lbl_count_point.AutoSize = true;
            this.lbl_count_point.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_count_point.Location = new System.Drawing.Point(32, 38);
            this.lbl_count_point.Name = "lbl_count_point";
            this.lbl_count_point.Size = new System.Drawing.Size(78, 15);
            this.lbl_count_point.TabIndex = 0;
            this.lbl_count_point.Text = "Число точек";
            // 
            // lbl_elasticity
            // 
            this.lbl_elasticity.AutoSize = true;
            this.lbl_elasticity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_elasticity.Location = new System.Drawing.Point(32, 95);
            this.lbl_elasticity.Name = "lbl_elasticity";
            this.lbl_elasticity.Size = new System.Drawing.Size(66, 15);
            this.lbl_elasticity.TabIndex = 1;
            this.lbl_elasticity.Text = "Упругость";
            // 
            // numeric_count_point
            // 
            this.numeric_count_point.Location = new System.Drawing.Point(128, 38);
            this.numeric_count_point.Name = "numeric_count_point";
            this.numeric_count_point.Size = new System.Drawing.Size(73, 20);
            this.numeric_count_point.TabIndex = 2;
            // 
            // numeric_elasticity
            // 
            this.numeric_elasticity.Location = new System.Drawing.Point(128, 95);
            this.numeric_elasticity.Name = "numeric_elasticity";
            this.numeric_elasticity.Size = new System.Drawing.Size(73, 20);
            this.numeric_elasticity.TabIndex = 3;
            // 
            // btn_create_graph
            // 
            this.btn_create_graph.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_create_graph.Location = new System.Drawing.Point(35, 371);
            this.btn_create_graph.Name = "btn_create_graph";
            this.btn_create_graph.Size = new System.Drawing.Size(166, 36);
            this.btn_create_graph.TabIndex = 5;
            this.btn_create_graph.Text = "Построить график";
            this.btn_create_graph.UseVisualStyleBackColor = true;
            this.btn_create_graph.Click += new System.EventHandler(this.btn_create_graph_Click);
            // 
            // pictureBox_graph_func
            // 
            this.pictureBox_graph_func.Location = new System.Drawing.Point(232, 38);
            this.pictureBox_graph_func.Name = "pictureBox_graph_func";
            this.pictureBox_graph_func.Size = new System.Drawing.Size(446, 369);
            this.pictureBox_graph_func.TabIndex = 6;
            this.pictureBox_graph_func.TabStop = false;
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_exit.Location = new System.Drawing.Point(592, 434);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(86, 36);
            this.btn_exit.TabIndex = 7;
            this.btn_exit.Text = "Выход";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_new_font
            // 
            this.btn_new_font.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_new_font.Location = new System.Drawing.Point(35, 312);
            this.btn_new_font.Name = "btn_new_font";
            this.btn_new_font.Size = new System.Drawing.Size(166, 36);
            this.btn_new_font.TabIndex = 8;
            this.btn_new_font.Text = "Выбрать шрифт";
            this.btn_new_font.UseVisualStyleBackColor = true;
            this.btn_new_font.Click += new System.EventHandler(this.btn_new_font_Click);
            // 
            // graph_function
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 497);
            this.Controls.Add(this.btn_new_font);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.pictureBox_graph_func);
            this.Controls.Add(this.btn_create_graph);
            this.Controls.Add(this.numeric_elasticity);
            this.Controls.Add(this.numeric_count_point);
            this.Controls.Add(this.lbl_elasticity);
            this.Controls.Add(this.lbl_count_point);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(733, 536);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(733, 536);
            this.Name = "graph_function";
            this.Text = "graph_function";
            this.Load += new System.EventHandler(this.graph_function_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numeric_count_point)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_elasticity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_graph_func)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_count_point;
        private System.Windows.Forms.Label lbl_elasticity;
        private System.Windows.Forms.NumericUpDown numeric_count_point;
        private System.Windows.Forms.NumericUpDown numeric_elasticity;
        private System.Windows.Forms.Button btn_create_graph;
        private System.Windows.Forms.PictureBox pictureBox_graph_func;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_new_font;
    }
}

