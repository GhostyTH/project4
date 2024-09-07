using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coins : MonoBehaviour
{
    public int Value = 1;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            CoinsCounter.instance.IncreaseCoins(Value);
        }
    }
}
