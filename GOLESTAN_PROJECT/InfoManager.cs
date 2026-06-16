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
    
    public class Info
    {
        public Info()
        {
            
        }

        private static Dictionary<string, IUser> people_dict = new Dictionary<string, IUser>(); 

        private static Dictionary<string, Class> class_dict = new Dictionary<string, Class>();

        private static Dictionary<string, Semester> semester_dict = new Dictionary<string, Semester>(); //{{ "1400-1", new Semester("1400-1")}};

        public void SaveData(ISaveLoader saveLoader)
        {
            saveLoader.SaveUserDictToFile(people_dict);
            saveLoader.SaveClassDictToFile(class_dict);
            saveLoader.SaveSemesterDictToFile(semester_dict);
            saveLoader.SaveSemsesterClassInfoToFile(semester_dict);
        }
        public void LoadData(ISaveLoader saveLoader)
        {
            people_dict = saveLoader.LoadUserDataToDict();
            class_dict = saveLoader.LoadClassDataToDict();
            semester_dict = saveLoader.LoadSemesterDataToDict();
            saveLoader.LoadSemsesterClassInfoToDict();
        }
       


        public  IUser RetPerson(string id)
        {
            if (people_dict.ContainsKey(id))
            {
                return people_dict[id];
            }
            return null;
        }

        public  Class RetClass(string id)
        {
            if (class_dict.ContainsKey(id))
            {
                return class_dict[id];
            }
            return null;
        }

        public  Semester RetSemester (string id)
        {
            if(semester_dict.ContainsKey(id))
            {
                return semester_dict[id];
            }
            return null;
        }

        public  Dictionary<string, IUser> RetAllMembers()
        {
            return people_dict;
        }

        public  Dictionary<string , Semester> RetAllSemesters()
        {
             return semester_dict;
            
        }

        public  List<string> RetAllClasses()
        {
            List<string> res = new List<string>();
            foreach(Class _class in class_dict.Values)
            {
                string classdata = _class.ClassName + "," + _class.GetClassId() + "," + _class.ClassField.ToString() +","+ _class.GetClassCredits().ToString();
                res.Add(classdata);
                
            }
            return res;
            
        }
        public  bool PIdExictence(string id)
        {
            
            if (people_dict.ContainsKey(id))
            {
                return true;
            }

            return false;
        }

        public  bool CIdExictence(string id)
        {
            if (class_dict.ContainsKey(id))
            {
                return true;
            }
            return false;
        }

        public  bool SIdExictance(string id)
        {
            if(semester_dict.ContainsKey(id))
            {
                return true;
            }
            return false;
        }

        public  string PersonType(string id)
        {
            if (people_dict[id] is Student)
            {
                return "Student";
            }
            else if (people_dict[id] is Teacher)
            {
                return "Professor";
            }
            else if (people_dict[id] is Moderator)
            {
                return "Moderator";
            }
            return null;
        }

        public  IUser UserLogin(string password, string id)
        {
            if (people_dict.ContainsKey(id))
            {
                IUser user = people_dict[id];
                if (user.CheckPassword(password))
                {
                    return user;
                }
                else
                {
                    return null;
                }
            }
            return null;

        }

        public  void AddToStudent(string name, string id, int entrance_year, int field, string password)
        {
            people_dict.Add(id, new Student(name, id, entrance_year, field, password));
        }
        public  void AddToProfessor(string name, string id, int field, string password)
        {

            people_dict.Add(id, new Teacher(name, id, field, password));
        }
        public static void AddToModerator(string name, string id, string password)
        {
            people_dict.Add(id, new Moderator(name, id, password));
        }

        public  void AddToSemester(string id, DateTime firstday, DateTime lastday, DateTime reg_firstday, DateTime reg_lastday)
        {
            semester_dict.Add(id , new Semester (id ,  firstday,  lastday,  reg_firstday,  reg_lastday));
        }

        public  void AddClass(string name, string class_id, int field,int credit)
        {
            class_dict.Add(class_id, new Class(name, class_id, field, credit));
        }


      

        public static void RemoveUser(IUser user)
        {
            if(people_dict.ContainsKey(user.Id))
            {
                people_dict.Remove(user.Id);
            }
            
        }

        public static void RemoveSemester(Semester semester)
        {
            semester_dict.Remove(semester.GetSemesterId());
        }

        public static void RemoveClass(Class _class)
        {
            if(class_dict.ContainsKey(_class.GetClassId()))
            {
                class_dict.Remove(_class.GetClassId());
            }
            
        }


    }

    



}

