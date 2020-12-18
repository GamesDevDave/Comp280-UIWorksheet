using UnityEngine;
using UnityEngine.SceneManagement;

public class SCR_UIInteraction : MonoBehaviour
{
    // Used whenever the play button has been pressed by the user.
        public void OnPlayPress() => SceneManager.LoadScene("SCN_MainGameScene", LoadSceneMode.Single);
}
