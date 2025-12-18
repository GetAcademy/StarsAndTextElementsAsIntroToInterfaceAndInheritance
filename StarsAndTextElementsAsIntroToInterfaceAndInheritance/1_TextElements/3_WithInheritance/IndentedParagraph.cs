namespace StarsAndTextElementsAsIntroToInterfaceAndInheritance._1_TextElements._3_WithInheritance
{
    internal class IndentedParagraph : TextElement
    {
        public IndentedParagraph(string text): base(text)
        {
        }

        public override void Show()
        {
            Console.CursorLeft = 4;
            base.Show();
            Console.WriteLine();
        }
    }
}
