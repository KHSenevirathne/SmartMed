using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SmartMed.Data;
using SmartMed.Models;
using SmartMed.Services;
using SmartMed.Utils;

namespace SmartMed.Forms
{
    public partial class SearchMedicinesForm : Form
    {
        private readonly MedicineRepository _repo = new MedicineRepository();
        private readonly SearchService _search = new SearchService();

        public SearchMedicinesForm()
        {
            InitializeComponent();
            UiTheme.StyleGrid(grid);
            LoadCategories();
            cmbSort.SelectedIndex = 0;
            RunSearch();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            RunSearch();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LoadCategories()
        {
            List<string> categories = _repo.GetAll()
                .Select(m => m.Category)
                .Where(c => !string.IsNullOrWhiteSpace(c))
                .Distinct()
                .OrderBy(c => c)
                .ToList();

            cmbCategory.Items.Add("All categories");
            foreach (string category in categories)
            {
                cmbCategory.Items.Add(category);
            }
            cmbCategory.SelectedIndex = 0;
        }

        private void RunSearch()
        {
            List<Medicine> list;

            if (chkExact.Checked)
            {
                List<Medicine> sortedByName = _search.SortByName(_repo.GetAll());
                Medicine match = _search.BinarySearchByName(sortedByName, txtName.Text);

                list = new List<Medicine>();
                if (match != null)
                {
                    list.Add(match);
                }
            }
            else
            {
                IEnumerable<Medicine> results = _repo.GetAll();

                results = _search.SearchByName(results, txtName.Text);

                string category = cmbCategory.SelectedIndex <= 0 ? null : cmbCategory.SelectedItem.ToString();
                results = _search.FilterByCategory(results, category);

                decimal? min = null;
                decimal? max = null;
                decimal parsed;
                if (Validator.IsNotEmpty(txtMin.Text) && Validator.TryParseDecimal(txtMin.Text, out parsed))
                {
                    min = parsed;
                }
                if (Validator.IsNotEmpty(txtMax.Text) && Validator.TryParseDecimal(txtMax.Text, out parsed))
                {
                    max = parsed;
                }
                results = _search.FilterByPriceRange(results, min, max);

                switch (cmbSort.SelectedIndex)
                {
                    case 1:
                        list = _search.SortByPrice(results, true);
                        break;
                    case 2:
                        list = _search.SortByPrice(results, false);
                        break;
                    default:
                        list = _search.SortByName(results);
                        break;
                }
            }

            grid.DataSource = null;
            grid.DataSource = list.Select(m => new
            {
                m.Name,
                m.Category,
                m.Dosage,
                Price = m.Price,
                Discounted = m.DiscountedPrice(),
                m.Stock,
                Prescription = m.RequiresPrescription ? "Yes" : "No",
                Expiry = m.ExpiryDate.ToString("yyyy-MM-dd")
            }).ToList();

            UiTheme.FormatMoneyColumns(grid, "Price", "Discounted");

            if (chkExact.Checked)
            {
                lblCount.Text = list.Count == 0
                    ? "No medicine found with that exact name."
                    : "1 exact match found by binary search.";
            }
            else
            {
                lblCount.Text = list.Count + " medicine(s) found.";
            }
        }

        private void ChkExact_CheckedChanged(object sender, EventArgs e)
        {
            RunSearch();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtMin.Clear();
            txtMax.Clear();
            cmbCategory.SelectedIndex = 0;
            cmbSort.SelectedIndex = 0;
            chkExact.Checked = false;
            RunSearch();
        }
    }
}
