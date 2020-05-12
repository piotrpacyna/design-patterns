namespace ChainOfResponsibilityPattern
{
    public class LeadDeveloper : IssueHandler
    {
        public override void Handle(Issue issue)
        {
            if (issue.Level == IssueLevel.VeryHard)
            {
                Log(nameof(LeadDeveloper), issue);
            }
        }
    }
}
