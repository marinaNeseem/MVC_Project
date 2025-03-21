using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BusinessLogic.DataTransferObject
{
    public class DepartmentDetialsDto
    {
        public int Id { get; set; }//pk
        public int CreatedBy { get; set; }//user Id
        public DateOnly CreatedOn { get; set; }
        public int LastModifaiedBy { get; set; }//userId
        public DateOnly LastModifaiedOn { get; set; }
        public bool IsDeleted { get; set; } // soft de
        public string Name { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty;
        public string? Description { get; set; }

    }
}
