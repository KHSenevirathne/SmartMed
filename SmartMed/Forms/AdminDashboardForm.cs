using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SmartMed.Data;
using SmartMed.Models;
using SmartMed.Services;

namespace SmartMed.Forms
{
    public partial class AdminDashboardForm : Form
    {
        public AdminDashboardForm()
        {
            InitializeComponent();

            welcome.Text = SessionContext.CurrentUser != null
                ? "Signed in as " + SessionContext.CurrentUser.FullName
                : "";

            LoadSummary();
        }

        private void BtnManageMedicines_Click(object sender, EventArgs e)
        {
            Open(new ManageMedicinesForm());
        }

        private void BtnManageCustomers_Click(object sender, EventArgs e)
        {
            Open(new ManageCustomersForm());
        }

        private void BtnManageOrders_Click(object sender, EventArgs e)
        {
            Open(new ManageOrdersForm());
        }

        private void BtnReports_Click(object sender, EventArgs e)
        {
            Open(new ReportsForm());
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
            LoadSummary();
        }

        private void LoadSummary()
        {
            ReportService reports = new ReportService();
            MedicineRepository medicineRepo = new MedicineRepository();
            OrderRepository orderRepo = new OrderRepository();

            List<Medicine> medicines = medicineRepo.GetAll().ToList();
            List<Order> orders = orderRepo.GetAll().ToList();

            cardSales.Text = reports.GetTotalSales().ToString("C2");
            cardStock.Text = medicines.Sum(m => m.Stock).ToString();
            cardOrders.Text = orders.Count(o =>
                o.Status == OrderStatus.Pending || o.Status == OrderStatus.ReadyForPickup).ToString();

            notificationsPanel.Controls.Clear();

            List<Medicine> nearExpiry = medicines.Where(m => m.IsNearExpiry()).ToList();
            List<Medicine> lowStock = medicines.Where(m => m.IsLowStock()).ToList();

            foreach (Medicine m in nearExpiry)
            {
                AddNotification(
                    "Near expiry  -  " + m.Name + " expires on " + m.ExpiryDate.ToString("yyyy-MM-dd"),
                    Color.FromArgb(219, 75, 75));
            }
            foreach (Medicine m in lowStock)
            {
                AddNotification(
                    "Low stock  -  " + m.Name + " has only " + m.Stock + " left",
                    Color.FromArgb(232, 169, 59));
            }

            if (notificationsPanel.Controls.Count == 0)
            {
                AddNotification("All good - no stock or expiry warnings.", Color.FromArgb(46, 158, 107));
            }
        }

        private void AddNotification(string text, Color color)
        {
            Label label = new Label
            {
                Text = "•  " + text,
                ForeColor = color,
                AutoSize = true,
                Margin = new Padding(8, 7, 8, 0),
                Font = new Font("Segoe UI", 10F)
            };
            notificationsPanel.Controls.Add(label);
        }
    }
}
