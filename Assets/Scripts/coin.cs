using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    [SerializeField] private GameObject coinParticleSystem;
    private UImanager uimanager;

    private void Start()
    {
        uimanager = FindObjectOfType<UImanager>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            uimanager.UpdateCoinsText();
            Instantiate(coinParticleSystem, new Vector3(transform.position.x, transform.position.y, -1), Quaternion.identity);
            Destroy(this.gameObject);
        }
    }
}
