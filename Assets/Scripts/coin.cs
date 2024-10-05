using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    private UImanager uimanager;

    private void Start()
    {
        uimanager = FindObjectOfType<UImanager>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            uimanager.UpdateCoinsText();
            Destroy(this.gameObject);
        }
    }
}
