namespace TPR4
{
    partial class WeightCrit
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
            this.dataCrit = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataAlt = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataCrit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataAlt)).BeginInit();
            this.SuspendLayout();
            // 
            // dataCrit
            // 
            this.dataCrit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCrit.Location = new System.Drawing.Point(12, 44);
            this.dataCrit.Name = "dataCrit";
            this.dataCrit.Size = new System.Drawing.Size(432, 236);
            this.dataCrit.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Веса и названия критериев:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(704, 286);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "ОК";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataAlt
            // 
            this.dataAlt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataAlt.Location = new System.Drawing.Point(468, 44);
            this.dataAlt.Name = "dataAlt";
            this.dataAlt.Size = new System.Drawing.Size(311, 236);
            this.dataAlt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(464, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Названия альтернатив:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // WeightCrit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(791, 315);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataAlt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataCrit);
            this.Name = "WeightCrit";
            this.Text = "Создание таблицы";
            ((System.ComponentModel.ISupportInitialize)(this.dataCrit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataAlt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataCrit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataAlt;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button button1;
    }
}