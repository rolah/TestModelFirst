namespace TestModelFirst
{
    partial class Form1
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnConcurrency = new System.Windows.Forms.Button();
            this.btnQuery = new System.Windows.Forms.Button();
            this.btnThreaded = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.rewards2DataSet = new TestModelFirst.Rewards2DataSet();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersTableAdapter = new TestModelFirst.Rewards2DataSetTableAdapters.CustomersTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchasesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.purchasesTableAdapter = new TestModelFirst.Rewards2DataSetTableAdapters.PurchasesTableAdapter();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customersIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbCustomerID = new System.Windows.Forms.ComboBox();
            this.customersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rewards2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchasesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(594, 34);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnConcurrency
            // 
            this.btnConcurrency.Location = new System.Drawing.Point(594, 75);
            this.btnConcurrency.Name = "btnConcurrency";
            this.btnConcurrency.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnConcurrency.Size = new System.Drawing.Size(75, 23);
            this.btnConcurrency.TabIndex = 1;
            this.btnConcurrency.Text = "&Concurrency";
            this.btnConcurrency.UseVisualStyleBackColor = true;
            this.btnConcurrency.Click += new System.EventHandler(this.btnConcurrency_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(594, 121);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 2;
            this.btnQuery.Text = "Query";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnThreaded
            // 
            this.btnThreaded.Location = new System.Drawing.Point(594, 166);
            this.btnThreaded.Name = "btnThreaded";
            this.btnThreaded.Size = new System.Drawing.Size(75, 23);
            this.btnThreaded.TabIndex = 3;
            this.btnThreaded.Text = "&Threaded";
            this.btnThreaded.UseVisualStyleBackColor = true;
            this.btnThreaded.Click += new System.EventHandler(this.btnThreaded_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(594, 209);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.customerNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.customersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(26, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(409, 177);
            this.dataGridView1.TabIndex = 5;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.purchaseDateDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.customersIdDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.purchasesBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(26, 252);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(643, 205);
            this.dataGridView2.TabIndex = 6;
            // 
            // rewards2DataSet
            // 
            this.rewards2DataSet.DataSetName = "Rewards2DataSet";
            this.rewards2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            //// 
            //// customersBindingSource
            //// 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.rewards2DataSet;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerNameDataGridViewTextBoxColumn
            // 
            this.customerNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn.HeaderText = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
            // 
            // purchasesBindingSource
            // 
            this.purchasesBindingSource.DataMember = "Purchases";
            this.purchasesBindingSource.DataSource = this.rewards2DataSet;
            // 
            // purchasesTableAdapter
            // 
            this.purchasesTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // purchaseDateDataGridViewTextBoxColumn
            // 
            this.purchaseDateDataGridViewTextBoxColumn.DataPropertyName = "PurchaseDate";
            this.purchaseDateDataGridViewTextBoxColumn.HeaderText = "PurchaseDate";
            this.purchaseDateDataGridViewTextBoxColumn.Name = "purchaseDateDataGridViewTextBoxColumn";
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            // 
            // customersIdDataGridViewTextBoxColumn
            // 
            this.customersIdDataGridViewTextBoxColumn.DataPropertyName = "CustomersId";
            this.customersIdDataGridViewTextBoxColumn.HeaderText = "CustomersId";
            this.customersIdDataGridViewTextBoxColumn.Name = "customersIdDataGridViewTextBoxColumn";
            // 
            // cbCustomerID
            // 
            this.cbCustomerID.DataSource = this.customersBindingSource1;
            this.cbCustomerID.DisplayMember = "Id";
            this.cbCustomerID.FormattingEnabled = true;
            this.cbCustomerID.Location = new System.Drawing.Point(26, 13);
            this.cbCustomerID.Name = "cbCustomerID";
            this.cbCustomerID.Size = new System.Drawing.Size(129, 21);
            this.cbCustomerID.TabIndex = 7;
            this.cbCustomerID.ValueMember = "Id";
            // 
            // customersBindingSource1
            // 
            this.customersBindingSource1.DataMember = "Customers";
            this.customersBindingSource1.DataSource = this.rewards2DataSet;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 486);
            this.Controls.Add(this.cbCustomerID);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnThreaded);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.btnConcurrency);
            this.Controls.Add(this.btnAdd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rewards2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchasesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnConcurrency;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Button btnThreaded;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private Rewards2DataSet rewards2DataSet;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private Rewards2DataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource purchasesBindingSource;
        private Rewards2DataSetTableAdapters.PurchasesTableAdapter purchasesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaseDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customersIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cbCustomerID;
        private System.Windows.Forms.BindingSource customersBindingSource1;
    }
}

