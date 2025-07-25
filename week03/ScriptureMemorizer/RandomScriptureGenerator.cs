using System;

public class RandomScriptureGenerator

{
    private List<Scripture> _scriptures = new List<Scripture>();
    public RandomScriptureGenerator()
    {

        _scriptures.Add(new Scripture(new Reference("John", 3, 16, 17), "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.\nFor God sent not his Son into the world to condemn the world; but that the world through him might be saved."));
        _scriptures.Add(new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all thine heart; and lean not unto thine own understanding.\nIn all thy ways acknowledge him, and he shall direct thy paths."));
        _scriptures.Add(new Scripture(new Reference("James", 1, 5, 6), "If any of you lack wisdom, let him ask of God, that giveth to all men liberally, and upbraideth not; and it shall be given him.\nBut let him ask in faith, nothing wavering. For he that wavereth is like a wave of the sea driven with the wind and tossed."));
        _scriptures.Add(new Scripture(new Reference("Isaiah", 41, 10), "Fear thou not; for I am with thee: be not dismayed; for I am thy God: I will strengthen thee; yea, I will help thee; yea, I will uphold thee with the right hand of my righteousness."));
        _scriptures.Add(new Scripture(new Reference("Ruth", 1, 17), "And Ruth said, Entreat me not to leave thee, or to return from following after thee: for whither thou goest, I will go; and where thou lodgest, I will lodge: thy people shall be my people, and thy God my God."));
        _scriptures.Add(new Scripture(new Reference("Romans", 8, 28), "And we know that all things work together for good to them that love God, to them who are the called according to his purpose."));
        _scriptures.Add(new Scripture(new Reference("Genesis", 1, 26), "And God said, Let us make man in our image, after our likeness: and let them have dominion over the fish of the sea, and over the fowl of the air, and over the cattle, and over all the earth, and over every creeping thing that creepeth upon the earth."));
        _scriptures.Add(new Scripture(new Reference("Corinthians", 13, 4, 8), "Charity suffereth long, and is kind; charity envieth not; charity vaunteth not itself, is not puffed up,\nDoth not behave itself unseemly, seeketh not her own, is not easily provoked, thinketh no evil;\nRejoiceth not in iniquity, but rejoiceth in the truth;\nBeareth all things, believeth all things, hopeth all things, endureth all things.\nCharity never faileth: but whether there be prophecies, they shall fail; whether there be tongues, they shall cease; whether there be knowledge, it shall vanish away."));
        _scriptures.Add(new Scripture(new Reference("Matthew", 22, 37, 38), "Jesus said unto him, Thou shalt love the Lord thy God with all thy heart, and with all thy soul, and with all thy mind.\nThis is the first and great commandment."));
    }

    public Scripture GetRandomScripture()
    {
        Random _randomScripture = new Random();
        int index = _randomScripture.Next(_scriptures.Count);
        return _scriptures[index];
    }

}