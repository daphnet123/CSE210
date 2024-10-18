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

class Word
{
    private string text;
    private bool hidden;

    public Word(string text)
    {
        this.text = text;
        this.hidden = false; 
    }

    public void Hide()
    {
        hidden = true;
    }

    public bool IsHidden()
    {
        return hidden;
    }

    public override string ToString()
    {
        return hidden ? "_____" : text;
    }
}

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

class Scriptures
{
    public static Dictionary<string, string> GetRandomScriptures()
    {
        return new Dictionary<string, string>
        {
            { "1 Nephi 3:7", "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them." },
            { "2 Nephi 2:25", "Adam fell that men might be; and men are, that they might have joy." },
            { "2 Nephi 2:27", "Wherefore, men are free according to the flesh; and all things are given them which are expedient unto man. And they are free to choose liberty and eternal life, through the great Mediator of all men, or to choose captivity and death, according to the captivity and power of the devil; for he seeketh that all men might be miserable like unto himself." },
            { "2 Nephi 9:28-29", "O that cunning plan of the evil one! O the vainness, and the frailties, and the foolishness of men! When they are learned they think they are wise, and they hearken not unto the counsel of God, for they set it aside, supposing they know of themselves, wherefore, their wisdom is foolishness and it profiteth them not. And they shall perish. But to be learned is good if they hearken unto the counsels of God." },
            { "Alma 32:21", "And now as I said concerning faith—faith is not to have a perfect knowledge of things; therefore if ye have faith ye hope for things which are not seen, which are true." },
            { "Moroni 7:41", "And what is it that ye shall hope for? Behold I say unto you that ye shall have hope through the atonement of Christ and the power of his resurrection, to be raised unto life eternal, and this because of your faith in him according to the promise." },
            { "Moroni 7:45, 47-48", "And charity suffereth long, and is kind, and envieth not, and is not puffed up, seeketh not her own, is not easily provoked, thinketh no evil, and rejoiceth not in iniquity but rejoiceth in the truth, beareth all things, believeth all things, hopeth all things, endureth all things. But charity is the pure love of Christ, and it endureth forever; and whoso is found possessed of it at the last day, it shall be well with him. Wherefore, my beloved brethren, pray unto the Father with all the energy of heart, that ye may be filled with this love, which he hath bestowed upon all who are true followers of his Son, Jesus Christ; that ye may become the sons of God; that when he shall appear we shall be like him, for we shall see him as he is; that we may have this hope; that we may be purified even as he is pure. Amen." },
            { "Moroni 10:4-5", "And when ye shall receive these things, I would exhort you that ye would ask God, the Eternal Father, in the name of Christ, if these things are not true; and if ye shall ask with a sincere heart, with real intent, having faith in Christ, he will manifest the truth of it unto you, by the power of the Holy Ghost. And by the power of the Holy Ghost ye may know the truth of all things." }
        };
    }
}
