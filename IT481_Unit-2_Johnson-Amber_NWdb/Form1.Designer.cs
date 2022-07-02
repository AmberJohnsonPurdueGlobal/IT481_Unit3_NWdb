using System;

namespace IT481_Unit_2_Johnson_Amber_NWdb
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
            this.updateDatabase_button = new System.Windows.Forms.Button();
            this.viewDatabase_button = new System.Windows.Forms.Button();
            this.id_label = new System.Windows.Forms.Label();
            this.company_label = new System.Windows.Forms.Label();
            this.id_textBox = new System.Windows.Forms.TextBox();
            this.companyName_textBox = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.northwindDataSet = new IT481_Unit_2_Johnson_Amber_NWdb.NorthwindDataSet();
            this.customersTableAdapter = new IT481_Unit_2_Johnson_Amber_NWdb.NorthwindDataSetTableAdapters.CustomersTableAdapter();
            this.recordCount_button = new System.Windows.Forms.Button();
            this.checkingConnection_label = new System.Windows.Forms.Label();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.northwindDataSet1 = new IT481_Unit_2_Johnson_Amber_NWdb.NorthwindDataSet1();
            this.customersTableAdapter1 = new IT481_Unit_2_Johnson_Amber_NWdb.NorthwindDataSet1TableAdapters.CustomersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // updateDatabase_button
            // 
            this.updateDatabase_button.Location = new System.Drawing.Point(59, 377);
            this.updateDatabase_button.Name = "updateDatabase_button";
            this.updateDatabase_button.Size = new System.Drawing.Size(303, 63);
            this.updateDatabase_button.TabIndex = 0;
            this.updateDatabase_button.Text = "Update Database";
            this.updateDatabase_button.UseVisualStyleBackColor = true;
            // 
            // viewDatabase_button
            // 
            this.viewDatabase_button.Location = new System.Drawing.Point(407, 377);
            this.viewDatabase_button.Name = "viewDatabase_button";
            this.viewDatabase_button.Size = new System.Drawing.Size(475, 63);
            this.viewDatabase_button.TabIndex = 2;
            this.viewDatabase_button.Text = "View Database";
            this.viewDatabase_button.UseVisualStyleBackColor = true;
            // 
            // id_label
            // 
            this.id_label.AutoSize = true;
            this.id_label.Location = new System.Drawing.Point(56, 54);
            this.id_label.Name = "id_label";
            this.id_label.Size = new System.Drawing.Size(18, 13);
            this.id_label.TabIndex = 3;
            this.id_label.Text = "ID";
            // 
            // company_label
            // 
            this.company_label.AutoSize = true;
            this.company_label.Location = new System.Drawing.Point(56, 93);
            this.company_label.Name = "company_label";
            this.company_label.Size = new System.Drawing.Size(51, 13);
            this.company_label.TabIndex = 4;
            this.company_label.Text = "Company";
            // 
            // id_textBox
            // 
            this.id_textBox.Location = new System.Drawing.Point(80, 54);
            this.id_textBox.Name = "id_textBox";
            this.id_textBox.Size = new System.Drawing.Size(237, 20);
            this.id_textBox.TabIndex = 7;
            // 
            // companyName_textBox
            // 
            this.companyName_textBox.Location = new System.Drawing.Point(113, 93);
            this.companyName_textBox.Name = "companyName_textBox";
            this.companyName_textBox.Size = new System.Drawing.Size(204, 20);
            this.companyName_textBox.TabIndex = 8;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerIDDataGridViewTextBoxColumn,
            this.companyNameDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.customersBindingSource1;
            this.dataGridView.Location = new System.Drawing.Point(59, 194);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(693, 150);
            this.dataGridView.TabIndex = 9;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.northwindDataSet;
            // 
            // northwindDataSet
            // 
            this.northwindDataSet.DataSetName = "NorthwindDataSet";
            this.northwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // recordCount_button
            // 
            this.recordCount_button.Location = new System.Drawing.Point(921, 377);
            this.recordCount_button.Name = "recordCount_button";
            this.recordCount_button.Size = new System.Drawing.Size(121, 75);
            this.recordCount_button.TabIndex = 10;
            this.recordCount_button.Text = "Record Count";
            this.recordCount_button.UseVisualStyleBackColor = true;
            // 
            // checkingConnection_label
            // 
            this.checkingConnection_label.AutoSize = true;
            this.checkingConnection_label.Location = new System.Drawing.Point(658, 93);
            this.checkingConnection_label.Name = "checkingConnection_label";
            this.checkingConnection_label.Size = new System.Drawing.Size(109, 13);
            this.checkingConnection_label.TabIndex = 11;
            this.checkingConnection_label.Text = "Checking Connection";
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(1275, 25);
            this.fillByToolStrip.TabIndex = 12;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(39, 22);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            // 
            // companyNameDataGridViewTextBoxColumn
            // 
            this.companyNameDataGridViewTextBoxColumn.DataPropertyName = "CompanyName";
            this.companyNameDataGridViewTextBoxColumn.HeaderText = "CompanyName";
            this.companyNameDataGridViewTextBoxColumn.Name = "companyNameDataGridViewTextBoxColumn";
            // 
            // customersBindingSource1
            // 
            this.customersBindingSource1.DataMember = "Customers";
            this.customersBindingSource1.DataSource = this.northwindDataSet1;
            // 
            // northwindDataSet1
            // 
            this.northwindDataSet1.DataSetName = "NorthwindDataSet1";
            this.northwindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersTableAdapter1
            // 
            this.customersTableAdapter1.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 489);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.checkingConnection_label);
            this.Controls.Add(this.recordCount_button);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.companyName_textBox);
            this.Controls.Add(this.id_textBox);
            this.Controls.Add(this.company_label);
            this.Controls.Add(this.id_label);
            this.Controls.Add(this.viewDatabase_button);
            this.Controls.Add(this.updateDatabase_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button updateDatabase_button;
        private System.Windows.Forms.Button viewDatabase_button;
        private System.Windows.Forms.Label id_label;
        private System.Windows.Forms.Label company_label;
        private System.Windows.Forms.TextBox id_textBox;
        private System.Windows.Forms.TextBox companyName_textBox;
        private System.Windows.Forms.DataGridView dataGridView;
        private NorthwindDataSet northwindDataSet;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private NorthwindDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button recordCount_button;
        private System.Windows.Forms.Label checkingConnection_label;
        private NorthwindDataSet1 northwindDataSet1;
        private System.Windows.Forms.BindingSource customersBindingSource1;
        private NorthwindDataSet1TableAdapters.CustomersTableAdapter customersTableAdapter1;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
    }
}

