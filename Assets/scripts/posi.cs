using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class posi : MonoBehaviour
{
    public int currentX { set; get; }
    public int currentY { set; get; }
    public bool isWhite;

    public void SetPosition(int x,int y)
    {
        currentX = x;
        currentY = y;
    }

    public virtual bool[,] PossibleMove()
    {
        return new bool[8,8];
    }
}
 