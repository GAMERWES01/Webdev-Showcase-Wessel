﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Rest_Api.Controllers
{
    //[ApiController]
    [Route("[controller]")]
    public class StudentsController : ControllerBase
    {

        private static List<string> _students = new List<string>{
            "Koen",
            "Thijs",
            "Rosalie"
        };

        [HttpGet(Name = "GetStudents")]
        public List<string> Get()
        {
            return _students;
        }
        [HttpPost(Name = "GetStudents")]
        public void Post(string name)
        {
            if (!_students.Contains(name))
            {
                _students.Add(name);
            } 
            
        }
    }
}
