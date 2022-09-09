namespace DBFirstEtüt
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
            this.btnGetOrderList = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lvOrders = new System.Windows.Forms.ListView();
            this.OrderID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OrderDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ShipCity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblEmployees = new System.Windows.Forms.ListBox();
            this.lblSupplier = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnGetOrderList
            // 
            this.btnGetOrderList.Location = new System.Drawing.Point(25, 31);
            this.btnGetOrderList.Name = "btnGetOrderList";
            this.btnGetOrderList.Size = new System.Drawing.Size(176, 41);
            this.btnGetOrderList.TabIndex = 0;
            this.btnGetOrderList.Text = "GetOrderList";
            this.btnGetOrderList.UseVisualStyleBackColor = true;
            this.btnGetOrderList.Click += new System.EventHandler(this.btnGetOrderList_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(273, 31);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(176, 41);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(468, 31);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(176, 41);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(663, 31);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(176, 41);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // lvOrders
            // 
            this.lvOrders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.OrderID,
            this.OrderDate,
            this.ShipCity});
            this.lvOrders.HideSelection = false;
            this.lvOrders.Location = new System.Drawing.Point(274, 92);
            this.lvOrders.Name = "lvOrders";
            this.lvOrders.Size = new System.Drawing.Size(566, 407);
            this.lvOrders.TabIndex = 6;
            this.lvOrders.UseCompatibleStateImageBehavior = false;
            this.lvOrders.View = System.Windows.Forms.View.Details;
            // 
            // OrderID
            // 
            this.OrderID.Text = "OrderID";
            this.OrderID.Width = 181;
            // 
            // OrderDate
            // 
            this.OrderDate.Text = "OrderDate";
            this.OrderDate.Width = 158;
            // 
            // ShipCity
            // 
            this.ShipCity.Text = "ShipCity";
            this.ShipCity.Width = 162;
            // 
            // lblEmployees
            // 
            this.lblEmployees.FormattingEnabled = true;
            this.lblEmployees.Location = new System.Drawing.Point(25, 92);
            this.lblEmployees.Name = "lblEmployees";
            this.lblEmployees.Size = new System.Drawing.Size(176, 199);
            this.lblEmployees.TabIndex = 7;
            // 
            // lblSupplier
            // 
            this.lblSupplier.FormattingEnabled = true;
            this.lblSupplier.Location = new System.Drawing.Point(25, 300);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(176, 199);
            this.lblSupplier.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 521);
            this.Controls.Add(this.lblSupplier);
            this.Controls.Add(this.lblEmployees);
            this.Controls.Add(this.lvOrders);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnGetOrderList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGetOrderList;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ListView lvOrders;
        private System.Windows.Forms.ColumnHeader OrderID;
        private System.Windows.Forms.ColumnHeader OrderDate;
        private System.Windows.Forms.ColumnHeader ShipCity;
        private System.Windows.Forms.ListBox lblEmployees;
        private System.Windows.Forms.ListBox lblSupplier;
    }
}

