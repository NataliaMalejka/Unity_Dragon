using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UImanager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI pointsText;
    [SerializeField] private TextMeshProUGUI coinsText;

    private int points = 0;
    private int coins = 0;

    public void UpdatePointsText()
    {
        points++;
        pointsText.text = "POINTS " + points.ToString() ;
    }
    public void UpdateCoinsText()
    {
        coins++;
        coinsText.text = "COINS " + coins.ToString();
    }
}