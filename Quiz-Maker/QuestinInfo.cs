namespace Quiz_Maker
{
    internal class AnswerInfo
    {
        public string Answer { get; set; }
        public bool IsCorrect { get; set; }

        // Constructor that initializes an AnswerInfo object with an answer and its correctness
        public AnswerInfo(string answer, bool isCorrect)
        {
            Answer = answer;
            IsCorrect = isCorrect;
        }
    }
}
