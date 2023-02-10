using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScriptMenu : MonoBehaviour
{
    public string premierNiveau;
    public Button boutonDebuter;
    public Button boutonQuitter;


    public void LorsDebuter()
    {
        SceneManager.LoadScene(premierNiveau);
    }

    public void LorsQuitte()
    {
        Application.Quit();
        Debug.Log("Bye!");
    }

    public void LorsPause()
    {
        if (Time.timeScale > 0.5f)
        {
            Time.timeScale = 0.0f;
            boutonDebuter.interactable = false;
            boutonQuitter.interactable = false;
        }
        else
        { 
            Time.timeScale = 1.0f;
            boutonDebuter.interactable = true;
            boutonQuitter.interactable = true;
        }
    }
}
