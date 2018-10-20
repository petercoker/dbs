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
            Console.WriteLine("\nList of Students sorted by Student ID");
            studentList.Sort();

            foreach (Student pupil in studentList)
            {
                Console.Write($"\nStudent ID: {pupil.StudentId}\nStudent is a current Student: {pupil.IsCurrentStudent}\nStudent: {pupil.Name}\nStatus: {pupil.Status}\nPhone: {pupil.Phone}\nEmail: {pupil.Email}\n");
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

        //public bool RemoveByID(int id)
        //{
        //    Student studentDelete = GetStudent(id);
        //    bool removed = false;

        //    if (studentDelete != null)
        //    {
        //        studentList.Remove(studentDelete);
        //        removed = true;
        //    }

        //    return removed;
        //}

        //public bool CheckUniqueID(int id)
        //{
        //    Student checkNumber = GetStudent(id);

        //    bool duplicate = false;

        //    if (checkNumber != null)
        //    {
        //        duplicate = true;
        //    }

        //    return duplicate;
        //}

        //public void CheckUniqueID(int id)
        //{
        //    bool found = false;

        //    for (int i = 0; i < studentList.Count; i++)
        //    {
        //        if (studentList[i].StudentId.Equals(id))
        //        {
        //            found = true;
        //        }

        //    }
        //Console.Write("Enter a few numbers (eg 1-2-3-4): ");
        //var input = Console.ReadLine();

        //var numbers = new List<int>();
        //foreach (var number in input.Split('-'))
        //    numbers.Add(Convert.ToInt32(number));

        //var uniques = new List<int>();
        //var includesDuplicates = false;
        //foreach (var number in numbers)
        //{
        //    if (!uniques.Contains(number))
        //        uniques.Add(number);
        //    else
        //    {
        //        includesDuplicates = true;
        //        break;
        //    }
        //}

        //if (includesDuplicates)
        //    Console.WriteLine("Duplicate");

        //}

        //public List<Student> GetStudentCurrent()
        //{
        //    List<Student> isCurrentStudentList = new List<Student>();

        //    foreach (Student item in studentList)
        //    {
        //        if (item.IsCurrentStudent == true)
        //        {
        //            isCurrentStudentList.Add(item);
        //        }
        //    }

        //    return isCurrentStudentList;
        //}

        //public List<Student> GetStudentNotCurrent()
        //{
        //    List<Student> isCurrentStudentList = new List<Student>();

        //    foreach (Student item in studentList)
        //    {
        //        if (item.IsCurrentStudent == false)
        //        {
        //            isCurrentStudentList.Add(item);
        //        }
        //    }

        //    return isCurrentStudentList;
        //}

        //public List<Student> GetAllPostgradStudent()
        //{
        //    List<Student> postgradStudentList = new List<Student>();

        //    foreach (Student item in studentList)
        //    {
        //        if (item.Status == StudentStatusEnum.Postgrad)
        //        {
        //            postgradStudentList.Add(item);
        //        }
        //    }

        //    return postgradStudentList;
        //}

        //public List<Student> GetAllUndergradStudent()
        //{
        //    List<Student> undergradStudentList = new List<Student>();

        //    foreach (Student item in studentList)
        //    {
        //        if (item.Status == StudentStatusEnum.Undergrad)
        //        {
        //            undergradStudentList.Add(item);
        //        }
        //    }

        //    return undergradStudentList;
        //}

        //public List<Student> GetPostgradStudentCurrent()
        //{
        //    List<Student> postgradStudentsCurrentList = new List<Student>();

        //    foreach (Student item in studentList)
        //    {
        //        if ((item.Status == StudentStatusEnum.Postgrad) && (item.IsCurrentStudent == true))
        //        {
        //            postgradStudentsCurrentList.Add(item);
        //        }
        //    }

        //    return postgradStudentsCurrentList;
        //}

        //public List<Student> GetUndergradStudentCurrent()
        //{
        //    List<Student> undergradStudentsCurrentList = new List<Student>();

        //    foreach (Student item in studentList)
        //    {
        //        if ((item.Status == StudentStatusEnum.Undergrad) && (item.IsCurrentStudent == true))
        //        {
        //            undergradStudentsCurrentList.Add(item);
        //        }
        //    }

        //    return undergradStudentsCurrentList;
        //}

        //public List<Student> GetPostgradStudentNotCurrent()
        //{
        //    List<Student> postgradStudentsNotCurrentList = new List<Student>();

        //    foreach (Student item in studentList)
        //    {
        //        if ((item.Status == StudentStatusEnum.Postgrad) && (item.IsCurrentStudent == false))
        //        {
        //            postgradStudentsNotCurrentList.Add(item);
        //        }
        //    }

        //    return postgradStudentsNotCurrentList;
        //}

        //public List<Student> GetUndergradStudentNotCurrent()
        //{
        //    List<Student> undergradStudentsNotCurrentList = new List<Student>();

        //    foreach (Student item in studentList)
        //    {
        //        if ((item.Status == StudentStatusEnum.Undergrad) && (item.IsCurrentStudent == false))
        //        {
        //            undergradStudentsNotCurrentList.Add(item);
        //        }
        //    }

        //    return undergradStudentsNotCurrentList;
        //}

        //public bool ChangeStudentName(int id, string name)
        //{
        //    Student studentChange = GetStudent(id);

        //    bool isChange = false;

        //    if (studentChange != null)
        //    {
        //        studentChange.Name = name;

        //        isChange = true;
        //    }

        //    return isChange;
        //}

        //public bool ChangeStudentPhone(int id, int phone)
        //{
        //    Student studentChange = GetStudent(id);

        //    bool isChange = false;

        //    if (studentChange != null)
        //    {
        //        studentChange.Phone = phone;

        //        isChange = true;
        //    }

        //    return isChange;
        //}

        //public bool ChangeStudentEmail(int id, string email)
        //{
        //    Student studentChange = GetStudent(id);

        //    bool isChange = false;

        //    if (studentChange != null)
        //    {
        //        studentChange.Email = email;

        //        isChange = true;
        //    }

        //    return isChange;
        //}

        //public bool ChangeStudentIfStudentCurrent(int id, bool isCurrentStudent)
        //{
        //    Student studentChange = GetStudent(id);

        //    bool isChange = false;

        //    if (studentChange != null)
        //    {
        //        studentChange.IsCurrentStudent = isCurrentStudent;

        //        isChange = true;
        //    }

        //    return isChange;
        //}

        //public bool ChangeStudentStatus(int id, int status)
        //{
        //    Student studentChange = GetStudent(id);

        //    bool isChange = false;

        //    if (studentChange != null)
        //    {
        //        if (status == 0)
        //        {
        //            studentChange.Status = StudentStatusEnum.Undergrad;
        //        }

        //        else if (status == 1)
        //        {
        //            studentChange.Status = StudentStatusEnum.Postgrad;
        //        }

        //        isChange = true;
        //    }

        //    return isChange;
        //}

        public bool ChangeStudentInfo(int id, bool isCurrentStudent, string name, int status, int phone, string email)
        {
            Student studentChange = GetStudent(id);

            bool isChange = false;

            if (studentChange != null)
            {

                studentChange.IsCurrentStudent = isCurrentStudent;

                studentChange.Name = name;

                if (status == 0)
                {
                    studentChange.Status = StudentStatusEnum.Undergrad;
                }

                else if (status == 1)
                {
                    studentChange.Status = StudentStatusEnum.Postgrad;
                }

                studentChange.Phone = phone;

                studentChange.Email = email;

                isChange = true;
            }

            return isChange;
        }

        //public bool ChangeStudentInfo(int id, bool isCurrentStudent, string name, int status, int phone, string email)
        //{
        //    Student studentDelete = GetStudent(id);
        //    Student studentChange = GetStudent(id);

        //    bool isChange = false;

        //    bool removed = false;

        //    if (studentDelete != null)
        //    {
        //        StudentList.IndexOf();
        //        removed = true;
        //    }

        //    if (studentChange != null)
        //    {

        //        studentChange.IsCurrentStudent = isCurrentStudent;

        //        studentChange.Name = name;

        //        if (status == 0)
        //        {
        //            studentChange.Status = StudentStatusEnum.Undergrad;
        //        }

        //        else if (status == 1)
        //        {
        //            studentChange.Status = StudentStatusEnum.Postgrad;
        //        }

        //        studentChange.Phone = phone;

        //        studentChange.Email = email;

        //        isChange = true;
        //    }

        //    return isChange;
        //}

        public void AddStudent()
        {
        //    Students studentList = new Students();
        //    Student student = new Student();
        //    int studentStatus, studentPhone;
        //    bool userInputID = false, userInputStudentAttendance = false, userInputName = false, userInputStatus = false, userInputPhone = false, userInputEmail = false;
        //    string inputStudentID, inputStudentStatus, inputStudentEmail, inputStudentName, inputStudentAttendance;

        //    while (!userInputID)
        //    {
        //        Console.Write("Please enter your Student ID number (integer): ");
        //        inputStudentID = Console.ReadLine();

        //        if (String.IsNullOrWhiteSpace(inputStudentID))
        //        {
        //            Console.WriteLine("\n\aInvalid Input, please enter a number");
        //            continue;
        //        }

        //        else if (int.TryParse(inputStudentID, out int id))
        //        {
        //            if (id < 0)
        //            {
        //                Console.WriteLine("\n\aPlease enter a postive number");
        //                continue;
        //            }

        //            else if (id >= 0)
        //            {
        //                Student checkNumber = GetStudent(id);

        //                bool found = false;

        //                if (checkNumber != null)
        //                {
        //                    found = true;
        //                    Console.WriteLine("\n\aStudent already exists");
        //                    continue;
        //                }

        //                else
        //                {
        //                    student.StudentId = id;
        //                    userInputID = true;
        //                }
        //            }
        //        }

        //        else
        //        {
        //            Console.WriteLine("\n\aNot a number");
        //            continue;
        //        }

        //    }

        //    while (!userInputStudentAttendance)
        //    {
        //        Console.Write("Please enter \"t\" or \"f\" if you are a current Student: ");
        //        inputStudentAttendance = Console.ReadLine().ToLower();

        //        if (String.IsNullOrWhiteSpace(inputStudentAttendance))
        //        {
        //            Console.WriteLine("\n\aInvalid Input, please enter a string input");
        //            continue;
        //        }

        //        else if (inputStudentAttendance == "t")
        //        {
        //            student.IsCurrentStudent = true;
        //            userInputStudentAttendance = true;
        //        }

        //        else if (inputStudentAttendance == "f")
        //        {
        //            student.IsCurrentStudent = false;
        //            userInputStudentAttendance = true;
        //        }

        //        else
        //        {
        //            Console.WriteLine("\n\aInvalid Input, only enter \"t\" or \"f\" if you are a current Student");
        //            continue;
        //        }
        //    }

        //    while (!userInputName)
        //    {
        //        Console.Write("Please enter your name: ");
        //        inputStudentName = Console.ReadLine();

        //        if (String.IsNullOrWhiteSpace(inputStudentName))
        //        {
        //            Console.WriteLine("\n\aInvalid Input, please enter a string input");
        //            continue;
        //        }

        //        else
        //        {
        //            student.Name = inputStudentName;
        //            userInputName = true;
        //        }

        //    }

        //    while (!userInputStatus)
        //    {
        //        Console.Write("Please enter \"0\" for Undergrad or \"1\" for Postgrad: ");
        //        inputStudentStatus = Console.ReadLine();

        //        if (String.IsNullOrWhiteSpace(inputStudentStatus))
        //        {
        //            Console.WriteLine("\n\aInvalid Input, please enter a number");
        //            continue;
        //        }

        //        else if (int.TryParse(inputStudentStatus, out studentStatus))
        //        {
        //            if (studentStatus == 0)
        //            {
        //                student.Status = StudentStatusEnum.Undergrad;
        //                userInputStatus = true;
        //            }

        //            else if (studentStatus == 1)
        //            {
        //                student.Status = StudentStatusEnum.Postgrad;
        //                userInputStatus = true;
        //            }

        //            else if (studentStatus < 0 || studentStatus > 1)
        //            {
        //                Console.WriteLine("\n\aPlease only enter a number between \"0\" and \"1\"");
        //                continue;
        //            }
        //        }

        //        else
        //        {
        //            Console.WriteLine("\n\aNot a number");
        //            continue;
        //        }
        //    }

        //    while (!userInputPhone)
        //    {
        //        Console.Write("Please enter your phone number (integer): ");
        //        string inputStudentPhone = Console.ReadLine();

        //        if (String.IsNullOrWhiteSpace(inputStudentPhone))
        //        {
        //            Console.WriteLine("\n\aInvalid Input, please enter a number");
        //            continue;
        //        }

        //        else if (int.TryParse(inputStudentPhone, out studentPhone))
        //        {
        //            if (studentPhone < 0)
        //            {
        //                Console.WriteLine("\n\aPlease enter a postive number");
        //                continue;
        //            }

        //            else
        //            {
        //                student.Phone = studentPhone;
        //                userInputPhone = true;
        //            }
        //        }

        //        else
        //        {
        //            Console.WriteLine("\n\aNot a number");
        //            continue;
        //        }

        //    }

        //    while (!userInputEmail)
        //    {
        //        Console.Write("Please enter your email: ");
        //        inputStudentEmail = Console.ReadLine();

        //        if (String.IsNullOrWhiteSpace(inputStudentEmail))
        //        {
        //            Console.WriteLine("\n\aInvalid Input, please enter a string input");
        //            continue;
        //        }

        //        else
        //        {
        //            student.Email = inputStudentEmail;
        //            userInputEmail = true;
        //        }
        //    }

        //    studentList.Add(student);
        //    Console.WriteLine("\nStudent has been added");

        }

        public void ChangeAllStudentInfo() //fix
        {
            //    Students studentList = new Students();
            Student student = new Student();
            int id, phone, status;
            bool changeInput = false;
            string name, email;
            bool isCurrentStudent;

            Students studentList = new Students();
            Student student = new Student();
            int studentStatus, studentPhone;
            bool changeUserInputID = false, userInputStudentAttendance = false, userInputName = false, userInputStatus = false, userInputPhone = false, userInputEmail = false;
            string inputStudentID, inputStudentStatus, inputStudentEmail, inputStudentName, inputStudentAttendance;

            while (!changeUserInputID)
            {
                Console.Write("Please enter your Student ID number (integer): ");
                inputStudentID = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(inputStudentID))
                {
                    Console.WriteLine("\n\aInvalid Input, please enter a number");
                    continue;
                }

                else if (int.TryParse(inputStudentID, out int id))
                {
                    if (id < 0)
                    {
                        Console.WriteLine("\n\aPlease enter a postive number");
                        continue;
                    }

                    else if (id >= 0)
                    {
                        Student checkNumber = GetStudent(id);

                        bool found = false;

                        if (checkNumber != null)
                        {
                            found = true;
                            Console.WriteLine("\n\aStudent already exists");
                            continue;
                        }

                        else
                        {
                            student.StudentId = id;
                            changeUserInputID = true;
                        }
                    }
                }

                else
                {
                    Console.WriteLine("\n\aNot a number");
                    continue;
                }

            }

            while (!userInputStudentAttendance)
            {
                Console.Write("Please enter \"t\" or \"f\" if you are a current Student: ");
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

                if (String.IsNullOrWhiteSpace(inputStudentName))
                {
                    Console.WriteLine("\n\aInvalid Input, please enter a string input");
                    continue;
                }

                else
                {
                    student.Name = inputStudentName;
                    userInputName = true;
                }

            }

            while (!userInputStatus)
            {
                Console.Write("Please enter \"0\" for Undergrad or \"1\" for Postgrad: ");
                inputStudentStatus = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(inputStudentStatus))
                {
                    Console.WriteLine("\n\aInvalid Input, please enter a number");
                    continue;
                }

                else if (int.TryParse(inputStudentStatus, out studentStatus))
                {
                    if (studentStatus == 0)
                    {
                        student.Status = StudentStatusEnum.Undergrad;
                        userInputStatus = true;
                    }

                    else if (studentStatus == 1)
                    {
                        student.Status = StudentStatusEnum.Postgrad;
                        userInputStatus = true;
                    }

                    else if (studentStatus < 0 || studentStatus > 1)
                    {
                        Console.WriteLine("\n\aPlease only enter a number between \"0\" and \"1\"");
                        continue;
                    }
                }

                else
                {
                    Console.WriteLine("\n\aNot a number");
                    continue;
                }
            }

            while (!userInputPhone)
            {
                Console.Write("Please enter your phone number (integer): ");
                string inputStudentPhone = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(inputStudentPhone))
                {
                    Console.WriteLine("\n\aInvalid Input, please enter a number");
                    continue;
                }

                else if (int.TryParse(inputStudentPhone, out studentPhone))
                {
                    if (studentPhone < 0)
                    {
                        Console.WriteLine("\n\aPlease enter a postive number");
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
                    Console.WriteLine("\n\aNot a number");
                    continue;
                }

            }

            while (!userInputEmail)
            {
                Console.Write("Please enter your email: ");
                inputStudentEmail = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(inputStudentEmail))
                {
                    Console.WriteLine("\n\aInvalid Input, please enter a string input");
                    continue;
                }

                else
                {
                    student.Email = inputStudentEmail;
                    userInputEmail = true;
                }
            }

            studentList.Add(student);
            Console.WriteLine("\nStudent has been added");

        

    }

    public void ShowAllStudents()
    {
        Console.WriteLine("\nAll Students in Dublin Business School");
        foreach (Student pupil in studentList)
        {
            Console.WriteLine(pupil.ToString());
        }
    }

    public void ShowAllPostgradStudents()
    {
        Console.WriteLine("\nList of Students that are Postgrad Students of Dublin Business School\n");

        List<Student> postgradStudentList = new List<Student>();

        foreach (Student item in studentList)
        {
            if (item.Status == StudentStatusEnum.Postgrad)
            {
                postgradStudentList.Add(item);
            }
        }

        foreach (var item in postgradStudentList)
        {
            Console.WriteLine(item.ToString());
        }
    }

    public void ShowAllUndergradStudents()
    {
        Console.WriteLine("\nList of Students that are Undergrad Students of Dublin Business School\n");

        List<Student> undergradStudentList = new List<Student>();

        foreach (Student item in studentList)
        {
            if (item.Status == StudentStatusEnum.Undergrad)
            {
                undergradStudentList.Add(item);
            }
        }

        foreach (var item in undergradStudentList)
        {
            Console.WriteLine(item.ToString());
        }
    }

    public void ShowAllCurrentStudents()
    {
        Console.WriteLine("\nList of all Students that are currently studying in Dublin Business School\n");

        List<Student> isCurrentStudentList = new List<Student>();

        foreach (Student item in studentList)
        {
            if (item.IsCurrentStudent == true)
            {
                isCurrentStudentList.Add(item);
            }
        }

        foreach (Student item in isCurrentStudentList)
        {
            Console.WriteLine(item.ToString());
        }

    }

    public void ShowAllPostgradCurrentStudents()
    {
        Console.WriteLine("\nList of all Students that are Postgrad Students and currently studying in Dublin Business School\n");

        List<Student> postgradStudentsCurrentList = new List<Student>();

        foreach (Student item in studentList)
        {
            if ((item.Status == StudentStatusEnum.Postgrad) && (item.IsCurrentStudent == true))
            {
                postgradStudentsCurrentList.Add(item);
            }
        }

        foreach (Student item in postgradStudentsCurrentList)
        {
            Console.WriteLine(item.ToString());
        }

    }

    public void ShowAllUndergradCurrentStudents()
    {
        Console.WriteLine("\nList of all Students that are Undergrad Students and currently studying in Dublin Business School\n");

        List<Student> undergradStudentsCurrentList = new List<Student>();

        foreach (Student item in studentList)
        {
            if ((item.Status == StudentStatusEnum.Undergrad) && (item.IsCurrentStudent == true))
            {
                undergradStudentsCurrentList.Add(item);
            }
        }

        foreach (Student item in undergradStudentsCurrentList)
        {
            Console.WriteLine(item.ToString());
        }

    }

    public void ShowAllNotCurrentStudents()
    {
        Console.WriteLine("\nList of all Students that are not currently studying in Dublin Business School\n");

        List<Student> isCurrentStudentList = new List<Student>();

        foreach (Student item in studentList)
        {
            if (item.IsCurrentStudent == false)
            {
                isCurrentStudentList.Add(item);
            }
        }

        foreach (Student item in isCurrentStudentList)
        {
            Console.WriteLine(item.ToString());
        }
    }

    public void ShowAllPostgradNotCurrentStudents()
    {
        Console.WriteLine("\nList of all Students that are Postgrad Students and not currently studying in Dublin Business School\n");

        List<Student> postgradStudentsNotCurrentList = new List<Student>();

        foreach (Student item in studentList)
        {
            if ((item.Status == StudentStatusEnum.Postgrad) && (item.IsCurrentStudent == false))
            {
                postgradStudentsNotCurrentList.Add(item);
            }
        }

        foreach (Student item in postgradStudentsNotCurrentList)
        {
            Console.WriteLine(item.ToString());
        }

    }

    public void ShowAllUndergradNotCurrentStudents()
    {
        List<Student> undergradStudentsNotCurrentList = new List<Student>();

        foreach (Student item in studentList)
        {
            if ((item.Status == StudentStatusEnum.Undergrad) && (item.IsCurrentStudent == false))
            {
                undergradStudentsNotCurrentList.Add(item);
            }
        }

        foreach (Student item in undergradStudentsNotCurrentList)
        {
            Console.WriteLine(item.ToString());
        }

    }

    public void ShowAllTotalNumberStudents()
    {
        Console.WriteLine($"\nThere are {studentList.Count} total number of Students in Dublin Business School");
    }

    public void FindStudent()
    {
        bool findInput = false, found = false;
        Student student1 = new Student();

        while (!findInput)
        {
            Console.Write("\nPlease enter the Student ID you wish to find: ");
            string inputID = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(inputID))
            {
                Console.WriteLine("\n\aInvalid Input, please enter a number");
                continue;
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
                    Console.WriteLine("\a\nStudent ID not found, Please add Student ID into Student Management System");
                    continue;
                }
            }

            else
            {
                Console.WriteLine("\n\aNot a number");
                continue;
            }

        }
    }

    public void DeleteStudent()
    {

        bool deleteInput = false, removed = false;

        while (!deleteInput)
        {
            Console.Write("\nPlease enter the Student ID you wish to delete: ");
            string inputID = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(inputID))
            {
                Console.WriteLine("\n\aInvalid Input, please enter a number");
                continue;
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
                    Console.WriteLine($"\nThe Student ID: {id} has been removed");

                    foreach (Student pupil in studentList)
                    {
                        Console.WriteLine(pupil.ToString());
                    }

                    deleteInput = true;
                }

                else
                {
                    Console.WriteLine("\a\nStudent does exist, Please add Student ID into Student Management System");
                    continue;
                }
            }

            else
            {
                Console.WriteLine("\n\aNot a number");
                continue;
            }
        }
    }

}
}

