using System;

public class Student  
{
    int studentid;
    string studentname;
    public Student()  
    {
        studentid = 0;
        studentname = "abc";
    }
    public static void Main()
    {
        Student s1 = new Student();  
        Console.WriteLine(s1.studentid);   
        Console.WriteLine(s1.studentname); 
    }
}

// Parameterized
using System;
public class Student
{
    int studentid;
    string studentname;
    public Student(int id, string s)
    {
        studentid = id;
        studentname = s;
    }
    public static void Main()
    {
        Student s1 = new Student(2, "Ram");
        Console.WriteLine(s1.studentid);
        Console.WriteLine(s1.studentname);
    }
}

// Default
using System;

public class Student
{
    int studentid;        
    string studentname;   

    public static void Main()
    {
        Student s1 = new Student(); 
        Console.WriteLine(s1.studentid);    
        Console.WriteLine(s1.studentname); 
    }
}
