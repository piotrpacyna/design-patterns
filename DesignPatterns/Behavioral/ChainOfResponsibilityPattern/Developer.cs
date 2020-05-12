namespace ChainOfResponsibilityPattern
{
    public class Developer : IssueHandler
    {
        public override void Handle(Issue issue)
        {
            if (issue.Level == IssueLevel.VerySimple || issue.Level == IssueLevel.Simple)
            {
                Log(nameof(Developer), issue);
            }
            else
            {
                Handler.Handle(issue);
            }
        }
    }
}
