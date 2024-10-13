using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinRenderer : MonoBehaviour
{
    [SerializeField] private GameObject coin;
    [SerializeField] private float RenderPosition;
    [SerializeField] private float distance;

    private List<GameObject> AddedCoins = new List<GameObject>();

    public void renderCoin()
    {
        int chance = Random.Range(0, 100);

        if(chance < 50)
        {
            AddedCoins.Add(Instantiate(coin, new Vector3(RenderPosition, Random.Range(-17, 27), 0), Quaternion.Euler(0,0,0)));

            if(AddedCoins.Count > 7)
            {
                GameObject coinToRemove = AddedCoins[0];
                AddedCoins.Remove(coinToRemove);
                Destroy(coinToRemove);
            }
        }

        RenderPosition += distance;
    }
}
