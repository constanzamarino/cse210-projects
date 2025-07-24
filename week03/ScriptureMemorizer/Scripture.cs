using System;
using System.Collections.Generic;
using System.Linq;


public class Scripture
{

    public Reference _reference;

    private List<Word> _words;



    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] _splitWord = text.Split(' ');

        foreach (string word in _splitWord)
        {
            Word newWord = new Word(word);
            _words.Add(newWord);
        }
    }

    public Word HideRandomWords(int _numberToHide)
    {
       Random _randomNumber = new Random();
       int _hiddenCount = 0;

       while(_hiddenCount < _numberToHide)
       {
        
        int index = _randomNumber.Next(_words.Count)

        if (!_words[index].IsHidden())
        {
            _words[index].Hide()
            _hiddenCount++;
        }

       }


    }

    public string GetDisplayText()
    {

    }

    public bool CompletelyHidden()
    {

    }

}