using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(w => new Word(w)).ToList();
    }

    public void HideWords(int count)
    {
        var visibleWords = _words.Where(word => !word.IsHidden()).ToList();
        Random random = new Random();

        for (int i = 0; i < count && visibleWords.Count > 0; i++)
        {
            int index = random.Next(visibleWords.Count);
            visibleWords[index].ToggleHidden();
            visibleWords.RemoveAt(index);
        }
    }

    public bool AllWordsHidden() => _words.All(word => word.IsHidden());

    public override string ToString()
    {
        return $"{_reference}\n{string.Join(" ", _words)}";
    }
}
