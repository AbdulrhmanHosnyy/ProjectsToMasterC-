namespace NumberTheory.Models
{
    public class HexadecimalSystem : Base
    {
        public HexadecimalSystem(string value)
        {
            value.Guard("0123456789ABCDEFabcdef", NumberBase.HEXADECIMAL);
            this.Value = value;
        }
    }
}
