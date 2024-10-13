using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wood : MonoBehaviour
{
    [SerializeField] private AudioClip destroyWood;
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
            Destroy(collision.gameObject);
            gameManager.GameOver(ref uimanager.coins, ref uimanager.points);
        }
        else if (collision.gameObject.CompareTag("Bullet"))
        {
            AudioSource.PlayClipAtPoint(destroyWood, collision.contacts[0].point, volume);
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }
    }
}
