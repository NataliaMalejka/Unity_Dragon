using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour
{
    [SerializeField]
    private Vector3 distance;
    private GameObject DragoObject;

    private void Start()
    {
        DragoObject = GameObject.FindGameObjectWithTag("Player");
    }

    private void Update()
    {
        if(DragoObject != null)     
            transform.position = new Vector3(DragoObject.transform.position.x, 0, 0) + distance;
    }
}
