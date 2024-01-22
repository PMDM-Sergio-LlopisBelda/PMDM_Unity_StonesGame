using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InterfaceDifficulty : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameManager.stonesThrown = 0;
        GameManager.stonesDestroyed = 0;
        GameManager.points = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ClickEasy() {
        SceneManager.LoadScene("EasyStoneGame");
    }

    public void ClickNormal() {
        SceneManager.LoadScene("NormalStoneGame");
    }

    public void ClickHard() {
        SceneManager.LoadScene("HardStoneGame");
    }

    public void ClickRules() {
        SceneManager.LoadScene("Rules");
    }
}
