using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");

        Job job1 = new Job();
        job1._jobTitle = "software developer";
        job1._company = "Samsung";
        job1._startYear = "2026";
        job1._endYear = "2028";
       

        Job job2 = new Job();
        job2._jobTitle = "Frontend Dev.";
        job2._company = "Fintech";
        job2._startYear = "2025";
        job2._endYear = "2026";

        job1.DisplayJobDetails();
        job2.DisplayJobDetails();

        Resume myResume = new Resume();
        myResume._name = "Joseph Precious";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.DisplayResume();


    }

}