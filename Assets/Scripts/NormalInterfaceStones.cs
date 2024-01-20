using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NormalInterfaceStones : MonoBehaviour
{
    public Text textThrown;
    public Text textDestroyed;
    public Text textPoints;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 5;
    }

    // Update is called once per frame
    void Update()
    {
        textThrown.text = "Number of Stones: " + GameManager.stonesThrown;
        textDestroyed.text = "Destroyed Stones: " + GameManager.stonesDestroyed;
        textPoints.text = "Points: " + GameManager.points;
    }
}
