using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarker_mvp.Views
{
    public partial class ProductsView : Form, IProductsView
    {
        private bool isEdit;
        private bool isSuccessful;
        private string message;
        public ProductsView()
        {
            InitializeComponent();
            AssociatedAndRaiseViewEvents();
            tabControl1.TabPages.Remove(tabPageProductDetail);
            BtnClose.Click += delegate { this.Close(); };
        }

        private void AssociatedAndRaiseViewEvents()
        {
            BtnSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };

            TxtSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchEvent?.Invoke(this, EventArgs.Empty);
                }
            };
            BtnNew.Click += delegate
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPageProductList);
                tabControl1.TabPages.Add(tabPageProductDetail);
                tabPageProductDetail.Text = "Add New Pay Mode";
            };
            BtnEdit.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPageProductList);
                tabControl1.TabPages.Add(tabPageProductDetail);
                tabPageProductDetail.Text = "Edit Pay Mode";
            };
            BtnDelete.Click += delegate
            {
                var result = MessageBox.Show(
                    "Are you sure you want to delete the selected Pay Mode",
                    "Warning",
             MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };
            BtnSave.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (isSuccessful)
                {

                    tabControl1.TabPages.Remove(tabPageProductDetail);
                    tabControl1.TabPages.Add(tabPageProductList);

                }
                MessageBox.Show(Message);
            };
            BtnCancel.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPageProductDetail);
                tabControl1.TabPages.Add(tabPageProductList);
            };
        }

        public string ProductId
        {
            get { return TxtProductsId.Text; }
            set { TxtProductsId.Text = value; }
        }
        public string ProductName
        {
            get { return TxtProductsName.Text; }
            set { TxtProductsName.Text = value; }
        }
        public string ProductPrice
        {
            get { return TxtProductsPrice.Text; }
            set { TxtProductsPrice.Text = value; }
        }
        public string ProductStock
        {
            get { return TxtProductsStock.Text; }
            set { TxtProductsStock.Text = value; }
        }
        public string ProductCategorieId
        {
            get { return TxtProductsCategory.Text; }
            set { TxtProductsCategory.Text = value; }
        }
        public string SearchValue
        {
            get { return TxtSearch.Text; }
            set { TxtSearch.Text = value; }
        }
        public bool IsEdit
        {
            get { return isEdit; }
            set { isEdit = value; }
        }
        public bool IsSuccessful
        {
            get { return isSuccessful; }
            set { isSuccessful = value; }
        }
        public string Message
        {
            get { return message; }
            set { message = value; }
        }

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        public void SetProductListBildingSource(BindingSource productList)
        {
            DgCategory.DataSource = productList;
        }

        private static ProductsView instance;
        public static ProductsView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new ProductsView();
                instance.MdiParent = parentContainer;

                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                {
                    instance.WindowState = FormWindowState.Normal;
                }
                instance.BringToFront();
            }
            return instance;
        }
    }
}
