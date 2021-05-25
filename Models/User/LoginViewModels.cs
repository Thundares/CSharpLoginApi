using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LoginApi.Models.User
{
    public class LoginViewModels
    {
        [Required(ErrorMessage = "O campo Login é necessário.")]
        public string Login { get; set; }

        [Required(ErrorMessage = "O campo Senha é necessário.")]
        public string Password { get; set; }
    }
}
