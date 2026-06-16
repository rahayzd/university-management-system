using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Golestan_Graphic
{
    

    public  class Commandcenter
    {

        public static string Action(string _command)
        {
            var splited_command = _command.Split(' ');
            //-----------------------------------------------------phaze 1 
            if (splited_command[0] == "register_student")
            {
                
                if (!new Info().PIdExictence(splited_command[2]))
                {

                    new Info().AddToStudent(splited_command[1], splited_command[2], int.Parse(splited_command[3]), int.Parse(splited_command[4]), splited_command[5]);

                    return ("به گلستان خوش آمدید");
                }
                else
                {
                    return ("این کدملی قبلا در سامانه ثبت شده است");
                }
            }

            else if (splited_command[0] == "register_professor")
            {
                if (!new Info().PIdExictence(splited_command[2]))
                {
                    new Info().AddToProfessor(splited_command[1], splited_command[2], int.Parse(splited_command[3]) , splited_command[4]);
                    return ("به گلستان خوش آمدید");
                }

                else
                {
                    return ("این کدملی قبلا در سامانه ثبت شده است");
                }

            }

            else if (splited_command[0] == "register_moderator")
            {
                if (!new Info().PIdExictence(splited_command[2]))
                {
                    Info.AddToModerator(splited_command[1], splited_command[2], splited_command[3]);
                    return ("به گلستان خوش آمدید");
                }
                else
                {
                    return ("این کدملی قبلا در سامانه ثبت شده است");
                }
            }
            else if (splited_command[0] == "make_semester")
            {
                if(!new Info().SIdExictance(splited_command[1]))
                {
                    string semesterId = splited_command[1];
                    DateTime semesterFirstday = DateTime.ParseExact(splited_command[2] , "dd/MM/yyyy", CultureInfo.CurrentCulture);;
                    DateTime semesterLastday = DateTime.ParseExact(splited_command[3], "dd/MM/yyyy", CultureInfo.CurrentCulture); ;
                    DateTime semesterRegFirstday = DateTime.ParseExact(splited_command[4], "dd/MM/yyyy", CultureInfo.CurrentCulture);
                    DateTime semesterRegLastday = DateTime.ParseExact(splited_command[5], "dd/MM/yyyy", CultureInfo.CurrentCulture); ;
                    new Info().AddToSemester(semesterId , semesterFirstday , semesterLastday, semesterRegFirstday , semesterRegLastday);
                    return ("ترم با موفقیت اضافه شد");
                }
                else
                {
                    return ("این ترم قبلا در سامانه اضافه شده است");
                }
            }

            else if (splited_command[0] == "make_class")
            {
                if (!new Info().CIdExictence(splited_command[2]))
                {
                    
                    new Info().AddClass(splited_command[1], splited_command[2], int.Parse(splited_command[3]), int.Parse(splited_command[4]));
                    return ("کلاس با موفقیت اضافه شد");
                }
                else
                {
                    return ("این کلاس قبلا ثبت شده است");
                }

            }
           
            //----------------------------------------------------------------------------------------// phaze 2

            else if (splited_command[0] == "add_class_tosemester")
            {
                string classid = splited_command[1];
                string semesterid = splited_command[2];
                if(new Info().RetClass(classid) == null)
                {
                    return ("کد کلاس معتبر نمی باشد");
                }
                else if(new Info().RetSemester(semesterid) == null)
                {
                    return ("کد ترم معتبر نمی باشد");
                }
                else
                {
                    return (new Info().RetSemester(semesterid).AddToClassesInSemester(new Info().RetClass(classid)));
                }
            }
            else if (splited_command[0] == "remove_class_from_semester")
            {
                string classid = splited_command[1];
                string semesterid = splited_command[2];
                if (new Info().RetClass(classid) == null)
                {
                    return ("کد کلاس معتبر نمی باشد");
                }
                else if (new Info().RetSemester(semesterid) == null)
                {
                    return ("کد ترم معتبر نمی باشد");
                }
                else
                {
                    return (new Info().RetSemester(semesterid).RemoveClassFromSemester(new Info().RetClass(classid)));
                }
            }
            else if (splited_command[0] == "add_student")
            {
                var student_id = splited_command[1];
                var class_id = splited_command[2];
                var semester_id = splited_command[3];

                if (!new Info().PIdExictence(student_id) || new Info().PersonType(student_id) != "Student")
                {

                    return ("کد ملی معتبر نمی باشد");

                }
                else if (!new Info().CIdExictence(class_id))
                {
                    
                    return ("کد کلاس معتبر نمی باشد");
                }
                else
                {
                    Class given_class = new Info().RetClass(class_id);
                    Student given_student = new Info().RetPerson(student_id) as Student;
                    Semester given_semester = new Info().RetSemester(semester_id);
                    string res = given_student.AddStudentToClass(given_class, given_class.GetClassId(), given_semester);

                    return res;
                   
                }
            }
            else if (splited_command[0] == "remove_student_from_class")
            {
                var student_id = splited_command[1];
                var class_id = splited_command[2];
                var semester_id = splited_command[3];

                if (!new Info().PIdExictence(student_id) || new Info().PersonType(student_id) != "Student")
                {

                    return ("کد ملی معتبر نمی باشد");

                }
                else if (!new Info().CIdExictence(class_id))
                {
                    return ("کد کلاس معتبر نمی باشد");
                }
                else
                {
                    Class given_class = new Info().RetClass(class_id);
                    Student given_student = new Info().RetPerson(student_id) as Student;
                    Semester given_semester = new Info().RetSemester(semester_id);
                    string res = given_class.RemoveStudentOfClassInSemester(given_semester, given_semester.GetSemesterId(), given_student);

                    return res;

                }
            }

            else if (splited_command[0] == "add_change_class_professor")
            {
                var professor_id = splited_command[1];
                var class_id = splited_command[2];
                var semester_id = splited_command[3];

                if (!new Info().PIdExictence(professor_id) || new Info().PersonType(professor_id) != "Professor")
                {
                    return ("کدملی نامعتبر می باشد");
                }
                else if (!new Info().CIdExictence(class_id))
                {
                    return ("کد کلاس نامعتبر می باشد");
                }

                else
                {
                    Class given_class = new Info().RetClass(class_id);
                    Teacher given_professor = new Info().RetPerson(professor_id) as Teacher;
                    Semester given_semester = new Info().RetSemester(semester_id);
                    return given_class.AddChangeProfessorToThisClass(given_professor, professor_id, given_semester);
                    
                }
            }

            else if (splited_command[0] == "student_status")
            {
                var given_student = new Info().RetPerson(splited_command[1]);
                if (given_student == null)
                {
                    return ("invalid student");
                }
                
                return "successful status";
            }

            else if (splited_command[0] == "professor_status")
            {
                Teacher given_professor = new Info().RetPerson(splited_command[1]) as Teacher;

                if (given_professor == null)
                {
                    return ("invalid professor");
                }
               
                return "successful status";
            }

            else if (splited_command[0] == "class_status")
            {
                string res = "";
                string class_id = splited_command[1];
                string semester_id = splited_command[2];

                Class given_class = new Info().RetClass(class_id);
                Semester given_semester = new Info().RetSemester(semester_id);

                if (given_class == null)
                {
                    return "invalid class";
                }
                res = given_class.RetClassMembers(given_semester);
                return res;
            }
        
            //---------------------------------------------------- phaze 3

            else if (splited_command[0] == "set_final_mark")
            {
                IUser given_professor = new Info().RetPerson(splited_command[1]);
                IUser given_student = new Info().RetPerson(splited_command[2]);
                Class given_class = new Info().RetClass(splited_command[3]);
                Semester given_semester = new Info().RetSemester(splited_command[4]);

                int grade = int.Parse(splited_command[5]);
                string res = "";
                if (given_professor == null)
                {
                    res = ("invalid professor");
                }
                else if (given_student == null)
                {
                    res = ("invalid student");
                }
                else if (given_class == null)
                {
                    res = ("invalid class");
                }
                
                res = given_class.SetMark(given_professor, given_student, grade, given_semester);
                return res;
            }

            else if (splited_command[0] == "mark_student")
            {
                Student given_student = new Info().RetPerson(splited_command[1]) as Student;
                Class given_class = new Info().RetClass(splited_command[2]);
                Semester semester = new Info().RetSemester(splited_command[3]);

                string res;
                if (given_student == null)
                {
                    return ("invalid student");
                }
                else if (given_class == null)
                {
                    return ("invalid class");
                }

                res = given_class.RetStudentMark(given_student, given_student.Id, semester);
                return res;

            }
            else if (splited_command[0] == "mark_list")
            {
                Class given_class = new Info().RetClass(splited_command[1]);
                Semester given_semester = new Info().RetSemester(splited_command[2]);

                if (given_class == null)
                {
                    return ("invalid class");
                }
                else
                {
                    return given_class.RetMarkList(given_semester);
                }
            }

            
            else if (splited_command[0] == "average_mark_student")
            {
                Student given_student = new Info().RetPerson(splited_command[1]) as Student;
                
                if (given_student == null)
                {
                    return  ("invalid student");
                }
                else
                {
                    double average_mark;
                    average_mark = given_student.CalculateAverageMark();

                    if ( average_mark != -1)
                    {
                        return average_mark.ToString();
                    }

                    else
                    {
                        return ("None");
                    }

                }
            }

            

            return null;
        }
    }



}

