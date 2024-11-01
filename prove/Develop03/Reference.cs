using System;
using System.Collections.Generic;
using System.Linq;

class Reference
{
    private string book;
    private int chapter;
    private int startVerse;
    private int? endVerse; 

    public Reference(string book, int chapter, int startVerse)
    {
        this.book = book;
        this.chapter = chapter;
        this.startVerse = startVerse;
        this.endVerse = null;
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        this.book = book;
        this.chapter = chapter;
        this.startVerse = startVerse;
        this.endVerse = endVerse;
    }

    public override string ToString()
    {
        if (endVerse.HasValue)
            return $"{book} {chapter}:{startVerse}-{endVerse}";
        else
            return $"{book} {chapter}:{startVerse}";
    }
}