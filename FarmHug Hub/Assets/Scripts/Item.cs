using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{

    

    private void Awake()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Enter Collision");
        CollectItem collectItem = other.GetComponent<CollectItem>();
        VirtualController vc = other.GetComponent<VirtualController>();
        if (collectItem != null)
        {
            if (vc.m_Collect == true)
            {
                collectItem.capsuleCollect();
                gameObject.SetActive(false);
            }
        }
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Stay Collision");
        CollectItem collectItem = other.GetComponent<CollectItem>();
        VirtualController vc = other.GetComponent<VirtualController>();
        if (collectItem != null)
        {
            if (vc.m_Collect == true)
            {
                collectItem.capsuleCollect();
                gameObject.SetActive(false);
                print("Press R to Reset");
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Exit Collision");
        CollectItem collectItem = other.GetComponent<CollectItem>();
        VirtualController vc = other.GetComponent<VirtualController>();
        if (collectItem != null)
        {
            if (vc.m_Collect == true)
            {
                //collectItem.capsuleCollect();
                gameObject.SetActive(true);
            }
        }
    }
}
    