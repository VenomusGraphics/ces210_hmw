public class MathAssignment : Assignments
{
    private string _textbook;
    private string _problems;

    public MathAssignment(string studentName, string topic, string textbook, string problems)
        : base(studentName, topic)
    { 
        _textbook = textbook;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"Textbook: {_textbook}, Problems: {_problems}";
    }
}