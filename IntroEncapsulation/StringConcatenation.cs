using System.Text;

namespace IntroEncapsulation
{
    internal class StringConcatenation
    {

        public void Dummy()
        {
            var number = 123.45;
            Console.WriteLine("Variabel: " + number);
            Console.WriteLine($"Variabel: {number:G4}");

            var name = "tejr";

            string s1 = "";
            string s2 = string.Empty;

            var s3 = "Hei";
            s3 = s3 + "på";
            s3 = s3 + "deg";

            var text = new StringBuilder();
            text.AppendLine("Hei");
            text.AppendLine("på");
            text.AppendLine("deg");
            var sa = text.ToString();

            var sb = new StringBuilder()
                .AppendLine("Hei")
                .AppendLine("på")
                .AppendLine("deg")
                .ToString();
        }
    }
}
