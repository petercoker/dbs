using System;
using System.Collections;
using System.Collections.Generic;

namespace dbs.ObjectOrientatedProgramming.PeterCokerCA1725266
{
    class Students : ICollection<Student>
    {
        public List<Student> studentList = new List<Student>();

        public int Count
        {
            get { return studentList.Count; }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public void Add(Student item)
        {
            studentList.Add(item);
        }

        public void Clear()
        {
            studentList.Clear();
            Console.WriteLine($"\nStudent List Cleared, there are {studentList.Count} total number of Students in the DBS Student Management System");
        }

        public bool Contains(Student item)
        {
            return studentList.Contains(item);
        }

        public void CopyTo(Student[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<Student> GetEnumerator()
        {
            return studentList.GetEnumerator();
        }

        public bool Remove(Student item)
        {
            return studentList.Remove(item);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void SortList()
        {
            if (!(studentList.Count == 0))
            {
                Console.WriteLine("\nList of Students sorted by Student ID");
                studentList.Sort();

                foreach (Student pupil in studentList)
                {
                    Console.Write($"\nStudent ID: {pupil.StudentId}\nStudent is a current Student: {pupil.IsCurrentStudent}\nStudent Name: {pupil.Name}\nStatus: {pupil.Status}\nPhone: {pupil.Phone}\nEmail: {pupil.Email}\n");
                }
            }

            else
            {
                Console.WriteLine("\n\aNo Student present in Student managemnt system, please enter add new Student into the Student management system");
            }
        }

        public Student GetStudent(int id)
        {
            Student student = null;

            foreach (Student pupil in studentList)
            {
                if (pupil.StudentId.Equals(id))
                {
                    student = pupil;
                    break;
                }
            }

            return student;
        }

        public void DisplayStudentMenu()
        {
            Console.WriteLine("\n[DBS Student Management System Menu]");
            Console.WriteLine("\nStudent Management: Data definition options");
            Console.WriteLine("1: Add a new Student");

            Console.WriteLine("\nStudent Management: Viewing options");
            Console.WriteLine("2: Show list of all Students in Dublin Business School");
            Console.WriteLine("3: Show list of all postgrad Students");
            Console.WriteLine("4: Show list of all undergrad Students");
            Console.WriteLine("5: Show list of all current Students");
            Console.WriteLine("6: Show list of all postgrad Students currently in Dublin Business School");
            Console.WriteLine("7: Show list of all undergrad Students currently in Dublin Business School");
            Console.WriteLine("8: Show list of all not current Students");
            Console.WriteLine("9: Show list of all postgrad Students not currently in Dublin Business School");
            Console.WriteLine("10: Show list of all undergrad Students not currently in Dublin Business School");
            Console.WriteLine("11: Show list of Students sorted by ID");
            Console.WriteLine("12: Show total number of Students in Dublin Business School");

            Console.WriteLine("\nStudent Management: Data manipulation options");
            Console.WriteLine("13: Find a Student by entering Student ID");
            Console.WriteLine("14: Delete a Student by entering Student ID");
            Console.WriteLine("15: Clear all Students in the Student management system");
            Console.WriteLine("16: Clear all Students in the Student management system & Go to Teacher Management System");
            Console.WriteLine("17: Quit application");
        }

        public void AddStudent()
        {
            Student student = new Student();
            int studentStatus, studentPhone;
            bool userInputID = false, userInputStudentAttendance = false, userInputName = false, userInputStatus = false, userInputPhone = false, userInputEmail = false, found = false; //Fix value not found
            string inputStudentID, inputStudentStatus, inputStudentEmail, inputStudentName, inputStudentAttendance, inputStudentPhone;

            while (!userInputID)
            {
                Console.Write("\nPlease enter your Student ID number (integer) with no spaces or enter \"q\" to go back to Student Menu: ");
                inputStudentID = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(inputStudentID))
                {
                    Console.WriteLine("\n\aInvalid Input, please enter a number");
                    continue;
                }

                else if (inputStudentID == "q")
                {
                    Console.Clear();
                    GetStudentManagementSystem();
                    userInputID = true;
                }

                else if (int.TryParse(inputStudentID, out int id))
                {
                    if (id <= 0)
                    {
                        Console.WriteLine("\n\aPlease enter a postive number or that's is not 0");
                        continue;
                    }

                    else if (id >= 0)
                    {
                        Student checkNumber = GetStudent(id);

                        found = false;

                        if (checkNumber != null)
                        {
                            found = true;
                            Console.WriteLine("\n\aStudent already exists");
                            continue;
                        }

                        else
                        {
                            student.StudentId = id;
                            userInputID = true;
                        }
                    }
                }

                else
                {
                    Console.WriteLine("\n\aInvalid Input");
                    continue;
                }

            }

            while (!userInputStudentAttendance)
            {
                Console.Write("Please enter \"t\" for True or \"f\" for False if you are a current Student: ");
                inputStudentAttendance = Console.ReadLine().ToLower();

                if (String.IsNullOrWhiteSpace(inputStudentAttendance))
                {
                    Console.WriteLine("\n\aInvalid Input, please enter a string input");
                    continue;
                }

                else if (inputStudentAttendance == "t")
                {
                    student.IsCurrentStudent = true;
                    userInputStudentAttendance = true;
                }

                else if (inputStudentAttendance == "f")
                {
                    student.IsCurrentStudent = false;
                    userInputStudentAttendance = true;
                }

                else
                {
                    Console.WriteLine("\n\aInvalid Input, only enter \"t\" or \"f\" if you are a current Student");
                    continue;
                }
            }

            while (!userInputName)
            {
                Console.Write("Please enter your name: ");
                inputStudentName = Console.ReadLine();

                if (!(String.IsNullOrWhiteSpace(inputStudentName)))
                {
                    if (!(int.TryParse(inputStudentName, out int number)))
                    {
                        student.Name = inputStudentName;
                        userInputName = true;
                    }

                    else
                    {
                        Console.WriteLine("\n\ainvalid Input");
                        continue;
                    }
                }

                else
                {
                    Console.WriteLine("\n\aInvalid input");
                    continue;
                }

            }

            while (!userInputStatus)
            {
                Console.Write("Please enter \"1\" for Undergrad or \"2\" for Postgrad: ");
                inputStudentStatus = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(inputStudentStatus))
                {
                    Console.WriteLine("\n\aInvalid Input, please enter a number");
                    continue;
                }

                else if (int.TryParse(inputStudentStatus, out studentStatus))
                {
                    if (studentStatus == 1)
                    {
                        student.Status = StudentStatusEnum.Undergrad;
                        userInputStatus = true;
                    }

                    else if (studentStatus == 2)
                    {
                        student.Status = StudentStatusEnum.Postgrad;
                        userInputStatus = true;
                    }

                    else
                    {
                        Console.WriteLine("\n\aPlease only enter a number between \"1\" and \"2\"");
                        continue;
                    }
                }

                else
                {
                    Console.WriteLine("\n\aInvalid Input");
                    continue;
                }
            }

            while (!userInputPhone)
            {
                Console.Write("Please enter your 10 digit phone number (integer) with no spaces in between the number: ");
                inputStudentPhone = Console.ReadLine();

                if (inputStudentPhone.Length < 10 || inputStudentPhone.Length > 10)
                {
                    Console.WriteLine("\n\aInvalid input, please enter a 10 positive digit phone number");
                    continue;
                }

                else if (int.TryParse(inputStudentPhone, out studentPhone))
                {
                    if (studentPhone < 0)
                    {
                        continue;
                    }

                    else
                    {
                        student.Phone = studentPhone;
                        userInputPhone = true;
                    }
                }

                else
                {
                    Console.WriteLine("\n\aInvalid Input");
                    continue;
                }

            }

            while (!userInputEmail)
            {
                Console.Write("Please enter a valid email address that contains \"@\" and \".com\": ");
                inputStudentEmail = Console.ReadLine().ToLower();

                if (!(String.IsNullOrWhiteSpace(inputStudentEmail)))
                {
                    if (inputStudentEmail.Contains(".com") && inputStudentEmail.Contains("@"))
                    {
                        student.Email = inputStudentEmail;
                        userInputEmail = true;
                    }

                    else
                    {
                        Console.WriteLine("\n\aInvalid Input, please enter a valid email address");
                        continue;
                    }

                }

                else
                {
                    Console.WriteLine("\n\aInvalid Input, please enter a string email");
                    continue;
                }
            }

            studentList.Add(student);
            Console.WriteLine("\nStudent has been added");
        }

        public void ShowAllStudents()
        {
            if (!(studentList.Count == 0))
            {
                Console.WriteLine("\nAll Students in Dublin Business School");

                foreach (Student pupil in studentList)
                {
                    Console.WriteLine(pupil.ToString());
                }
            }

            else
            {
                Console.WriteLine("\n\aNo Student present in Student managemnt system, please enter add new Student into the Student management system");
            }
        }

        public void ShowAllPostgradStudents()
        {
            if (!(studentList.Count == 0))
            {
                Console.WriteLine("\nList of Students that are Postgrad Students of Dublin Business School");

                List<Student> postgradStudentList = new List<Student>();

                foreach (Student item in studentList)
                {
                    if (item.Status == StudentStatusEnum.Postgrad)
                    {
                        postgradStudentList.Add(item);
                    }
                }

                if (!(postgradStudentList.Count == 0))
                {
                    foreach (var item in postgradStudentList)
                    {
                        Console.WriteLine(item.ToString());
                    }
                }

                else
                {
                    Console.WriteLine("\n\aNo postgrad Students present in Student managemnt system, please enter add Student into the Student management system");
                }

            }

            else
            {
                Console.WriteLine("\n\aNo Student present in Student managemnt system, please enter add Student into the Student management system");
            }
        }

        public void ShowAllUndergradStudents()
        {
            if (!(studentList.Count == 0))
            {
                Console.WriteLine("\nList of Students that are Undergrad Students of Dublin Business School");

                List<Student> undergradStudentList = new List<Student>();

                foreach (Student item in studentList)
                {
                    if (item.Status == StudentStatusEnum.Undergrad)
                    {
                        undergradStudentList.Add(item);
                    }

                }

                if (!(undergradStudentList.Count == 0))
                {
                    foreach (var item in undergradStudentList)
                    {
                        Console.WriteLine(item.ToString());
                    }

                }

                else
                {
                    Console.WriteLine("\n\aNo undergrad Students present in Student managemnt system, please enter add Student into the Student management system");
                }

            }

            else
            {
                Console.WriteLine("\n\aNo Students present in Student managemnt system, please enter add Student into the Student management system");
            }
        }

        public void ShowAllCurrentStudents()
        {
            if (!(studentList.Count == 0))
            {
                Console.WriteLine("\nList of all Students that are currently studying in Dublin Business School");

                List<Student> isCurrentStudentList = new List<Student>();

                foreach (Student item in studentList)
                {
                    if (item.IsCurrentStudent == true)
                    {
                        isCurrentStudentList.Add(item);
                    }

                }

                if (!(isCurrentStudentList.Count == 0))
                {
                    foreach (Student item in isCurrentStudentList)
                    {
                        Console.WriteLine(item.ToString());
                    }
                }

                else
                {
                    Console.WriteLine("\n\aNo current Student present in Student managemnt system, please enter add Student into the Student management system");
                }

            }

            else
            {
                Console.WriteLine("\n\aNo Students present in Student managment system, please enter add new Student into the Student management system");
            }
        }

        public void ShowAllPostgradCurrentStudents()
        {
            if (!(studentList.Count == 0))
            {
                Console.WriteLine("\nList of all Students that are Postgrad Students and currently studying in Dublin Business School");

                List<Student> postgradStudentsCurrentList = new List<Student>();

                foreach (Student item in studentList)
                {
                    if ((item.Status == StudentStatusEnum.Postgrad) && (item.IsCurrentStudent == true))
                    {
                        postgradStudentsCurrentList.Add(item);
                    }
                }

                if (!(postgradStudentsCurrentList.Count == 0))
                {
                    foreach (Student item in postgradStudentsCurrentList)
                    {
                        Console.WriteLine(item.ToString());
                    }
                }

                else
                {
                    Console.WriteLine("\n\aNo current postgrad Students present in student management, please enter a new student into the Student management system");
                }
            }

            else
            {
                Console.WriteLine("\n\aNo Students present in student management, please enter a new student into the Student management system");
            }
        }

        public void ShowAllUndergradCurrentStudents()
        {
            if (!(studentList.Count == 0))
            {
                Console.WriteLine("\nList of all Students that are Undergrad Students and currently studying in Dublin Business School");

                List<Student> undergradStudentsCurrentList = new List<Student>();

                foreach (Student item in studentList)
                {
                    if ((item.Status == StudentStatusEnum.Undergrad) && (item.IsCurrentStudent == true))
                    {
                        undergradStudentsCurrentList.Add(item);
                    }
                }

                if (!(undergradStudentsCurrentList.Count == 0))
                {
                    foreach (Student item in undergradStudentsCurrentList)
                    {
                        Console.WriteLine(item.ToString());
                    }
                }

                else
                {
                    Console.WriteLine("\n\aNo current undergrad Students present in student management, please enter a new student into the Student management system");
                }

            }

            else
            {
                Console.WriteLine("\n\aNo Students present in student management, please enter a new student into the Student management system");
            }
        }

        public void ShowAllNotCurrentStudents()
        {
            if (!(studentList.Count == 0))
            {
                Console.WriteLine("\nList of all Students that are not currently studying in Dublin Business School");

                List<Student> isCurrentStudentList = new List<Student>();

                foreach (Student item in studentList)
                {
                    if (item.IsCurrentStudent == false)
                    {
                        isCurrentStudentList.Add(item);
                    }
                }

                if (!(isCurrentStudentList.Count == 0))
                {
                    foreach (Student item in isCurrentStudentList)
                    {
                        Console.WriteLine(item.ToString());
                    }
                }

                else
                {
                    Console.WriteLine("\n\aNo past Students present in student management system, please enter student into the Student management system");
                }

            }

            else
            {
                Console.WriteLine("\n\aNo Student present in student mannagement system, please enter a new student into the Student management system");
            }
        }

        public void ShowAllPostgradNotCurrentStudents()
        {
            if (!(studentList.Count == 0))
            {
                Console.WriteLine("\nList of all Students that are Postgrad Students and not currently studying in Dublin Business School");

                List<Student> postgradStudentsNotCurrentList = new List<Student>();

                foreach (Student item in studentList)
                {
                    if ((item.Status == StudentStatusEnum.Postgrad) && (item.IsCurrentStudent == false))
                    {
                        postgradStudentsNotCurrentList.Add(item);
                    }
                }

                if (!(postgradStudentsNotCurrentList.Count == 0))
                {
                    foreach (Student item in postgradStudentsNotCurrentList)
                    {
                        Console.WriteLine(item.ToString());
                    }
                }

                else
                {
                    Console.WriteLine("\n\aNo past postgrad Students present in student management system, please enter student into the Student management system");
                }

            }

            else
            {
                Console.WriteLine("\n\aNo Student present in student mannagement system, please enter a new student into the Student management system");
            }
        }

        public void ShowAllUndergradNotCurrentStudents()
        {
            if (!(studentList.Count == 0))
            {
                List<Student> undergradStudentsNotCurrentList = new List<Student>();

                foreach (Student item in studentList)
                {
                    if ((item.Status == StudentStatusEnum.Undergrad) && (item.IsCurrentStudent == false))
                    {
                        undergradStudentsNotCurrentList.Add(item);
                    }
                }

                if (!(undergradStudentsNotCurrentList.Count == 0))
                {
                    foreach (Student item in undergradStudentsNotCurrentList)
                    {
                        Console.WriteLine(item.ToString());
                    }
                }

                else
                {
                    Console.WriteLine("\n\aNo past undergrad Students present in student management system, please enter student into the Student management system");
                }
            }

            else
            {
                Console.WriteLine("\n\aNo Student present in student mannagement system, please enter a new student into the Student management system");
            }
        }

        public void ShowAllTotalNumberStudents()
        {
            Console.WriteLine($"\nThere are {studentList.Count} total number of Students in Dublin Business School management system");
        }

        public void FindStudent()
        {
            bool findInput = false, found = false;
            string inputID;
            Student student1 = new Student();

            while (!findInput)
            {
                Console.Write("\nPlease enter the Student ID you wish to find with no spaces in between the numbers or enter \"q\" to go back to Student Menu: ");
                inputID = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(inputID))
                {
                    Console.WriteLine("\n\aInvalid Input, please enter a number");
                    continue;
                }

                else if (inputID == "q")
                {
                    Console.Clear();
                    GetStudentManagementSystem();
                    findInput = true;
                }

                else if (int.TryParse(inputID, out int id))
                {
                    foreach (Student student in studentList)
                    {
                        if (student.StudentId == id)
                        {
                            student1 = student;
                            found = true;
                            findInput = true;
                        }

                    }

                    if (found)
                    {
                        Console.Write(student1.ToString());
                    }

                    else
                    {
                        Console.WriteLine("\a\nStudent ID not found, please add Student into Student Management System");
                        continue;
                    }
                }

                else
                {
                    Console.WriteLine("\n\aInvalid Input");
                    continue;
                }

            }
        }

        public void DeleteStudent()
        {
            Student student = new Student();
            bool deleteInput = false, removed = false;

            while (!deleteInput)
            {
                Console.Write("\nPlease enter the Student ID you wish to delete with no spaces in between the number or enter \"q\" to go back to Student Menu: ");
                string inputID = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(inputID))
                {
                    Console.WriteLine("\n\aInvalid Input, please enter a number");
                    continue;
                }

                else if (inputID == "q")
                {
                    Console.Clear();
                    GetStudentManagementSystem();
                    deleteInput = true;
                }

                else if (int.TryParse(inputID, out int id))
                {

                    for (int i = 0; i < studentList.Count; i++)
                    {
                        if (studentList[i].StudentId == id)
                        {
                            studentList.Remove(studentList[i]);
                            removed = true;
                        }

                    }

                    if (removed)
                    {
                        Console.WriteLine($"\nThe Student account number: {id} has been removed from the Student management system");

                        foreach (Student pupil in studentList)
                        {
                            Console.WriteLine(pupil.ToString());
                        }

                        deleteInput = true;
                    }

                    else
                    {
                        Console.WriteLine("\a\nStudent does exist, please add Student into Student Management System");
                        continue;
                    }
                }

                else
                {
                    Console.WriteLine("\n\aInvalid Input");
                    continue;
                }
            }
        }

