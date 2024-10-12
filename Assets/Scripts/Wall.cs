using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Wall : MonoBehaviour
{
    [SerializeField] private AudioClip destroyBullet;
    [SerializeField] private float volume;
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

        if(collision.gameObject.CompareTag("Bullet"))
        {
            AudioSource.PlayClipAtPoint(destroyBullet, collision.contacts[0].point, volume);
        }

        Destroy(collision.gameObject);
    }
}
