
namespace NUSA
{
    partial class NUSAForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.tabLaptops = new System.Windows.Forms.TabPage();
            this.dataGridViewLaptops = new System.Windows.Forms.DataGridView();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.tabInvoices = new System.Windows.Forms.TabPage();
            this.CostName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostProcessor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostRAM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostHDD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainTabControl.SuspendLayout();
            this.tabLaptops.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLaptops)).BeginInit();
            this.panelSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.tabLaptops);
            this.mainTabControl.Controls.Add(this.tabInvoices);
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.Location = new System.Drawing.Point(0, 0);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(1196, 673);
            this.mainTabControl.TabIndex = 0;
            // 
            // tabLaptops
            // 
            this.tabLaptops.Controls.Add(this.dataGridViewLaptops);
            this.tabLaptops.Controls.Add(this.panelSearch);
            this.tabLaptops.Location = new System.Drawing.Point(4, 24);
            this.tabLaptops.Name = "tabLaptops";
            this.tabLaptops.Padding = new System.Windows.Forms.Padding(3);
            this.tabLaptops.Size = new System.Drawing.Size(1188, 645);
            this.tabLaptops.TabIndex = 0;
            this.tabLaptops.Text = "Ноутбуки";
            this.tabLaptops.UseVisualStyleBackColor = true;
            // 
            // dataGridViewLaptops
            // 
            this.dataGridViewLaptops.AllowUserToAddRows = false;
            this.dataGridViewLaptops.AllowUserToDeleteRows = false;
            this.dataGridViewLaptops.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLaptops.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CostName,
            this.CostProcessor,
            this.CostRAM,
            this.CostHDD});
            this.dataGridViewLaptops.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewLaptops.Location = new System.Drawing.Point(3, 71);
            this.dataGridViewLaptops.Name = "dataGridViewLaptops";
            this.dataGridViewLaptops.ReadOnly = true;
            this.dataGridViewLaptops.RowTemplate.Height = 25;
            this.dataGridViewLaptops.Size = new System.Drawing.Size(1182, 571);
            this.dataGridViewLaptops.TabIndex = 1;
            // 
            // panelSearch
            // 
            this.panelSearch.Controls.Add(this.buttonSearch);
            this.panelSearch.Controls.Add(this.textSearch);
            this.panelSearch.Controls.Add(this.labelSearch);
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearch.Location = new System.Drawing.Point(3, 3);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(1182, 68);
            this.panelSearch.TabIndex = 0;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(865, 20);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.Text = "Шукати";
            this.buttonSearch.UseVisualStyleBackColor = true;
            // 
            // textSearch
            // 
            this.textSearch.Location = new System.Drawing.Point(87, 21);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(759, 23);
            this.textSearch.TabIndex = 1;
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Location = new System.Drawing.Point(19, 24);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(49, 15);
            this.labelSearch.TabIndex = 0;
            this.labelSearch.Text = "Пошук:";
            // 
            // tabInvoices
            // 
            this.tabInvoices.Location = new System.Drawing.Point(4, 24);
            this.tabInvoices.Name = "tabInvoices";
            this.tabInvoices.Padding = new System.Windows.Forms.Padding(3);
            this.tabInvoices.Size = new System.Drawing.Size(1188, 645);
            this.tabInvoices.TabIndex = 1;
            this.tabInvoices.Text = "Накладні";
            this.tabInvoices.UseVisualStyleBackColor = true;
            // 
            // CostName
            // 
            this.CostName.DataPropertyName = "CostPrice.Name";
            this.CostName.HeaderText = "Назва";
            this.CostName.Name = "CostName";
            this.CostName.ReadOnly = true;
            // 
            // CostProcessor
            // 
            this.CostProcessor.HeaderText = "Процесор";
            this.CostProcessor.Name = "CostProcessor";
            this.CostProcessor.ReadOnly = true;
            // 
            // CostRAM
            // 
            this.CostRAM.HeaderText = "Оперативка";
            this.CostRAM.Name = "CostRAM";
            this.CostRAM.ReadOnly = true;
            // 
            // CostHDD
            // 
            this.CostHDD.DataPropertyName = "CostPrice.HDD";
            this.CostHDD.HeaderText = "HDD";
            this.CostHDD.Name = "CostHDD";
            this.CostHDD.ReadOnly = true;
            // 
            // NUSAForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 673);
            this.Controls.Add(this.mainTabControl);
            this.Name = "NUSAForm";
            this.Text = "NUSA v.1.0";
            this.Load += new System.EventHandler(this.NUSAForm_Load);
            this.mainTabControl.ResumeLayout(false);
            this.tabLaptops.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLaptops)).EndInit();
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage tabLaptops;
        private System.Windows.Forms.TabPage tabInvoices;
        private System.Windows.Forms.DataGridView dataGridViewLaptops;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostProcessor;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostRAM;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostHDD;
    }
}

