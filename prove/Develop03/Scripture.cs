public class Scripture 
{
    public List<Word> words;
    // public scripture constructor
    public Scripture () {
        words = new List<Word>();
        string scripture = "And he fell to the earth, and heard a voice saying unto him, Saul, Saul, why persecutest thou me?";
        string [] scriptureList = scripture.Split(" ");
        
        foreach (string word in scriptureList)
        {
            Word newWord = new Word();
            newWord.text = word;
            newWord.isHidden = false;
            words.Add(newWord);
        }
    }
    public void HideWord()
    {
        if (this.AllWordsHidden()) return;

        Random random = new Random();
        int randi;
        do {
            randi = random.Next(this.words.Count);
        } while(words[randi].isHidden);

        words[randi].isHidden = true;
    }

    public bool AllWordsHidden() {
        // Check if all words are hidden or not
        foreach (Word word in this.words) 
        {
            if (!word.isHidden)
            {
                return false;
            }
        }
        return true;
    }
}