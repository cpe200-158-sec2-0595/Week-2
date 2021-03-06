﻿using System;

public class Course
{
    private string _name;
    private string _courseid;
    private string _lecturer;
    private int _maxstudents;
    private int _numstudents;

    public override string ToString()
    {
        string s = "[Course: " + Name + " (" + CourseID + "), Lecturer=" + Lecturer + ", has " + NumStudents + " students, max=" + MaxStudents + "]";
        return s;
    }

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public string CourseID{
        get { return _courseid; }
        set{
            if (value.Length != 6)
            {
                Console.WriteLine(this.CourseID + " : ERROR! INVALID COURSE ID!");
            }
            else
            {
                bool isdigit = true;
                foreach (char s in value)
                {
                    if (char.IsDigit(s) == false)
                    {
                        isdigit = false;
                        Console.WriteLine(this.CourseID + " : ERROR! INVALID COURSE ID!");
                        break;
                    }
                }
                if (isdigit == true) { _courseid = value; }
            }
        }
    }

    public string Lecturer{
        get { return _lecturer; }
        set { _lecturer = value; }
    }

    public int MaxStudents{
        get { return _maxstudents; }
        set
        {
            if (value < 0 || value > 80 || value < this.NumStudents)
            {
                Console.WriteLine(this.CourseID + " : ERROR! INVALID INPUT!");
            }
            else
            {
                _maxstudents = value;
            }
        }
    }

    public int NumStudents{
        get { return _numstudents; }
        set
        {
            if (value < 0 || value >= this.MaxStudents)
            {
                Console.WriteLine(this.CourseID + " : ERROR! INVALID INPUT!");
            }
            else
            {
                _numstudents = value;
            }
        }
    }

    public Course(){
        this.Name = "N/A";
        this.CourseID = "000000";
        this.Lecturer = "STAFF";
        this.MaxStudents = 30;
        this.NumStudents = 0;
    }

    public Course(string name, string courseid){
        this.Name = name;
        this.CourseID = courseid;
        this.Lecturer = "STAFF";
        this.MaxStudents = 30;
        this.NumStudents = 0;
    }

    public Course(string name, string courseid, string lecturer){
        this.Name = name;
        this.CourseID = courseid;
        this.Lecturer = lecturer;
        this.MaxStudents = 30;
        this.NumStudents = 0;
    }

    public Course(string name, string courseid, string lecturer, int maxstudent){
        this.Name = name;
        this.CourseID = courseid;
        this.Lecturer = lecturer;
        this.MaxStudents = maxstudent;
        this.NumStudents = 0;
    }

}
