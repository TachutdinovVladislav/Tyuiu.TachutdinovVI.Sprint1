using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.TachutdinovVI.Sprint1.Task6.V8.Lib
{
    public class DataService : ISprint1Task6V8
    {
        public string MoveLetterToEnd(string value)
        {
            string[] words = value.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > 1)
                    words[i] = words[i].Substring(1) + words[i][0];
            }
            return string.Join(" ", words);
        }
    }
}