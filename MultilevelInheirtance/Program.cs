namespace MultilevelInheirtance
{

    class Student
    {
        int rn;
        string name;
        string address;
        public Student()
        {
            
        }
        public Student(int rn, string name, string address)
        {
            this.rn = rn;
            this.name = name;
            this.address = address;
     
        }

        public void GetDetails()
        {
            Console.WriteLine("enter rn");
            rn  = byte.Parse(Console.ReadLine());
            Console.WriteLine("enter name");
            name = Console.ReadLine();
            Console.WriteLine("Enter address");
            address = Console.ReadLine();
        }
        public void DisplayDetails()
        {
            Console.WriteLine("rn is " + rn);
            Console.WriteLine("name is " + name);
            Console.WriteLine("address is "+ address);
        }

    }
    class Sports : Student
    {
        string sportsName;
        protected int score;
        public Sports() { }
        public Sports(string sportsName, int score)
        {
            this.sportsName = sportsName;
            this.score = score;

        }
        public void GetDetails()
        {
            base.GetDetails();
            Console.WriteLine("enter sportsName");
            sportsName = Console.ReadLine();
            Console.WriteLine("enter score");
            score = byte.Parse(Console.ReadLine());
        }
        public void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("sportsName is " + sportsName);
            Console.WriteLine("score is " + score);
        }
    }
    class Test : Sports
    {
        int[] marks = [90, 34, 56, 56, 44];
        protected int totalScore;
        public Test() { }
        public void CalculateTotalScore()
        {
            base.GetDetails();
            foreach (var mark in marks)
                totalScore += mark;
        }
        public void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("total score is " + totalScore);
        }
    }
    class Result : Test
    {
        int finalScore;
        public void CalculateFinalScore()
        {
            base.CalculateTotalScore();
            finalScore =  score + totalScore;
        }
        public void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("finalScore is " + finalScore);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Result result = new Result();
            result.CalculateFinalScore();
            result.DisplayDetails();
            
            //result.score = 0;
            //result.totalScore = 0;
        }
    }
}
