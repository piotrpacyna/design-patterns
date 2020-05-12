namespace ChainOfResponsibilityPattern
{
    public class Issue
    {
        public IssueLevel Level { get; }

        public Issue(IssueLevel level)
        {
            Level = level;
        }
    }
}
