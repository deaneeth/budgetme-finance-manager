namespace BudgetMe
{
    partial class AllDash
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.spendprgbar = new CircularProgressBar.CircularProgressBar();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dailyprgbar = new CircularProgressBar.CircularProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.totamtlabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.totamtprgbar = new CircularProgressBar.CircularProgressBar();
            this.label8 = new System.Windows.Forms.Label();
            this.incometext = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.savingtext = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.exptext = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.spendtext = new System.Windows.Forms.TextBox();
            this.transact_button = new System.Windows.Forms.Button();
            this.Transactions = new System.Windows.Forms.DataGridView();
            this.datesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.budgetMeDatabasesDataSet2trans = new BudgetMe.BudgetMeDatabasesDataSet2trans();
            this.submit_button = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.transactionsTableAdapter = new BudgetMe.BudgetMeDatabasesDataSet2transTableAdapters.TransactionsTableAdapter();
            this.tableAdapterManager = new BudgetMe.BudgetMeDatabasesDataSet2transTableAdapters.TableAdapterManager();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Transactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetMeDatabasesDataSet2trans)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(100)))), ((int)(((byte)(146)))));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.spendprgbar);
            this.panel2.Location = new System.Drawing.Point(337, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(225, 219);
            this.panel2.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Poppins Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(63, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 36);
            this.label3.TabIndex = 8;
            this.label3.Text = "------";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(70, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Spendable";
            // 
            // spendprgbar
            // 
            this.spendprgbar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.spendprgbar.AnimationSpeed = 500;
            this.spendprgbar.BackColor = System.Drawing.Color.Transparent;
            this.spendprgbar.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.spendprgbar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(100)))), ((int)(((byte)(146)))));
            this.spendprgbar.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(100)))), ((int)(((byte)(146)))));
            this.spendprgbar.InnerMargin = 2;
            this.spendprgbar.InnerWidth = -1;
            this.spendprgbar.Location = new System.Drawing.Point(11, 6);
            this.spendprgbar.MarqueeAnimationSpeed = 2000;
            this.spendprgbar.Name = "spendprgbar";
            this.spendprgbar.OuterColor = System.Drawing.Color.Aqua;
            this.spendprgbar.OuterMargin = -25;
            this.spendprgbar.OuterWidth = 26;
            this.spendprgbar.ProgressColor = System.Drawing.Color.White;
            this.spendprgbar.ProgressWidth = 15;
            this.spendprgbar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.spendprgbar.Size = new System.Drawing.Size(206, 208);
            this.spendprgbar.StartAngle = 270;
            this.spendprgbar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.spendprgbar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.spendprgbar.SubscriptText = ".23";
            this.spendprgbar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.spendprgbar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.spendprgbar.SuperscriptText = "°C";
            this.spendprgbar.TabIndex = 29;
            this.spendprgbar.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.spendprgbar.Value = 68;
            this.spendprgbar.Click += new System.EventHandler(this.spendprgbar_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(100)))), ((int)(((byte)(146)))));
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.dailyprgbar);
            this.panel4.Location = new System.Drawing.Point(623, 48);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(225, 219);
            this.panel4.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Poppins", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(61, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Daily Limit : -----";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Poppins Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(59, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 36);
            this.label2.TabIndex = 11;
            this.label2.Text = "------";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(53, 80);
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
            this.dailyprgbar.Location = new System.Drawing.Point(10, 7);
            this.dailyprgbar.MarqueeAnimationSpeed = 2000;
            this.dailyprgbar.Name = "dailyprgbar";
            this.dailyprgbar.OuterColor = System.Drawing.Color.Aqua;
            this.dailyprgbar.OuterMargin = -25;
            this.dailyprgbar.OuterWidth = 26;
            this.dailyprgbar.ProgressColor = System.Drawing.Color.White;
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
            this.dailyprgbar.TabIndex = 30;
            this.dailyprgbar.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.dailyprgbar.Value = 68;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(100)))), ((int)(((byte)(146)))));
            this.panel1.Controls.Add(this.totamtlabel);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.totamtprgbar);
            this.panel1.Location = new System.Drawing.Point(50, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 219);
            this.panel1.TabIndex = 15;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // totamtlabel
            // 
            this.totamtlabel.AutoSize = true;
            this.totamtlabel.BackColor = System.Drawing.Color.Transparent;
            this.totamtlabel.Font = new System.Drawing.Font("Poppins Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totamtlabel.ForeColor = System.Drawing.Color.White;
            this.totamtlabel.Location = new System.Drawing.Point(60, 102);
            this.totamtlabel.Name = "totamtlabel";
            this.totamtlabel.Size = new System.Drawing.Size(105, 36);
            this.totamtlabel.TabIndex = 8;
            this.totamtlabel.Text = "------";
            this.totamtlabel.Click += new System.EventHandler(this.totamtlabel_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(58, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "Total Amount";
            // 
            // totamtprgbar
            // 
            this.totamtprgbar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.totamtprgbar.AnimationSpeed = 500;
            this.totamtprgbar.BackColor = System.Drawing.Color.Transparent;
            this.totamtprgbar.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.totamtprgbar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(100)))), ((int)(((byte)(146)))));
            this.totamtprgbar.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(100)))), ((int)(((byte)(146)))));
            this.totamtprgbar.InnerMargin = 2;
            this.totamtprgbar.InnerWidth = -1;
            this.totamtprgbar.Location = new System.Drawing.Point(9, 6);
            this.totamtprgbar.MarqueeAnimationSpeed = 2000;
            this.totamtprgbar.Name = "totamtprgbar";
            this.totamtprgbar.OuterColor = System.Drawing.Color.Aqua;
            this.totamtprgbar.OuterMargin = -25;
            this.totamtprgbar.OuterWidth = 26;
            this.totamtprgbar.ProgressColor = System.Drawing.Color.White;
            this.totamtprgbar.ProgressWidth = 15;
            this.totamtprgbar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.totamtprgbar.Size = new System.Drawing.Size(206, 208);
            this.totamtprgbar.StartAngle = 270;
            this.totamtprgbar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.totamtprgbar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.totamtprgbar.SubscriptText = ".24";
            this.totamtprgbar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.totamtprgbar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.totamtprgbar.SuperscriptText = "°C";
            this.totamtprgbar.TabIndex = 28;
            this.totamtprgbar.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.totamtprgbar.Value = 68;
            this.totamtprgbar.Click += new System.EventHandler(this.totamtprgbar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(334, 283);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 19);
            this.label8.TabIndex = 16;
            this.label8.Text = "Transactions";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // incometext
            // 
            this.incometext.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.incometext.Location = new System.Drawing.Point(50, 333);
            this.incometext.Multiline = true;
            this.incometext.Name = "incometext";
            this.incometext.Size = new System.Drawing.Size(225, 25);
            this.incometext.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(46, 311);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 19);
            this.label9.TabIndex = 18;
            this.label9.Text = "Income";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(46, 372);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 19);
            this.label10.TabIndex = 20;
            this.label10.Text = "Savings";
            // 
            // savingtext
            // 
            this.savingtext.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.savingtext.Location = new System.Drawing.Point(50, 394);
            this.savingtext.Multiline = true;
            this.savingtext.Name = "savingtext";
            this.savingtext.Size = new System.Drawing.Size(225, 25);
            this.savingtext.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(46, 434);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 19);
            this.label11.TabIndex = 22;
            this.label11.Text = "Fixed Expenses";
            // 
            // exptext
            // 
            this.exptext.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.exptext.Location = new System.Drawing.Point(50, 456);
            this.exptext.Multiline = true;
            this.exptext.Name = "exptext";
            this.exptext.Size = new System.Drawing.Size(225, 25);
            this.exptext.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(46, 496);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 19);
            this.label12.TabIndex = 24;
            this.label12.Text = "Spendable";
            // 
            // spendtext
            // 
            this.spendtext.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.spendtext.Location = new System.Drawing.Point(50, 518);
            this.spendtext.Multiline = true;
            this.spendtext.Name = "spendtext";
            this.spendtext.Size = new System.Drawing.Size(225, 25);
            this.spendtext.TabIndex = 23;
            // 
            // transact_button
            // 
            this.transact_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.transact_button.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.transact_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transact_button.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transact_button.ForeColor = System.Drawing.Color.White;
            this.transact_button.Location = new System.Drawing.Point(731, 277);
            this.transact_button.Name = "transact_button";
            this.transact_button.Size = new System.Drawing.Size(117, 29);
            this.transact_button.TabIndex = 25;
            this.transact_button.Text = "Add Trasaction";
            this.transact_button.UseVisualStyleBackColor = true;
            this.transact_button.Click += new System.EventHandler(this.transact_button_Click);
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
            this.datesDataGridViewTextBoxColumn,
            this.namesDataGridViewTextBoxColumn,
            this.descriptionsDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn});
            this.Transactions.DataSource = this.transactionsBindingSource;
            this.Transactions.EnableHeadersVisualStyles = false;
            this.Transactions.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.Transactions.Location = new System.Drawing.Point(338, 318);
            this.Transactions.Name = "Transactions";
            this.Transactions.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Transactions.RowTemplate.DividerHeight = 10;
            this.Transactions.Size = new System.Drawing.Size(512, 278);
            this.Transactions.TabIndex = 26;
            this.Transactions.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Transactions_CellContentClick);
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
            // transactionsBindingSource
            // 
            this.transactionsBindingSource.DataMember = "Transactions";
            this.transactionsBindingSource.DataSource = this.budgetMeDatabasesDataSet2trans;
            // 
            // budgetMeDatabasesDataSet2trans
            // 
            this.budgetMeDatabasesDataSet2trans.DataSetName = "BudgetMeDatabasesDataSet2trans";
            this.budgetMeDatabasesDataSet2trans.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // submit_button
            // 
            this.submit_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.submit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submit_button.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.submit_button.ForeColor = System.Drawing.Color.White;
            this.submit_button.Location = new System.Drawing.Point(50, 567);
            this.submit_button.Name = "submit_button";
            this.submit_button.Size = new System.Drawing.Size(225, 29);
            this.submit_button.TabIndex = 27;
            this.submit_button.Text = "Submit";
            this.submit_button.UseVisualStyleBackColor = true;
            this.submit_button.Click += new System.EventHandler(this.submit_button_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Poppins SemiBold", 8F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(172, 283);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 34);
            this.button2.TabIndex = 37;
            this.button2.Text = "REFRESH";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(597, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 29);
            this.button1.TabIndex = 38;
            this.button1.Text = "Add Daily";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(463, 277);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 29);
            this.button3.TabIndex = 39;
            this.button3.Text = "Add Debt";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
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
            // AllDash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.submit_button);
            this.Controls.Add(this.Transactions);
            this.Controls.Add(this.transact_button);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.spendtext);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.exptext);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.savingtext);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.incometext);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Name = "AllDash";
            this.Size = new System.Drawing.Size(901, 668);
            this.Load += new System.EventHandler(this.AllDash_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Transactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetMeDatabasesDataSet2trans)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label totamtlabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox incometext;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox savingtext;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox exptext;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox spendtext;
        private System.Windows.Forms.Button transact_button;
        private System.Windows.Forms.DataGridView Transactions;
        private System.Windows.Forms.Button submit_button;
        private CircularProgressBar.CircularProgressBar spendprgbar;
        private CircularProgressBar.CircularProgressBar dailyprgbar;
        private CircularProgressBar.CircularProgressBar totamtprgbar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn datesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource transactionsBindingSource;
        private BudgetMeDatabasesDataSet2trans budgetMeDatabasesDataSet2trans;
        private BudgetMeDatabasesDataSet2transTableAdapters.TransactionsTableAdapter transactionsTableAdapter;
        private BudgetMeDatabasesDataSet2transTableAdapters.TableAdapterManager tableAdapterManager;
    }
}
