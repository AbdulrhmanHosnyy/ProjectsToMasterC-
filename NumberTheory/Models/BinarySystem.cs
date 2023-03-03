namespace NumberTheory.Models
{
    public class BinarySystem: Base
    {
        public BinarySystem(string value)
        {
            value.Guard("01",NumberBase.BINARY);
            this.Value = value; 
        }
    }
}
