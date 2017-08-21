namespace PrototypePattern.StructuralCode
{
    class ConcretePrototype2 : Prototype
    {
        // Constructor
        public ConcretePrototype2(string id)
          : base(id)
        {
        }

        // Returns a shallow copy
        public override Prototype Clone()
        {
            return (Prototype)MemberwiseClone();
        }
    }
}