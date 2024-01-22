
namespace Russo_Andrew_CPT_206_Chapter_14
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.productBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.productBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.productDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numSearchButton = new System.Windows.Forms.Button();
            this.numSearchInputTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.descSearchInputTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.descSearchButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.orderByDescPriceButton = new System.Windows.Forms.Button();
            this.orderByAscPriceButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.orderByDescOnHandButton = new System.Windows.Forms.Button();
            this.orderByAscOnHandButton = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.onHandLessThanButton = new System.Windows.Forms.Button();
            this.onHandMoreThanButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.onHandSerachValueInputTextBox = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.priceBetweenButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.maxPriceInputTextBox = new System.Windows.Forms.TextBox();
            this.minPriceInputTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.resetListButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingNavigator)).BeginInit();
            this.productBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // productBindingNavigator
            // 
            this.productBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.productBindingNavigator.BindingSource = this.productBindingSource;
            this.productBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.productBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.productBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.productBindingNavigatorSaveItem});
            this.productBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.productBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.productBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.productBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.productBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.productBindingNavigator.Name = "productBindingNavigator";
            this.productBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.productBindingNavigator.Size = new System.Drawing.Size(933, 25);
            this.productBindingNavigator.TabIndex = 0;
            this.productBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(Russo_Andrew_CPT_206_Chapter_14.Product);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(58, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // productBindingNavigatorSaveItem
            // 
            this.productBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.productBindingNavigatorSaveItem.Enabled = false;
            this.productBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("productBindingNavigatorSaveItem.Image")));
            this.productBindingNavigatorSaveItem.Name = "productBindingNavigatorSaveItem";
            this.productBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.productBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // productDataGridView
            // 
            this.productDataGridView.AutoGenerateColumns = false;
            this.productDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.productDataGridView.DataSource = this.productBindingSource;
            this.productDataGridView.Location = new System.Drawing.Point(14, 32);
            this.productDataGridView.Name = "productDataGridView";
            this.productDataGridView.Size = new System.Drawing.Size(554, 488);
            this.productDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Product_Number";
            this.dataGridViewTextBoxColumn1.HeaderText = "Product_Number";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn2.HeaderText = "Description";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Units_On_Hand";
            this.dataGridViewTextBoxColumn3.HeaderText = "Units_On_Hand";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn4.HeaderText = "Price";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // numSearchButton
            // 
            this.numSearchButton.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSearchButton.Location = new System.Drawing.Point(209, 47);
            this.numSearchButton.Name = "numSearchButton";
            this.numSearchButton.Size = new System.Drawing.Size(128, 25);
            this.numSearchButton.TabIndex = 3;
            this.numSearchButton.Text = "Search by Num";
            this.numSearchButton.UseVisualStyleBackColor = true;
            this.numSearchButton.Click += new System.EventHandler(this.numSearchButton_Click);
            // 
            // numSearchInputTextBox
            // 
            this.numSearchInputTextBox.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSearchInputTextBox.Location = new System.Drawing.Point(11, 47);
            this.numSearchInputTextBox.Name = "numSearchInputTextBox";
            this.numSearchInputTextBox.Size = new System.Drawing.Size(139, 23);
            this.numSearchInputTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Product Number";
            // 
            // descSearchInputTextBox
            // 
            this.descSearchInputTextBox.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descSearchInputTextBox.Location = new System.Drawing.Point(11, 98);
            this.descSearchInputTextBox.Name = "descSearchInputTextBox";
            this.descSearchInputTextBox.Size = new System.Drawing.Size(139, 23);
            this.descSearchInputTextBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "(partial) Description";
            // 
            // descSearchButton
            // 
            this.descSearchButton.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descSearchButton.Location = new System.Drawing.Point(209, 98);
            this.descSearchButton.Name = "descSearchButton";
            this.descSearchButton.Size = new System.Drawing.Size(128, 25);
            this.descSearchButton.TabIndex = 8;
            this.descSearchButton.Text = "Search By Desc";
            this.descSearchButton.UseVisualStyleBackColor = true;
            this.descSearchButton.Click += new System.EventHandler(this.descSearchButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.descSearchButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.descSearchInputTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numSearchInputTextBox);
            this.groupBox1.Controls.Add(this.numSearchButton);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(574, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 127);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SEARCH BY";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(575, 161);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(347, 139);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ORDER BY";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.orderByDescPriceButton);
            this.groupBox4.Controls.Add(this.orderByAscPriceButton);
            this.groupBox4.Location = new System.Drawing.Point(180, 30);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(129, 100);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Price";
            // 
            // orderByDescPriceButton
            // 
            this.orderByDescPriceButton.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderByDescPriceButton.Location = new System.Drawing.Point(6, 60);
            this.orderByDescPriceButton.Name = "orderByDescPriceButton";
            this.orderByDescPriceButton.Size = new System.Drawing.Size(100, 25);
            this.orderByDescPriceButton.TabIndex = 4;
            this.orderByDescPriceButton.Text = "Descending";
            this.orderByDescPriceButton.UseVisualStyleBackColor = true;
            this.orderByDescPriceButton.Click += new System.EventHandler(this.orderByDescPriceButton_Click);
            // 
            // orderByAscPriceButton
            // 
            this.orderByAscPriceButton.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderByAscPriceButton.Location = new System.Drawing.Point(6, 29);
            this.orderByAscPriceButton.Name = "orderByAscPriceButton";
            this.orderByAscPriceButton.Size = new System.Drawing.Size(100, 25);
            this.orderByAscPriceButton.TabIndex = 3;
            this.orderByAscPriceButton.Text = "Ascending";
            this.orderByAscPriceButton.UseVisualStyleBackColor = true;
            this.orderByAscPriceButton.Click += new System.EventHandler(this.orderByAscPriceButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.orderByDescOnHandButton);
            this.groupBox3.Controls.Add(this.orderByAscOnHandButton);
            this.groupBox3.Location = new System.Drawing.Point(20, 30);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(129, 100);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "On Hand";
            // 
            // orderByDescOnHandButton
            // 
            this.orderByDescOnHandButton.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderByDescOnHandButton.Location = new System.Drawing.Point(6, 60);
            this.orderByDescOnHandButton.Name = "orderByDescOnHandButton";
            this.orderByDescOnHandButton.Size = new System.Drawing.Size(100, 25);
            this.orderByDescOnHandButton.TabIndex = 11;
            this.orderByDescOnHandButton.Text = "Descending";
            this.orderByDescOnHandButton.UseVisualStyleBackColor = true;
            this.orderByDescOnHandButton.Click += new System.EventHandler(this.orderByDescOnHandButton_Click);
            // 
            // orderByAscOnHandButton
            // 
            this.orderByAscOnHandButton.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderByAscOnHandButton.Location = new System.Drawing.Point(6, 29);
            this.orderByAscOnHandButton.Name = "orderByAscOnHandButton";
            this.orderByAscOnHandButton.Size = new System.Drawing.Size(100, 25);
            this.orderByAscOnHandButton.TabIndex = 8;
            this.orderByAscOnHandButton.Text = "Ascending";
            this.orderByAscOnHandButton.UseVisualStyleBackColor = true;
            this.orderByAscOnHandButton.Click += new System.EventHandler(this.orderByAscOnHandButton_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.onHandLessThanButton);
            this.groupBox5.Controls.Add(this.onHandMoreThanButton);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.onHandSerachValueInputTextBox);
            this.groupBox5.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(575, 305);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(347, 100);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "SEARCH BY ON HAND";
            // 
            // onHandLessThanButton
            // 
            this.onHandLessThanButton.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onHandLessThanButton.Location = new System.Drawing.Point(30, 65);
            this.onHandLessThanButton.Name = "onHandLessThanButton";
            this.onHandLessThanButton.Size = new System.Drawing.Size(100, 25);
            this.onHandLessThanButton.TabIndex = 13;
            this.onHandLessThanButton.Text = "Less Than";
            this.onHandLessThanButton.UseVisualStyleBackColor = true;
            this.onHandLessThanButton.Click += new System.EventHandler(this.onHandLessThanButton_Click);
            // 
            // onHandMoreThanButton
            // 
            this.onHandMoreThanButton.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onHandMoreThanButton.Location = new System.Drawing.Point(30, 34);
            this.onHandMoreThanButton.Name = "onHandMoreThanButton";
            this.onHandMoreThanButton.Size = new System.Drawing.Size(100, 25);
            this.onHandMoreThanButton.TabIndex = 12;
            this.onHandMoreThanButton.Text = "More Than";
            this.onHandMoreThanButton.UseVisualStyleBackColor = true;
            this.onHandMoreThanButton.Click += new System.EventHandler(this.onHandMoreThanButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(171, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "How many";
            // 
            // onHandSerachValueInputTextBox
            // 
            this.onHandSerachValueInputTextBox.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onHandSerachValueInputTextBox.Location = new System.Drawing.Point(170, 49);
            this.onHandSerachValueInputTextBox.Name = "onHandSerachValueInputTextBox";
            this.onHandSerachValueInputTextBox.Size = new System.Drawing.Size(139, 23);
            this.onHandSerachValueInputTextBox.TabIndex = 14;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.priceBetweenButton);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.maxPriceInputTextBox);
            this.groupBox6.Controls.Add(this.minPriceInputTextBox);
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(575, 412);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(346, 81);
            this.groupBox6.TabIndex = 12;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "SEARCH BY PRICE";
            // 
            // priceBetweenButton
            // 
            this.priceBetweenButton.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceBetweenButton.Location = new System.Drawing.Point(265, 45);
            this.priceBetweenButton.Name = "priceBetweenButton";
            this.priceBetweenButton.Size = new System.Drawing.Size(75, 25);
            this.priceBetweenButton.TabIndex = 4;
            this.priceBetweenButton.Text = "Search";
            this.priceBetweenButton.UseVisualStyleBackColor = true;
            this.priceBetweenButton.Click += new System.EventHandler(this.priceBetweenButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(116, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "AND";
            // 
            // maxPriceInputTextBox
            // 
            this.maxPriceInputTextBox.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxPriceInputTextBox.Location = new System.Drawing.Point(159, 45);
            this.maxPriceInputTextBox.Name = "maxPriceInputTextBox";
            this.maxPriceInputTextBox.Size = new System.Drawing.Size(100, 23);
            this.maxPriceInputTextBox.TabIndex = 2;
            // 
            // minPriceInputTextBox
            // 
            this.minPriceInputTextBox.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minPriceInputTextBox.Location = new System.Drawing.Point(10, 45);
            this.minPriceInputTextBox.Name = "minPriceInputTextBox";
            this.minPriceInputTextBox.Size = new System.Drawing.Size(100, 23);
            this.minPriceInputTextBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(244, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Search for items with a price between:";
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(585, 499);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 25);
            this.closeButton.TabIndex = 13;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // resetListButton
            // 
            this.resetListButton.Location = new System.Drawing.Point(734, 499);
            this.resetListButton.Name = "resetListButton";
            this.resetListButton.Size = new System.Drawing.Size(100, 25);
            this.resetListButton.TabIndex = 14;
            this.resetListButton.Text = "Reset List";
            this.resetListButton.UseVisualStyleBackColor = true;
            this.resetListButton.Click += new System.EventHandler(this.resetListButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 532);
            this.Controls.Add(this.resetListButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.productDataGridView);
            this.Controls.Add(this.productBindingNavigator);
            this.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Russo-Andrew-CPT-206-Ch14-Product Search";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productBindingNavigator)).EndInit();
            this.productBindingNavigator.ResumeLayout(false);
            this.productBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.BindingNavigator productBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton productBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView productDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button numSearchButton;
        private System.Windows.Forms.TextBox numSearchInputTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox descSearchInputTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button descSearchButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button orderByDescPriceButton;
        private System.Windows.Forms.Button orderByAscPriceButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button orderByDescOnHandButton;
        private System.Windows.Forms.Button orderByAscOnHandButton;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button onHandLessThanButton;
        private System.Windows.Forms.Button onHandMoreThanButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox onHandSerachValueInputTextBox;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button priceBetweenButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox maxPriceInputTextBox;
        private System.Windows.Forms.TextBox minPriceInputTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button resetListButton;
    }
}

