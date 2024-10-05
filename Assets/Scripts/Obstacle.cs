using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private ObstacleRenderer obstacleRenderer;
    private CoinRenderer coinRenderer;

    private void Start()
    {
        obstacleRenderer = FindAnyObjectByType<ObstacleRenderer>();
        coinRenderer = FindAnyObjectByType<CoinRenderer>();
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            obstacleRenderer.renderObstacle();
            coinRenderer.renderCoin();           
        }
    }
}
