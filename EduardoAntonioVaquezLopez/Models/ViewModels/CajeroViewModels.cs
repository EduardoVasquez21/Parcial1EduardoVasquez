using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EduardoAntonioVaquezLopez.Models.ViewModels
{
    public class CajeroViewModels
    {
        [Display(Name = "Monto")]
        [Required(ErrorMessage = "Campo requerido")]
        public string monto { get; set; }
    }
}