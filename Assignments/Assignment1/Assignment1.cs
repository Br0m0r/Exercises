using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise_1;

public class StudentProfessorTest
{
    public static void Main()
    {
        helper.Person NewPerson = new helper.Person();
        NewPerson.Greet();

        helper.Student newStudent = new helper.Student();
        newStudent.SetAge(18);
        newStudent.Greet();
        newStudent.ShowAge();
        newStudent.study();

        helper.Teacher newTeacher = new helper.Teacher();
        newTeacher.SetAge(37);
        newTeacher.Greet();
        newTeacher.explain();
    }




}