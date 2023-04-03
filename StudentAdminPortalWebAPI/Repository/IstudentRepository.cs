using StudentAdminPortalWebAPI.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAdminPortalWebAPI.Repository
{
 public   interface IstudentRepository
    {
       Task< List<Student>> GetStudents();
    }
}
