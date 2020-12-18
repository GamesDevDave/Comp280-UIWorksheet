using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCR_Pausing : MonoBehaviour
{
    
    private SCR_UIInteraction uiScript;

    private bool isPaused = false;

    private void Start() 
    {
        uiScript = GetComponent<SCR_UIInteraction>();
    }
    public void CheckForPause()
    {
        if(uiScript.pausePressed)
        {
            if(isPaused)
            {
                Time.timeScale = 0;
                Debug.Log("Testing Pause");
            }

            else
            {
                Time.timeScale = 1;
                Debug.Log("Testing Resume");
            }
        }
    }
}
