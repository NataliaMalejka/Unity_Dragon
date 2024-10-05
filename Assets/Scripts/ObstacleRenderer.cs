using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using Unity.VisualScripting;
using UnityEngine;

public class ObstacleRenderer : MonoBehaviour
{
    [SerializeField] private List<GameObject> obstacles = new List<GameObject>();
    [SerializeField] private float RenderPosition;
    [SerializeField] private float distance;

    private List<GameObject> AddedObstacles = new List<GameObject>();

    private void Start()
    {
        for(int i = 0; i <=3; i++)
        {
            renderObstacle();
        }
    }

    public void renderObstacle()
    {
        int obstacle_number = Random.Range(0, obstacles.Count);

        AddedObstacles.Add(Instantiate(obstacles[obstacle_number], new UnityEngine.Vector3(RenderPosition, Random.Range(-17, 27), 0),
            UnityEngine.Quaternion.Euler(0, 0, 0)));

        if(AddedObstacles.Count > 5)
        {
            GameObject obstacleToRemove = AddedObstacles[0];
            AddedObstacles.Remove(obstacleToRemove);
            Destroy(obstacleToRemove);
        }

        RenderPosition += distance;
    }
}
