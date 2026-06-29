using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SmartMed.Data;
using SmartMed.Models;
using SmartMed.Services;

namespace SmartMed.Forms
{
    public partial class CustomerDashboardForm : Form
    {
        public CustomerDashboardForm()
        {
            InitializeComponent();

            string name = SessionContext.CurrentUser != null ? SessionContext.CurrentUser.FullName : "Customer";
            header.Text = "Welcome, " + name;

            LoadNotices();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            Open(new SearchMedicinesForm());
        }

        private void BtnPlaceOrder_Click(object sender, EventArgs e)
        {
            Open(new PlaceOrderForm());
        }

        private void BtnTrackOrders_Click(object sender, EventArgs e)
        {
            Open(new TrackOrdersForm());
        }

        private void BtnProfile_Click(object sender, EventArgs e)
        {
            Open(new ProfileForm());
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Open(Form form)
        {
            using (form)
            {
                form.ShowDialog(this);
            }
            LoadNotices();
        }

        private void LoadNotices()
        {
            noticesPanel.Controls.Clear();
            MedicineRepository repo = new MedicineRepository();

            var promos = repo.GetAll()
                .Where(m => m.DiscountPercent > 0m && m.Stock > 0)
                .OrderByDescending(m => m.DiscountPercent)
                .ToList();

            foreach (Medicine m in promos)
            {
                AddNotice(string.Format("•  {0}% off {1}  -  now {2} (was {3})",
                    m.DiscountPercent.ToString("0.##"), m.Name,
                    m.DiscountedPrice().ToString("C2"), m.Price.ToString("C2")),
                    Color.FromArgb(46, 158, 107));
            }

            if (noticesPanel.Controls.Count == 0)
            {
                AddNotice("No promotions right now - check back soon!", Color.FromArgb(138, 147, 166));
            }
        }

        private void AddNotice(string text, Color color)
        {
            Label label = new Label
            {
                Text = text,
                ForeColor = color,
                AutoSize = true,
                Margin = new Padding(8, 7, 8, 0),
                Font = new Font("Segoe UI", 10F)
            };
            noticesPanel.Controls.Add(label);
        }
    }
}
