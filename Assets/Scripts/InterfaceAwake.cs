using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InterfaceAwake : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameManager.stonesThrown = 0;
        GameManager.stonesDestroyed = 0;
        GameManager.points = 0;
        Time.timeScale = 3;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ClickPlay() {
        SceneManager.LoadScene("Difficulty");
    }

    public void ClickOptions() {
        SceneManager.LoadScene("NormalStoneGame");
    }

    public void ClickExit() {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }
}
