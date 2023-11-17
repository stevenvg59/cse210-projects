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

    }

    public bool isHidden()
    {
        return false;
    }

    public string GetDisplayText()
    {
        return "";
    }
}