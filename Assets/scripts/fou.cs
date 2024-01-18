using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fou : posi
{
   public override bool[,] PossibleMove ()
    {
        bool[,] r = new bool[8, 8];

        posi c;
        int i, j;

        // avance a droite
        i = currentX;
        j = currentY;

        while (true)
        {
            i--;
            j++;
            if (i < 0 || j >= 8)
                break;

            c = plateau.Instance.posis[i, j];
            if (c == null)
                r[i, j] = true;
            else
            {
                if (isWhite != c.isWhite)
                    r[i, j] = true;

                break;
            }

        }

        // avance a gauche
        i = currentX;
        j = currentY;

        while (true)
        {
            i++;
            j++;
            if (i >= 8 || j >= 8)
                break;

            c = plateau.Instance.posis[i, j];
            if (c == null)
                r[i, j] = true;
            else
            {
                if (isWhite != c.isWhite)
                    r[i, j] = true;

                break;
            }

        }

        // d a gauche
        i = currentX;
        j = currentY;

        while (true)
        {
            i--;
            j--;
            if (i < 0 || j < 0)
                break;

            c = plateau.Instance.posis[i, j];
            if (c == null)
                r[i, j] = true;
            else
            {
                if (isWhite != c.isWhite)
                    r[i, j] = true;

                break;
            }

        }


        // d a gauche
        i = currentX;
        j = currentY;

        while (true)
        {
            i++;
            j--;
            if (i >= 8 || j < 0)
                break;

            c = plateau.Instance.posis[i, j];
            if (c == null)
                r[i, j] = true;
            else
            {
                if (isWhite != c.isWhite)
                    r[i, j] = true;

                break;
            }

        }

        return r;

    }
}
