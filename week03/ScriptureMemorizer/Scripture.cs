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
        Random randomNumber = new Random();
        int index = randomNumber.Next(_words.Count);
        return _words[index];


    }

    public string GetDisplayText()
    {

    }

    public bool CompletelyHidden()
    {

    }

}