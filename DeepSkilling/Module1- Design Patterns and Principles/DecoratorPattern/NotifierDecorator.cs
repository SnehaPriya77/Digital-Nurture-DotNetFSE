namespace DecoratorPattern
{
    public abstract class NotifierDecorator : Notifier
    {
        protected Notifier notifier;

        protected NotifierDecorator(Notifier notifier)
        {
            this.notifier = notifier;
        }

        public virtual void Send(string message)
        {
            notifier.Send(message);
        }
    }
}