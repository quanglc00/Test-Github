namespace ResterantManagerment
{
    partial class OrderForm
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
            this.dgvListDish = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnShowDish = new System.Windows.Forms.Button();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.totalPrice = new System.Windows.Forms.Label();
            this.lbEmp = new System.Windows.Forms.Label();
            this.btnInHd = new System.Windows.Forms.Button();
            this.cbbCustomer = new System.Windows.Forms.ComboBox();
            this.managerResterantDataSet = new ResterantManagerment.ManagerResterantDataSet();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter = new ResterantManagerment.ManagerResterantDataSetTableAdapters.CustomerTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbEmp = new System.Windows.Forms.ComboBox();
            this.managerResterantDataSet1 = new ResterantManagerment.ManagerResterantDataSet1();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapter = new ResterantManagerment.ManagerResterantDataSet1TableAdapters.EmployeeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListDish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerResterantDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerResterantDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListDish
            // 
            this.dgvListDish.AllowUserToOrderColumns = true;
            this.dgvListDish.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListDish.Location = new System.Drawing.Point(3, 58);
            this.dgvListDish.Name = "dgvListDish";
            this.dgvListDish.Size = new System.Drawing.Size(449, 200);
            this.dgvListDish.TabIndex = 0;
            this.dgvListDish.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListDish_CellClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(77, 288);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Thêm món ăn";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnShowDish
            // 
            this.btnShowDish.Location = new System.Drawing.Point(256, 288);
            this.btnShowDish.Name = "btnShowDish";
            this.btnShowDish.Size = new System.Drawing.Size(123, 23);
            this.btnShowDish.TabIndex = 2;
            this.btnShowDish.Text = "Xem danh sách món";
            this.btnShowDish.UseVisualStyleBackColor = true;
            // 
            // dgvOrder
            // 
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Location = new System.Drawing.Point(580, 41);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.Size = new System.Drawing.Size(558, 253);
            this.dgvOrder.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(90, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Danh sách món ăn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(766, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Hóa đơn";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(743, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Xoá món";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(843, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tổng tiền : ";
            // 
            // totalPrice
            // 
            this.totalPrice.AutoSize = true;
            this.totalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPrice.Location = new System.Drawing.Point(948, 321);
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.Size = new System.Drawing.Size(17, 18);
            this.totalPrice.TabIndex = 9;
            this.totalPrice.Text = "0";
            // 
            // lbEmp
            // 
            this.lbEmp.AutoSize = true;
            this.lbEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmp.Location = new System.Drawing.Point(40, 438);
            this.lbEmp.Name = "lbEmp";
            this.lbEmp.Size = new System.Drawing.Size(142, 24);
            this.lbEmp.TabIndex = 10;
            this.lbEmp.Text = "Người quản trị";
            // 
            // btnInHd
            // 
            this.btnInHd.Location = new System.Drawing.Point(813, 435);
            this.btnInHd.Name = "btnInHd";
            this.btnInHd.Size = new System.Drawing.Size(152, 35);
            this.btnInHd.TabIndex = 11;
            this.btnInHd.Text = "In hóa đơn";
            this.btnInHd.UseVisualStyleBackColor = true;
            this.btnInHd.Click += new System.EventHandler(this.btnInHd_Click);
            // 
            // cbbCustomer
            // 
            this.cbbCustomer.DataSource = this.customerBindingSource;
            this.cbbCustomer.DisplayMember = "CustomerName";
            this.cbbCustomer.FormattingEnabled = true;
            this.cbbCustomer.Location = new System.Drawing.Point(951, 374);
            this.cbbCustomer.Name = "cbbCustomer";
            this.cbbCustomer.Size = new System.Drawing.Size(121, 21);
            this.cbbCustomer.TabIndex = 12;
            this.cbbCustomer.ValueMember = "CustomerId";
            // 
            // managerResterantDataSet
            // 
            this.managerResterantDataSet.DataSetName = "ManagerResterantDataSet";
            this.managerResterantDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.managerResterantDataSet;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(753, 371);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "Chọn Khách hàng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 371);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Nhân viên phục vụ :";
            // 
            // cbbEmp
            // 
            this.cbbEmp.DataSource = this.employeeBindingSource;
            this.cbbEmp.DisplayMember = "EmployeeName";
            this.cbbEmp.FormattingEnabled = true;
            this.cbbEmp.Location = new System.Drawing.Point(188, 371);
            this.cbbEmp.Name = "cbbEmp";
            this.cbbEmp.Size = new System.Drawing.Size(131, 21);
            this.cbbEmp.TabIndex = 15;
            this.cbbEmp.ValueMember = "EmployeeId";
            // 
            // managerResterantDataSet1
            // 
            this.managerResterantDataSet1.DataSetName = "ManagerResterantDataSet1";
            this.managerResterantDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.managerResterantDataSet1;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 492);
            this.Controls.Add(this.cbbEmp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbbCustomer);
            this.Controls.Add(this.btnInHd);
            this.Controls.Add(this.lbEmp);
            this.Controls.Add(this.totalPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvOrder);
            this.Controls.Add(this.btnShowDish);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvListDish);
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListDish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerResterantDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerResterantDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListDish;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnShowDish;
        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label totalPrice;
        private System.Windows.Forms.Label lbEmp;
        private System.Windows.Forms.Button btnInHd;
        private System.Windows.Forms.ComboBox cbbCustomer;
        private ManagerResterantDataSet managerResterantDataSet;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private ManagerResterantDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbEmp;
        private ManagerResterantDataSet1 managerResterantDataSet1;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private ManagerResterantDataSet1TableAdapters.EmployeeTableAdapter employeeTableAdapter;
    }
}