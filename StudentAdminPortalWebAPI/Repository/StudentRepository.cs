using StudentAdminPortalWebAPI.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace StudentAdminPortalWebAPI.Repository
{
    public class StudentRepository : IstudentRepository
    {    
        private readonly StudentDbContext context;

        public   StudentRepository(StudentDbContext context)
        {
            this.context = context;
        }
        public async Task< List<Student>> GetStudents()
        {
            return await context.Student.Include(nameof(Gender)).Include(nameof(Address)).ToListAsync();
        }
    }
}
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       