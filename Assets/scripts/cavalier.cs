using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cavalier : posi
{
   public override bool [,] PossibleMove ()
    {
        bool[,] r = new bool[8, 8];

        // saut a gauche 
        chMove(currentX - 1, currentY + 2, ref r);

        // saut a droit 
        chMove(currentX + 1, currentY + 2, ref r);

        // devant a gauche 
        chMove(currentX + 2, currentY + 1, ref r);

        // devant a droit 
        chMove(currentX + 2, currentY  -1, ref r);

        // d a gauche 
        chMove(currentX - 1, currentY - 2, ref r);

        // d a droit 
        chMove(currentX + 1, currentY - 2, ref r);

        //  a gauche 
        chMove(currentX - 2, currentY + 1, ref r);

        //  a droit 
        chMove(currentX - 2, currentY - 1, ref r);




        return r;
    }

    public void chMove(int x,int y,ref bool[,] r)
    {
        posi c;
        if(x >= 0 && x < 8 && y >= 0 && y < 8)
        {
            c = plateau.Instance.posis[x, y];
            if (c == null)
                r[x, y] = true;
            else if (isWhite != c.isWhite)
                r[x, y] = true;

        } 
    }
}
