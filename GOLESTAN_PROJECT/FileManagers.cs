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
using System.Globalization;

namespace Golestan_Graphic
{

    public partial interface ISaveLoader
    {
        void SaveUserDictToFile( Dictionary<string, IUser> peopledict);
        void SaveClassDictToFile( Dictionary<string , Class> class_dict);
        void SaveSemesterDictToFile( Dictionary<string , Semester> semester_dict);

        void SaveSemsesterClassInfoToFile(Dictionary<string, Semester> semester_dict);
        
    }
    public partial interface ISaveLoader
    {
        Dictionary<string , IUser> LoadUserDataToDict();
        Dictionary<string , Class> LoadClassDataToDict();
        Dictionary<string, Semester>  LoadSemesterDataToDict();
        void LoadSemsesterClassInfoToDict();
    }

    public partial class CSV_FileSaveLoader : ISaveLoader
    {
        public void SaveUserDictToFile( Dictionary<string, IUser> user_dict)
        {

            string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            this.SaveUserCSVToFile(Path.Combine(path, "Students.csv")   , "Students.csv"   , user_dict);
            this.SaveUserCSVToFile(Path.Combine(path, "Professors.csv") , "Professors.csv" , user_dict);
            this.SaveUserCSVToFile(Path.Combine(path, "Moderators.csv") , "Moderators.csv" , user_dict);

            
        }

        private void SaveUserCSVToFile(string path , string filename , Dictionary<string , IUser> people_dict)
        {
            File.WriteAllText(path, "");

            if (filename == "Students.csv")
            {
                foreach (IUser p in people_dict.Values)
                {
                    if (p is Student)
                    {
                        string line = p.Name + "," + p.Id + "," + (p as Student).GetEnteranceYear().ToString()
                            + "," + (p as Student).GetField().ToString()+ "," + p.GetPassword();
                        File.AppendAllText(path, line + '\n');

                    }


                }

            }
            else if (filename == "Professors.csv")
            {
                foreach (IUser p in people_dict.Values)
                {
                    if (p is Teacher)
                    {
                        string line = p.Name + "," + p.Id + "," + (p as Teacher).GetField() + "," + p.GetPassword();
                        File.AppendAllText(path, line + '\n');

                    }

                }
            }
            else if (filename == "Moderators.csv")
            {
                foreach (IUser p in people_dict.Values)
                {
                    if (p is Moderator)
                    {
                        string line = p.Name + "," + p.Id + "," + p.GetPassword();
                        File.AppendAllText(path, line + '\n');

                    }

                }
            }
        }

        public void SaveClassDictToFile( Dictionary<string, Class> class_dict)
        {
            string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            this.SaveClassCSVToFile(Path.Combine(path, "Classes.csv"), "Classes.csv", class_dict);

        }

        private void SaveClassCSVToFile(string path, string filename, Dictionary<string, Class> class_dict)
        {
            File.WriteAllText(path, "");
            foreach (Class c in class_dict.Values)
            {
                string line = c.ClassName + "," + c.GetClassId() + "," + c.ClassField+"," + c.GetClassCredits().ToString();

                File.AppendAllText(path, line + '\n');
            }
        }

        public void SaveSemesterDictToFile( Dictionary<string, Semester> semester_dict)
        {
            string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            this.SaveSemesterCSVToFile(Path.Combine(path, "Semesters.csv"), "Semesters.csv", semester_dict);

        }
        private void SaveSemesterCSVToFile(string path , string filename , Dictionary<string , Semester> semester_dict)
        {
            File.WriteAllText(path, "");
            foreach (Semester semester in semester_dict.Values)
            {
                string line = semester.GetSemesterId() + "," + semester.GetSemesterFirstDay().ToString("dd/MM/yyyy")
                    + "," + semester.GetSemesterLastDay().ToString("dd/MM/yyyy") + ","+ semester.GetSemesterFirstDay().ToString("dd/MM/yyyy")
                    + "," + semester.GetRegistration_LastDay().ToString("dd/MM/yyyy");

                File.AppendAllText(path, line + '\n');
            }
        }

        public void SaveSemsesterClassInfoToFile(Dictionary<string, Semester> semester_dict)
        {
            string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            this.SaveSemsesterClassInfoCSV_ToFile(Path.Combine(path, "SemestersInfo.csv"), "SemestersInfo.csv", semester_dict);
        }
        private void SaveSemsesterClassInfoCSV_ToFile(string path , string filename , Dictionary<string , Semester> semester_dict)
        {
            File.WriteAllText(path, "");

            string line ;
            
            foreach(Semester semester in semester_dict.Values)
            {
                
                foreach(Class _class in semester.RetClassesInSemester(-1).Values)
                {
                    line = semester.GetSemesterId();

                    line += "," + _class.GetClassId();
                    
                    IUser class_professor = _class.RetSemesterClassProfessor(semester);
                    if ( class_professor != null)
                    {
                        line += "," + class_professor.Id;
                    }
                    else
                    {
                        line += "," + "None";
                    }
                   

                    foreach(Student student in _class.RetSemesterStudent(semester))
                    {
                        line += "," + student.Id+ "," + student.GetClassMark(_class , _class.GetClassId());
                        //MessageBox.Show(student.Id);
                        
                    }
                    File.AppendAllText(path, line + '\n');
                }
                 

                
            }
        }


    }

