namespace IntroEncapsulation
{
    internal class Resharper
    {
        /*
         * De viktigste refactoringsene
         *  - Extract Variable CTRL-R CTRL-V
         *  - Inline Variable  CTRL-R CTRL-I
         *  - Extract Method   CTRL-R CTRL-M
         *  - Extract Class
         *
         */

        public void Dummy()
        {
            var a = 5;
            var b = 3;

            var product = Multiply(a, b);
            var c = product + 8;
            var d = product + 9;
        }

        private static int Multiply(int a, int b)
        {
            var product = a * b;
            return product;
        }
    }
}
