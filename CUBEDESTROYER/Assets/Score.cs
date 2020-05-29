using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{

    void Update()
    {
        SetScore();
    }

    void SetScore()
    {
        var anzeige = this.gameObject.GetComponent<TextMeshProUGUI>();
        anzeige.text = Player.score.ToString();
    }


}
