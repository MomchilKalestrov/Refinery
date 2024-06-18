namespace Refinery
{
    public static class Lexer
    {
        public static Lesson[] ParseTimetable(string toParse)
        {
            TimeOnly previous = TimeOnly.MinValue;
            Stack<Lesson> lessons = [];
            string[] tokens = toParse.Split('\n');

            if (toParse.Length < 7 || !toParse.Contains('-') || !toParse.Contains(':'))
                throw new Exception("The lexer failed to parse the timetable. <0>");

            for (int i = 0; i < tokens.Length; i++)
            {
                TimeOnly start = TimeOnly.Parse(tokens[i].Split('-')[0].Trim());
                TimeOnly end = TimeOnly.Parse(tokens[i].Split('-')[1].Trim());

                if (start >= end || start <= previous)
                    throw new Exception($"The lexer failed to parse the timetable. <{i}>");

                lessons.Push(new Lesson
                {
                    Start = start,
                    End = end
                });

                previous = end;
            }
            return [.. lessons];
        }
    }
}
