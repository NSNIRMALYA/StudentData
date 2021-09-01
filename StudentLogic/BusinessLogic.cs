using DataAccess;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentLogic
{
    public class BusinessLogicL: IBusinessLogic
    {
        List<StudentEntity> entityList = new List<StudentEntity>();
        //{
        //    new StudentEntity{Name="Nirmalya", RollNo=1},
        //    new StudentEntity{Name="Digbijay", RollNo=2},
        //    new StudentEntity{Name="Dibakar", RollNo=3},
        //    new StudentEntity{Name="Prodosh", RollNo=4},
        //    new StudentEntity{Name="Amulya", RollNo=5},
        //    new StudentEntity{Name="Priyabrata", RollNo=6},
        //    new StudentEntity{Name="Soumya", RollNo=7}
        //};
        StudentDbContext _dbCtxt;
        public BusinessLogicL()
        {
           // _dbCtxt = cdb;
        }

        public BusinessLogicL(StudentDbContext cdb)
        {
            _dbCtxt = cdb;
        }

        public int AddTwoNumber(int a, int b)
        {
            return a + b;
        }
        public int MultiplyTwoNumber(int x, int y)
        {
            return x * y;
        }
        public StudentEntity GetFilteredStudentRecord(int rollNo)
        {
            for (int i = 0; i < entityList.Count; i++)
            {
                if (entityList[i].RollNo == rollNo)
                {
                    return entityList[i];
                }
            }
            return null;
        }

        public bool Addrecord(StudentEntity et)
        {
            _dbCtxt.StudentEntity.Add(et);
            _dbCtxt.SaveChanges();
            return true;
        }
        public StudentEntity GetRandomStudentRecord()
        {
            entityList = _dbCtxt.StudentEntity.ToList();
            int num = new Random().Next(0, entityList.Count-1);
            return entityList[num];
        }
        public List<StudentEntity> GetStudentRecordByNmae(string letters)
        {
            List<StudentEntity> StudentList = new List<StudentEntity>();
            for (int j = 0; j < entityList.Count; j++)
            {
                if(entityList[j].Name.ToUpper().Contains(letters.ToUpper())==true)
                {
                    StudentList.Add(entityList[j]);
                }
            }
            
                return StudentList;
            
        }
    }

}
