namespace LearningCenter;

public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string CourseName { get; set; }
    public TimeSpan CourseTime { get; set; }
    public decimal CoursePrice { get; set; }

    public Student(string name, int age, string courseName, TimeSpan courseTime, decimal coursePrice)
    {
        Name = name;
        Age = age;
        CourseName = courseName;
        CourseTime = courseTime;
        CoursePrice = coursePrice;
    }
}
