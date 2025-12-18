namespace StarsAndTextElementsAsIntroToInterfaceAndInheritance._1_TextElements._3_WithInheritance
{
    internal class RightAlignedText : TextElement
    {
        public RightAlignedText(string text) : base(text)
        {
        }

        public override void Show()
        {
            var col = Console.BufferWidth - Text.Length;
            Console.CursorLeft = col;
            base.Show();
        }
    }
}
