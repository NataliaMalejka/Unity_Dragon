using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour
{
    [SerializeField]
    private Vector3 distance;
    private GameObject DragoObject;
    private GameManager gameManager;

    private void Start()
    {
        DragoObject = GameObject.FindGameObjectWithTag("Player");
        gameManager = GameObject.FindObjectOfType<GameManager>();
    }

    private void Update()
    {
        if (DragoObject != null)
            transform.position = new Vector3(DragoObject.transform.position.x, 0, 0) + distance;
        else
            gameManager.GameOver();
    }
}
