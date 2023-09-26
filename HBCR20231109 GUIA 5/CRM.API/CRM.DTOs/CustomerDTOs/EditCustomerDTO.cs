using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRM.DTOs.CustomerDTOs;

namespace CRM.DTOs.CustomerDTOs
{
    public EditCustomerDTO(GetIdResultCutomerDTO getIdResultCutomerDTO)
    {
        Id = GetIdResultCutomerDTO.Id;
    }
}
