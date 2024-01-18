using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roi : posi
{

    public override bool[,] PossibleMove()
    {

        bool[,] r = new bool[8, 8];

        posi c;
        int i, j;

        // mouveent h

        i = currentX - 1;
        j = currentY + 1;

        if (currentY != 7)
        {

            for (int k = 0; k < 3; k++)
            {
                if (i >= 0 || i < 8)
                {
                    c = plateau.Instance.posis[i, j];
                    if (c == null)
                        r[i, j] = true;
                    else if (isWhite != c.isWhite)
                        r[i, j] = true;
                }

                i++;
            }

        }

        // mouveent h

        i = currentX - 1;
        j = currentY - 1;

        if (currentY != 0)
        {

            for (int k = 0; k < 3; k++)
            {
                if (i >= 0 || i < 8)
                {
                    c = plateau.Instance.posis[i, j];
                    if (c == null)
                        r[i, j] = true;
                    else if (isWhite != c.isWhite)
                        r[i, j] = true;
                }

                i++;
            }

        }

        // d droit
        if (currentX != 0)
        {
            c = plateau.Instance.posis[currentX - 1, currentY];
            if (c == null)
                r[currentX - 1, currentY]  = true;
            else if (isWhite != c.isWhite)
                r[currentX - 1, currentY] = true;
        }

        // d gauche
        if (currentX != 7)
        {
            c = plateau.Instance.posis[currentX + 1, currentY];
            if (c == null)
                r[currentX + 1, currentY] = true;
            else if (isWhite != c.isWhite)
                r[currentX + 1, currentY] = true;
        }


        return r;
 
    }

}
