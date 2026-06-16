using System;
using System.Collections.Generic;
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
    public enum fields_enum { Computer_Engineering, Electrical_Engineering, Mechanical_Engineering }
    

    public interface IUser
    {
        string Name { get; set; }
        string Id { get; set; }
        void SetPassword(string value);
        string GetPassword();

        bool CheckPassword(string password);
    }
    public class Student : IUser
    {
        public Student(string name, string id, int entranceYear, int field, string password)
        {
            this.SetEnteranceYear(entranceYear);
            this.SetField(field);

            this.ClassMarks = new Dictionary<Class, int>();
            this.MarkAve = -1;
            this.SemesterRegisteredClasses = new Dictionary<string, List<Class>>();
            this.SetRegisterEnable(true);

            this.Name = name;
            this.Id = id;
            this.SetPassword(password);


        }
        public string Name { get; set; }

        private string password;

        public string GetPassword()
        {
            return password;
        }

        public void SetPassword(string value)
        {
            password = value;
        }

        public string Id { get; set; }


        private Dictionary<string, List<Class>>SemesterRegisteredClasses { get; set; }

        private int enteranceYear;

        public int GetEnteranceYear()
        {
            return enteranceYear;
        }

        private void SetEnteranceYear(int value)
        {
            enteranceYear = value;
        }


        private int field;

        public int GetField()
        {
            return field;
        }

        public void SetField(int value)
        {
            field = value;
        }

        private bool registerEnable;

        public bool GetRegisterEnable()
        {
            return registerEnable;
        }

        public void SetRegisterEnable(bool value)
        {
            registerEnable = value;
        }

        private Dictionary<Class , int> ClassMarks { get; set; }

        private double MarkAve { get; set; }


        public bool CheckPassword(string password)
        {
            if (this.GetPassword() == password)
            {
                return true;
            }
            return false;
        }
        public string AddStudentToClass(Class _class , string classid , Semester semester)
        {
            if(this.GetField() == _class.ClassField )
            {
                
                if (this.SemesterRegisteredClasses.ContainsKey(semester.GetSemesterId()) && this.SemesterRegisteredClasses[semester.GetSemesterId()].Contains(_class))
                {
                    return "دانشجو قبلا اضافه شده است";
                }
                else
                {
                    if(SemesterRegisteredClasses.ContainsKey(semester.GetSemesterId()))
                    {
                        SemesterRegisteredClasses[semester.GetSemesterId()].Add(_class);
                    }
                    else
                    {
                        SemesterRegisteredClasses.Add(semester.GetSemesterId(), new List<Class>() { _class });
                    }
                    _class.AddStudentToThisClass(this, this.Id ,semester);
                    if(!ClassMarks.ContainsKey(_class))
                    {
                        ClassMarks.Add(_class, -1);
                    }
                    
                    return "دانشجو با موفقیت به کلاس اضافه شد";
                }
                

            }
            else
            {
                return "رشته دانشجو با کلاس همخوانی ندارد";
            }
            

        }

        public void RemoveStudentFromClass(Class _class , string classid , Semester semester)
        {
            if (this.SemesterRegisteredClasses[semester.GetSemesterId()].Contains(_class))
            {
                this.SemesterRegisteredClasses[semester.GetSemesterId()].Remove(_class);
                if(this.ClassMarks.ContainsKey(_class))
                {
                    this.ClassMarks.Remove(_class);
                }
                
            }
        }
        public List<Class> RetRegisteredClasses(Semester semester)
        {
           
            string semesterid = semester.GetSemesterId();
            List<Class> res = new List<Class>();
            if (this.SemesterRegisteredClasses.ContainsKey(semesterid))
            {
                foreach (var c in this.SemesterRegisteredClasses[semester.GetSemesterId()])
                {
                    res.Add(c);
                }
                
            }
            return res;
            
        }

        public void SetClassMark(Class _class , string classid, int mark)
        {
            this.ClassMarks[_class] = mark;
        }
        public string GetClassMark(Class _class, string classid)
        {
            return this.ClassMarks[_class].ToString();
        }

        public double CalculateAverageMark()
        {
            double average_mark = -1;

            if(this.ClassMarks.Count > 0)
            {
                average_mark =  this.ClassMarks.Values.Average();
            }
            

            this.MarkAve = average_mark;
            return average_mark;
        }

        public List<Semester> RetStudentSemesters()
        {
            
            List<Semester> studetnt_semester_list = new List<Semester>();
            for(int i= GetEnteranceYear(); i<= DateTime.Now.Year - 622; i++)
            {
                
                Semester semester1 = new Info().RetSemester(i.ToString() + "-" + 1);
                Semester semester2 = new Info().RetSemester(i.ToString() + "-" + 2);
                if(semester1 != null)
                {
                    studetnt_semester_list.Add(semester1);
                }
                if (semester2 != null)
                {
                    studetnt_semester_list.Add(semester2);
                }
                
            }
            return studetnt_semester_list;

        }

    }

    public class Teacher : IUser
    {
        
        public Teacher(string name, string id, int field, string password)
        {
            this.SetField(field);
            this.Classes = new Dictionary<string, Class>();
            this.SemesterClass = new Dictionary<string, List<Class>>();
            this.Name = name;
            this.Id = id;
            this.SetPassword(password);
            return;
        }
        public string Name { get; set; }
        public string Id { get; set; }

        private string password;

        public string GetPassword()
        {
            return password;
        }

        public void SetPassword(string value)
        {
            password = value;
        }

        private Dictionary<string , List<Class>> SemesterClass { get; set; }
        private Dictionary<string,Class> Classes { get; set;}

        private int field;

        public int GetField()
        {
            return field;
        }

        public void SetField(int value)
        {
            field = value;
        }

        public bool CheckPassword(string password)
        {
            if (this.GetPassword() == password)
            {
                return true;
            }
            return false;
        }
        public string AddClassToClasses(Class _class , string classid , Semester semester )
        {
            if(this.GetField() == _class.ClassField )
            {
                if(this.SemesterClass.ContainsKey(semester.GetSemesterId()))
                {
                    this.SemesterClass[semester.GetSemesterId()].Add(_class);
                }
                else
                {
                    this.SemesterClass.Add(semester.GetSemesterId(),new List<Class>() { _class});
                }
                return "استاد درس با موفقیت تغییر یافت";
            }
            else
            {
                return "رشته استاد با درس همخوانی ندارد";
            }
           
        }

        public List<Class> RetRegisteredClasses(Semester semester)
        {
            List<Class> res = new List<Class>();
            if(this.SemesterClass.ContainsKey(semester.GetSemesterId()))
            {
                
                foreach (var c in this.SemesterClass[semester.GetSemesterId()])
                {
                     res.Add(c);

                }
            }
            return res;
            
        }

        

        
    }

    public class Moderator : IUser
    {
        public Moderator(string name , string id , string password)
        {
            this.Id =id;
            this.Name = name;
            this.SetPassword(password);
            
        }

        
        public string Id { get; set; }
        public string Name { get; set; }

        private string password;

        public string GetPassword()
        {
            return password;
        }

        public void SetPassword(string value)
        {
            password = value;
        }

        public bool CheckPassword(string password)
        {
            if(this.GetPassword() == password)
            {
                return true;
            }
            return false;
        }


    }

    public class Class
    {
        public Class(string className, string classId, int classField, int credit)
        {
            ClassName = className;
            SetClassId(classId);
            ClassField = classField;
            classCredits = credit;

            ClassSemesters = new Dictionary<string, Semester>();
            SemesterStudents = new Dictionary<string, List<IUser>>();
            SemesterProfessor = new Dictionary<string, IUser>();
            StudentsMark = new Dictionary<IUser, int>();
        }

        public string ClassName { get; set; }

        private string classId;

        public string GetClassId()
        {
            return classId;
        }

        public void SetClassId(string value)
        {
            classId = value;
        }

        public int ClassField { get; set; }

        private int classCredits;

        public int GetClassCredits()
        {
            return classCredits;
        }

        public void SetClassCredits(int value)
        {
            classCredits = value;
        }

        private Dictionary<string , Semester> ClassSemesters { get; set; }
        private Dictionary<string ,List<IUser> > SemesterStudents { get; set; }

        private Dictionary<IUser , int> StudentsMark { get; set; }
        
        private Dictionary<string , IUser> SemesterProfessor { get; set; }

        public  List<IUser> RetSemesterStudent(Semester semester)
        {
            if (this.SemesterStudents.ContainsKey(semester.GetSemesterId()))
            {
                return this.SemesterStudents[semester.GetSemesterId()];

            }
            else
            {
                return new List<IUser>();
            }
            
            
        }
        public string AddThisClassToSemester(Semester semester)
        {
            if (ClassSemesters.Values.Contains(semester))
            {
                return "این کلاس قبلا به ترم اضافه شده است";
            }
            else
            {
                ClassSemesters.Add(semester.GetSemesterId() , semester);

                return "کلاس با موفقیت به ترم اضافه شد";
            }
        }
        public string AddChangeProfessorToThisClass(Teacher professor , string professorid , Semester semester)
        {
            
            if((professor).RetRegisteredClasses(semester).Count > 3 )
            {
                return "سقف کلاسهای مجاز استاد پر شده است";
            }
           
            else
            {
                string res = (professor).AddClassToClasses(this, this.classId, semester);
                if(res == "استاد درس با موفقیت تغییر یافت")
                {
                    this.SemesterProfessor[semester.GetSemesterId()] = professor;
                }
                
                return res;
                
            }
            
        }

        public Teacher RetClassSemesterProfessor(Semester semester)
        {
            if (this.SemesterProfessor.ContainsKey(semester.GetSemesterId()))
            {
                return this.SemesterProfessor[semester.GetSemesterId()] as Teacher;
            }
            return null;
        }
        public void AddStudentToThisClass(Student student , string studentid , Semester semester)
        {
            if(SemesterStudents.ContainsKey(semester.GetSemesterId()))
            {
                SemesterStudents[semester.GetSemesterId()].Add(student);

            }
            else
            {
                SemesterStudents.Add(semester.GetSemesterId(), new List<IUser>() { student });
            }
            if (!StudentsMark.ContainsKey(student))
            {
                this.StudentsMark.Add(student, -1);
            }
            
            
            
        }

        public string RetClassMembers(Semester semester)
        {
            string res = "";

            if (! this.SemesterProfessor.ContainsKey(semester.GetSemesterId()) || this.SemesterProfessor[semester.GetSemesterId()] == null)
            {
                res += "None";
            }
            else
            {
                res += this.SemesterProfessor[semester.GetSemesterId()].Name ;
            }
            if(this.SemesterStudents.ContainsKey(semester.GetSemesterId()))
            {
                foreach (var s in this.SemesterStudents[semester.GetSemesterId()])
                {
                    res +=  "," + s.Id;

                }
            }
            
            return res;
        }

        public string SetMark(IUser professor , IUser student , int mark , Semester semester)
        {
            if (this.SemesterProfessor[semester.GetSemesterId()] != professor)
            {
                return "رشته استاد با دانشجو همخوانی ندارد";
            }
            else if (!this.SemesterStudents[semester.GetSemesterId()].Contains(student))
            {
                return "دانشجو در این کلاس ثبت نام نشده است";
            }
            else
            {
                (student as Student).SetClassMark(this, GetClassId(), mark);
                if(this.StudentsMark.ContainsKey(student))
                {
                    this.StudentsMark[student] =  mark;
                }
                else
                {
                    this.StudentsMark.Add(student , mark);
                }
                
                return "نمره دانشجو با موفقیت تغییر یافت";
            }
        }

        public string  RetStudentMark(Student student , string studetid, Semester semester)
        {
            if (!this.SemesterStudents[semester.GetSemesterId()].Contains(student))
            {
                return "student did not registered";
            }
            else if (this.StudentsMark[student] == -1)
            {
                return "None";
            }
            else
            {
                return (this.StudentsMark[student]).ToString();
            }
        }
        public string RetMarkList(Semester semester)
        {
            string res = "";
            if (this.SemesterProfessor[semester.GetSemesterId()] == null)
            {
                res += ("no professor");
            }
            else if (this.SemesterStudents.Count == 0)
            {
                res += ("no student");
            }
            else
            {
                foreach (Student student in this.SemesterStudents[semester.GetSemesterId()])
                {
                    int student_mark = int.Parse(RetStudentMark(student, student.Id, semester));
                    if ( student_mark == -1)
                    {
                        res += ("None ");
                    }
                    else
                    {
                        res +=  student_mark.ToString();
                    }

                }
                
            }
            return res;
        }

        public IUser RetSemesterClassProfessor(Semester semester)
        {
            if (this.SemesterProfessor.ContainsKey(semester.GetSemesterId()))
            {
                return this.SemesterProfessor[semester.GetSemesterId()];
            }
            else
            {
                return null;
            }
            
        }

        public string RetSemsesterClassRegistration(Semester semester , string semesterid)
        {
            if(this.SemesterStudents.ContainsKey(semesterid))
            {
                return this.SemesterStudents[semesterid].Count().ToString();
            }
            return "0";
            
        }

        public string RemoveStudentOfClassInSemester(Semester semester , string semesterid ,Student student )
        {
            if(SemesterStudents.ContainsKey(semesterid))
            {
                if (SemesterStudents[semesterid].Contains(student))
                {
                    this.SemesterStudents[semesterid].Remove(student);
                    student.RemoveStudentFromClass(this, this.classId, semester);
                    return "حذف دانشجو از این کلاس با موفقیت انجام شد";
                }
                
            }
            return "دانشجو در این کلاس ثبت نام نشده است";
            
        }

        public void RemoveClassSemsester(Semester semester ,string semesterid)
        {
            if(SemesterProfessor.ContainsKey(semesterid))
            {
                SemesterProfessor.Remove(semesterid);

            }
            if(SemesterStudents.ContainsKey(semesterid))
            {
                SemesterStudents.Remove(semesterid);
            }
        }
    }


    public class Semester
    {
        public Semester(string id ,  DateTime firstday, DateTime lastday, DateTime reg_firstday, DateTime reg_lastday)
        {
            this.SetSemesterId(id);
            this.SetDates(firstday, lastday, reg_firstday, reg_lastday);
            this.ClassesInSemeter = new Dictionary<string, Class>();
        }

        private string semesterId;

        public string GetSemesterId()
        {
            return semesterId;
        }

        private void SetSemesterId(string value)
        {
            semesterId = value;
        }

        private void SetDates(DateTime firstday, DateTime lastday, DateTime reg_firstday, DateTime reg_lastday)
        {
            this.SetSemesterFirstDay(firstday);
            this.SetSemesterLastDay(lastday);

            this.SetRegisteratio_FirstDay(reg_firstday);
            this.SetRegistration_LastDay(reg_lastday);
        }

        private DateTime semesterFirstDay;

        public DateTime GetSemesterFirstDay()
        {
            return semesterFirstDay;
        }

        private void SetSemesterFirstDay(DateTime value)
        {
            semesterFirstDay = value;
        }

        private DateTime semesterLastDay;

        public DateTime GetSemesterLastDay()
        {
            return semesterLastDay;
        }

        private void SetSemesterLastDay(DateTime value)
        {
            semesterLastDay = value;
        }

        private DateTime registerationFirstDay;

        public DateTime GetRegisterationFirstDay()
        {
            return registerationFirstDay;
        }

        private void SetRegisteratio_FirstDay(DateTime value)
        {
            registerationFirstDay = value;
        }

        private DateTime registration_LastDay;

        public DateTime GetRegistration_LastDay()
        {
            return registration_LastDay;
        }

        private void SetRegistration_LastDay(DateTime value)
        {
            registration_LastDay = value;
        }

        private Dictionary<string, Class> ClassesInSemeter { get; set; }

        public string AddToClassesInSemester(Class _class)
        {
            if(ClassesInSemeter.ContainsKey(_class.GetClassId()))
            {
                return "این کلاس قبلا به این ترم اضافه شده است";
            }
            else
            {
                this.ClassesInSemeter.Add(_class.GetClassId(), _class);
                _class.AddThisClassToSemester(this);
                return "کلاس با موفقیت به ترم افزوده شد";
            }
        }
        public Dictionary<string , Class> RetClassesInSemester(int field_filter)
        {
            if(field_filter == -1)
            {
                return this.ClassesInSemeter;
            }
            else
            {
                Dictionary<string, Class> Filtered_ClassDict = new Dictionary<string, Class>();
                foreach(Class _class in this.ClassesInSemeter.Values)
                {
                    if(_class.ClassField == field_filter)
                    {
                        Filtered_ClassDict.Add(_class.GetClassId() , _class);
                    }
                }
                return Filtered_ClassDict;

            }

        }

        public string RemoveClassFromSemester(Class _class)
        {
            if(this.ClassesInSemeter.ContainsKey(_class.GetClassId()))
            {
                
                if( int.Parse(_class.RetSemsesterClassRegistration(this , this.semesterId)) < 10)
                {
                    this.ClassesInSemeter.Remove(_class.GetClassId());
                    _class.RemoveClassSemsester(this, this.semesterId);
                    return "حذف درس از این ترم با موفقیت انجام شد";
                    
                }
                return "تعداد ثبت نام بیشتر از 10 نفر است.";
                
            }
            return "این درس در ترم ثبت نشده است";

        }
       
        
    }

    
}

