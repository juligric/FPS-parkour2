using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deteccionDeColiciones : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Contacto");
        Destroy(collision.gameObject);
    }
}
