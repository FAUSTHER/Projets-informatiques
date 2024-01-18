using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pion : posi
{
   public override bool[,] PossibleMove()
    {
        bool[,] r = new bool[8, 8];
        posi c, c2;
        
        //les blancs
        if (isWhite)
        {
            // bouffer a gauche
            if (currentX != 0 && currentY != 7)
            {
                c = plateau.Instance.posis[currentX - 1, currentY + 1];
                if (c != null && !c.isWhite)
                    r[currentX - 1, currentY + 1] = true;

            }
            // bouffer a droite
            if (currentX != 7 && currentY != 7)
            {
                c = plateau.Instance.posis[currentX + 1, currentY + 1];
                if (c != null && !c.isWhite)
                    r[currentX + 1, currentY + 1] = true;

            }

            //milieu
            if (currentY != 7)
            {
                c = plateau.Instance.posis[currentX, currentY + 1];
                if (c == null)
                    r[currentX, currentY + 1] = true;
            }


            // premier mouvement
            if (currentY == 1)
            {
                c = plateau.Instance.posis[currentX, currentY + 1];
                c2= plateau.Instance.posis[currentX, currentY + 2];
                if (c == null & c2 == null)
                    r[currentX, currentY + 2] = true;


            }

        } else
        {
            // bouffer a gauche
            if (currentX != 0 && currentY != 0)
            {
                c = plateau.Instance.posis[currentX - 1, currentY - 1];
                if (c != null && c.isWhite)
                    r[currentX - 1, currentY - 1] = true;

            }
            // bouffer a droite
            if (currentX != 7 && currentY != 0)
            {
                c = plateau.Instance.posis[currentX + 1, currentY - 1];
                if (c != null && c.isWhite)
                    r[currentX + 1, currentY - 1] = true;

            }

            //milieu
            if (currentY != 0)
            {
                c = plateau.Instance.posis[currentX, currentY - 1];
                if (c == null)
                    r[currentX, currentY - 1] = true;
            }


            // premier mouvement
            if (currentY == 6)
            {
                c = plateau.Instance.posis[currentX, currentY - 1];
                c2 = plateau.Instance.posis[currentX, currentY - 2];
                if (c == null & c2 == null)
                    r[currentX, currentY - 2] = true;


            }
        }


        return r;
    }
}
