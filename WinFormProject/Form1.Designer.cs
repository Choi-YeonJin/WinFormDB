﻿namespace WinFormDBProjectEX
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.Table_book = new System.Windows.Forms.Panel();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Tablename_book = new System.Windows.Forms.Label();
            this.book_publisher = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.book_price = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.book_name = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.book_id = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Book = new System.Windows.Forms.RadioButton();
            this.Customer = new System.Windows.Forms.RadioButton();
            this.Orders = new System.Windows.Forms.RadioButton();
            this.Table = new System.Windows.Forms.GroupBox();
            this.Table_customer = new System.Windows.Forms.Panel();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.Tablename_customer = new System.Windows.Forms.Label();
            this.customer_address = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.customer_phone = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.customer_name = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.customer_id = new System.Windows.Forms.Label();
            this.Table_orders = new System.Windows.Forms.Panel();
            this.textBox14 = new System.Windows.Forms.DateTimePicker();
            this.textBox13 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.orders_bookid = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.orders_custid = new System.Windows.Forms.Label();
            this.Tablename_orders = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.orders_orderdate = new System.Windows.Forms.Label();
            this.orders_id = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.orders_saleprice = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Table_book.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Table.SuspendLayout();
            this.Table_customer.SuspendLayout();
            this.Table_orders.SuspendLayout();
            this.SuspendLayout();
            // 
            // Table_book
            // 
            this.Table_book.Controls.Add(this.textBox15);
            this.Table_book.Controls.Add(this.label2);
            this.Table_book.Controls.Add(this.textBox3);
            this.Table_book.Controls.Add(this.Tablename_book);
            this.Table_book.Controls.Add(this.book_publisher);
            this.Table_book.Controls.Add(this.textBox4);
            this.Table_book.Controls.Add(this.book_price);
            this.Table_book.Controls.Add(this.textBox2);
            this.Table_book.Controls.Add(this.book_name);
            this.Table_book.Controls.Add(this.textBox1);
            this.Table_book.Controls.Add(this.book_id);
            this.Table_book.Location = new System.Drawing.Point(29, 508);
            this.Table_book.Name = "Table_book";
            this.Table_book.Size = new System.Drawing.Size(344, 210);
            this.Table_book.TabIndex = 0;
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(181, 174);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(129, 25);
            this.textBox15.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(141, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 28);
            this.label2.TabIndex = 15;
            this.label2.Text = "~";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(127, 108);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(183, 25);
            this.textBox3.TabIndex = 7;
            // 
            // Tablename_book
            // 
            this.Tablename_book.AutoSize = true;
            this.Tablename_book.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Tablename_book.Location = new System.Drawing.Point(164, 9);
            this.Tablename_book.Name = "Tablename_book";
            this.Tablename_book.Size = new System.Drawing.Size(67, 24);
            this.Tablename_book.TabIndex = 7;
            this.Tablename_book.Text = "Book";
            // 
            // book_publisher
            // 
            this.book_publisher.AutoSize = true;
            this.book_publisher.Location = new System.Drawing.Point(51, 114);
            this.book_publisher.Name = "book_publisher";
            this.book_publisher.Size = new System.Drawing.Size(67, 15);
            this.book_publisher.TabIndex = 6;
            this.book_publisher.Text = "Publisher";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(127, 139);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(129, 25);
            this.textBox4.TabIndex = 5;
            // 
            // book_price
            // 
            this.book_price.AutoSize = true;
            this.book_price.Location = new System.Drawing.Point(71, 142);
            this.book_price.Name = "book_price";
            this.book_price.Size = new System.Drawing.Size(40, 15);
            this.book_price.TabIndex = 4;
            this.book_price.Text = "Price";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(127, 77);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(183, 25);
            this.textBox2.TabIndex = 3;
            // 
            // book_name
            // 
            this.book_name.AutoSize = true;
            this.book_name.Location = new System.Drawing.Point(78, 80);
            this.book_name.Name = "book_name";
            this.book_name.Size = new System.Drawing.Size(43, 15);
            this.book_name.TabIndex = 2;
            this.book_name.Text = "Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(127, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(183, 25);
            this.textBox1.TabIndex = 1;
            // 
            // book_id
            // 
            this.book_id.AutoSize = true;
            this.book_id.Location = new System.Drawing.Point(98, 49);
            this.book_id.Name = "book_id";
            this.book_id.Size = new System.Drawing.Size(20, 15);
            this.book_id.TabIndex = 0;
            this.book_id.Text = "ID";
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(404, 508);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(176, 33);
            this.btnSelect.TabIndex = 1;
            this.btnSelect.Text = "SELECT";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(404, 548);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(176, 33);
            this.btnInsert.TabIndex = 2;
            this.btnInsert.Text = "INSERT";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(404, 587);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(176, 33);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(404, 626);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(176, 33);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(404, 665);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(176, 33);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "텍스트박스 지우기";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(551, 360);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ALLAHUAKBAR);
            // 
            // Book
            // 
            this.Book.AutoSize = true;
            this.Book.Location = new System.Drawing.Point(16, 42);
            this.Book.Name = "Book";
            this.Book.Size = new System.Drawing.Size(63, 19);
            this.Book.TabIndex = 9;
            this.Book.TabStop = true;
            this.Book.Text = "Book";
            this.Book.UseVisualStyleBackColor = true;
            this.Book.CheckedChanged += new System.EventHandler(this.Book_CheckedChanged);
            // 
            // Customer
            // 
            this.Customer.AutoSize = true;
            this.Customer.Location = new System.Drawing.Point(98, 42);
            this.Customer.Name = "Customer";
            this.Customer.Size = new System.Drawing.Size(90, 19);
            this.Customer.TabIndex = 10;
            this.Customer.TabStop = true;
            this.Customer.Text = "Customer";
            this.Customer.UseVisualStyleBackColor = true;
            this.Customer.CheckedChanged += new System.EventHandler(this.Customer_CheckedChanged);
            // 
            // Orders
            // 
            this.Orders.AutoSize = true;
            this.Orders.Location = new System.Drawing.Point(194, 42);
            this.Orders.Name = "Orders";
            this.Orders.Size = new System.Drawing.Size(72, 19);
            this.Orders.TabIndex = 11;
            this.Orders.TabStop = true;
            this.Orders.Text = "Orders";
            this.Orders.UseVisualStyleBackColor = true;
            this.Orders.CheckedChanged += new System.EventHandler(this.Orders_CheckedChanged);
            // 
            // Table
            // 
            this.Table.Controls.Add(this.Book);
            this.Table.Controls.Add(this.Orders);
            this.Table.Controls.Add(this.Customer);
            this.Table.Location = new System.Drawing.Point(175, 23);
            this.Table.Name = "Table";
            this.Table.Size = new System.Drawing.Size(279, 74);
            this.Table.TabIndex = 12;
            this.Table.TabStop = false;
            this.Table.Text = "Table";
            // 
            // Table_customer
            // 
            this.Table_customer.Controls.Add(this.textBox7);
            this.Table_customer.Controls.Add(this.Tablename_customer);
            this.Table_customer.Controls.Add(this.customer_address);
            this.Table_customer.Controls.Add(this.textBox8);
            this.Table_customer.Controls.Add(this.customer_phone);
            this.Table_customer.Controls.Add(this.textBox6);
            this.Table_customer.Controls.Add(this.customer_name);
            this.Table_customer.Controls.Add(this.textBox5);
            this.Table_customer.Controls.Add(this.customer_id);
            this.Table_customer.Location = new System.Drawing.Point(29, 508);
            this.Table_customer.Name = "Table_customer";
            this.Table_customer.Size = new System.Drawing.Size(344, 184);
            this.Table_customer.TabIndex = 8;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(127, 108);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(183, 25);
            this.textBox7.TabIndex = 7;
            // 
            // Tablename_customer
            // 
            this.Tablename_customer.AutoSize = true;
            this.Tablename_customer.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Tablename_customer.Location = new System.Drawing.Point(164, 9);
            this.Tablename_customer.Name = "Tablename_customer";
            this.Tablename_customer.Size = new System.Drawing.Size(116, 24);
            this.Tablename_customer.TabIndex = 7;
            this.Tablename_customer.Text = "Customer";
            // 
            // customer_address
            // 
            this.customer_address.AutoSize = true;
            this.customer_address.Location = new System.Drawing.Point(58, 111);
            this.customer_address.Name = "customer_address";
            this.customer_address.Size = new System.Drawing.Size(60, 15);
            this.customer_address.TabIndex = 6;
            this.customer_address.Text = "Address";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(127, 139);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(183, 25);
            this.textBox8.TabIndex = 5;
            // 
            // customer_phone
            // 
            this.customer_phone.AutoSize = true;
            this.customer_phone.Location = new System.Drawing.Point(71, 142);
            this.customer_phone.Name = "customer_phone";
            this.customer_phone.Size = new System.Drawing.Size(50, 15);
            this.customer_phone.TabIndex = 4;
            this.customer_phone.Text = "Phone";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(127, 77);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(183, 25);
            this.textBox6.TabIndex = 3;
            // 
            // customer_name
            // 
            this.customer_name.AutoSize = true;
            this.customer_name.Location = new System.Drawing.Point(78, 80);
            this.customer_name.Name = "customer_name";
            this.customer_name.Size = new System.Drawing.Size(43, 15);
            this.customer_name.TabIndex = 2;
            this.customer_name.Text = "Name";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(127, 46);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(183, 25);
            this.textBox5.TabIndex = 1;
            // 
            // customer_id
            // 
            this.customer_id.AutoSize = true;
            this.customer_id.Location = new System.Drawing.Point(98, 49);
            this.customer_id.Name = "customer_id";
            this.customer_id.Size = new System.Drawing.Size(20, 15);
            this.customer_id.TabIndex = 0;
            this.customer_id.Text = "ID";
            // 
            // Table_orders
            // 
            this.Table_orders.Controls.Add(this.textBox14);
            this.Table_orders.Controls.Add(this.textBox13);
            this.Table_orders.Controls.Add(this.label1);
            this.Table_orders.Controls.Add(this.textBox11);
            this.Table_orders.Controls.Add(this.orders_bookid);
            this.Table_orders.Controls.Add(this.textBox10);
            this.Table_orders.Controls.Add(this.orders_custid);
            this.Table_orders.Controls.Add(this.Tablename_orders);
            this.Table_orders.Controls.Add(this.textBox9);
            this.Table_orders.Controls.Add(this.orders_orderdate);
            this.Table_orders.Controls.Add(this.orders_id);
            this.Table_orders.Controls.Add(this.textBox12);
            this.Table_orders.Controls.Add(this.orders_saleprice);
            this.Table_orders.Location = new System.Drawing.Point(29, 508);
            this.Table_orders.Name = "Table_orders";
            this.Table_orders.Size = new System.Drawing.Size(344, 243);
            this.Table_orders.TabIndex = 9;
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(181, 204);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(129, 25);
            this.textBox14.TabIndex = 14;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(124, 170);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(131, 25);
            this.textBox13.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(140, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 28);
            this.label1.TabIndex = 13;
            this.label1.Text = "~";
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(127, 108);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(183, 25);
            this.textBox11.TabIndex = 11;
            // 
            // orders_bookid
            // 
            this.orders_bookid.AutoSize = true;
            this.orders_bookid.Location = new System.Drawing.Point(67, 111);
            this.orders_bookid.Name = "orders_bookid";
            this.orders_bookid.Size = new System.Drawing.Size(53, 15);
            this.orders_bookid.TabIndex = 10;
            this.orders_bookid.Text = "Bookid";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(127, 77);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(183, 25);
            this.textBox10.TabIndex = 9;
            // 
            // orders_custid
            // 
            this.orders_custid.AutoSize = true;
            this.orders_custid.Location = new System.Drawing.Point(72, 80);
            this.orders_custid.Name = "orders_custid";
            this.orders_custid.Size = new System.Drawing.Size(48, 15);
            this.orders_custid.TabIndex = 8;
            this.orders_custid.Text = "Custid";
            // 
            // Tablename_orders
            // 
            this.Tablename_orders.AutoSize = true;
            this.Tablename_orders.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Tablename_orders.Location = new System.Drawing.Point(164, 9);
            this.Tablename_orders.Name = "Tablename_orders";
            this.Tablename_orders.Size = new System.Drawing.Size(84, 24);
            this.Tablename_orders.TabIndex = 7;
            this.Tablename_orders.Text = "Orders";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(127, 46);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(183, 25);
            this.textBox9.TabIndex = 1;
            // 
            // orders_orderdate
            // 
            this.orders_orderdate.AutoSize = true;
            this.orders_orderdate.Location = new System.Drawing.Point(51, 176);
            this.orders_orderdate.Name = "orders_orderdate";
            this.orders_orderdate.Size = new System.Drawing.Size(71, 15);
            this.orders_orderdate.TabIndex = 6;
            this.orders_orderdate.Text = "Orderdate";
            // 
            // orders_id
            // 
            this.orders_id.AutoSize = true;
            this.orders_id.Location = new System.Drawing.Point(64, 49);
            this.orders_id.Name = "orders_id";
            this.orders_id.Size = new System.Drawing.Size(54, 15);
            this.orders_id.TabIndex = 0;
            this.orders_id.Text = "Orderid";
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(127, 139);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(183, 25);
            this.textBox12.TabIndex = 3;
            // 
            // orders_saleprice
            // 
            this.orders_saleprice.AutoSize = true;
            this.orders_saleprice.Location = new System.Drawing.Point(51, 142);
            this.orders_saleprice.Name = "orders_saleprice";
            this.orders_saleprice.Size = new System.Drawing.Size(67, 15);
            this.orders_saleprice.TabIndex = 2;
            this.orders_saleprice.Text = "Saleprice";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(348, 544);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 25);
            this.button1.TabIndex = 13;
            this.button1.Text = "삭제";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(348, 578);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 25);
            this.button2.TabIndex = 14;
            this.button2.Text = "삭제";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(348, 609);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 25);
            this.button3.TabIndex = 15;
            this.button3.Text = "삭제";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(348, 640);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(50, 25);
            this.button4.TabIndex = 16;
            this.button4.Text = "삭제";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 779);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Table_orders);
            this.Controls.Add(this.Table_customer);
            this.Controls.Add(this.Table);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.Table_book);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Table_book.ResumeLayout(false);
            this.Table_book.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Table.ResumeLayout(false);
            this.Table.PerformLayout();
            this.Table_customer.ResumeLayout(false);
            this.Table_customer.PerformLayout();
            this.Table_orders.ResumeLayout(false);
            this.Table_orders.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Table_book;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label book_publisher;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label book_price;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label book_name;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label book_id;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label Tablename_book;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton Book;
        private System.Windows.Forms.RadioButton Customer;
        private System.Windows.Forms.RadioButton Orders;
        private System.Windows.Forms.GroupBox Table;
        private System.Windows.Forms.Panel Table_customer;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label Tablename_customer;
        private System.Windows.Forms.Label customer_address;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label customer_phone;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label customer_name;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label customer_id;
        private System.Windows.Forms.Panel Table_orders;
        private System.Windows.Forms.Label Tablename_orders;
        private System.Windows.Forms.Label orders_orderdate;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label orders_saleprice;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label orders_id;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label orders_bookid;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label orders_custid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker textBox14;
        private System.Windows.Forms.DateTimePicker textBox13;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.Label label2;
    }
}

