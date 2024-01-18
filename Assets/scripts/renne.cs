using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class renne : posi
{
   public override bool[,] PossibleMove ()
    {

        bool[,] r = new bool[8, 8];

        posi c;
        int i,j;

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
            if (i >= 8)
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
