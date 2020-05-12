using System;

namespace ChainOfResponsibilityPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var developer = new Developer();
            var seniorDeveloper = new SeniorDeveloper();
            var leadDeveloper = new LeadDeveloper();

            developer.SetHandler(seniorDeveloper);
            seniorDeveloper.SetHandler(leadDeveloper);

            var issue = new Issue(IssueLevel.Simple);
            developer.Handle(issue);

            issue = new Issue(IssueLevel.Hard);
            developer.Handle(issue);

            issue = new Issue(IssueLevel.VeryHard);
            developer.Handle(issue);

            Console.ReadLine();
        }
    }
}
