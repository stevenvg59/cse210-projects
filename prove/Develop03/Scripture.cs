public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        //The process of splitting the string text into a list of words
        //   and then adding them to the _words<Word> list
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
        //Displaying first the reference
        Console.Write(_reference.GetDisplayText());

        //Displaying each word
        foreach(Word word in _words)
        {
            Console.Write(word.GetDisplayText());
        }
    }

    public void HideRandomWords(int numberToHide) //You can change this value in Main
    {
        Random random = new Random();

        //A counter for words being replaced
        int wordsReplaced = 0;

        while (wordsReplaced < numberToHide)
        {
            //Getting random index for hiding
            int randomIndex = random.Next(_words.Count);

            //FOR STRETCH CHALLENGE: I WAS ABLE TO RAMDONLY SELECT ANY WORD BUT ONLY FROM THOSE WORDS THAT ARE NOT ALREADY HIDDEN
            // ...
            //Checking if the Word is already hidden
            if (_words[randomIndex]._isHidden == false)
            {
                //If not, then, proceed to hide it
                _words[randomIndex].Hide();
                //Counter incrementing
                wordsReplaced++;
            }
        }
    }

    public bool IsCompletelyHidden()
    {
        //Initializing a counter for the hidden words
        int count = 0;

        //Iterating word by word
        foreach(Word word in _words)
        {
            if(word._isHidden)
            {
                //If is hidden, the counter increments
                count++;
            }
        }

        if (count < _words.Count)
        {
            //If the counter is less than the total of words means that there are words 
            //   that are not hidden
            return false;
        }
        else {
            //This means that there are not any word hidden
            return true;
        }
        
    }

}