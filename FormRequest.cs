using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Configuration;
using System.Windows.Forms;
using Hospital.Data;
using Hospital.Lib.Services;
using Hospital.Lib;
using Hospital.Lib.Models;

namespace Hospital
{
    public partial class FormRequest : Form
    {
        private RequestService _requestService;
        private List<RequestView> _allRequests;

        public FormRequest()
        {
            InitializeComponent();
            string connStr = ConfigurationManager.ConnectionStrings["HospitalMySql"].ConnectionString;
            var repo = new MySqlRequestRepository(connStr);
            _requestService = new RequestService(repo);
        }

        private void FormRequest_Load(object sender, EventArgs e)
        {
            LoadRequests();
        }
        private void LoadRequests()
        {
            _allRequests = _requestService.GetAllRequests();

            lstRequests.Items.Clear();

            if (_allRequests.Count == 0)
            {
                lblInfo.Text = "Заявок нет";
                dgvRequestDetails.DataSource = null;
                return;
            }

            lblInfo.Text = "";

            var grouped = _allRequests
                .GroupBy(r => r.Id)
                .Select(g => new { Id = g.Key })
                .ToList();

            foreach (var item in grouped)
            {
                lstRequests.Items.Add(item.Id);
            }
        }

        private void lblInfo_Click(object sender, EventArgs e)
        {

        }

        private void lstRequests_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstRequests.SelectedItem == null) return;

            string selectedId = lstRequests.SelectedItem.ToString();

            var filtered = _requestService.GetSelectedRequest(selectedId);

            dgvRequestDetails.DataSource = filtered;
        }
    }
}
