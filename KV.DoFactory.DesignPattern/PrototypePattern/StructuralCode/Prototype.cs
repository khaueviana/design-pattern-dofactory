namespace PrototypePattern.StructuralCode
{
    abstract class Prototype
    {
        private string _id;

        // Constructor
        public Prototype(string id)
        {
            _id = id;
        }

        // Gets id
        public string Id
        {
            get { return _id; }
        }

        public abstract Prototype Clone();
    }
}