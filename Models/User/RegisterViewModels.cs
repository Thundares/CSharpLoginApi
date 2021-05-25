using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LoginApi.Models.User
{
    public class RegisterViewModels
    {
        [Required(ErrorMessage = "O campo Nome é necessário.")]
        public string name { get; set; }

        [Required(ErrorMessage = "O campo E-mail é necessário.")]
        public string email { get; set; }

        [Required(ErrorMessage = "O campo Login é necessário.")]
        public string login { get; set; }

        [Required(ErrorMessage = "O campo Senha é necessário.")]
        public string password { get; set; }
    }
}
