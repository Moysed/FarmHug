using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        CollectItem collectItem = other.GetComponent<CollectItem>();
        if (Input.GetKeyDown(KeyCode.F))
        {
            collectItem.capsuleCollect();
            gameObject.SetActive(false);
        }
    }
    private void OnTriggerStay(Collider other)
    {
        CollectItem collectItem = other.GetComponent<CollectItem>();

        if (collectItem != null)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                collectItem.capsuleCollect();
                gameObject.SetActive(false);
                print("Press R to Reset");
            }
        }
    }

    
}
    