namespace TallerMecanico
{
    public class ComboboxItem
    {
        public ComboboxItem(object value, string text)
        {
            Text = text;
            Value = value;
        }

        public string Text { get; set; }
        public object Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}
