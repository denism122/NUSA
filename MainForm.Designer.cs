
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
            this.components = new System.ComponentModel.Container();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.tabLaptops = new System.Windows.Forms.TabPage();
            this.dataGridViewLaptops = new System.Windows.Forms.DataGridView();
            this.CostName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostProcessor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostRAM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostHDD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostBattery = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostAC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostComment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostPurchaseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostLotNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostTrackNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostBodyPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostACPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostRAMPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostHDDPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostBatteryPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostCaddyPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostCustomPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostShippingPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostUnlockPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostBuyPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostSellPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostCoursePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.laptopContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteLaptopMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createLaptopMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editLaptopMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.tabInvoices = new System.Windows.Forms.TabPage();
            this.buttonAddItem = new System.Windows.Forms.Button();
            this.mainTabControl.SuspendLayout();
            this.tabLaptops.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLaptops)).BeginInit();
            this.laptopContextMenu.SuspendLayout();
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
            this.CostHDD,
            this.CostBattery,
            this.CostAC,
            this.CostComment,
            this.CostPurchaseDate,
            this.CostLotNumber,
            this.CostTrackNumber,
            this.CostBodyPrice,
            this.CostACPrice,
            this.CostRAMPrice,
            this.CostHDDPrice,
            this.CostBatteryPrice,
            this.CostCaddyPrice,
            this.CostCustomPrice,
            this.CostShippingPrice,
            this.CostUnlockPrice,
            this.CostBuyPrice,
            this.CostSellPrice,
            this.CostCoursePrice});
            this.dataGridViewLaptops.ContextMenuStrip = this.laptopContextMenu;
            this.dataGridViewLaptops.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewLaptops.Location = new System.Drawing.Point(3, 71);
            this.dataGridViewLaptops.Name = "dataGridViewLaptops";
            this.dataGridViewLaptops.ReadOnly = true;
            this.dataGridViewLaptops.RowTemplate.Height = 25;
            this.dataGridViewLaptops.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewLaptops.Size = new System.Drawing.Size(1182, 571);
            this.dataGridViewLaptops.TabIndex = 1;
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
            // CostBattery
            // 
            this.CostBattery.DataPropertyName = "CostPrice.Battery";
            this.CostBattery.HeaderText = "Батарея";
            this.CostBattery.Name = "CostBattery";
            this.CostBattery.ReadOnly = true;
            // 
            // CostAC
            // 
            this.CostAC.HeaderText = "AC";
            this.CostAC.Name = "CostAC";
            this.CostAC.ReadOnly = true;
            // 
            // CostComment
            // 
            this.CostComment.HeaderText = "Comment";
            this.CostComment.Name = "CostComment";
            this.CostComment.ReadOnly = true;
            // 
            // CostPurchaseDate
            // 
            this.CostPurchaseDate.HeaderText = "Дата покупки";
            this.CostPurchaseDate.Name = "CostPurchaseDate";
            this.CostPurchaseDate.ReadOnly = true;
            // 
            // CostLotNumber
            // 
            this.CostLotNumber.HeaderText = "Номер лота";
            this.CostLotNumber.Name = "CostLotNumber";
            this.CostLotNumber.ReadOnly = true;
            // 
            // CostTrackNumber
            // 
            this.CostTrackNumber.HeaderText = "Track";
            this.CostTrackNumber.Name = "CostTrackNumber";
            this.CostTrackNumber.ReadOnly = true;
            // 
            // CostBodyPrice
            // 
            this.CostBodyPrice.HeaderText = "Купив";
            this.CostBodyPrice.Name = "CostBodyPrice";
            this.CostBodyPrice.ReadOnly = true;
            // 
            // CostACPrice
            // 
            this.CostACPrice.HeaderText = "Зарядка";
            this.CostACPrice.Name = "CostACPrice";
            this.CostACPrice.ReadOnly = true;
            // 
            // CostRAMPrice
            // 
            this.CostRAMPrice.HeaderText = "RAM";
            this.CostRAMPrice.Name = "CostRAMPrice";
            this.CostRAMPrice.ReadOnly = true;
            // 
            // CostHDDPrice
            // 
            this.CostHDDPrice.HeaderText = "Хард";
            this.CostHDDPrice.Name = "CostHDDPrice";
            this.CostHDDPrice.ReadOnly = true;
            // 
            // CostBatteryPrice
            // 
            this.CostBatteryPrice.HeaderText = "Батарея";
            this.CostBatteryPrice.Name = "CostBatteryPrice";
            this.CostBatteryPrice.ReadOnly = true;
            // 
            // CostCaddyPrice
            // 
            this.CostCaddyPrice.HeaderText = "Caddy";
            this.CostCaddyPrice.Name = "CostCaddyPrice";
            this.CostCaddyPrice.ReadOnly = true;
            // 
            // CostCustomPrice
            // 
            this.CostCustomPrice.HeaderText = "Розмитнення";
            this.CostCustomPrice.Name = "CostCustomPrice";
            this.CostCustomPrice.ReadOnly = true;
            // 
            // CostShippingPrice
            // 
            this.CostShippingPrice.HeaderText = "Доставка";
            this.CostShippingPrice.Name = "CostShippingPrice";
            this.CostShippingPrice.ReadOnly = true;
            // 
            // CostUnlockPrice
            // 
            this.CostUnlockPrice.HeaderText = "Unlock";
            this.CostUnlockPrice.Name = "CostUnlockPrice";
            this.CostUnlockPrice.ReadOnly = true;
            // 
            // CostBuyPrice
            // 
            this.CostBuyPrice.HeaderText = "Собівартість";
            this.CostBuyPrice.Name = "CostBuyPrice";
            this.CostBuyPrice.ReadOnly = true;
            // 
            // CostSellPrice
            // 
            this.CostSellPrice.HeaderText = "Продаж";
            this.CostSellPrice.Name = "CostSellPrice";
            this.CostSellPrice.ReadOnly = true;
            // 
            // CostCoursePrice
            // 
            this.CostCoursePrice.HeaderText = "Курс";
            this.CostCoursePrice.Name = "CostCoursePrice";
            this.CostCoursePrice.ReadOnly = true;
            // 
            // laptopContextMenu
            // 
            this.laptopContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteLaptopMenuItem,
            this.createLaptopMenuItem,
            this.editLaptopMenuItem});
            this.laptopContextMenu.Name = "laptopContextMenu";
            this.laptopContextMenu.Size = new System.Drawing.Size(181, 70);
            // 
            // deleteLaptopMenuItem
            // 
            this.deleteLaptopMenuItem.Name = "deleteLaptopMenuItem";
            this.deleteLaptopMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteLaptopMenuItem.Text = "Видалити";
            this.deleteLaptopMenuItem.Click += new System.EventHandler(this.deleteLaptopMenuItem_Click);
            // 
            // createLaptopMenuItem
            // 
            this.createLaptopMenuItem.Name = "createLaptopMenuItem";
            this.createLaptopMenuItem.Size = new System.Drawing.Size(180, 22);
            this.createLaptopMenuItem.Text = "Створити";
            this.createLaptopMenuItem.Click += new System.EventHandler(this.createLaptopMenuItem_Click);
            // 
            // editLaptopMenuItem
            // 
            this.editLaptopMenuItem.Name = "editLaptopMenuItem";
            this.editLaptopMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editLaptopMenuItem.Text = "toolStripMenuItem1";
            // 
            // panelSearch
            // 
            this.panelSearch.Controls.Add(this.buttonAddItem);
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
            // buttonAddItem
            // 
            this.buttonAddItem.Location = new System.Drawing.Point(1077, 20);
            this.buttonAddItem.Name = "buttonAddItem";
            this.buttonAddItem.Size = new System.Drawing.Size(75, 23);
            this.buttonAddItem.TabIndex = 3;
            this.buttonAddItem.Text = "Add";
            this.buttonAddItem.UseVisualStyleBackColor = true;
            this.buttonAddItem.Click += new System.EventHandler(this.buttonAddItem_Click);
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
            this.laptopContextMenu.ResumeLayout(false);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn CostBattery;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostAC;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostComment;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostPurchaseDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostLotNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostTrackNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostBodyPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostACPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostRAMPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostHDDPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostBatteryPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostCaddyPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostCustomPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostShippingPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostUnlockPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostBuyPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostSellPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostCoursePrice;
        private System.Windows.Forms.ContextMenuStrip laptopContextMenu;
        private System.Windows.Forms.ToolStripMenuItem deleteLaptopMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createLaptopMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editLaptopMenuItem;
        private System.Windows.Forms.Button buttonAddItem;
    }
}

