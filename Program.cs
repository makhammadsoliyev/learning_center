using LearningCenter;


List<Student> students = new List<Student>();

bool isTrue = true;
while (isTrue)
{
    Console.WriteLine("-\t--\t-");
    Console.WriteLine("1. Add student");
    Console.WriteLine("2. Display all students");
    Console.WriteLine("3. Update student");
    Console.WriteLine("4. Delete student");
    Console.WriteLine("\n0. Exit");
    Console.WriteLine("-\t--\t-");

    Console.Write("Enter your choice number: ");
    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            // Add
            AddStudent(students);
            break; 
        case "2":
            // Display
            GetAllStudents(students);
            break; 
        case "3":
            // Update
            UpdateStudent(students);
            break; 
        case "4":
            // Delete
            DeleteStudent(students);
            break;
        case "0":
        default:
            Console.WriteLine("Good-Bye!!!");
            isTrue = false;
            break;
    }
    Console.WriteLine("\n");


    #region Add student service
    static void AddStudent(List<Student> students)
    {
        Console.Write("Enter student's name: ");
        string name = Console.ReadLine().Trim().ToLower();

        Console.Write("Enter student's age: ");
        int age;

        while (!int.TryParse(Console.ReadLine().Trim(), out age))
        {
            Console.WriteLine("Invalid age. Please enter valid age");
            Console.Write("Enter student's age: ");
        }

        Console.Write("Enter name of the course: ");
        string courseName = Console.ReadLine().Trim().ToLower();

        
        Console.Write("Enter time of the course (ex. 08:00): ");
        TimeSpan courseTime;

        while (!TimeSpan.TryParse(Console.ReadLine().Trim(), out courseTime))
        {
            Console.WriteLine("Invalid time. Please enter valid time");
            Console.Write("Enter time of the course (ex. 08:00): ");
        }

        Console.Write("Enter the course price: ");
        decimal coursePrice;

        while (!decimal.TryParse(Console.ReadLine().Trim(), out coursePrice))
        {
            Console.WriteLine("Invalid price. Please enter valid price");
            Console.Write("Enter the course price: ");
        }

        Student stundent = new Student(name, age, courseName, courseTime, coursePrice);

        students.Add(stundent);

        Console.WriteLine("Student successfully added...");
    }
    #endregion

    #region List Of all students
    static void GetAllStudents(List<Student> students)
    {
        Console.WriteLine("List of all students");
        foreach (var student in students)
        {
            Console.WriteLine($"Name: {student.Name}, Course: {student.CourseName}, Time: {student.CourseTime}");
        }
    }
    #endregion

    #region Update Student data
    static void UpdateStudent(List<Student> students)
    {
        Console.Write("Enter student name: ");
        string name = Console.ReadLine().Trim().ToLower();

        int idx = students.FindIndex(t => t.Name == name);
        Student student = students[idx];

        bool isTrue = true;
        while (isTrue)
        {
            Console.WriteLine("-\t--\t-");
            Console.WriteLine("1. Change student name");
            Console.WriteLine("2. Change student age");
            Console.WriteLine("3. Change course name");
            Console.WriteLine("4. Change course time");
            Console.WriteLine("5. Change course price");
            Console.WriteLine("\n0. Go back..");
            Console.WriteLine("-\t--\t-");
            Console.Write("Please enter what needs to be changed: ");

            string choice;
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter student's name: ");
                    string newName = Console.ReadLine().Trim().ToLower();
                    student.Name = newName;
                    break;
                case "2":
                    Console.Write("Enter student's age: ");
                    int newAge;

                    while (!int.TryParse(Console.ReadLine().Trim(), out newAge))
                    {
                        Console.WriteLine("Invalid age. Please enter valid age");
                        Console.Write("Enter student's age: ");
                    }
                    student.Age = newAge;
                    break;
                case "3":
                    Console.Write("Enter name of the course: ");
                    string newCourseName = Console.ReadLine().Trim().ToLower();
                    student.CourseName = newCourseName;
                    break;
                case "4":
                    Console.Write("Enter time of the course (ex. 08:00): ");
                    TimeSpan newCourseTime;

                    while (!TimeSpan.TryParse(Console.ReadLine().Trim(), out newCourseTime))
                    {
                        Console.WriteLine("Invalid time. Please enter valid time");
                        Console.Write("Enter time of the course (ex. 08:00): ");
                    }
                    student.CourseTime = newCourseTime;
                    break;
                case "5":
                    Console.Write("Enter the course price: ");
                    decimal newCoursePrice;

                    while (!decimal.TryParse(Console.ReadLine().Trim(), out newCoursePrice))
                    {
                        Console.WriteLine("Invalid price. Please enter valid price");
                        Console.Write("Enter the course price: ");
                    }
                    student.CoursePrice = newCoursePrice;
                    break;
                default:
                    isTrue = false;
                    break;
            }
            students[idx] = student;
        }
        Console.WriteLine("Successfully updated...");
    }
    #endregion

    #region Delete student
    static void DeleteStudent(List<Student> students)
    {
        Console.Write("Enter student name: ");
        string name = Console.ReadLine().Trim().ToLower();

        int idx = students.FindIndex(t => t.Name == name);
        Student student = students[idx];

        students.RemoveAt(idx);
        Console.WriteLine("Successfully deleted...");
    }
    #endregion
}