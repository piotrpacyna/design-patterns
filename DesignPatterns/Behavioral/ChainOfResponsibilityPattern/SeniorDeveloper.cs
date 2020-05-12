namespace ChainOfResponsibilityPattern
{
    public class SeniorDeveloper : IssueHandler
    {
        public override void Handle(Issue issue)
        {
            if (issue.Level == IssueLevel.Medium || issue.Level == IssueLevel.Hard)
            {
                Log(nameof(SeniorDeveloper), issue);
            }
            else
            {
                Handler.Handle(issue);
            }
        }
    }
}
