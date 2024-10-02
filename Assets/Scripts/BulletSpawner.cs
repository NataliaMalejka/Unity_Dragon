using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    private GameObject DragonObject;
    [SerializeField] private GameObject bullet;
    [SerializeField] private Vector3 distance;

    private void Start()
    {
        DragonObject = GameObject.FindGameObjectWithTag("Player");
    }

    public void CreateObject()
    {
        Instantiate(bullet, DragonObject.transform.position + distance, Quaternion.identity);
    }
}
