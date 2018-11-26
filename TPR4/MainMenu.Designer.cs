namespace TPR4
{
    partial class MainMenu
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.exit = new System.Windows.Forms.Button();
            this.numalternative = new System.Windows.Forms.NumericUpDown();
            this.numcrit = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.createtable = new System.Windows.Forms.Button();
            this.clearbutton = new System.Windows.Forms.Button();
            this.calcbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numalternative)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numcrit)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(183, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(472, 415);
            this.dataGridView1.TabIndex = 0;
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("Georgia", 11.25F);
            this.exit.Location = new System.Drawing.Point(577, 433);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(78, 25);
            this.exit.TabIndex = 1;
            this.exit.Text = "Выход";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // numalternative
            // 
            this.numalternative.Location = new System.Drawing.Point(12, 51);
            this.numalternative.Name = "numalternative";
            this.numalternative.Size = new System.Drawing.Size(120, 20);
            this.numalternative.TabIndex = 2;
            // 
            // numcrit
            // 
            this.numcrit.Location = new System.Drawing.Point(12, 125);
            this.numcrit.Name = "numcrit";
            this.numcrit.Size = new System.Drawing.Size(120, 20);
            this.numcrit.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Кол-во альтернатив:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 11.25F);
            this.label2.Location = new System.Drawing.Point(12, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Кол-во критериев:";
            // 
            // createtable
            // 
            this.createtable.Font = new System.Drawing.Font("Georgia", 11.25F);
            this.createtable.Location = new System.Drawing.Point(12, 183);
            this.createtable.Name = "createtable";
            this.createtable.Size = new System.Drawing.Size(120, 30);
            this.createtable.TabIndex = 7;
            this.createtable.Text = "Создать таблицу";
            this.createtable.UseVisualStyleBackColor = true;
            this.createtable.Click += new System.EventHandler(this.createtable_Click);
            // 
            // clearbutton
            // 
            this.clearbutton.Font = new System.Drawing.Font("Georgia", 11.25F);
            this.clearbutton.Location = new System.Drawing.Point(12, 241);
            this.clearbutton.Name = "clearbutton";
            this.clearbutton.Size = new System.Drawing.Size(120, 29);
            this.clearbutton.TabIndex = 8;
            this.clearbutton.Text = "Очистка";
            this.clearbutton.UseVisualStyleBackColor = true;
            this.clearbutton.Click += new System.EventHandler(this.clearbutton_Click);
            // 
            // calcbutton
            // 
            this.calcbutton.Font = new System.Drawing.Font("Georgia", 11.25F);
            this.calcbutton.Location = new System.Drawing.Point(15, 391);
            this.calcbutton.Name = "calcbutton";
            this.calcbutton.Size = new System.Drawing.Size(120, 36);
            this.calcbutton.TabIndex = 9;
            this.calcbutton.Text = "Расчёт";
            this.calcbutton.UseVisualStyleBackColor = true;
            this.calcbutton.Click += new System.EventHandler(this.calcbutton_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(667, 463);
            this.Controls.Add(this.calcbutton);
            this.Controls.Add(this.clearbutton);
            this.Controls.Add(this.createtable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numcrit);
            this.Controls.Add(this.numalternative);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.Text = "ТПР №4";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numalternative)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numcrit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.NumericUpDown numalternative;
        private System.Windows.Forms.NumericUpDown numcrit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button createtable;
        private System.Windows.Forms.Button clearbutton;
        private System.Windows.Forms.Button calcbutton;
    }
}

