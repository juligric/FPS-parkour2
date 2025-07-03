using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interaction_area : MonoBehaviour
{
    public GameObject interactionmessage;
    public MercanciaScript mercansia;
    // Start is called before the first frame update
    void Start()
    {
        interactionmessage.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeydown(KeyCode.E))
        {
            if(mercansia)
            {
                Destroy(mercansia.gameObject);
            }
        }
    }



    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);
        interactionmessage.SetActive(true);
        mercansia = other.GetComponent<MercanciaScript>();
        if(mercansia)
        {
            interactionmessage.SetActive(true);
        }

    }

    private void OntriggerExit(Collider other)
    {
        interactionmessage.SetActive(false);
        mercansia = null;
    }

    void stopinteraction ()
    {
         interactionmessage.SetActive(false);
        mercansia = null;
    }
}
