namespace Supermarker_mvp.Views
{
    partial class ProductsView
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPageProductList = new TabPage();
            tabPageProductDetail = new TabPage();
            BtnClose = new Button();
            BtnDelete = new Button();
            BtnEdit = new Button();
            BtnNew = new Button();
            BtnSearch = new Button();
            DgCategory = new DataGridView();
            TxtSearch = new TextBox();
            label2 = new Label();
            TxtProductsStock = new TextBox();
            label7 = new Label();
            TxtProductsPrice = new TextBox();
            label6 = new Label();
            TxtProductsCategory = new TextBox();
            label5 = new Label();
            TxtProductsName = new TextBox();
            label4 = new Label();
            TxtProductsId = new TextBox();
            label3 = new Label();
            BtnCancel = new Button();
            BtnSave = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPageProductList.SuspendLayout();
            tabPageProductDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgCategory).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(806, 125);
            panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.products;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(12, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(153, 125);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(192, 41);
            label1.Name = "label1";
            label1.Size = new Size(163, 38);
            label1.TabIndex = 0;
            label1.Text = "PRODUCTS";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageProductList);
            tabControl1.Controls.Add(tabPageProductDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 125);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(806, 474);
            tabControl1.TabIndex = 3;
            // 
            // tabPageProductList
            // 
            tabPageProductList.Controls.Add(BtnClose);
            tabPageProductList.Controls.Add(BtnDelete);
            tabPageProductList.Controls.Add(BtnEdit);
            tabPageProductList.Controls.Add(BtnNew);
            tabPageProductList.Controls.Add(BtnSearch);
            tabPageProductList.Controls.Add(DgCategory);
            tabPageProductList.Controls.Add(TxtSearch);
            tabPageProductList.Controls.Add(label2);
            tabPageProductList.Location = new Point(4, 29);
            tabPageProductList.Name = "tabPageProductList";
            tabPageProductList.Padding = new Padding(3);
            tabPageProductList.Size = new Size(798, 418);
            tabPageProductList.TabIndex = 0;
            tabPageProductList.Text = "Products List";
            tabPageProductList.UseVisualStyleBackColor = true;
            // 
            // tabPageProductDetail
            // 
            tabPageProductDetail.Controls.Add(BtnCancel);
            tabPageProductDetail.Controls.Add(BtnSave);
            tabPageProductDetail.Controls.Add(TxtProductsStock);
            tabPageProductDetail.Controls.Add(label7);
            tabPageProductDetail.Controls.Add(TxtProductsPrice);
            tabPageProductDetail.Controls.Add(label6);
            tabPageProductDetail.Controls.Add(TxtProductsCategory);
            tabPageProductDetail.Controls.Add(label5);
            tabPageProductDetail.Controls.Add(TxtProductsName);
            tabPageProductDetail.Controls.Add(label4);
            tabPageProductDetail.Controls.Add(TxtProductsId);
            tabPageProductDetail.Controls.Add(label3);
            tabPageProductDetail.Location = new Point(4, 29);
            tabPageProductDetail.Name = "tabPageProductDetail";
            tabPageProductDetail.Padding = new Padding(3);
            tabPageProductDetail.Size = new Size(798, 441);
            tabPageProductDetail.TabIndex = 1;
            tabPageProductDetail.Text = "Product Detail";
            tabPageProductDetail.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            BtnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnClose.BackgroundImage = Properties.Resources.cerrar;
            BtnClose.BackgroundImageLayout = ImageLayout.Zoom;
            BtnClose.Location = new Point(670, 254);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(94, 38);
            BtnClose.TabIndex = 28;
            BtnClose.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnDelete.BackgroundImage = Properties.Resources.delete;
            BtnDelete.BackgroundImageLayout = ImageLayout.Zoom;
            BtnDelete.Location = new Point(670, 189);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(94, 39);
            BtnDelete.TabIndex = 27;
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            BtnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEdit.BackgroundImage = Properties.Resources.edit;
            BtnEdit.BackgroundImageLayout = ImageLayout.Zoom;
            BtnEdit.Location = new Point(670, 128);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(94, 38);
            BtnEdit.TabIndex = 26;
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnNew
            // 
            BtnNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnNew.BackgroundImage = Properties.Resources._new;
            BtnNew.BackgroundImageLayout = ImageLayout.Zoom;
            BtnNew.Location = new Point(670, 66);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(94, 40);
            BtnNew.TabIndex = 25;
            BtnNew.UseVisualStyleBackColor = true;
            // 
            // BtnSearch
            // 
            BtnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSearch.BackgroundImage = Properties.Resources.search;
            BtnSearch.BackgroundImageLayout = ImageLayout.Zoom;
            BtnSearch.Location = new Point(526, 10);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(50, 48);
            BtnSearch.TabIndex = 24;
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // DgCategory
            // 
            DgCategory.AllowUserToAddRows = false;
            DgCategory.AllowUserToDeleteRows = false;
            DgCategory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DgCategory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgCategory.Location = new Point(35, 66);
            DgCategory.Name = "DgCategory";
            DgCategory.ReadOnly = true;
            DgCategory.RowHeadersWidth = 51;
            DgCategory.RowTemplate.Height = 29;
            DgCategory.Size = new Size(541, 342);
            DgCategory.TabIndex = 23;
            // 
            // TxtSearch
            // 
            TxtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtSearch.Location = new Point(35, 33);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Data to search";
            TxtSearch.Size = new Size(472, 27);
            TxtSearch.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(35, 10);
            label2.Name = "label2";
            label2.Size = new Size(114, 20);
            label2.TabIndex = 21;
            label2.Text = "Search Product";
            // 
            // TxtProductsStock
            // 
            TxtProductsStock.Location = new Point(20, 220);
            TxtProductsStock.Name = "TxtProductsStock";
            TxtProductsStock.PlaceholderText = "Providers Name";
            TxtProductsStock.Size = new Size(367, 27);
            TxtProductsStock.TabIndex = 29;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(20, 197);
            label7.Name = "label7";
            label7.Size = new Size(100, 20);
            label7.TabIndex = 28;
            label7.Text = "Product Stock";
            // 
            // TxtProductsPrice
            // 
            TxtProductsPrice.Location = new Point(18, 158);
            TxtProductsPrice.Name = "TxtProductsPrice";
            TxtProductsPrice.PlaceholderText = "Providers Name";
            TxtProductsPrice.Size = new Size(367, 27);
            TxtProductsPrice.TabIndex = 27;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 135);
            label6.Name = "label6";
            label6.Size = new Size(96, 20);
            label6.TabIndex = 26;
            label6.Text = "Product Price";
            // 
            // TxtProductsCategory
            // 
            TxtProductsCategory.Location = new Point(19, 268);
            TxtProductsCategory.Multiline = true;
            TxtProductsCategory.Name = "TxtProductsCategory";
            TxtProductsCategory.PlaceholderText = "Observation";
            TxtProductsCategory.Size = new Size(366, 77);
            TxtProductsCategory.TabIndex = 25;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 245);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 24;
            label5.Text = "Category";
            // 
            // TxtProductsName
            // 
            TxtProductsName.Location = new Point(20, 92);
            TxtProductsName.Name = "TxtProductsName";
            TxtProductsName.PlaceholderText = "Providers Name";
            TxtProductsName.Size = new Size(367, 27);
            TxtProductsName.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 69);
            label4.Name = "label4";
            label4.Size = new Size(104, 20);
            label4.TabIndex = 22;
            label4.Text = "Product Name";
            // 
            // TxtProductsId
            // 
            TxtProductsId.Location = new Point(18, 29);
            TxtProductsId.Name = "TxtProductsId";
            TxtProductsId.ReadOnly = true;
            TxtProductsId.Size = new Size(168, 27);
            TxtProductsId.TabIndex = 21;
            TxtProductsId.Text = "0";
            TxtProductsId.TextAlign = HorizontalAlignment.Right;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 12);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 20;
            label3.Text = "Provider Id";
            // 
            // BtnCancel
            // 
            BtnCancel.BackgroundImage = Properties.Resources.cancel;
            BtnCancel.BackgroundImageLayout = ImageLayout.Zoom;
            BtnCancel.Location = new Point(162, 363);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(94, 47);
            BtnCancel.TabIndex = 31;
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            BtnSave.BackgroundImage = Properties.Resources.save;
            BtnSave.BackgroundImageLayout = ImageLayout.Zoom;
            BtnSave.Location = new Point(43, 363);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(94, 47);
            BtnSave.TabIndex = 30;
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // ProductsView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(806, 599);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "ProductsView";
            Text = "ProductsView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPageProductList.ResumeLayout(false);
            tabPageProductList.PerformLayout();
            tabPageProductDetail.ResumeLayout(false);
            tabPageProductDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgCategory).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPageProductList;
        private TabPage tabPageProductDetail;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnNew;
        private Button BtnSearch;
        private DataGridView DgCategory;
        private TextBox TxtSearch;
        private Label label2;
        private TextBox TxtProductsStock;
        private Label label7;
        private TextBox TxtProductsPrice;
        private Label label6;
        private TextBox TxtProductsCategory;
        private Label label5;
        private TextBox TxtProductsName;
        private Label label4;
        private TextBox TxtProductsId;
        private Label label3;
        private Button BtnCancel;
        private Button BtnSave;
    }
}