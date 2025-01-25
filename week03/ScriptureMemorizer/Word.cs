public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public bool IsHidden() => _isHidden;

    public void ToggleHidden() => _isHidden = true;

    public override string ToString()
    {
        return _isHidden ? new string('_', _text.Length) : _text;
    }
}
