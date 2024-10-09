using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Wall : MonoBehaviour
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
            gameManager.GameOver(ref uimanager.coins, ref uimanager.points);
        }

        Destroy(collision.gameObject);
    }
}
