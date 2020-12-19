using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCR_Pausing : MonoBehaviour
{
    
    private SCR_UIInteraction uiScript;
    public GameObject pauseMenu;

    private bool isPaused = false;

    private void Start() 
    {
        uiScript = GetComponent<SCR_UIInteraction>();
    }
    public void CheckForPause()
    {
        if(uiScript.pausePressed)
        {
            Time.timeScale = 0;
            Debug.Log("Testing Pause");
            pauseMenu.SetActive(true);
        }
    }
    public void CheckForUnpause()
    {
        if(!uiScript.pausePressed)
        {
            Unpause();
        }
    }

    public void Unpause()
    {
        Time.timeScale = 0;
        Debug.Log("Testing Pause");
        pauseMenu.SetActive(false);
    }
}
