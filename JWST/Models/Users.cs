//Users module

using System.ComponentModel.DataAnnotations;
using System.Configuration;

namespace JWST.Models
{
    public class Users
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }        
        public int isAdmin { get; set; }
    }
}