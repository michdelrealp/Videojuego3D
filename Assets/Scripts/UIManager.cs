using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI CurrentScoreText;
    public TextMeshProUGUI BestScoreText;

    void Update()
    {
        CurrentScoreText.text = "Score: " + GameManager.singleton.currentScore;
        BestScoreText.text = "Best: " + GameManager.singleton.bestScore;
    }
}
 
