public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        string passage = text;
        string[] words = passage.Split();

        foreach(string word in words)
        {
            Word newWord = new Word();
            newWord._text = word;

            _words.Add(newWord);
        }
        
    }

    public void GetDisplayText()
    {
        Console.Write(_reference.GetDisplayText());
        foreach(Word word in _words)
        {
            Console.Write(word._text + " ");
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        int wordsReplaced = 0;

        while (wordsReplaced < numberToHide)
        {
            int randomIndex = random.Next(_words.Count);

            if (_words[randomIndex]._isHidden == false)
            {
                _words[randomIndex].Hide();
                wordsReplaced++;
            }
        }
    }

    public bool IsCompletelyHidden()
    {
        return false;
    }

}