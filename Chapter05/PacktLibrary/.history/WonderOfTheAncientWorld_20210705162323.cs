namespace Packt.Shared
{
    [System.Flags]
    public enum WonderOfTheAncientWorld
    {
        none                        = 0b_0000_0000, // i.e. 0
        GreatPyramidOfGiza          = 0b_0000_0001, // i.e. 1
        HangingGardensOfBabylon     = 0b_0000_0010, // i.e. 2
        StatueOfZeusAtOlympia       = 0b_0000_,
        TempleOfArtemisAtEphesus,
        MausoleumAtHalicarnassus,
        ColossusOfRhodes,
        LighthouseOfAlexandria
    }
}