namespace Radiostation_BD
{
    partial class Workinglist
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
            this.workinglistBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.radiostationDataSet0 = new Radiostation_BD.radiostationDataSet0();
            this.working_listTableAdapter = new Radiostation_BD.radiostationDataSet0TableAdapters.working_listTableAdapter();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.tbStr = new System.Windows.Forms.TextBox();
            this.idemployeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idrecordsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timerecordsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workinglistBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radiostationDataSet0)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idemployeeDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.idrecordsDataGridViewTextBoxColumn,
            this.timerecordsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.workinglistBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(698, 450);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow);
            // 
            // workinglistBindingSource
            // 
            this.workinglistBindingSource.DataMember = "working_list";
            this.workinglistBindingSource.DataSource = this.radiostationDataSet0;
            // 
            // radiostationDataSet0
            // 
            this.radiostationDataSet0.DataSetName = "radiostationDataSet0";
            this.radiostationDataSet0.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // working_listTableAdapter
            // 
            this.working_listTableAdapter.ClearBeforeFill = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(12, 386);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(130, 35);
            this.button6.TabIndex = 22;
            this.button6.Text = "Удалить";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(148, 386);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(130, 35);
            this.button7.TabIndex = 21;
            this.button7.Text = "Редактировать";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(284, 386);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(130, 35);
            this.button8.TabIndex = 20;
            this.button8.Text = "Найти";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(420, 386);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(130, 35);
            this.button9.TabIndex = 19;
            this.button9.Text = "Добавить";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(556, 386);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(130, 35);
            this.button10.TabIndex = 18;
            this.button10.Text = "Сохранить";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // tbStr
            // 
            this.tbStr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbStr.Location = new System.Drawing.Point(0, 427);
            this.tbStr.Name = "tbStr";
            this.tbStr.Size = new System.Drawing.Size(698, 23);
            this.tbStr.TabIndex = 23;
            this.tbStr.Text = "Введите данные";
            // 
            // idemployeeDataGridViewTextBoxColumn
            // 
            this.idemployeeDataGridViewTextBoxColumn.DataPropertyName = "id_employee";
            this.idemployeeDataGridViewTextBoxColumn.HeaderText = "Код сотрудника";
            this.idemployeeDataGridViewTextBoxColumn.Name = "idemployeeDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 185;
            // 
            // idrecordsDataGridViewTextBoxColumn
            // 
            this.idrecordsDataGridViewTextBoxColumn.DataPropertyName = "id_records";
            this.idrecordsDataGridViewTextBoxColumn.HeaderText = "Код записей";
            this.idrecordsDataGridViewTextBoxColumn.Name = "idrecordsDataGridViewTextBoxColumn";
            this.idrecordsDataGridViewTextBoxColumn.Width = 185;
            // 
            // timerecordsDataGridViewTextBoxColumn
            // 
            this.timerecordsDataGridViewTextBoxColumn.DataPropertyName = "time_records";
            this.timerecordsDataGridViewTextBoxColumn.HeaderText = "Время записей";
            this.timerecordsDataGridViewTextBoxColumn.Name = "timerecordsDataGridViewTextBoxColumn";
            this.timerecordsDataGridViewTextBoxColumn.Width = 185;
            // 
            // Workinglist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 450);
            this.Controls.Add(this.tbStr);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Workinglist";
            this.Text = "Таблица - График работы";
            this.Load += new System.EventHandler(this.Workinglist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workinglistBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radiostationDataSet0)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private radiostationDataSet0 radiostationDataSet0;
        private System.Windows.Forms.BindingSource workinglistBindingSource;
        private radiostationDataSet0TableAdapters.working_listTableAdapter working_listTableAdapter;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.TextBox tbStr;
        private System.Windows.Forms.DataGridViewTextBoxColumn idemployeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idrecordsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timerecordsDataGridViewTextBoxColumn;
    }
}