using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeShop.Application.Models.Identity
{
    public class LoginRequest
    {
        [Required(ErrorMessage = "Khong duoc de trong !")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Khong duoc de trong !")]
        public string Password { get; set; }
    }
}
