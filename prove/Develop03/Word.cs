public class Word{
    public string _text;
    public bool _isHidden = false;

    public Word()
    {
        _text = "";
    }

    public void Hide()
    {
        //Creating a new string with '_' instead of the characters. We use length in order to put the same
        // amount of characters
        _text = new string('_', _text.Length);
        _isHidden = true;
    }

    public void Show()
    {
        //Displaying the word and a space
        Console.Write(_text + " ");
    }

    public bool isHidden()
    {
        //FOR STRETCH CHALLENGE: I WAS ABLE TO RAMDONLY SELECT ANY WORD BUT ONLY FROM THOSE WORDS THAT ARE NOT ALREADY HIDDEN
        // ...
        //Checking if the word is hidden (replaced with underscores "_") or not
        if (_text != "_"){
            return false;
        }
        else {
            return true;
        }
        
    }

    public string GetDisplayText()
    {
        //Adding a space between words
        return _text + " ";
    }
}