using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MENU : MonoBehaviour
{
    public void play()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
          
    }

    public void quitter()
    {
        Debug.Log("VOUS AVEZ QUITTER LE JEU");
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit ();
#endif
    }
    //Debug.Log("VOUS AVEZ QUITTER LE JEU");
    //Application.Quit();
}

