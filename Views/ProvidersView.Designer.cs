namespace Supermarker_mvp.Views
{
    partial class ProvidersView
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
            tabPageProviderList = new TabPage();
            BtnClose = new Button();
            BtnDelete = new Button();
            BtnEdit = new Button();
            BtnNew = new Button();
            BtnSearch = new Button();
            DgProviders = new DataGridView();
            TxtSearch = new TextBox();
            label2 = new Label();
            tabPageProvidersDetail = new TabPage();
            BtnCancel = new Button();
            BtnSave = new Button();
            TxtProviderObservation = new TextBox();
            label5 = new Label();
            TxtProviderName = new TextBox();
            label4 = new Label();
            TxtProviderId = new TextBox();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPageProviderList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgProviders).BeginInit();
            tabPageProvidersDetail.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(840, 125);
            panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.providers;
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
            label1.Size = new Size(140, 38);
            label1.TabIndex = 0;
            label1.Text = "Providers";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageProviderList);
            tabControl1.Controls.Add(tabPageProvidersDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 125);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(840, 395);
            tabControl1.TabIndex = 3;
            // 
            // tabPageProviderList
            // 
            tabPageProviderList.Controls.Add(BtnClose);
            tabPageProviderList.Controls.Add(BtnDelete);
            tabPageProviderList.Controls.Add(BtnEdit);
            tabPageProviderList.Controls.Add(BtnNew);
            tabPageProviderList.Controls.Add(BtnSearch);
            tabPageProviderList.Controls.Add(DgProviders);
            tabPageProviderList.Controls.Add(TxtSearch);
            tabPageProviderList.Controls.Add(label2);
            tabPageProviderList.Location = new Point(4, 29);
            tabPageProviderList.Name = "tabPageProviderList";
            tabPageProviderList.Padding = new Padding(3);
            tabPageProviderList.Size = new Size(832, 362);
            tabPageProviderList.TabIndex = 0;
            tabPageProviderList.Text = "Providers List";
            tabPageProviderList.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            BtnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnClose.BackgroundImage = Properties.Resources.cerrar;
            BtnClose.BackgroundImageLayout = ImageLayout.Zoom;
            BtnClose.Location = new Point(657, 256);
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
            BtnDelete.Location = new Point(657, 191);
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
            BtnEdit.Location = new Point(657, 130);
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
            BtnNew.Location = new Point(657, 68);
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
            BtnSearch.Location = new Point(513, 12);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(50, 48);
            BtnSearch.TabIndex = 24;
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // DgProviders
            // 
            DgProviders.AllowUserToAddRows = false;
            DgProviders.AllowUserToDeleteRows = false;
            DgProviders.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DgProviders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgProviders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgProviders.Location = new Point(22, 68);
            DgProviders.Name = "DgProviders";
            DgProviders.ReadOnly = true;
            DgProviders.RowHeadersWidth = 51;
            DgProviders.RowTemplate.Height = 29;
            DgProviders.Size = new Size(541, 282);
            DgProviders.TabIndex = 23;
            // 
            // TxtSearch
            // 
            TxtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtSearch.Location = new Point(22, 35);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Data to search";
            TxtSearch.Size = new Size(472, 27);
            TxtSearch.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(22, 12);
            label2.Name = "label2";
            label2.Size = new Size(118, 20);
            label2.TabIndex = 21;
            label2.Text = "Search Provider";
            // 
            // tabPageProvidersDetail
            // 
            tabPageProvidersDetail.Controls.Add(BtnCancel);
            tabPageProvidersDetail.Controls.Add(BtnSave);
            tabPageProvidersDetail.Controls.Add(TxtProviderObservation);
            tabPageProvidersDetail.Controls.Add(label5);
            tabPageProvidersDetail.Controls.Add(TxtProviderName);
            tabPageProvidersDetail.Controls.Add(label4);
            tabPageProvidersDetail.Controls.Add(TxtProviderId);
            tabPageProvidersDetail.Controls.Add(label3);
            tabPageProvidersDetail.Location = new Point(4, 29);
            tabPageProvidersDetail.Name = "tabPageProvidersDetail";
            tabPageProvidersDetail.Padding = new Padding(3);
            tabPageProvidersDetail.Size = new Size(832, 362);
            tabPageProvidersDetail.TabIndex = 1;
            tabPageProvidersDetail.Text = "Providers Detail";
            tabPageProvidersDetail.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            BtnCancel.BackgroundImage = Properties.Resources.cancel;
            BtnCancel.BackgroundImageLayout = ImageLayout.Zoom;
            BtnCancel.Location = new Point(163, 296);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(94, 47);
            BtnCancel.TabIndex = 31;
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            BtnSave.BackgroundImage = Properties.Resources.save;
            BtnSave.BackgroundImageLayout = ImageLayout.Zoom;
            BtnSave.Location = new Point(44, 296);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(94, 47);
            BtnSave.TabIndex = 30;
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // TxtProviderObservation
            // 
            TxtProviderObservation.Location = new Point(22, 202);
            TxtProviderObservation.Multiline = true;
            TxtProviderObservation.Name = "TxtProviderObservation";
            TxtProviderObservation.PlaceholderText = "Pay Mode Observation";
            TxtProviderObservation.Size = new Size(366, 77);
            TxtProviderObservation.TabIndex = 29;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 179);
            label5.Name = "label5";
            label5.Size = new Size(148, 20);
            label5.TabIndex = 28;
            label5.Text = "Provider Observation";
            // 
            // TxtProviderName
            // 
            TxtProviderName.Location = new Point(21, 120);
            TxtProviderName.Name = "TxtProviderName";
            TxtProviderName.PlaceholderText = "Pay Mode Name";
            TxtProviderName.Size = new Size(367, 27);
            TxtProviderName.TabIndex = 27;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 97);
            label4.Name = "label4";
            label4.Size = new Size(108, 20);
            label4.TabIndex = 26;
            label4.Text = "Provider Name";
            // 
            // TxtProviderId
            // 
            TxtProviderId.Location = new Point(20, 42);
            TxtProviderId.Name = "TxtProviderId";
            TxtProviderId.ReadOnly = true;
            TxtProviderId.Size = new Size(168, 27);
            TxtProviderId.TabIndex = 25;
            TxtProviderId.Text = "0";
            TxtProviderId.TextAlign = HorizontalAlignment.Right;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 19);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 24;
            label3.Text = "Provider Id";
            // 
            // ProvidersView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(840, 520);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "ProvidersView";
            Text = "ProvidersView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPageProviderList.ResumeLayout(false);
            tabPageProviderList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgProviders).EndInit();
            tabPageProvidersDetail.ResumeLayout(false);
            tabPageProvidersDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPageProviderList;
        private TabPage tabPageProvidersDetail;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnNew;
        private Button BtnSearch;
        private DataGridView DgProviders;
        private TextBox TxtSearch;
        private Label label2;
        private Button BtnCancel;
        private Button BtnSave;
        private TextBox TxtProviderObservation;
        private Label label5;
        private TextBox TxtProviderName;
        private Label label4;
        private TextBox TxtProviderId;
        private Label label3;
    }
}