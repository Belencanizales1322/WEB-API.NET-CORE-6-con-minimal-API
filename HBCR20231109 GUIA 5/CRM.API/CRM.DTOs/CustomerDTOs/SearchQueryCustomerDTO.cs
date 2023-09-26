using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CRM.DTOs.CustomerDTOs
{
    public class SearchQueryCustomerDTO
    {
        [Display(Name = "Nombre")]
        public string? Name_Like { get; set; }
        [Display(Name = "Apellido")]
        public string? LastName_Like { get; set; }
        [Display(Name = "Pagina")]
        public string? Skip { get; set; }
        [Display(Name = "CantReg x Pagina")]
        public string? Take { get; set; }

        public byte SendRowCount { get; set; }
    }
}
