using CompProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompProject.Repositories
{
   public  interface IStudentRepository
    {
        List<Student> GetAllStudents();
        Student GetStudentById(int id);
        int AddStudent(Student stud);
        int UpdateStudent(Student stud);
        int DeleteStudent(int id);
    }
}
