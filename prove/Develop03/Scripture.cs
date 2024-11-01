using System;
using System.Collections.Generic;
using System.Linq;

class Scripture
{
    private Reference reference;
    private List<Word> words;
    private Random random;

    public Scripture(Reference reference, string text)
    {
        this.reference = reference;
        this.words = text.Split(' ').Select(w => new Word(w)).ToList();
        this.random = new Random();
    }

    public void Display()
    {
        Console.WriteLine(reference.ToString()); 
        foreach (Word word in words)
        {
            Console.Write(word.ToString() + " ");
        }
        Console.WriteLine();
    }

    public void HideRandomWords(int count = 3)
    {
        List<Word> visibleWords = words.Where(w => !w.IsHidden()).ToList();

        for (int i = 0; i < count && visibleWords.Count > 0; i++)
        {
            int index = random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }

    public bool AllWordsHidden()
    {
        return words.All(w => w.IsHidden());
    }
}
