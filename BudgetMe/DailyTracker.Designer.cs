namespace BudgetMe
{
    partial class DailyTracker
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dailyprgbar = new CircularProgressBar.CircularProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel2 = new System.Windows.Forms.Panel();
            this.surplusamt = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.shortageamt = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.statusamt = new System.Windows.Forms.Label();
            this.Transactions = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dailyExpensessBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.budgetMeDatabasesDataSet = new BudgetMe.BudgetMeDatabasesDataSet();
            this.dailyExpensessBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dailyExpensesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.transactBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transactBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.dailyExpensessTableAdapter = new BudgetMe.BudgetMeDatabasesDataSetTableAdapters.DailyExpensessTableAdapter();
            this.tableAdapterManager = new BudgetMe.BudgetMeDatabasesDataSetTableAdapters.TableAdapterManager();
            this.newday_button = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Transactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dailyExpensessBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetMeDatabasesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dailyExpensessBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dailyExpensesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(100)))), ((int)(((byte)(146)))));
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.dailyprgbar);
            this.panel4.Location = new System.Drawing.Point(52, 47);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(225, 219);
            this.panel4.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Poppins Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(60, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 36);
            this.label2.TabIndex = 11;
            this.label2.Text = "------";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(53, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Daily Limit Left";
            // 
            // dailyprgbar
            // 
            this.dailyprgbar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.dailyprgbar.AnimationSpeed = 500;
            this.dailyprgbar.BackColor = System.Drawing.Color.Transparent;
            this.dailyprgbar.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.dailyprgbar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(100)))), ((int)(((byte)(146)))));
            this.dailyprgbar.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(100)))), ((int)(((byte)(146)))));
            this.dailyprgbar.InnerMargin = 2;
            this.dailyprgbar.InnerWidth = -1;
            this.dailyprgbar.Location = new System.Drawing.Point(9, 5);
            this.dailyprgbar.MarqueeAnimationSpeed = 2000;
            this.dailyprgbar.Name = "dailyprgbar";
            this.dailyprgbar.OuterColor = System.Drawing.Color.White;
            this.dailyprgbar.OuterMargin = -25;
            this.dailyprgbar.OuterWidth = 26;
            this.dailyprgbar.ProgressColor = System.Drawing.Color.Aqua;
            this.dailyprgbar.ProgressWidth = 15;
            this.dailyprgbar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.dailyprgbar.Size = new System.Drawing.Size(206, 208);
            this.dailyprgbar.StartAngle = 270;
            this.dailyprgbar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.dailyprgbar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.dailyprgbar.SubscriptText = ".23";
            this.dailyprgbar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.dailyprgbar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.dailyprgbar.SuperscriptText = "°C";
            this.dailyprgbar.TabIndex = 31;
            this.dailyprgbar.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.dailyprgbar.Value = 68;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(48, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "Daily Limit : 5000/=";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.chart1);
            this.panel1.Location = new System.Drawing.Point(312, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(542, 219);
            this.panel1.TabIndex = 17;
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            this.chart1.BackSecondaryColor = System.Drawing.Color.White;
            this.chart1.BorderSkin.BackColor = System.Drawing.Color.White;
            this.chart1.BorderSkin.PageColor = System.Drawing.Color.Transparent;
            chartArea1.BorderColor = System.Drawing.Color.White;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(-26, 2);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "DailyChart";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(697, 221);
            this.chart1.TabIndex = 21;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(100)))), ((int)(((byte)(146)))));
            this.panel2.Controls.Add(this.surplusamt);
            this.panel2.Location = new System.Drawing.Point(52, 300);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(225, 61);
            this.panel2.TabIndex = 20;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // surplusamt
            // 
            this.surplusamt.AutoSize = true;
            this.surplusamt.BackColor = System.Drawing.Color.Transparent;
            this.surplusamt.Font = new System.Drawing.Font("Poppins Medium", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surplusamt.ForeColor = System.Drawing.Color.White;
            this.surplusamt.Location = new System.Drawing.Point(54, 8);
            this.surplusamt.Name = "surplusamt";
            this.surplusamt.Size = new System.Drawing.Size(109, 44);
            this.surplusamt.TabIndex = 25;
            this.surplusamt.Text = "-----";
            this.surplusamt.Click += new System.EventHandler(this.label7_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(48, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 19);
            this.label1.TabIndex = 17;
            this.label1.Text = "Surplus";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(334, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 19);
            this.label3.TabIndex = 21;
            this.label3.Text = "Shortage";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(100)))), ((int)(((byte)(146)))));
            this.panel3.Controls.Add(this.shortageamt);
            this.panel3.Location = new System.Drawing.Point(338, 300);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(225, 61);
            this.panel3.TabIndex = 22;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // shortageamt
            // 
            this.shortageamt.AutoSize = true;
            this.shortageamt.BackColor = System.Drawing.Color.Transparent;
            this.shortageamt.Font = new System.Drawing.Font("Poppins Medium", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shortageamt.ForeColor = System.Drawing.Color.White;
            this.shortageamt.Location = new System.Drawing.Point(56, 8);
            this.shortageamt.Name = "shortageamt";
            this.shortageamt.Size = new System.Drawing.Size(109, 44);
            this.shortageamt.TabIndex = 26;
            this.shortageamt.Text = "-----";
            this.shortageamt.Click += new System.EventHandler(this.label8_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(625, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 19);
            this.label6.TabIndex = 23;
            this.label6.Text = "Yesturday Status";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(100)))), ((int)(((byte)(146)))));
            this.panel5.Controls.Add(this.statusamt);
            this.panel5.Location = new System.Drawing.Point(629, 300);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(225, 61);
            this.panel5.TabIndex = 24;
            // 
            // statusamt
            // 
            this.statusamt.AutoSize = true;
            this.statusamt.BackColor = System.Drawing.Color.Transparent;
            this.statusamt.Font = new System.Drawing.Font("Poppins Medium", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusamt.ForeColor = System.Drawing.Color.White;
            this.statusamt.Location = new System.Drawing.Point(59, 8);
            this.statusamt.Name = "statusamt";
            this.statusamt.Size = new System.Drawing.Size(109, 44);
            this.statusamt.TabIndex = 27;
            this.statusamt.Text = "-----";
            this.statusamt.Click += new System.EventHandler(this.statusamt_Click);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(100)))), ((int)(((byte)(146)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Transactions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Transactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Transactions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.Transactions.DataSource = this.dailyExpensessBindingSource1;
            this.Transactions.EnableHeadersVisualStyles = false;
            this.Transactions.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.Transactions.Location = new System.Drawing.Point(52, 419);
            this.Transactions.Name = "Transactions";
            this.Transactions.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Transactions.RowHeadersWidth = 51;
            this.Transactions.RowTemplate.DividerHeight = 10;
            this.Transactions.Size = new System.Drawing.Size(802, 229);
            this.Transactions.TabIndex = 28;
            this.Transactions.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Transactions_CellContentClick);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Dates";
            this.dataGridViewTextBoxColumn2.HeaderText = "Dates";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Names";
            this.dataGridViewTextBoxColumn3.HeaderText = "Names";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Descriptions";
            this.dataGridViewTextBoxColumn4.HeaderText = "Descriptions";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Amount";
            this.dataGridViewTextBoxColumn5.HeaderText = "Amount";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dailyExpensessBindingSource1
            // 
            this.dailyExpensessBindingSource1.DataMember = "DailyExpensess";
            this.dailyExpensessBindingSource1.DataSource = this.budgetMeDatabasesDataSet;
            // 
            // budgetMeDatabasesDataSet
            // 
            this.budgetMeDatabasesDataSet.DataSetName = "BudgetMeDatabasesDataSet";
            this.budgetMeDatabasesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dailyExpensesBindingSource
            // 
            this.dailyExpensesBindingSource.DataMember = "DailyExpenses";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(48, 380);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(147, 19);
            this.label10.TabIndex = 27;
            this.label10.Text = "Daily Transactions";
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(629, 371);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 37);
            this.button1.TabIndex = 29;
            this.button1.Text = "Add Daily Expense";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(308, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(289, 19);
            this.label11.TabIndex = 30;
            this.label11.Text = "Daily Surplus/Shortage For the Month";
            // 
            // panel6
            // 
            this.panel6.Location = new System.Drawing.Point(14, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(38, 37);
            this.panel6.TabIndex = 32;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint_1);
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Poppins SemiBold", 8F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(204, 374);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 34);
            this.button2.TabIndex = 33;
            this.button2.Text = "REFRESH";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dailyExpensessTableAdapter
            // 
            this.dailyExpensessTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DailyExpensessTableAdapter = this.dailyExpensessTableAdapter;
            this.tableAdapterManager.UpdateOrder = BudgetMe.BudgetMeDatabasesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // newday_button
            // 
            this.newday_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.newday_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newday_button.Font = new System.Drawing.Font("Poppins SemiBold", 8F, System.Drawing.FontStyle.Bold);
            this.newday_button.ForeColor = System.Drawing.Color.White;
            this.newday_button.Location = new System.Drawing.Point(326, 373);
            this.newday_button.Name = "newday_button";
            this.newday_button.Size = new System.Drawing.Size(103, 34);
            this.newday_button.TabIndex = 34;
            this.newday_button.Text = "NEW DAY";
            this.newday_button.UseVisualStyleBackColor = true;
            this.newday_button.Click += new System.EventHandler(this.newday_button_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Poppins SemiBold", 8F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(696, 17);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(158, 25);
            this.button3.TabIndex = 35;
            this.button3.Text = "REFRESH CHART";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // DailyTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.newday_button);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Transactions);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Name = "DailyTracker";
            this.Size = new System.Drawing.Size(907, 759);
            this.Load += new System.EventHandler(this.DailyTracker_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Transactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dailyExpensessBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetMeDatabasesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dailyExpensessBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dailyExpensesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label surplusamt;
        private System.Windows.Forms.Label shortageamt;
        private System.Windows.Forms.Label statusamt;
        private System.Windows.Forms.DataGridView Transactions;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.BindingSource dailyExpensesBindingSource;
        private System.Windows.Forms.BindingSource dailyExpensessBindingSource;

        private System.Windows.Forms.BindingSource transactBindingSource;
        private System.Windows.Forms.BindingSource transactBindingSource1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.BindingSource dailyExpensessBindingSource1;
        private BudgetMeDatabasesDataSet budgetMeDatabasesDataSet;
        private BudgetMeDatabasesDataSetTableAdapters.DailyExpensessTableAdapter dailyExpensessTableAdapter;
        private BudgetMeDatabasesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button newday_button;
        private System.Windows.Forms.Button button3;
        private CircularProgressBar.CircularProgressBar dailyprgbar;
    }
}
