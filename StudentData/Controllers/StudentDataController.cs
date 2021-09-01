using Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StudentLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentData.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class StudentDataController : Controller
    {
        private ILogger<StudentDataController> _logger;
        IBusinessLogic _businessLogic;
        public StudentDataController(ILogger<StudentDataController> logger, IBusinessLogic businessLogic)
        {
            _logger =logger;
            _businessLogic = businessLogic;
        }
        [HttpGet]
        public IEnumerable<StudentEntity> Get(int rollNo)
        {
            var result = _businessLogic.GetFilteredStudentRecord(rollNo);
            return Enumerable.Range(1, 1).Select(Index => new StudentEntity
            {
                Name= result.Name,
                RollNo= result.RollNo
            });
        }

        [HttpGet]
        public IEnumerable<StudentEntity> GetRandom()
        {
            var result = _businessLogic.GetRandomStudentRecord();
            return Enumerable.Range(1, 1).Select(Index => new StudentEntity
            {
                Name= result.Name,
                RollNo= result.RollNo
            });
        }

        [HttpGet]
        public IEnumerable<StudentEntity> GetName(string letters)
        {
            var result = _businessLogic.GetStudentRecordByNmae(letters);
            return result.AsEnumerable();
            //return Enumerable.Range(1, 1).Select(Index => new StudentEntity
            //{
            //    Name= result.Name,
            //    RollNo= result.RollNo
            //});
        }

        [HttpPost]
        public bool AddRecord(StudentEntity letters)
        {
           return  _businessLogic.Addrecord(letters);
          //  return true;// result.AsEnumerable();
            //return Enumerable.Range(1, 1).Select(Index => new StudentEntity
            //{
            //    Name= result.Name,
            //    RollNo= result.RollNo
            //});
        }
    }
}
