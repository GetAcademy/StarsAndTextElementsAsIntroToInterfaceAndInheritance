namespace StarsAndTextElementsAsIntroToInterfaceAndInheritance._1_TextElements._2_WithInterface
{
    internal class IndentedParagraph : ITextElement
    {
        private string _text;

        public IndentedParagraph(string text)
        {
            _text = text;
        }

        public void Show()
        {
            Console.CursorLeft = 4;
            Console.WriteLine(_text);
        }
    }
}
