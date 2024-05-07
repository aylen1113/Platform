using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickup : MonoBehaviour
{
    public int value;

    public float turnSpeed = 90f;

    public GameObject pickupEffect;

    private void OnTriggerEnter(Collider other)
  
    {
        if (other.tag == "Player")
        {
            FindObjectOfType<GameManager>().AddCoins(value);

            Instantiate(pickupEffect, transform.position, transform.rotation);
            Destroy(gameObject);

        }
;
    }
    private void Update()
    {
        transform.Rotate(0, 0, turnSpeed * Time.deltaTime);
    }
}
