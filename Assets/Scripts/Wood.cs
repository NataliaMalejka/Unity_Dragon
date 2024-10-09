using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wood : MonoBehaviour
{
    private GameManager gameManager;
    private UImanager uimanager;
    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        uimanager = FindObjectOfType<UImanager>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            Destroy(collision.gameObject);
            gameManager.GameOver(ref uimanager.coins, ref uimanager.points);
        }
        else if (collision.gameObject.CompareTag("Bullet"))
        {
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }
    }
}
