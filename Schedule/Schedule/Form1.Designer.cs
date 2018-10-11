namespace Schedule
{
    partial class Form1
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
            this.rtbWorks = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSolve = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbWorkersCount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbPointsCount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbWorks
            // 
            this.rtbWorks.Location = new System.Drawing.Point(19, 36);
            this.rtbWorks.Name = "rtbWorks";
            this.rtbWorks.Size = new System.Drawing.Size(30, 162);
            this.rtbWorks.TabIndex = 0;
            this.rtbWorks.Text = "A-D\nB-D\nC-A\nE-A\nF-D";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Последовательность работ:";
            // 
            // btnSolve
            // 
            this.btnSolve.Location = new System.Drawing.Point(70, 160);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new System.Drawing.Size(44, 19);
            this.btnSolve.TabIndex = 2;
            this.btnSolve.Text = "Go";
            this.btnSolve.UseVisualStyleBackColor = true;
            this.btnSolve.Click += new System.EventHandler(this.btnSolve_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Кол-во исполнителей:";
            // 
            // tbWorkersCount
            // 
            this.tbWorkersCount.Location = new System.Drawing.Point(70, 52);
            this.tbWorkersCount.Name = "tbWorkersCount";
            this.tbWorkersCount.Size = new System.Drawing.Size(70, 20);
            this.tbWorkersCount.TabIndex = 4;
            this.tbWorkersCount.Text = "3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(261, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Результат:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(259, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(159, 134);
            this.dataGridView1.TabIndex = 6;
            // 
            // tbPointsCount
            // 
            this.tbPointsCount.Location = new System.Drawing.Point(70, 101);
            this.tbPointsCount.Name = "tbPointsCount";
            this.tbPointsCount.Size = new System.Drawing.Size(100, 20);
            this.tbPointsCount.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Кол-во работ:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 219);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbPointsCount);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbWorkersCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSolve);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbWorks);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbWorks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSolve;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbWorkersCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tbPointsCount;
        private System.Windows.Forms.Label label4;
    }
}

