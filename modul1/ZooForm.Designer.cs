namespace modul1
{
    partial class ZooForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZooForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.animal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requiredArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requiredTemperature = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalAreaLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.animal,
            this.requiredArea,
            this.requiredTemperature});
            this.dataGridView1.Location = new System.Drawing.Point(421, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(747, 375);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // animal
            // 
            this.animal.HeaderText = "Назва";
            this.animal.MinimumWidth = 8;
            this.animal.Name = "animal";
            this.animal.Width = 150;
            // 
            // requiredArea
            // 
            this.requiredArea.HeaderText = "Площа";
            this.requiredArea.MinimumWidth = 8;
            this.requiredArea.Name = "requiredArea";
            this.requiredArea.Width = 150;
            // 
            // requiredTemperature
            // 
            this.requiredTemperature.HeaderText = "Температура";
            this.requiredTemperature.MinimumWidth = 8;
            this.requiredTemperature.Name = "requiredTemperature";
            this.requiredTemperature.Width = 150;
            // 
            // totalAreaLabel
            // 
            this.totalAreaLabel.AutoSize = true;
            this.totalAreaLabel.Location = new System.Drawing.Point(31, 424);
            this.totalAreaLabel.Name = "totalAreaLabel";
            this.totalAreaLabel.Size = new System.Drawing.Size(0, 20);
            this.totalAreaLabel.TabIndex = 1;
            this.totalAreaLabel.Click += new System.EventHandler(this.totalAreaLabel_Click);
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(71, 352);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(240, 38);
            this.calculateButton.TabIndex = 2;
            this.calculateButton.Text = "Розрахувати площі вольєрів";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 260);
            this.label1.TabIndex = 3;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // ZooForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1187, 554);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.totalAreaLabel);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "ZooForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label totalAreaLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn animal;
        private System.Windows.Forms.DataGridViewTextBoxColumn requiredArea;
        private System.Windows.Forms.DataGridViewTextBoxColumn requiredTemperature;
        private System.Windows.Forms.Label label1;
    }
}