    public partial class CSV_FileSaveLoader : ISaveLoader
    {
        public Dictionary<string, IUser> LoadUserDataToDict()
        {
            string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            Dictionary<string, IUser> UserDict = new Dictionary<string, IUser>();

            string[] s_lines = File.ReadAllLines(Path.Combine(path, "Students.csv"));
            foreach (var l in s_lines)
            {
                string[] temp = l.Split(',');
                string name = temp[0].Trim();
                string id = temp[1].Trim();
                int year = int.Parse(temp[2].Trim());
                int field = int.Parse(temp[3].Trim());
                string password = temp[4].Trim();
                UserDict.Add(id , new Student(name, id, year, field, password));

            }

            string[] p_lines = File.ReadAllLines(Path.Combine(path, "Professors.csv"));
            foreach (var l in p_lines)
            {
                string[] temp = l.Split(',');
                string name = temp[0].Trim();
                string id = temp[1].Trim();
                int field = int.Parse(temp[2].Trim());
                string password = temp[3].Trim();

                UserDict.Add(id , new Teacher(name, id, field, password));

            }

            string[] m_lines = File.ReadAllLines(Path.Combine(path, "Moderators.csv"));
            foreach (var l in m_lines)
            {
                string[] temp = l.Split(',');
                string name = temp[0].Trim();
                string id = temp[1].Trim();
                string password = temp[2].Trim();

                UserDict.Add(id , new Moderator(name, id, password));

            }

            return UserDict;
        }
        public Dictionary<string, Class> LoadClassDataToDict()
        {
            Dictionary<string, Class> ClassDict = new Dictionary<string, Class>();
            string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string[] c_lines = File.ReadAllLines(Path.Combine(path, "Classes.csv"));
            foreach (var l in c_lines)
            {
                string[] temp = l.Split(',');
                string name = temp[0].Trim();
                string id = temp[1].Trim();
                int field = int.Parse(temp[2].Trim());
                int credit = int.Parse(temp[3].Trim());

                ClassDict.Add(id, new Class(name, id, field, credit));

            }
            return ClassDict;
        }
        public Dictionary<string, Semester> LoadSemesterDataToDict()
        {
            Dictionary<string, Semester> SemesterDict = new Dictionary<string, Semester>();
            string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            string[] S_lines = File.ReadAllLines(Path.Combine(path, "Semesters.csv"));
            foreach (var l in S_lines)
            {
                string[] temp = l.Split(',');
                string id = temp[0].Trim();
                DateTime firstday     = DateTime.ParseExact(temp[1].Trim(), "dd/MM/yyyy", CultureInfo.CurrentCulture);
                DateTime lastday      = DateTime.ParseExact(temp[2].Trim(), "dd/MM/yyyy", CultureInfo.CurrentCulture);
                DateTime reg_firstday = DateTime.ParseExact(temp[3].Trim(), "dd/MM/yyyy", CultureInfo.CurrentCulture);
                DateTime reg_lastday  = DateTime.ParseExact(temp[4].Trim(), "dd/MM/yyyy", CultureInfo.CurrentCulture);


                SemesterDict.Add(id, new Semester(id, firstday, lastday, reg_firstday, reg_lastday));
            }

            return SemesterDict;
        }

        public void LoadSemsesterClassInfoToDict()
        {
            
            string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            string[] Info_lines = File.ReadAllLines(Path.Combine(path, "SemestersInfo.csv"));
            foreach (var l in Info_lines)
            {
                string[] temp = l.Split(',');
                Semester  semester = new Info().RetSemester( temp[0].Trim());
                if(temp.Length > 1)
                {
                    Class _class = new Info().RetClass(temp[1].Trim());
                    semester.AddToClassesInSemester(_class);

                    if(temp.Length > 2)
                    {
                        if (temp[2].Trim() != "None")
                        {
                            Teacher professor = new Info().RetPerson(temp[2].Trim()) as Teacher;
                            _class.AddChangeProfessorToThisClass(professor, professor.Id, semester);
                        }
                        if(temp.Length > 3)
                        {
                            
                            for (int i = 3; i < temp.Length; i+=2)
                            {
                                Student student = new Info().RetPerson(temp[i].Trim()) as Student;
                                string mark = temp[i+1].Trim();

                                

                                string command = "add_student" + " " + student.Id
                                    + " " + _class.GetClassId() + " " + semester.GetSemesterId();

                                string res = Commandcenter.Action(command);

                                student.SetClassMark(_class, _class.GetClassId(), int.Parse(mark));

                            }

                        }
                        
                    }
                    
                }
            }
        }
    }

}



