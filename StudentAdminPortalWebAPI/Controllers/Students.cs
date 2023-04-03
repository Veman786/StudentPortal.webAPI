using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentAdminPortalWebAPI.DomainModels;
using StudentAdminPortalWebAPI.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAdminPortalWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Students : ControllerBase
    {
        private readonly IstudentRepository studentRepository;
        private readonly IMapper mapper;

        public Students(IstudentRepository studentRepository,IMapper mapper)
        {
            this.studentRepository = studentRepository;
            this.mapper = mapper;
        }
        [HttpGet]
        [Route("[controller]")]
        public async Task< IActionResult> GetALLStudents()
        {
            var students = await studentRepository.GetStudents();


            //var domainModelstudents = new List<Student>();

            //foreach (var student in students)
            //{
            //    domainModelstudents.Add(new Student()
            //    {
            //        Id = student.Id,
            //        FirstName = student.FirstName,
            //        LastName = student.LastName,
            //        DateOfBirth = student.DateOfBirth,
            //        Email = student.Email,
            //        Mobile = student.Mobile,
            //        ProfileImageUrl = student.ProfileImageUrl,
            //        GenderId = student.GenderId,
            //        Address=new Address()
            //        {
            //          Id=student.Address.Id,
            //          PhysicalAddress=student.Address.PhysicalAddress,
            //          PostalAddress=student.Address.PostalAddress
            //        },
            //        Gender=new Gender()
            //        {
            //            Id=student.Gender.Id,
            //            Description=student.Gender.Description
            //        }



            //    });

            //}
            return Ok(mapper.Map<List<Student>>(students));
        }
    }
}
