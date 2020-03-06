using System;
using System.Collections.Generic;

namespace StudentExercises
{
    class Cohort
    {
        public string Name { get; set; }

        public List<Student> Students = new List<Student>();

        public List<Instructor> Instructors = new List<Instructor>();

        public void addStudent(Student student)
        {
            Students.Add(student);
        }

        public void addInstructor(Instructor instructor)
        {
            Instructors.Add(instructor);
        }
    }
}