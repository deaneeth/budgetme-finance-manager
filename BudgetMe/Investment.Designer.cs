namespace BudgetMe
{
    partial class Investment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.namesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.investmentDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.budgetMeDatabasesDataSet2InvestDetails = new BudgetMe.BudgetMeDatabasesDataSet2InvestDetails();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.datesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namesDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.investmentsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.budgetMeDatabasesDataSet2 = new BudgetMe.BudgetMeDatabasesDataSet2();
            this.investmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.budgetMeDatabasesDataSet2Invests = new BudgetMe.BudgetMeDatabasesDataSet2Invests();
            this.label10 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.invst = new System.Windows.Forms.Label();
            this.invstamt = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.investmentDetailsTableAdapter = new BudgetMe.BudgetMeDatabasesDataSet2InvestDetailsTableAdapters.InvestmentDetailsTableAdapter();
            this.tableAdapterManager = new BudgetMe.BudgetMeDatabasesDataSet2InvestDetailsTableAdapters.TableAdapterManager();
            this.investmentsTableAdapter = new BudgetMe.BudgetMeDatabasesDataSet2InvestsTableAdapters.InvestmentsTableAdapter();
            this.tableAdapterManager1 = new BudgetMe.BudgetMeDatabasesDataSet2InvestsTableAdapters.TableAdapterManager();
            this.investmentsTableAdapter1 = new BudgetMe.BudgetMeDatabasesDataSet2TableAdapters.InvestmentsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.investmentDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetMeDatabasesDataSet2InvestDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.investmentsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetMeDatabasesDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.investmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetMeDatabasesDataSet2Invests)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(283, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 19);
            this.label1.TabIndex = 45;
            this.label1.Text = "Investment Details";
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Poppins SemiBold", 8F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(170, 281);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 34);
            this.button2.TabIndex = 44;
            this.button2.Text = "REFRESH";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(577, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(267, 32);
            this.button1.TabIndex = 42;
            this.button1.Text = "Add Investment Transaction";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView3.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView3.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView3.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(100)))), ((int)(((byte)(146)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.namesDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.investmentDetailsBindingSource;
            this.dataGridView3.EnableHeadersVisualStyles = false;
            this.dataGridView3.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.dataGridView3.Location = new System.Drawing.Point(287, 51);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.DividerHeight = 10;
            this.dataGridView3.Size = new System.Drawing.Size(557, 219);
            this.dataGridView3.TabIndex = 41;
            // 
            // namesDataGridViewTextBoxColumn
            // 
            this.namesDataGridViewTextBoxColumn.DataPropertyName = "Names";
            this.namesDataGridViewTextBoxColumn.HeaderText = "Names";
            this.namesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namesDataGridViewTextBoxColumn.Name = "namesDataGridViewTextBoxColumn";
            this.namesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // investmentDetailsBindingSource
            // 
            this.investmentDetailsBindingSource.DataMember = "InvestmentDetails";
            this.investmentDetailsBindingSource.DataSource = this.budgetMeDatabasesDataSet2InvestDetails;
            // 
            // budgetMeDatabasesDataSet2InvestDetails
            // 
            this.budgetMeDatabasesDataSet2InvestDetails.DataSetName = "BudgetMeDatabasesDataSet2InvestDetails";
            this.budgetMeDatabasesDataSet2InvestDetails.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(100)))), ((int)(((byte)(146)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.datesDataGridViewTextBoxColumn,
            this.namesDataGridViewTextBoxColumn1,
            this.descriptionsDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn1});
            this.dataGridView1.DataSource = this.investmentsBindingSource1;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.dataGridView1.Location = new System.Drawing.Point(42, 326);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.DividerHeight = 10;
            this.dataGridView1.Size = new System.Drawing.Size(802, 313);
            this.dataGridView1.TabIndex = 40;
            // 
            // datesDataGridViewTextBoxColumn
            // 
            this.datesDataGridViewTextBoxColumn.DataPropertyName = "Dates";
            this.datesDataGridViewTextBoxColumn.HeaderText = "Dates";
            this.datesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.datesDataGridViewTextBoxColumn.Name = "datesDataGridViewTextBoxColumn";
            // 
            // namesDataGridViewTextBoxColumn1
            // 
            this.namesDataGridViewTextBoxColumn1.DataPropertyName = "Names";
            this.namesDataGridViewTextBoxColumn1.HeaderText = "Names";
            this.namesDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.namesDataGridViewTextBoxColumn1.Name = "namesDataGridViewTextBoxColumn1";
            // 
            // descriptionsDataGridViewTextBoxColumn
            // 
            this.descriptionsDataGridViewTextBoxColumn.DataPropertyName = "Descriptions";
            this.descriptionsDataGridViewTextBoxColumn.HeaderText = "Descriptions";
            this.descriptionsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionsDataGridViewTextBoxColumn.Name = "descriptionsDataGridViewTextBoxColumn";
            // 
            // amountDataGridViewTextBoxColumn1
            // 
            this.amountDataGridViewTextBoxColumn1.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn1.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.amountDataGridViewTextBoxColumn1.Name = "amountDataGridViewTextBoxColumn1";
            // 
            // investmentsBindingSource1
            // 
            this.investmentsBindingSource1.DataMember = "Investments";
            this.investmentsBindingSource1.DataSource = this.budgetMeDatabasesDataSet2;
            // 
            // budgetMeDatabasesDataSet2
            // 
            this.budgetMeDatabasesDataSet2.DataSetName = "BudgetMeDatabasesDataSet2";
            this.budgetMeDatabasesDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // investmentsBindingSource
            // 
            this.investmentsBindingSource.DataMember = "Investments";
            this.investmentsBindingSource.DataSource = this.budgetMeDatabasesDataSet2Invests;
            // 
            // budgetMeDatabasesDataSet2Invests
            // 
            this.budgetMeDatabasesDataSet2Invests.DataSetName = "BudgetMeDatabasesDataSet2Invests";
            this.budgetMeDatabasesDataSet2Invests.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(38, 289);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 19);
            this.label10.TabIndex = 39;
            this.label10.Text = "Investments";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(100)))), ((int)(((byte)(146)))));
            this.panel4.Controls.Add(this.invst);
            this.panel4.Controls.Add(this.invstamt);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Location = new System.Drawing.Point(42, 51);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(231, 212);
            this.panel4.TabIndex = 38;
            // 
            // invst
            // 
            this.invst.AutoSize = true;
            this.invst.BackColor = System.Drawing.Color.Transparent;
            this.invst.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invst.ForeColor = System.Drawing.Color.White;
            this.invst.Location = new System.Drawing.Point(67, 79);
            this.invst.Name = "invst";
            this.invst.Size = new System.Drawing.Size(92, 19);
            this.invst.TabIndex = 10;
            this.invst.Text = "Investment";
            // 
            // invstamt
            // 
            this.invstamt.AutoSize = true;
            this.invstamt.BackColor = System.Drawing.Color.Transparent;
            this.invstamt.Font = new System.Drawing.Font("Poppins Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invstamt.ForeColor = System.Drawing.Color.White;
            this.invstamt.Location = new System.Drawing.Point(62, 98);
            this.invstamt.Name = "invstamt";
            this.invstamt.Size = new System.Drawing.Size(105, 36);
            this.invstamt.TabIndex = 11;
            this.invstamt.Text = "------";
            this.invstamt.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::BudgetMe.Properties.Resources.measure;
            this.pictureBox2.Location = new System.Drawing.Point(15, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(201, 194);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(42, 351);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 291);
            this.panel1.TabIndex = 43;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(68, 17);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(802, 291);
            this.panel2.TabIndex = 36;
            // 
            // investmentDetailsTableAdapter
            // 
            this.investmentDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.InvestmentDetailsTableAdapter = this.investmentDetailsTableAdapter;
            this.tableAdapterManager.UpdateOrder = BudgetMe.BudgetMeDatabasesDataSet2InvestDetailsTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // investmentsTableAdapter
            // 
            this.investmentsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.InvestmentsTableAdapter = this.investmentsTableAdapter;
            this.tableAdapterManager1.UpdateOrder = BudgetMe.BudgetMeDatabasesDataSet2InvestsTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // investmentsTableAdapter1
            // 
            this.investmentsTableAdapter1.ClearBeforeFill = true;
            // 
            // Investment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Name = "Investment";
            this.Size = new System.Drawing.Size(882, 664);
            this.Load += new System.EventHandler(this.Investment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.investmentDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetMeDatabasesDataSet2InvestDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.investmentsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetMeDatabasesDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.investmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetMeDatabasesDataSet2Invests)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn namesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource investmentDetailsBindingSource;
        private BudgetMeDatabasesDataSet2InvestDetails budgetMeDatabasesDataSet2InvestDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn datesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namesDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource investmentsBindingSource;
        private BudgetMeDatabasesDataSet2Invests budgetMeDatabasesDataSet2Invests;
        private BudgetMeDatabasesDataSet2InvestDetailsTableAdapters.InvestmentDetailsTableAdapter investmentDetailsTableAdapter;
        private BudgetMeDatabasesDataSet2InvestDetailsTableAdapters.TableAdapterManager tableAdapterManager;
        private BudgetMeDatabasesDataSet2InvestsTableAdapters.InvestmentsTableAdapter investmentsTableAdapter;
        private BudgetMeDatabasesDataSet2InvestsTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.BindingSource investmentsBindingSource1;
        private BudgetMeDatabasesDataSet2 budgetMeDatabasesDataSet2;
        private BudgetMeDatabasesDataSet2TableAdapters.InvestmentsTableAdapter investmentsTableAdapter1;
        private System.Windows.Forms.Label invst;
        private System.Windows.Forms.Label invstamt;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
