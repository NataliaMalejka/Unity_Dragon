using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private ObstacleRenderer obstacleRenderer;
    private CoinRenderer coinRenderer;
    private UImanager uimanager;

    private void Start()
    {
        obstacleRenderer = FindAnyObjectByType<ObstacleRenderer>();
        coinRenderer = FindAnyObjectByType<CoinRenderer>();
        uimanager = FindObjectOfType<UImanager>();
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            uimanager.UpdatePointsText();
            obstacleRenderer.renderObstacle();
            coinRenderer.renderCoin();           
        }
    }
}
