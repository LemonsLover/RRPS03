namespace RRPS03
{
    public interface ITarget
    {
        string GetRequest();
    }

    class Adaptee
    {
        public string GetSpecificRequest()
        {
            return "Specific request.";
        }
    }

    class Adapter : ITarget
    {
        private readonly Adaptee adaptee;

        public Adapter(Adaptee adaptee)
        {
            this.adaptee = adaptee;
        }

        public string GetRequest()
        {
            return $"This is '{this.adaptee.GetSpecificRequest()}'";
        }
    }
}
