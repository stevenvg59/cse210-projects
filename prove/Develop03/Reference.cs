public class Reference{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse = 0;


    //Two constructors:
    // 1. With a single verse
    // 2. With a block of verses (start & end verses)
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }

    public string GetDisplayText()
    {
        string result;
        
        //It will display the end verse only if it exists
        if (_endVerse != 0)
        {   
            result = $"{_book} {_chapter}:{_verse}-{_endVerse} ";
        }
        else 
        {
            result = $"{_book} {_chapter}:{_verse} ";
        }

        return result;
    }
}