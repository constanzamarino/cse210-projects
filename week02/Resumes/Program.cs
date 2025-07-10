using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Samsung";
        job1._jobTitle = "Staff Engineer";
        job1._startYear = 2015;
        job1._endYear = 2020;

        Job job2 = new Job();
        job2._company = "Intuit";
        job2._jobTitle = "Senior Software Engineer";
        job2._startYear = 2021;
        job2._endYear = 2025;

        Resume resume = new Resume();
        resume._name = "Elizabeth Sallow";

        resume._jobs.Add(job1);
        resume._jobs.Add(job2);


        resume.Display();
    }
}


