using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class plateau : MonoBehaviour
{

    public static plateau Instance { set; get; }
    private bool[,] allowedMoves { set; get; }
    public posi[,] posis { set; get; }
    private posi selectedposi;

    private const float T_SIZE = 1.0f;
    private const float T_OFFSET = 0.5f;

    private int selectionX = -1;
    private int selectionY = -1;

    public List<GameObject> pieces;
    private List<GameObject> activegame;

    private Quaternion orientation = Quaternion.Euler(0, 180, 0);

    public bool isWhiteTurn = true;

    private void Start()
    {
        Instance = this;
        spawall();
    }

    private void Update()
    {
        Drawchess();
        UpSelection();


        if (Input.GetMouseButtonDown(0))
        {
            if (selectionX >= 0 && selectionY >= 0)
            {
                if (selectedposi == null)
                {
                    // dp des pieces
                    Selectposi(selectionX, selectionY);
                }
                else
                {
                    // dp
                    Move(selectionX, selectionY);
                }
            }
        }
    }

    private void Selectposi(int x,int y)
    {
        if (posis[x, y] == null)
            return;

        if (posis[x, y].isWhite != isWhiteTurn)
            return;

        bool hasAtleastOnMove = false;

        allowedMoves = posis[x, y].PossibleMove();
        for (int i = 0; i < 8; i++)
            for (int j = 0; j < 8; j++)
                if (allowedMoves[i, j])
                    hasAtleastOnMove = true;
        selectedposi = posis[x, y];

        BoardHighlights.Instance.HighlightAllowedMoves(allowedMoves);
    }

    private void Move(int x, int y)
    {
        if (allowedMoves[x,y])
        {

            posi c = posis[x, y];

            if (c != null && c.isWhite != isWhiteTurn)
            {
                //roi

                if (c.GetType() == typeof(roi))
                {
                    // fin du jeu
                    End();
                  

                    //return;
                }
                //bouffer la piece
                activegame.Remove(c.gameObject);
                Destroy(c.gameObject);
            }
            posis [selectedposi.currentX, selectedposi.currentY] = null;
            selectedposi.transform.position = Getcenter(x, y);
            selectedposi.SetPosition(x, y);
            posis[x, y] = selectedposi;
            isWhiteTurn = !isWhiteTurn;
        }

        BoardHighlights.Instance.Hidehighlights();
        selectedposi = null;
    }

    private void UpSelection()
    {
        if (!Camera.main)
            return;

        RaycastHit hit;
        if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 25.0f, LayerMask.GetMask("plateau")))
        {
            selectionX = (int)hit.point.x;
            selectionY = (int)hit.point.z;

        }
        else
        {
            selectionX = -1;
            selectionY = -1;
        }

    }

    private void Spawn(int index,int x,int y)
    {
        GameObject bouge = Instantiate(pieces[index], Getcenter(x,y), Quaternion.identity) as GameObject;
        bouge.transform.SetParent(transform); //Quaternion.identity a la place de orientation ou l'inverse pour faire pivoter les  pieces 
       posis[x,y] = bouge.GetComponent<posi>();
        posis[x, y].SetPosition(x, y);
        activegame.Add(bouge);
         
    }

    private Vector3 Getcenter(int x,int y)
    {
        Vector3 origin = Vector3.zero;
        origin.x += (T_SIZE * x) + T_OFFSET;
        origin.z += (T_SIZE * y) + T_OFFSET;
        return origin;
    }

    private void spawall()
    {
        // le positionnement des pieces 

        activegame = new List<GameObject>();
        posis = new posi[8, 8];

        // bouger le coté blanc

        // le roi

        Spawn(0,3, 0);

        // la reine 

        Spawn(1,4,0);

        // la tour
        Spawn(2,0, 0);
        Spawn(2,7, 0);

        // le fou
        Spawn(3,2, 0);
        Spawn(3,5, 0);

        // le cavalier
        Spawn(4,1, 0);
        Spawn(4,6, 0);

        // le pion
        for (int i = 0; i < 8; i++)
            Spawn(5,i, 1);


        // le positionnement des pieces 

        activegame = new List<GameObject>();

        // bouger le coté noir

        // le roi

        Spawn(6,3,7);

        // la reine 

        Spawn(7,4, 7);

        // la tour
        Spawn(8,0, 7);
        Spawn(8,7, 7);

        // le fou
        Spawn(9,2, 7);
        Spawn(9,5, 7);

        // le cavalier
        Spawn(10,1, 7);
        Spawn(10,6, 7);

        // le pion
        for (int i = 0; i < 8; i++)
            Spawn(11,i, 6);

    }

    private void Drawchess()
    {
        Vector3 widthLine = Vector3.right * 8;
        Vector3 heightLine = Vector3.forward * 8;

        for (int i = 0; i <= 8; i++)
        {
            Vector3 start = Vector3.forward * i;
            Debug.DrawLine(start, start + widthLine);
            for (int f = 0; f <= 8; f++)
            {
                start = Vector3.right * f;
                Debug.DrawLine(start, start + heightLine);
            }
        }

        //  POUR NAVIGUER

        if (selectionX >= 0 && selectionY >= 0)
        {
            Debug.DrawLine(
                Vector3.forward * selectionY + Vector3.right * selectionX,
                Vector3.forward * (selectionY + 1) + Vector3.right * (selectionX + 1));

            Debug.DrawLine(
               Vector3.forward * (selectionY + 1) + Vector3.right * selectionX,
               Vector3.forward * selectionY + Vector3.right * (selectionX + 1));  
        }
    }

    private void End()
    {
        if (isWhiteTurn)
            Debug.Log("LES BLANCS GANENT");
        else
            Debug.Log("LES NOIRS ONT GAGNE");

        foreach (GameObject go in activegame)
            Destroy(go);

        isWhiteTurn = true;
        BoardHighlights.Instance.Hidehighlights();
        spawall();
       // yield return new WaitForSeconds(3);

       SceneManager.LoadScene(0);

    }


}
