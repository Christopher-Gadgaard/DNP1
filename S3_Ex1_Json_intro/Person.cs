﻿namespace S3_Ex1_Json_intro;
public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public double Height { get; set; }
    public bool IsMarried { get; set; }
    public char Sex { get; set; }
    public string[] Hobbies { get; set; }
    
    
    public Person(string firstName, string lastName, int age, double height, bool isMarried, char sex, string[] hobbies)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        Height = height;
        IsMarried = isMarried;
        Sex = sex;
        Hobbies = hobbies;
    }
}