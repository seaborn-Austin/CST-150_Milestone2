namespace CST_150_Milestone2
{
    partial class inventoryFrm
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
            this.addItemBtn = new System.Windows.Forms.Button();
            this.inventoryAddLbl = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.itemName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.itemSKU = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.itemNameLbl = new System.Windows.Forms.Label();
            this.itemNameTxt = new System.Windows.Forms.TextBox();
            this.itemSkuLbl = new System.Windows.Forms.Label();
            this.itemSkuTxt = new System.Windows.Forms.TextBox();
            this.quantityLbl = new System.Windows.Forms.Label();
            this.quantityTxt = new System.Windows.Forms.TextBox();
            this.removeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addItemBtn
            // 
            this.addItemBtn.Location = new System.Drawing.Point(21, 158);
            this.addItemBtn.Name = "addItemBtn";
            this.addItemBtn.Size = new System.Drawing.Size(75, 23);
            this.addItemBtn.TabIndex = 1;
            this.addItemBtn.Text = "Add";
            this.addItemBtn.UseVisualStyleBackColor = true;
            this.addItemBtn.Click += new System.EventHandler(this.addItemBtn_Click);
            // 
            // inventoryAddLbl
            // 
            this.inventoryAddLbl.AutoSize = true;
            this.inventoryAddLbl.Location = new System.Drawing.Point(33, 158);
            this.inventoryAddLbl.Name = "inventoryAddLbl";
            this.inventoryAddLbl.Size = new System.Drawing.Size(0, 13);
            this.inventoryAddLbl.TabIndex = 2;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listView1.BackgroundImageTiled = true;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.itemName,
            this.itemSKU,
            this.quantity});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(15, 212);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(559, 245);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // itemName
            // 
            this.itemName.Text = "Name";
            this.itemName.Width = 150;
            // 
            // itemSKU
            // 
            this.itemSKU.Text = "SKU";
            this.itemSKU.Width = 150;
            // 
            // quantity
            // 
            this.quantity.Text = "Quantity";
            this.quantity.Width = 150;
            // 
            // itemNameLbl
            // 
            this.itemNameLbl.AutoSize = true;
            this.itemNameLbl.BackColor = System.Drawing.SystemColors.Control;
            this.itemNameLbl.Location = new System.Drawing.Point(12, 44);
            this.itemNameLbl.Name = "itemNameLbl";
            this.itemNameLbl.Size = new System.Drawing.Size(59, 13);
            this.itemNameLbl.TabIndex = 4;
            this.itemNameLbl.Text = "Item name:";
            // 
            // itemNameTxt
            // 
            this.itemNameTxt.Location = new System.Drawing.Point(77, 37);
            this.itemNameTxt.Name = "itemNameTxt";
            this.itemNameTxt.Size = new System.Drawing.Size(100, 20);
            this.itemNameTxt.TabIndex = 5;
            // 
            // itemSkuLbl
            // 
            this.itemSkuLbl.AutoSize = true;
            this.itemSkuLbl.Location = new System.Drawing.Point(12, 80);
            this.itemSkuLbl.Name = "itemSkuLbl";
            this.itemSkuLbl.Size = new System.Drawing.Size(55, 13);
            this.itemSkuLbl.TabIndex = 6;
            this.itemSkuLbl.Text = "Item SKU:";
            // 
            // itemSkuTxt
            // 
            this.itemSkuTxt.Location = new System.Drawing.Point(73, 73);
            this.itemSkuTxt.Name = "itemSkuTxt";
            this.itemSkuTxt.Size = new System.Drawing.Size(100, 20);
            this.itemSkuTxt.TabIndex = 7;
            // 
            // quantityLbl
            // 
            this.quantityLbl.AutoSize = true;
            this.quantityLbl.Location = new System.Drawing.Point(12, 119);
            this.quantityLbl.Name = "quantityLbl";
            this.quantityLbl.Size = new System.Drawing.Size(49, 13);
            this.quantityLbl.TabIndex = 8;
            this.quantityLbl.Text = "Quantity:";
            // 
            // quantityTxt
            // 
            this.quantityTxt.Location = new System.Drawing.Point(67, 112);
            this.quantityTxt.Name = "quantityTxt";
            this.quantityTxt.Size = new System.Drawing.Size(100, 20);
            this.quantityTxt.TabIndex = 9;
            // 
            // removeBtn
            // 
            this.removeBtn.Location = new System.Drawing.Point(102, 158);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(75, 23);
            this.removeBtn.TabIndex = 10;
            this.removeBtn.Text = "Remove row";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // inventoryFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CST_150_Milestone2.Properties.Resources.produce;
            this.ClientSize = new System.Drawing.Size(586, 469);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.quantityTxt);
            this.Controls.Add(this.quantityLbl);
            this.Controls.Add(this.itemSkuTxt);
            this.Controls.Add(this.itemSkuLbl);
            this.Controls.Add(this.itemNameTxt);
            this.Controls.Add(this.itemNameLbl);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.inventoryAddLbl);
            this.Controls.Add(this.addItemBtn);
            this.Name = "inventoryFrm";
            this.Text = "Inventory Application";
            this.Load += new System.EventHandler(this.inventoryFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addItemBtn;
        private System.Windows.Forms.Label inventoryAddLbl;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader itemName;
        private System.Windows.Forms.ColumnHeader itemSKU;
        private System.Windows.Forms.Label itemNameLbl;
        private System.Windows.Forms.TextBox itemNameTxt;
        private System.Windows.Forms.Label itemSkuLbl;
        private System.Windows.Forms.TextBox itemSkuTxt;
        private System.Windows.Forms.Label quantityLbl;
        private System.Windows.Forms.TextBox quantityTxt;
        private System.Windows.Forms.ColumnHeader quantity;
        private System.Windows.Forms.Button removeBtn;
    }
}

