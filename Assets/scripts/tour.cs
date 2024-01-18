using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tour : posi
{
    public override bool[,] PossibleMove()
    {
        bool[,] r = new bool[8, 8];

        posi c;
        int i;

        //gauche

    i = currentX;
    while (true)
        {

            i++;
            if (i >= 8)
                break;

            c = plateau.Instance.posis[i, currentY];
            if (c == null)
                r[i, currentY] = true;
            else
            {
                if (c.isWhite != isWhite)
                    r[i, currentY] = true;

                break;

            }
        }
            // droite

        i = currentX;
        while (true)
        {

            i--;
            if (i < 0)
                break;

            c = plateau.Instance.posis[i, currentY];
            if (c == null)
                r[i, currentY] = true;
            else
            {
                if (c.isWhite != isWhite)
                    r[i, currentY] = true;

                break;

            }


        }

        // devant

        i = currentY;
        while (true)
        {

            i++;
            if (i >= 8 )
                break;

            c = plateau.Instance.posis[currentX, i];
            if (c == null)
                r[currentX, i] = true;
            else
            {
                if (c.isWhite != isWhite)
                    r[currentX, i] = true;

                break;

            }
        }

        // derriere

        i = currentY;
        while (true)
        {

            i--;
            if (i < 0)
                break;

            c = plateau.Instance.posis[currentX, i];
            if (c == null)
                r[currentX, i] = true;
            else
            {
                if (c.isWhite != isWhite)
                    r[currentX, i] = true;

                break;

            }
        }

        return r;
    }   
}
