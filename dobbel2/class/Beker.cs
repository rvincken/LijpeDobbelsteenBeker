using System.Collections.Generic;
using System.Drawing;
using System.Numerics;
using System.Security.Cryptography;

namespace dobbel2;

public class Beker
{
    public List<Dobbelsteen> Dobbels = new List<Dobbelsteen>{};


    public Beker(List<Dobbelsteen> dobbelstenen)
    {
        Dobbels = dobbelstenen; 
    }   
    public List<int> DoeWorp()
    {
        List<int> geworpenDobbels = new List<int>{};
        foreach (Dobbelsteen dobbel in Dobbels)
        {
            geworpenDobbels.Add(dobbel.Dobbel());

        }
        return geworpenDobbels;

    }
}