using Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentLogic
{
    public interface IBusinessLogic
    {
        public StudentEntity GetFilteredStudentRecord(int rollNo);
        public StudentEntity GetRandomStudentRecord();
        public List<StudentEntity> GetStudentRecordByNmae(string letters);
        bool Addrecord(StudentEntity et);
    }
}
