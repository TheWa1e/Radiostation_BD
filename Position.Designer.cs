namespace Radiostation_BD
{
    partial class Position
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.positionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.radiostationDataSet0 = new Radiostation_BD.radiostationDataSet0();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.positionsTableAdapter = new Radiostation_BD.radiostationDataSet0TableAdapters.positionsTableAdapter();
            this.tbStr = new System.Windows.Forms.TextBox();
            this.idpositionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namepositionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dutiesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.demandsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radiostationDataSet0)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idpositionDataGridViewTextBoxColumn,
            this.namepositionDataGridViewTextBoxColumn,
            this.salaryDataGridViewTextBoxColumn,
            this.dutiesDataGridViewTextBoxColumn,
            this.demandsDataGridViewTextBoxColumn});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView1.DataSource = this.positionsBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(793, 450);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow);
            // 
            // positionsBindingSource
            // 
            this.positionsBindingSource.DataMember = "positions";
            this.positionsBindingSource.DataSource = this.radiostationDataSet0;
            // 
            // radiostationDataSet0
            // 
            this.radiostationDataSet0.DataSetName = "radiostationDataSet0";
            this.radiostationDataSet0.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(107, 386);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(130, 35);
            this.button5.TabIndex = 11;
            this.button5.Text = "Удалить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(243, 386);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(130, 35);
            this.button4.TabIndex = 10;
            this.button4.Text = "Редактировать";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(379, 386);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 35);
            this.button3.TabIndex = 9;
            this.button3.Text = "Найти";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(515, 386);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 35);
            this.button2.TabIndex = 8;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(651, 386);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 35);
            this.button1.TabIndex = 7;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // positionsTableAdapter
            // 
            this.positionsTableAdapter.ClearBeforeFill = true;
            // 
            // tbStr
            // 
            this.tbStr.CausesValidation = false;
            this.tbStr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbStr.Location = new System.Drawing.Point(0, 427);
            this.tbStr.Name = "tbStr";
            this.tbStr.Size = new System.Drawing.Size(793, 23);
            this.tbStr.TabIndex = 12;
            this.tbStr.Text = "Введите данные";
            // 
            // idpositionDataGridViewTextBoxColumn
            // 
            this.idpositionDataGridViewTextBoxColumn.DataPropertyName = "id_position";
            this.idpositionDataGridViewTextBoxColumn.HeaderText = "Код должности";
            this.idpositionDataGridViewTextBoxColumn.Name = "idpositionDataGridViewTextBoxColumn";
            // 
            // namepositionDataGridViewTextBoxColumn
            // 
            this.namepositionDataGridViewTextBoxColumn.DataPropertyName = "name_position";
            this.namepositionDataGridViewTextBoxColumn.HeaderText = "Наименование должности";
            this.namepositionDataGridViewTextBoxColumn.Name = "namepositionDataGridViewTextBoxColumn";
            this.namepositionDataGridViewTextBoxColumn.Width = 200;
            // 
            // salaryDataGridViewTextBoxColumn
            // 
            this.salaryDataGridViewTextBoxColumn.DataPropertyName = "salary";
            this.salaryDataGridViewTextBoxColumn.HeaderText = "Оклад";
            this.salaryDataGridViewTextBoxColumn.Name = "salaryDataGridViewTextBoxColumn";
            // 
            // dutiesDataGridViewTextBoxColumn
            // 
            this.dutiesDataGridViewTextBoxColumn.DataPropertyName = "duties";
            this.dutiesDataGridViewTextBoxColumn.HeaderText = "Обязанности";
            this.dutiesDataGridViewTextBoxColumn.Name = "dutiesDataGridViewTextBoxColumn";
            this.dutiesDataGridViewTextBoxColumn.Width = 175;
            // 
            // demandsDataGridViewTextBoxColumn
            // 
            this.demandsDataGridViewTextBoxColumn.DataPropertyName = "demands";
            this.demandsDataGridViewTextBoxColumn.HeaderText = "Требования";
            this.demandsDataGridViewTextBoxColumn.Name = "demandsDataGridViewTextBoxColumn";
            this.demandsDataGridViewTextBoxColumn.Width = 175;
            // 
            // Position
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 450);
            this.Controls.Add(this.tbStr);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Position";
            this.Text = "Таблица - Должности";
            this.Load += new System.EventHandler(this.Position_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radiostationDataSet0)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Button button5;
        public System.Windows.Forms.Button button4;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button1;
        public radiostationDataSet0 radiostationDataSet0;
        public System.Windows.Forms.BindingSource positionsBindingSource;
        public radiostationDataSet0TableAdapters.positionsTableAdapter positionsTableAdapter;
        private System.Windows.Forms.TextBox tbStr;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpositionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namepositionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dutiesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn demandsDataGridViewTextBoxColumn;
    }
}