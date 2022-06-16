using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Model
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Address { get; set; }

        public string Phonenumber { get; set; }

        public bool IsAdmin { get; set; }
       
        public Customer()
        {

        }
        public Customer(string name, string email, string password, string address, string phone)
        {
            Name = name;
            Email = email;
            Password = password;
            Address = address;
            Phonenumber = phone;
            IsAdmin = false;
        }
    }
}
