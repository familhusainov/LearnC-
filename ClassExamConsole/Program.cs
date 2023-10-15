using ClassExamBusiness.Entites;
using ClassExamBusiness.Factory;
using System;
static class Exam
{
    static public void Main(String[] args)
    {
        var pupil = new Pupil();
        pupil.Name = "Mahmud";
        pupil.Age = 20;
        pupil.Attendance = true;
        var pupilFactory = new PupilFactory();
        pupilFactory.Add(pupil);
        //pupilFactory.AddTeacher();
        ////////////////////////////////////////////////
        
        

    }
}