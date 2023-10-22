namespace Supermarker_mvp.Views
{
    partial class PayModeView
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
            tabPagePayModeList = new TabPage();
            BtnClose = new Button();
            BtnDelete = new Button();
            BtnEdit = new Button();
            BtnNew = new Button();
            BtnSearch = new Button();
            DgPayMode = new DataGridView();
            TxtSearch = new TextBox();
            label2 = new Label();
            tabPagePayModeDetail = new TabPage();
            BtnCancel = new Button();
            BtnSave = new Button();
            TxtPayModeObservation = new TextBox();
            label5 = new Label();
            TxtPayModeName = new TextBox();
            label4 = new Label();
            TxtPayModeId = new TextBox();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPagePayModeList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgPayMode).BeginInit();
            tabPagePayModeDetail.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(850, 125);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.buy;
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
            label1.Size = new Size(147, 38);
            label1.TabIndex = 0;
            label1.Text = "Pay Mode";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPagePayModeList);
            tabControl1.Controls.Add(tabPagePayModeDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 125);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(850, 421);
            tabControl1.TabIndex = 1;
            // 
            // tabPagePayModeList
            // 
            tabPagePayModeList.Controls.Add(BtnClose);
            tabPagePayModeList.Controls.Add(BtnDelete);
            tabPagePayModeList.Controls.Add(BtnEdit);
            tabPagePayModeList.Controls.Add(BtnNew);
            tabPagePayModeList.Controls.Add(BtnSearch);
            tabPagePayModeList.Controls.Add(DgPayMode);
            tabPagePayModeList.Controls.Add(TxtSearch);
            tabPagePayModeList.Controls.Add(label2);
            tabPagePayModeList.Location = new Point(4, 29);
            tabPagePayModeList.Name = "tabPagePayModeList";
            tabPagePayModeList.Padding = new Padding(3);
            tabPagePayModeList.Size = new Size(842, 388);
            tabPagePayModeList.TabIndex = 0;
            tabPagePayModeList.Text = "Pay Mode List";
            tabPagePayModeList.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            BtnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnClose.BackgroundImage = Properties.Resources.cerrar;
            BtnClose.BackgroundImageLayout = ImageLayout.Zoom;
            BtnClose.Location = new Point(654, 270);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(94, 38);
            BtnClose.TabIndex = 12;
            BtnClose.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnDelete.BackgroundImage = Properties.Resources.delete;
            BtnDelete.BackgroundImageLayout = ImageLayout.Zoom;
            BtnDelete.Location = new Point(654, 205);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(94, 39);
            BtnDelete.TabIndex = 11;
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            BtnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEdit.BackgroundImage = Properties.Resources.edit;
            BtnEdit.BackgroundImageLayout = ImageLayout.Zoom;
            BtnEdit.Location = new Point(654, 144);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(94, 38);
            BtnEdit.TabIndex = 10;
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnNew
            // 
            BtnNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnNew.BackgroundImage = Properties.Resources._new;
            BtnNew.BackgroundImageLayout = ImageLayout.Zoom;
            BtnNew.Location = new Point(654, 82);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(94, 40);
            BtnNew.TabIndex = 9;
            BtnNew.UseVisualStyleBackColor = true;
            // 
            // BtnSearch
            // 
            BtnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSearch.BackgroundImage = Properties.Resources.search;
            BtnSearch.BackgroundImageLayout = ImageLayout.Zoom;
            BtnSearch.Location = new Point(510, 26);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(50, 48);
            BtnSearch.TabIndex = 8;
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // DgPayMode
            // 
            DgPayMode.AllowUserToAddRows = false;
            DgPayMode.AllowUserToDeleteRows = false;
            DgPayMode.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DgPayMode.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgPayMode.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgPayMode.Location = new Point(19, 82);
            DgPayMode.Name = "DgPayMode";
            DgPayMode.ReadOnly = true;
            DgPayMode.RowHeadersWidth = 51;
            DgPayMode.RowTemplate.Height = 29;
            DgPayMode.Size = new Size(541, 282);
            DgPayMode.TabIndex = 6;
            // 
            // TxtSearch
            // 
            TxtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtSearch.Location = new Point(19, 49);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Data to search";
            TxtSearch.Size = new Size(472, 27);
            TxtSearch.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(19, 26);
            label2.Name = "label2";
            label2.Size = new Size(128, 20);
            label2.TabIndex = 4;
            label2.Text = "Search Pay Mode";
            // 
            // tabPagePayModeDetail
            // 
            tabPagePayModeDetail.Controls.Add(BtnCancel);
            tabPagePayModeDetail.Controls.Add(BtnSave);
            tabPagePayModeDetail.Controls.Add(TxtPayModeObservation);
            tabPagePayModeDetail.Controls.Add(label5);
            tabPagePayModeDetail.Controls.Add(TxtPayModeName);
            tabPagePayModeDetail.Controls.Add(label4);
            tabPagePayModeDetail.Controls.Add(TxtPayModeId);
            tabPagePayModeDetail.Controls.Add(label3);
            tabPagePayModeDetail.Location = new Point(4, 29);
            tabPagePayModeDetail.Name = "tabPagePayModeDetail";
            tabPagePayModeDetail.Padding = new Padding(3);
            tabPagePayModeDetail.Size = new Size(842, 388);
            tabPagePayModeDetail.TabIndex = 1;
            tabPagePayModeDetail.Text = "Pay Mode Detail";
            tabPagePayModeDetail.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            BtnCancel.BackgroundImage = Properties.Resources.cancel;
            BtnCancel.BackgroundImageLayout = ImageLayout.Zoom;
            BtnCancel.Location = new Point(183, 307);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(94, 47);
            BtnCancel.TabIndex = 15;
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            BtnSave.BackgroundImage = Properties.Resources.save;
            BtnSave.BackgroundImageLayout = ImageLayout.Zoom;
            BtnSave.Location = new Point(64, 307);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(94, 47);
            BtnSave.TabIndex = 14;
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // TxtPayModeObservation
            // 
            TxtPayModeObservation.Location = new Point(42, 213);
            TxtPayModeObservation.Multiline = true;
            TxtPayModeObservation.Name = "TxtPayModeObservation";
            TxtPayModeObservation.PlaceholderText = "Pay Mode Observation";
            TxtPayModeObservation.Size = new Size(366, 77);
            TxtPayModeObservation.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(41, 190);
            label5.Name = "label5";
            label5.Size = new Size(158, 20);
            label5.TabIndex = 12;
            label5.Text = "Pay Mode Observation";
            // 
            // TxtPayModeName
            // 
            TxtPayModeName.Location = new Point(41, 131);
            TxtPayModeName.Name = "TxtPayModeName";
            TxtPayModeName.PlaceholderText = "Pay Mode Name";
            TxtPayModeName.Size = new Size(367, 27);
            TxtPayModeName.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 108);
            label4.Name = "label4";
            label4.Size = new Size(118, 20);
            label4.TabIndex = 10;
            label4.Text = "Pay Mode Name";
            // 
            // TxtPayModeId
            // 
            TxtPayModeId.Location = new Point(40, 53);
            TxtPayModeId.Name = "TxtPayModeId";
            TxtPayModeId.ReadOnly = true;
            TxtPayModeId.Size = new Size(168, 27);
            TxtPayModeId.TabIndex = 9;
            TxtPayModeId.Text = "0";
            TxtPayModeId.TextAlign = HorizontalAlignment.Right;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 30);
            label3.Name = "label3";
            label3.Size = new Size(91, 20);
            label3.TabIndex = 8;
            label3.Text = "Pay Mode Id";
            // 
            // PayModeView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 546);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "PayModeView";
            Text = "Pay Mode Management";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPagePayModeList.ResumeLayout(false);
            tabPagePayModeList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgPayMode).EndInit();
            tabPagePayModeDetail.ResumeLayout(false);
            tabPagePayModeDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPagePayModeList;
        private TabPage tabPagePayModeDetail;
        private DataGridView DgPayMode;
        private TextBox TxtSearch;
        private Label label2;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnNew;
        private Button BtnSearch;
        private Button BtnCancel;
        private Button BtnSave;
        private TextBox TxtPayModeObservation;
        private Label label5;
        private TextBox TxtPayModeName;
        private Label label4;
        private TextBox TxtPayModeId;
        private Label label3;
    }
}