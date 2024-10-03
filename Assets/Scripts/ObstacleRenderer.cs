using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using Unity.VisualScripting;
using UnityEngine;

public class ObstacleRenderer : MonoBehaviour
{
    [SerializeField] private List<GameObject> gameObjects = new List<GameObject>();
    [SerializeField] private float startPosition;
    [SerializeField] private float distance;

    private void Start()
    {
        for(int i = 0; i <=3; i++)
        {
            renderObstacle();
        }
    }

    private void renderObstacle()
    {

    }
}
