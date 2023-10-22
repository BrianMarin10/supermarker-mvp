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
    public partial class ProvidersView : Form, IProvidersView
    {
        private bool isEdit;
        private bool isSuccessful;
        private string message;
        public ProvidersView()
        {
            InitializeComponent();
            AssociatedAndRaiseViewEvents();
            tabControl1.TabPages.Remove(tabPageProvidersDetail);
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
                tabControl1.TabPages.Remove(tabPageProviderList);
                tabControl1.TabPages.Add(tabPageProvidersDetail);
                tabPageProvidersDetail.Text = "Add New Pay Mode";
            };
            BtnEdit.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPageProviderList);
                tabControl1.TabPages.Add(tabPageProvidersDetail);
                tabPageProvidersDetail.Text = "Edit Pay Mode";
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

                    tabControl1.TabPages.Remove(tabPageProvidersDetail);
                    tabControl1.TabPages.Add(tabPageProviderList);

                }
                MessageBox.Show(Message);
            };
            BtnCancel.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPageProvidersDetail);
                tabControl1.TabPages.Add(tabPageProviderList);
            };
        }

        public string ProviderId
        {
            get { return TxtProviderId.Text; }
            set { TxtProviderId.Text = value; }
        }
        public string ProviderName
        {
            get { return TxtProviderName.Text; }
            set { TxtProviderName.Text = value; }
        }
        public string ProviderObservation
        {
            get { return TxtProviderObservation.Text; }
            set { TxtProviderObservation.Text = value; }
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

        public void SetProviderListBildingSource(BindingSource providerList)
        {
            DgProviders.DataSource = providerList;
        }
        private static ProvidersView instance;
        public static ProvidersView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new ProvidersView();
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
