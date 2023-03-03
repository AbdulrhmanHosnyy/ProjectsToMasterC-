namespace NumberTheory.Models
{
    public class OctalSystem : Base
    {
        public OctalSystem(string value)
        {
            value.Guard("01234567", NumberBase.OCTAL);
            this.Value = value;
        }
    }
}
