namespace BudgetMe
{
    partial class DebtManager
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.debtamt = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.debtprgbar = new CircularProgressBar.CircularProgressBar();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.datesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.debtsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.budgetMeDatabasesDataSetDebt = new BudgetMe.BudgetMeDatabasesDataSetDebt();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.namesDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.debtorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.budgetMeDatabasesDataSet1 = new BudgetMe.BudgetMeDatabasesDataSet1();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.debtsTableAdapter = new BudgetMe.BudgetMeDatabasesDataSetDebtTableAdapters.DebtsTableAdapter();
            this.tableAdapterManager = new BudgetMe.BudgetMeDatabasesDataSetDebtTableAdapters.TableAdapterManager();
            this.label1 = new System.Windows.Forms.Label();
            this.debtorsTableAdapter = new BudgetMe.BudgetMeDatabasesDataSet1TableAdapters.DebtorsTableAdapter();
            this.tableAdapterManager1 = new BudgetMe.BudgetMeDatabasesDataSet1TableAdapters.TableAdapterManager();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.debtsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetMeDatabasesDataSetDebt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.debtorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetMeDatabasesDataSet1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(100)))), ((int)(((byte)(146)))));
            this.panel4.Controls.Add(this.debtamt);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.debtprgbar);
            this.panel4.Location = new System.Drawing.Point(53, 47);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(225, 219);
            this.panel4.TabIndex = 16;
            // 
            // debtamt
            // 
            this.debtamt.AutoSize = true;
            this.debtamt.BackColor = System.Drawing.Color.Transparent;
            this.debtamt.Font = new System.Drawing.Font("Poppins Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debtamt.ForeColor = System.Drawing.Color.White;
            this.debtamt.Location = new System.Drawing.Point(60, 107);
            this.debtamt.Name = "debtamt";
            this.debtamt.Size = new System.Drawing.Size(105, 36);
            this.debtamt.TabIndex = 11;
            this.debtamt.Text = "------";
            this.debtamt.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(49, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Debt to be paid";
            // 
            // debtprgbar
            // 
            this.debtprgbar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.debtprgbar.AnimationSpeed = 500;
            this.debtprgbar.BackColor = System.Drawing.Color.Transparent;
            this.debtprgbar.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.debtprgbar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(100)))), ((int)(((byte)(146)))));
            this.debtprgbar.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(100)))), ((int)(((byte)(146)))));
            this.debtprgbar.InnerMargin = 2;
            this.debtprgbar.InnerWidth = -1;
            this.debtprgbar.Location = new System.Drawing.Point(12, 8);
            this.debtprgbar.MarqueeAnimationSpeed = 2000;
            this.debtprgbar.Name = "debtprgbar";
            this.debtprgbar.OuterColor = System.Drawing.Color.Aqua;
            this.debtprgbar.OuterMargin = -25;
            this.debtprgbar.OuterWidth = 26;
            this.debtprgbar.ProgressColor = System.Drawing.Color.White;
            this.debtprgbar.ProgressWidth = 15;
            this.debtprgbar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.debtprgbar.Size = new System.Drawing.Size(202, 202);
            this.debtprgbar.StartAngle = 270;
            this.debtprgbar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.debtprgbar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.debtprgbar.SubscriptText = ".24";
            this.debtprgbar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.debtprgbar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.debtprgbar.SuperscriptText = "°C";
            this.debtprgbar.TabIndex = 39;
            this.debtprgbar.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.debtprgbar.Value = 68;
            this.debtprgbar.Click += new System.EventHandler(this.debtprgbar_Click_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(49, 285);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 19);
            this.label10.TabIndex = 30;
            this.label10.Text = "Debt Paid/Gain";
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(100)))), ((int)(((byte)(146)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.datesDataGridViewTextBoxColumn,
            this.namesDataGridViewTextBoxColumn,
            this.descriptionsDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.debtsBindingSource;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.dataGridView1.Location = new System.Drawing.Point(53, 322);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.DividerHeight = 10;
            this.dataGridView1.Size = new System.Drawing.Size(802, 313);
            this.dataGridView1.TabIndex = 31;
            // 
            // datesDataGridViewTextBoxColumn
            // 
            this.datesDataGridViewTextBoxColumn.DataPropertyName = "Dates";
            this.datesDataGridViewTextBoxColumn.HeaderText = "Dates";
            this.datesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.datesDataGridViewTextBoxColumn.Name = "datesDataGridViewTextBoxColumn";
            // 
            // namesDataGridViewTextBoxColumn
            // 
            this.namesDataGridViewTextBoxColumn.DataPropertyName = "Names";
            this.namesDataGridViewTextBoxColumn.HeaderText = "Names";
            this.namesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namesDataGridViewTextBoxColumn.Name = "namesDataGridViewTextBoxColumn";
            // 
            // descriptionsDataGridViewTextBoxColumn
            // 
            this.descriptionsDataGridViewTextBoxColumn.DataPropertyName = "Descriptions";
            this.descriptionsDataGridViewTextBoxColumn.HeaderText = "Descriptions";
            this.descriptionsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionsDataGridViewTextBoxColumn.Name = "descriptionsDataGridViewTextBoxColumn";
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            // 
            // debtsBindingSource
            // 
            this.debtsBindingSource.DataMember = "Debts";
            this.debtsBindingSource.DataSource = this.budgetMeDatabasesDataSetDebt;
            // 
            // budgetMeDatabasesDataSetDebt
            // 
            this.budgetMeDatabasesDataSetDebt.DataSetName = "BudgetMeDatabasesDataSetDebt";
            this.budgetMeDatabasesDataSetDebt.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView3.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView3.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView3.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(100)))), ((int)(((byte)(146)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.namesDataGridViewTextBoxColumn1,
            this.amountDataGridViewTextBoxColumn1});
            this.dataGridView3.DataSource = this.debtorsBindingSource;
            this.dataGridView3.EnableHeadersVisualStyles = false;
            this.dataGridView3.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.dataGridView3.Location = new System.Drawing.Point(298, 47);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.DividerHeight = 10;
            this.dataGridView3.Size = new System.Drawing.Size(557, 219);
            this.dataGridView3.TabIndex = 33;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // namesDataGridViewTextBoxColumn1
            // 
            this.namesDataGridViewTextBoxColumn1.DataPropertyName = "Names";
            this.namesDataGridViewTextBoxColumn1.HeaderText = "Names";
            this.namesDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.namesDataGridViewTextBoxColumn1.Name = "namesDataGridViewTextBoxColumn1";
            // 
            // amountDataGridViewTextBoxColumn1
            // 
            this.amountDataGridViewTextBoxColumn1.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn1.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.amountDataGridViewTextBoxColumn1.Name = "amountDataGridViewTextBoxColumn1";
            // 
            // debtorsBindingSource
            // 
            this.debtorsBindingSource.DataMember = "Debtors";
            this.debtorsBindingSource.DataSource = this.budgetMeDatabasesDataSet1;
            // 
            // budgetMeDatabasesDataSet1
            // 
            this.budgetMeDatabasesDataSet1.DataSetName = "BudgetMeDatabasesDataSet1";
            this.budgetMeDatabasesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(630, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 32);
            this.button1.TabIndex = 34;
            this.button1.Text = "Add Debt Transaction";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(53, 347);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 291);
            this.panel1.TabIndex = 35;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(68, 17);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(802, 291);
            this.panel2.TabIndex = 36;
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Poppins SemiBold", 8F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(181, 277);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 34);
            this.button2.TabIndex = 36;
            this.button2.Text = "REFRESH";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // debtsTableAdapter
            // 
            this.debtsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DebtsTableAdapter = this.debtsTableAdapter;
            this.tableAdapterManager.UpdateOrder = BudgetMe.BudgetMeDatabasesDataSetDebtTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(294, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 19);
            this.label1.TabIndex = 37;
            this.label1.Text = "Debtor Details";
            // 
            // debtorsTableAdapter
            // 
            this.debtorsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.DebtorsTableAdapter = this.debtorsTableAdapter;
            this.tableAdapterManager1.UpdateOrder = BudgetMe.BudgetMeDatabasesDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // DebtManager
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
            this.Name = "DebtManager";
            this.Size = new System.Drawing.Size(899, 669);
            this.Load += new System.EventHandler(this.DebtManager_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.debtsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetMeDatabasesDataSetDebt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.debtorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetMeDatabasesDataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label debtamt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn datesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource debtsBindingSource;
        private BudgetMeDatabasesDataSetDebt budgetMeDatabasesDataSetDebt;
        private BudgetMeDatabasesDataSetDebtTableAdapters.DebtsTableAdapter debtsTableAdapter;
        private BudgetMeDatabasesDataSetDebtTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn namesDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource debtorsBindingSource;
        private BudgetMeDatabasesDataSet1 budgetMeDatabasesDataSet1;
        private BudgetMeDatabasesDataSet1TableAdapters.DebtorsTableAdapter debtorsTableAdapter;
        private BudgetMeDatabasesDataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private CircularProgressBar.CircularProgressBar debtprgbar;
    }
}
