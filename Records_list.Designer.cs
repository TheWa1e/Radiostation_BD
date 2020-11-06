﻿namespace Radiostation_BD
{
    partial class Records_list
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
            this.recordslistBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.radiostationDataSet0 = new Radiostation_BD.radiostationDataSet0();
            this.records_listTableAdapter = new Radiostation_BD.radiostationDataSet0TableAdapters.records_listTableAdapter();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tbStr = new System.Windows.Forms.TextBox();
            this.idrecordsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timerecords1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coderecords1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timerecords2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coderecords2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timerecords3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coderecords3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordslistBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radiostationDataSet0)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idrecordsDataGridViewTextBoxColumn,
            this.timerecords1DataGridViewTextBoxColumn,
            this.coderecords1DataGridViewTextBoxColumn,
            this.timerecords2DataGridViewTextBoxColumn,
            this.coderecords2DataGridViewTextBoxColumn,
            this.timerecords3DataGridViewTextBoxColumn,
            this.coderecords3DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.recordslistBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(743, 450);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow);
            // 
            // recordslistBindingSource
            // 
            this.recordslistBindingSource.DataMember = "records_list";
            this.recordslistBindingSource.DataSource = this.radiostationDataSet0;
            // 
            // radiostationDataSet0
            // 
            this.radiostationDataSet0.DataSetName = "radiostationDataSet0";
            this.radiostationDataSet0.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // records_listTableAdapter
            // 
            this.records_listTableAdapter.ClearBeforeFill = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(57, 386);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(130, 35);
            this.button5.TabIndex = 16;
            this.button5.Text = "Удалить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(193, 386);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(130, 35);
            this.button4.TabIndex = 15;
            this.button4.Text = "Редактировать";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(329, 386);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 35);
            this.button3.TabIndex = 14;
            this.button3.Text = "Найти";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(465, 386);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 35);
            this.button2.TabIndex = 13;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(601, 386);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 35);
            this.button1.TabIndex = 12;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbStr
            // 
            this.tbStr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbStr.Location = new System.Drawing.Point(0, 427);
            this.tbStr.Name = "tbStr";
            this.tbStr.Size = new System.Drawing.Size(743, 23);
            this.tbStr.TabIndex = 17;
            this.tbStr.Text = "Введите данные";
            // 
            // idrecordsDataGridViewTextBoxColumn
            // 
            this.idrecordsDataGridViewTextBoxColumn.DataPropertyName = "id_records";
            this.idrecordsDataGridViewTextBoxColumn.HeaderText = "Код записи";
            this.idrecordsDataGridViewTextBoxColumn.Name = "idrecordsDataGridViewTextBoxColumn";
            // 
            // timerecords1DataGridViewTextBoxColumn
            // 
            this.timerecords1DataGridViewTextBoxColumn.DataPropertyName = "time_records_1";
            this.timerecords1DataGridViewTextBoxColumn.HeaderText = "Время записи 1";
            this.timerecords1DataGridViewTextBoxColumn.Name = "timerecords1DataGridViewTextBoxColumn";
            // 
            // coderecords1DataGridViewTextBoxColumn
            // 
            this.coderecords1DataGridViewTextBoxColumn.DataPropertyName = "code_records_1";
            this.coderecords1DataGridViewTextBoxColumn.HeaderText = "Код записи 1";
            this.coderecords1DataGridViewTextBoxColumn.Name = "coderecords1DataGridViewTextBoxColumn";
            // 
            // timerecords2DataGridViewTextBoxColumn
            // 
            this.timerecords2DataGridViewTextBoxColumn.DataPropertyName = "time_records_2";
            this.timerecords2DataGridViewTextBoxColumn.HeaderText = "Время записи 2";
            this.timerecords2DataGridViewTextBoxColumn.Name = "timerecords2DataGridViewTextBoxColumn";
            // 
            // coderecords2DataGridViewTextBoxColumn
            // 
            this.coderecords2DataGridViewTextBoxColumn.DataPropertyName = "code_records_2";
            this.coderecords2DataGridViewTextBoxColumn.HeaderText = "Код записи 2";
            this.coderecords2DataGridViewTextBoxColumn.Name = "coderecords2DataGridViewTextBoxColumn";
            // 
            // timerecords3DataGridViewTextBoxColumn
            // 
            this.timerecords3DataGridViewTextBoxColumn.DataPropertyName = "time_records_3";
            this.timerecords3DataGridViewTextBoxColumn.HeaderText = "Время записи 3";
            this.timerecords3DataGridViewTextBoxColumn.Name = "timerecords3DataGridViewTextBoxColumn";
            // 
            // coderecords3DataGridViewTextBoxColumn
            // 
            this.coderecords3DataGridViewTextBoxColumn.DataPropertyName = "code_records_3";
            this.coderecords3DataGridViewTextBoxColumn.HeaderText = "Код записи 3";
            this.coderecords3DataGridViewTextBoxColumn.Name = "coderecords3DataGridViewTextBoxColumn";
            // 
            // Records_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 450);
            this.Controls.Add(this.tbStr);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Records_list";
            this.Text = "Таблица - Лист записей";
            this.Load += new System.EventHandler(this.Records_list_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordslistBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radiostationDataSet0)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private radiostationDataSet0 radiostationDataSet0;
        private System.Windows.Forms.BindingSource recordslistBindingSource;
        private radiostationDataSet0TableAdapters.records_listTableAdapter records_listTableAdapter;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbStr;
        private System.Windows.Forms.DataGridViewTextBoxColumn idrecordsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timerecords1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coderecords1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timerecords2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coderecords2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timerecords3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coderecords3DataGridViewTextBoxColumn;
    }
}