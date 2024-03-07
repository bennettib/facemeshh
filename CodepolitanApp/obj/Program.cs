namespace CodepolitanApp
{
    using System;

    internal class program
    {
        public static void main(
            string[] args)
        {
            console.WriteLine(@"Hello CodePolitan!");

            for (var i = 0; i < 26; i++)
            {
                var c = i;
                console.Write(Convert.ToChar(c + 'a') + "");
            }

            console.Write(Environment.NewLine);
        }
    }
}