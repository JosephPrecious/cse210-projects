using System;
using System.Collections.Generic;

public class ScriptureLibrary
{
    private List<Scripture> _scriptures;

    public ScriptureLibrary()
    {
        _scriptures = new List<Scripture>
        {
            new Scripture(new Reference("John", 3, 16), "For God so loved the world that he gave his only begotten Son, that whosoever believeth in him should not perish but have everlasting life."),
            new Scripture(new Reference("Proverbs", 3, 5), "Trust in the Lord with all thine heart and lean not unto thine own understanding. In all thy ways acknowledge him and he shall direct thy paths."),
            new Scripture(new Reference("Psalm", 23, 1), "The Lord is my shepherd I shall not want. He maketh me to lie down in green pastures he leadeth me beside the still waters. He restoreth my soul.")
        };
    }

    public Scripture GetRandomScripture()
    {
        Random random = new Random();
        int index = random.Next(_scriptures.Count);
        return _scriptures[index];
    }
}
