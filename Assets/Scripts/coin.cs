using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    [SerializeField] private GameObject coinParticleSystem;
    private UImanager uimanager;
    private SoundsManager soundsManager;

    private void Start()
    {
        uimanager = FindObjectOfType<UImanager>();
        soundsManager = FindAnyObjectByType<SoundsManager>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            soundsManager.PlaySounds(SoundsManager.Sounds.CollectCoin);
            uimanager.UpdateCoinsText();
            Instantiate(coinParticleSystem, new Vector3(transform.position.x, transform.position.y, -1), Quaternion.identity);
            Destroy(this.gameObject);
        }
    }
}
