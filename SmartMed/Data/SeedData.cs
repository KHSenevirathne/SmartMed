using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using SmartMed.Models;
using SmartMed.Utils;

namespace SmartMed.Data
{
    public static class SeedData
    {
        public static string DataFolder
        {
            get { return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "AppData"); }
        }

        public static string PrescriptionsFolder
        {
            get { return Path.Combine(DataFolder, "Prescriptions"); }
        }

        public static void EnsureSeeded()
        {
            Directory.CreateDirectory(DataFolder);
            Directory.CreateDirectory(PrescriptionsFolder);

            SeedAdmins();
            SeedMedicines();
            SeedCustomers();
        }

        private static void SeedAdmins()
        {
            AdminRepository repo = new AdminRepository();
            if (repo.GetAll().Any())
            {
                return;
            }

            Admin admin = new Admin
            {
                FullName = "System Administrator",
                Email = "admin@smartmed.local",
                Phone = "000-0000000",
                Address = "SmartMed Head Office",
                Username = "admin",
                PasswordHash = PasswordHasher.Hash("Admin@123")
            };
            repo.Add(admin);
        }

        private static void SeedMedicines()
        {
            MedicineRepository repo = new MedicineRepository();
            if (repo.GetAll().Any())
            {
                return;
            }

            DateTime today = DateTime.Now.Date;

            List<Medicine> medicines = new List<Medicine>
            {
                new Medicine { Name = "Paracetamol", Category = "Painkiller", Dosage = "500mg",
                    Price = 5.00m, Stock = 120, Supplier = "MediSupply Co",
                    ExpiryDate = today.AddMonths(18), RequiresPrescription = false, DiscountPercent = 0m },

                new Medicine { Name = "Ibuprofen", Category = "Painkiller", Dosage = "200mg",
                    Price = 6.50m, Stock = 80, Supplier = "MediSupply Co",
                    ExpiryDate = today.AddMonths(12), RequiresPrescription = false, DiscountPercent = 10m },

                new Medicine { Name = "Amoxicillin", Category = "Antibiotic", Dosage = "250mg",
                    Price = 12.00m, Stock = 40, Supplier = "PharmaWorld",
                    ExpiryDate = today.AddMonths(9), RequiresPrescription = true, DiscountPercent = 0m },

                new Medicine { Name = "Azithromycin", Category = "Antibiotic", Dosage = "500mg",
                    Price = 18.75m, Stock = 25, Supplier = "PharmaWorld",
                    ExpiryDate = today.AddDays(20), RequiresPrescription = true, DiscountPercent = 5m },

                new Medicine { Name = "Cetirizine", Category = "Antihistamine", Dosage = "10mg",
                    Price = 4.25m, Stock = 200, Supplier = "HealthLine Ltd",
                    ExpiryDate = today.AddMonths(24), RequiresPrescription = false, DiscountPercent = 15m },

                new Medicine { Name = "Vitamin C", Category = "Supplement", Dosage = "1000mg",
                    Price = 8.00m, Stock = 150, Supplier = "HealthLine Ltd",
                    ExpiryDate = today.AddMonths(20), RequiresPrescription = false, DiscountPercent = 20m },

                new Medicine { Name = "Insulin Glargine", Category = "Diabetes", Dosage = "100IU/mL",
                    Price = 45.00m, Stock = 15, Supplier = "GlobalMeds",
                    ExpiryDate = today.AddDays(25), RequiresPrescription = true, DiscountPercent = 0m },

                new Medicine { Name = "Salbutamol Inhaler", Category = "Respiratory", Dosage = "100mcg",
                    Price = 14.50m, Stock = 30, Supplier = "GlobalMeds",
                    ExpiryDate = today.AddMonths(15), RequiresPrescription = true, DiscountPercent = 0m },

                new Medicine { Name = "Omeprazole", Category = "Gastrointestinal", Dosage = "20mg",
                    Price = 9.99m, Stock = 60, Supplier = "MediSupply Co",
                    ExpiryDate = today.AddDays(10), RequiresPrescription = false, DiscountPercent = 0m },

                new Medicine { Name = "Loratadine", Category = "Antihistamine", Dosage = "10mg",
                    Price = 5.75m, Stock = 8, Supplier = "HealthLine Ltd",
                    ExpiryDate = today.AddMonths(11), RequiresPrescription = false, DiscountPercent = 0m },

                new Medicine { Name = "Cough Syrup", Category = "Respiratory", Dosage = "100mL",
                    Price = 7.20m, Stock = 5, Supplier = "PharmaWorld",
                    ExpiryDate = today.AddDays(28), RequiresPrescription = false, DiscountPercent = 10m }
            };

            foreach (Medicine medicine in medicines)
            {
                repo.Add(medicine);
            }
        }

        private static void SeedCustomers()
        {
            CustomerRepository repo = new CustomerRepository();
            if (repo.GetAll().Any())
            {
                return;
            }

            Customer john = new Customer
            {
                FullName = "John Smith",
                Email = "john.smith@example.com",
                Phone = "555-0101",
                Address = "12 Baker Street, London",
                Username = "john",
                PasswordHash = PasswordHasher.Hash("Customer@123"),
                DateRegistered = DateTime.Now.AddMonths(-3)
            };

            Customer mary = new Customer
            {
                FullName = "Mary Jones",
                Email = "mary.jones@example.com",
                Phone = "555-0102",
                Address = "8 Queen Avenue, Leeds",
                Username = "mary",
                PasswordHash = PasswordHasher.Hash("Customer@123"),
                DateRegistered = DateTime.Now.AddMonths(-1)
            };

            repo.Add(john);
            repo.Add(mary);
        }
    }
}
