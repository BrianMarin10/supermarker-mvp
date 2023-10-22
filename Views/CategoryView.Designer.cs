namespace Supermarker_mvp.Views
{
    partial class CategoryView
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
            tabCategoryModeList = new TabPage();
            BtnClose = new Button();
            BtnDelete = new Button();
            BtnEdit = new Button();
            BtnNew = new Button();
            BtnSearch = new Button();
            DgCategory = new DataGridView();
            TxtSearch = new TextBox();
            label2 = new Label();
            tabPageCategoryDetail = new TabPage();
            BtnCancel = new Button();
            BtnSave = new Button();
            TxtCategoryObservation = new TextBox();
            label5 = new Label();
            TxtCategoryName = new TextBox();
            label4 = new Label();
            TxtCategoryId = new TextBox();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabCategoryModeList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgCategory).BeginInit();
            tabPageCategoryDetail.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(823, 125);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.categories;
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
            label1.Size = new Size(155, 38);
            label1.TabIndex = 0;
            label1.Text = "Categories";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabCategoryModeList);
            tabControl1.Controls.Add(tabPageCategoryDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 125);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(823, 474);
            tabControl1.TabIndex = 2;
            // 
            // tabCategoryModeList
            // 
            tabCategoryModeList.Controls.Add(BtnClose);
            tabCategoryModeList.Controls.Add(BtnDelete);
            tabCategoryModeList.Controls.Add(BtnEdit);
            tabCategoryModeList.Controls.Add(BtnNew);
            tabCategoryModeList.Controls.Add(BtnSearch);
            tabCategoryModeList.Controls.Add(DgCategory);
            tabCategoryModeList.Controls.Add(TxtSearch);
            tabCategoryModeList.Controls.Add(label2);
            tabCategoryModeList.Location = new Point(4, 29);
            tabCategoryModeList.Name = "tabCategoryModeList";
            tabCategoryModeList.Padding = new Padding(3);
            tabCategoryModeList.Size = new Size(815, 441);
            tabCategoryModeList.TabIndex = 0;
            tabCategoryModeList.Text = "Category List";
            tabCategoryModeList.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            BtnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnClose.BackgroundImage = Properties.Resources.cerrar;
            BtnClose.BackgroundImageLayout = ImageLayout.Zoom;
            BtnClose.Location = new Point(656, 277);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(94, 38);
            BtnClose.TabIndex = 20;
            BtnClose.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnDelete.BackgroundImage = Properties.Resources.delete;
            BtnDelete.BackgroundImageLayout = ImageLayout.Zoom;
            BtnDelete.Location = new Point(656, 212);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(94, 39);
            BtnDelete.TabIndex = 19;
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            BtnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEdit.BackgroundImage = Properties.Resources.edit;
            BtnEdit.BackgroundImageLayout = ImageLayout.Zoom;
            BtnEdit.Location = new Point(656, 151);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(94, 38);
            BtnEdit.TabIndex = 18;
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnNew
            // 
            BtnNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnNew.BackgroundImage = Properties.Resources._new;
            BtnNew.BackgroundImageLayout = ImageLayout.Zoom;
            BtnNew.Location = new Point(656, 89);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(94, 40);
            BtnNew.TabIndex = 17;
            BtnNew.UseVisualStyleBackColor = true;
            // 
            // BtnSearch
            // 
            BtnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSearch.BackgroundImage = Properties.Resources.search;
            BtnSearch.BackgroundImageLayout = ImageLayout.Zoom;
            BtnSearch.Location = new Point(512, 33);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(50, 48);
            BtnSearch.TabIndex = 16;
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // DgCategory
            // 
            DgCategory.AllowUserToAddRows = false;
            DgCategory.AllowUserToDeleteRows = false;
            DgCategory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DgCategory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgCategory.Location = new Point(21, 89);
            DgCategory.Name = "DgCategory";
            DgCategory.ReadOnly = true;
            DgCategory.RowHeadersWidth = 51;
            DgCategory.RowTemplate.Height = 29;
            DgCategory.Size = new Size(541, 282);
            DgCategory.TabIndex = 15;
            // 
            // TxtSearch
            // 
            TxtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtSearch.Location = new Point(21, 56);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Data to search";
            TxtSearch.Size = new Size(472, 27);
            TxtSearch.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(21, 33);
            label2.Name = "label2";
            label2.Size = new Size(123, 20);
            label2.TabIndex = 13;
            label2.Text = "Search Category";
            // 
            // tabPageCategoryDetail
            // 
            tabPageCategoryDetail.Controls.Add(BtnCancel);
            tabPageCategoryDetail.Controls.Add(BtnSave);
            tabPageCategoryDetail.Controls.Add(TxtCategoryObservation);
            tabPageCategoryDetail.Controls.Add(label5);
            tabPageCategoryDetail.Controls.Add(TxtCategoryName);
            tabPageCategoryDetail.Controls.Add(label4);
            tabPageCategoryDetail.Controls.Add(TxtCategoryId);
            tabPageCategoryDetail.Controls.Add(label3);
            tabPageCategoryDetail.Location = new Point(4, 29);
            tabPageCategoryDetail.Name = "tabPageCategoryDetail";
            tabPageCategoryDetail.Padding = new Padding(3);
            tabPageCategoryDetail.Size = new Size(815, 441);
            tabPageCategoryDetail.TabIndex = 1;
            tabPageCategoryDetail.Text = "Category Detail";
            tabPageCategoryDetail.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            BtnCancel.BackgroundImage = Properties.Resources.cancel;
            BtnCancel.BackgroundImageLayout = ImageLayout.Zoom;
            BtnCancel.Location = new Point(162, 310);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(94, 47);
            BtnCancel.TabIndex = 23;
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            BtnSave.BackgroundImage = Properties.Resources.save;
            BtnSave.BackgroundImageLayout = ImageLayout.Zoom;
            BtnSave.Location = new Point(43, 310);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(94, 47);
            BtnSave.TabIndex = 22;
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // TxtCategoryObservation
            // 
            TxtCategoryObservation.Location = new Point(21, 216);
            TxtCategoryObservation.Multiline = true;
            TxtCategoryObservation.Name = "TxtCategoryObservation";
            TxtCategoryObservation.PlaceholderText = "Pay Mode Observation";
            TxtCategoryObservation.Size = new Size(366, 77);
            TxtCategoryObservation.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 193);
            label5.Name = "label5";
            label5.Size = new Size(153, 20);
            label5.TabIndex = 20;
            label5.Text = "Category Observation";
            // 
            // TxtCategoryName
            // 
            TxtCategoryName.Location = new Point(20, 134);
            TxtCategoryName.Name = "TxtCategoryName";
            TxtCategoryName.PlaceholderText = "Pay Mode Name";
            TxtCategoryName.Size = new Size(367, 27);
            TxtCategoryName.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 111);
            label4.Name = "label4";
            label4.Size = new Size(113, 20);
            label4.TabIndex = 18;
            label4.Text = "Category Name";
            // 
            // TxtCategoryId
            // 
            TxtCategoryId.Location = new Point(19, 56);
            TxtCategoryId.Name = "TxtCategoryId";
            TxtCategoryId.ReadOnly = true;
            TxtCategoryId.Size = new Size(168, 27);
            TxtCategoryId.TabIndex = 17;
            TxtCategoryId.Text = "0";
            TxtCategoryId.TextAlign = HorizontalAlignment.Right;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 33);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 16;
            label3.Text = "Category Id";
            // 
            // CategoryView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(823, 599);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "CategoryView";
            Text = "CategorieView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabCategoryModeList.ResumeLayout(false);
            tabCategoryModeList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgCategory).EndInit();
            tabPageCategoryDetail.ResumeLayout(false);
            tabPageCategoryDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabCategoryModeList;
        private TabPage tabPageCategoryDetail;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnNew;
        private Button BtnSearch;
        private DataGridView DgCategory;
        private TextBox TxtSearch;
        private Label label2;
        private Button BtnCancel;
        private Button BtnSave;
        private TextBox TxtCategoryObservation;
        private Label label5;
        private TextBox TxtCategoryName;
        private Label label4;
        private TextBox TxtCategoryId;
        private Label label3;
    }
}