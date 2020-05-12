using DesignPatterns.Core;

namespace ChainOfResponsibilityPattern
{
    public abstract class IssueHandler
    {
        protected IssueHandler Handler;

        public void SetHandler(IssueHandler handler)
        {
            Handler = handler;
        }

        public virtual void Log(string handledBy, Issue issue)
        {
            LogHelper.Log($"Issue with level: {issue.Level} handled by {handledBy}");
        }

        public abstract void Handle(Issue issue);
    }
}
