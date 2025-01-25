public class Reference
{
    private string _book;
    private int _startChapter;
    private int _startVerse;
    private int _endChapter;
    private int _endVerse;
    private bool _hasRange;

    public Reference(string book, int startChapter, int startVerse, int endChapter = 0, int endVerse = 0)
    {
        _book = book;
        _startChapter = startChapter;
        _startVerse = startVerse;
        _endChapter = endChapter;
        _endVerse = endVerse;
        _hasRange = endChapter > 0 && endVerse > 0;
    }

    public override string ToString()
    {
        if (_hasRange)
            return $"{_book} {_startChapter}:{_startVerse}-{_endVerse}";
        return $"{_book} {_startChapter}:{_startVerse}";
    }
}
