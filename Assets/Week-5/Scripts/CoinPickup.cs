using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickup : MonoBehaviour
{
    [SerializeField] GameObject Guy;
    [SerializeField] GameObject Coin;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Guy.GetComponent<PlayerControl>().CoinCollect(1);
        Coin.SetActive(false);
    }
}
