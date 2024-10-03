using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using Unity.VisualScripting;
using UnityEngine;

public class ObstacleRenderer : MonoBehaviour
{
    [SerializeField] private List<GameObject> obstacles = new List<GameObject>();
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
        int obstacle_number = Random.Range(0, obstacles.Count);

        Instantiate(obstacles[obstacle_number], new UnityEngine.Vector3(distance, 0, 0), UnityEngine.Quaternion.Euler(0, 0, 0));
        distance += 70;
    }
}
