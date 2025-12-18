namespace StarsAndTextElementsAsIntroToInterfaceAndInheritance._1_TextElements._3_WithInheritance
{
    internal class InvertedText : TextElement
    {
        public InvertedText(string text):base(text)
        {
        }

        public override void Show()
        {
            var foreColor = Console.ForegroundColor;
            var backColor = Console.BackgroundColor;
            Console.ForegroundColor = backColor;
            Console.BackgroundColor = foreColor;
            base.Show();
            Console.WriteLine();
            Console.ForegroundColor = foreColor;
            Console.BackgroundColor = backColor;
        }
    }
}
