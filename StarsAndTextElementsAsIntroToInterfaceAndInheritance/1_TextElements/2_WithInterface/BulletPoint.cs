namespace StarsAndTextElementsAsIntroToInterfaceAndInheritance._1_TextElements._2_WithInterface
{
    internal class BulletPoint : ITextElement
    {
        private string _text;

        public BulletPoint(string text)
        {
            _text = text;
        }

        public void Show()
        {
            Console.Write(" * ");
            Console.WriteLine(_text);
        }
    }
}
