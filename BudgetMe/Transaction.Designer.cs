namespace BudgetMe
{
    partial class Transaction
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.Transactions = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.budgetMeDatabasesDataSet2trans = new BudgetMe.BudgetMeDatabasesDataSet2trans();
            this.transactionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transactionsTableAdapter = new BudgetMe.BudgetMeDatabasesDataSet2transTableAdapters.TransactionsTableAdapter();
            this.tableAdapterManager = new BudgetMe.BudgetMeDatabasesDataSet2transTableAdapters.TableAdapterManager();
            this.datesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Transactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetMeDatabasesDataSet2trans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(621, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 32);
            this.button1.TabIndex = 32;
            this.button1.Text = "Add Transaction";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Transactions
            // 
            this.Transactions.AutoGenerateColumns = false;
            this.Transactions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Transactions.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.Transactions.BackgroundColor = System.Drawing.Color.White;
            this.Transactions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Transactions.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.Transactions.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(100)))), ((int)(((byte)(146)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Transactions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.Transactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Transactions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.datesDataGridViewTextBoxColumn,
            this.namesDataGridViewTextBoxColumn,
            this.descriptionsDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn});
            this.Transactions.DataSource = this.transactionsBindingSource;
            this.Transactions.EnableHeadersVisualStyles = false;
            this.Transactions.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.Transactions.Location = new System.Drawing.Point(44, 75);
            this.Transactions.Name = "Transactions";
            this.Transactions.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Transactions.RowTemplate.DividerHeight = 10;
            this.Transactions.Size = new System.Drawing.Size(802, 557);
            this.Transactions.TabIndex = 31;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(40, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 19);
            this.label10.TabIndex = 30;
            this.label10.Text = "All Transactions";
            // 
            // budgetMeDatabasesDataSet2trans
            // 
            this.budgetMeDatabasesDataSet2trans.DataSetName = "BudgetMeDatabasesDataSet2trans";
            this.budgetMeDatabasesDataSet2trans.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // transactionsBindingSource
            // 
            this.transactionsBindingSource.DataMember = "Transactions";
            this.transactionsBindingSource.DataSource = this.budgetMeDatabasesDataSet2trans;
            // 
            // transactionsTableAdapter
            // 
            this.transactionsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TransactionsTableAdapter = this.transactionsTableAdapter;
            this.tableAdapterManager.UpdateOrder = BudgetMe.BudgetMeDatabasesDataSet2transTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // datesDataGridViewTextBoxColumn
            // 
            this.datesDataGridViewTextBoxColumn.DataPropertyName = "Dates";
            this.datesDataGridViewTextBoxColumn.HeaderText = "Dates";
            this.datesDataGridViewTextBoxColumn.Name = "datesDataGridViewTextBoxColumn";
            // 
            // namesDataGridViewTextBoxColumn
            // 
            this.namesDataGridViewTextBoxColumn.DataPropertyName = "Names";
            this.namesDataGridViewTextBoxColumn.HeaderText = "Names";
            this.namesDataGridViewTextBoxColumn.Name = "namesDataGridViewTextBoxColumn";
            // 
            // descriptionsDataGridViewTextBoxColumn
            // 
            this.descriptionsDataGridViewTextBoxColumn.DataPropertyName = "Descriptions";
            this.descriptionsDataGridViewTextBoxColumn.HeaderText = "Descriptions";
            this.descriptionsDataGridViewTextBoxColumn.Name = "descriptionsDataGridViewTextBoxColumn";
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Poppins SemiBold", 8F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(174, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 34);
            this.button2.TabIndex = 37;
            this.button2.Text = "REFRESH";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Transaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Transactions);
            this.Controls.Add(this.label10);
            this.Name = "Transaction";
            this.Size = new System.Drawing.Size(901, 668);
            this.Load += new System.EventHandler(this.Transaction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Transactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetMeDatabasesDataSet2trans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView Transactions;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn datesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource transactionsBindingSource;
        private BudgetMeDatabasesDataSet2trans budgetMeDatabasesDataSet2trans;
        private BudgetMeDatabasesDataSet2transTableAdapters.TransactionsTableAdapter transactionsTableAdapter;
        private BudgetMeDatabasesDataSet2transTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button button2;
    }
}
