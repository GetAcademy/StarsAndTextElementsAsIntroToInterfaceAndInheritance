namespace StarsAndTextElementsAsIntroToInterfaceAndInheritance._1_TextElements._2_WithInterface
{
    internal class RightAlignedText : ITextElement
    {
        private readonly string _text;

        public RightAlignedText(string text)
        {
            _text = text;
        }

        public void Show()
        {
            var col = Console.BufferWidth - _text.Length;
            Console.CursorLeft = col;
            Console.Write(_text);
        }
    }
}
