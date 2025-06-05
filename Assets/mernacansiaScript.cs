using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mernacansiaScript : MonoBehaviour
{
    public float cost;
    public MoneyManager money

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "player")
        {
            Destroy(gameObject);
        }
    }
}