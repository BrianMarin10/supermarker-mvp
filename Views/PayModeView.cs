using Supermarket_mvp.Views;
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
    public partial class PayModeView : Form, IPayModeView
    {
        private bool isEdit;
        private bool isSuccessful;
        private string message;

        public PayModeView()
        {
            InitializeComponent();
            AssociatedAndRaiseViewEvents();
            tabControl1.TabPages.Remove(tabPagePayModeDetail);

            BtnClose.Click += delegate { this.Close(); };
        }

        private void AssociatedAndRaiseViewEvents()
        {
            throw new NotImplementedException();
        }

        public string PayModeId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string PayModeName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string PayModeObservation { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string SearchValue { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool IsEdit { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool IsSuccessful { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Message { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        public void SetPayModeListBildingSource(BindingSource payModeList)
        {
            DgPayMode.DataSource = payModeList;
        }
    }
}
