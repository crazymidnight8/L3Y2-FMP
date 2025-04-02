using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerinteractions : MonoBehaviour
{
    public Collider triggerColl;

    RaycastHit hit;

    gamemanager gmSc;

    // Start is called before the first frame update
    void Start()
    {
        gmSc = GameObject.Find("GameManager").GetComponent<gamemanager>();
        gmSc.infoText.text = " ";   
    }

    // Update is called once per frame
    void Update()
    {
        if (triggerColl == null)
        {
            gmSc.infoText.text = " ";   
        }
        else if (triggerColl != null && Input.GetKeyDown(KeyCode.E))
        {
            if (triggerColl.gameObject.CompareTag("lever"))
            {
                Lever leverSc = triggerColl.gameObject.GetComponent<Lever>();
                leverSc.isOn = !leverSc.isOn;
            }
        } 

    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("collide");
        triggerColl = other;

        if (other.gameObject.CompareTag("lever"))
        {
            gmSc.infoText.text = "Press E to interact";
        }
    }

    void OnTriggerExit(Collider other) 
    {
        triggerColl = null;
    }
}
