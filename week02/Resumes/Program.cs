using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");
    }

    public class Job
    {
        public string _company;
        public string _jobTitle;
        public int _startYear;
        public int _endYear;

        // constructeur
        public Job(string company, string jobTitle, int startYear, int endYear)
        {
            _company = company;
            _jobTitle = jobTitle;
            _startYear = startYear;
            _endYear = endYear;
        }

        // method
        public void display()
        {

        }
    }
}