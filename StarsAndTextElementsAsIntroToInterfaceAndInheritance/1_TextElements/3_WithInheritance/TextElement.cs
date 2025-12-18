namespace StarsAndTextElementsAsIntroToInterfaceAndInheritance._1_TextElements._3_WithInheritance
{
    internal class TextElement
    {
        public string Text { get; }

        public TextElement(string text)
        {
            Text = text;
        }

        public virtual void Show()
        {
            Console.Write(Text);
        }
    }
}