        public void GetStudentManagementSystem()
        {
            Student student = new Student();
            Teachers teacher = new Teachers();
            bool keepGoing = true, userOption = true;
            string inputOption;

            while (keepGoing)
            {
                keepGoing = false;

                while (userOption)
                {
                    DisplayStudentMenu();

                    Console.Write("\nPlease enter a number listed by the menu above, with no spaces in between the number: ");
                    inputOption = Console.ReadLine();

                    if (String.IsNullOrWhiteSpace(inputOption))
                    {
                        Console.WriteLine("\n\aInvalid Input, please enter a number");
                        continue;
                    }

                    else if (int.TryParse(inputOption, out int option))
                    {
                        switch (option)
                        {
                            case 1:
                                AddStudent();
                                break;

                            case 2:
                                ShowAllStudents();
                                break;

                            case 3:
                                ShowAllPostgradStudents();
                                break;

                            case 4:
                                ShowAllUndergradStudents();
                                break;

                            case 5:
                                ShowAllCurrentStudents();
                                break;

                            case 6:
                                ShowAllPostgradCurrentStudents();
                                break;

                            case 7:
                                ShowAllUndergradCurrentStudents();
                                break;

                            case 8:
                                ShowAllNotCurrentStudents();
                                break;

                            case 9:
                                ShowAllPostgradNotCurrentStudents();
                                break;

                            case 10:
                                ShowAllUndergradNotCurrentStudents();
                                break;

                            case 11:
                                SortList();
                                break;

                            case 12:
                                ShowAllTotalNumberStudents();
                                break;

                            case 13:
                                FindStudent();
                                break;

                            case 14:
                                DeleteStudent();
                                break;

                            case 15:
                                Clear();
                                break;

                            case 16:
                                Console.Clear();
                                teacher.GetTeacherManagementSystem();
                                break;

                            case 17:
                                Console.Clear();
                                Console.WriteLine("Thank you for using the Student management system");
                                userOption = false;
                                break;

                            default:
                                Console.WriteLine("\n\aThat is not an option");
                                continue;
                        }
                    }

                    else
                    {
                        Console.WriteLine("\n\aInvalid Input ");
                        continue;
                    }
                }

            }
        }


    }
}
