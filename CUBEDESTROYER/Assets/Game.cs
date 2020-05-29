using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Game : MonoBehaviour
{

    public float GameLength = 20f;
    public GameObject TimerAnzeige;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Timer();
    }

   void RestartGame()
    {
        Player.score = 0;
        GameLength = 20f;

    }



    void Timer()
    {
        GameLength -= Time.deltaTime;
        var anzeige = TimerAnzeige.GetComponent<TextMeshProUGUI>();
        anzeige.text = GameLength.ToString();

        if (GameLength < 0)
        {
            RestartGame();
        }
    }
}
