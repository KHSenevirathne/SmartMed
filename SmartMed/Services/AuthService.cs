using System;
using System.Linq;
using SmartMed.Data;
using SmartMed.Models;
using SmartMed.Utils;

namespace SmartMed.Services
{
    public class AuthService
    {
        private readonly AdminRepository _admins;
        private readonly CustomerRepository _customers;

        public AuthService()
        {
            _admins = new AdminRepository();
            _customers = new CustomerRepository();
        }

        public Admin LoginAdmin(string username, string password)
        {
            if (!Validator.IsNotEmpty(username) || !Validator.IsNotEmpty(password))
            {
                return null;
            }

            Admin admin = _admins.GetAll().FirstOrDefault(
                a => string.Equals(a.Username, username.Trim(), StringComparison.OrdinalIgnoreCase));

            if (admin != null && PasswordHasher.Verify(password, admin.PasswordHash))
            {
                return admin;
            }
            return null;
        }

        public Customer LoginCustomer(string username, string password)
        {
            if (!Validator.IsNotEmpty(username) || !Validator.IsNotEmpty(password))
            {
                return null;
            }

            Customer customer = _customers.GetAll().FirstOrDefault(
                c => string.Equals(c.Username, username.Trim(), StringComparison.OrdinalIgnoreCase));

            if (customer != null && PasswordHasher.Verify(password, customer.PasswordHash))
            {
                return customer;
            }
            return null;
        }

        public bool UsernameExists(string username)
        {
            if (!Validator.IsNotEmpty(username))
            {
                return false;
            }

            string trimmed = username.Trim();
            bool inAdmins = _admins.GetAll().Any(
                a => string.Equals(a.Username, trimmed, StringComparison.OrdinalIgnoreCase));
            bool inCustomers = _customers.GetAll().Any(
                c => string.Equals(c.Username, trimmed, StringComparison.OrdinalIgnoreCase));

            return inAdmins || inCustomers;
        }

        public Customer RegisterCustomer(string fullName, string email, string phone,
            string address, string username, string plainPassword)
        {
            if (UsernameExists(username))
            {
                throw new InvalidOperationException("That username is already taken.");
            }

            Customer customer = new Customer
            {
                FullName = fullName == null ? null : fullName.Trim(),
                Email = email == null ? null : email.Trim(),
                Phone = phone == null ? null : phone.Trim(),
                Address = address == null ? null : address.Trim(),
                Username = username == null ? null : username.Trim(),
                PasswordHash = PasswordHasher.Hash(plainPassword),
                DateRegistered = DateTime.Now
            };

            _customers.Add(customer);
            return customer;
        }
    }
}
