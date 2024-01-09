using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{

    public VirtualController _vc;

    private void Awake()
    {
        _vc = new VirtualController();
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Enter Collision");
        CollectItem collectItem = other.GetComponent<CollectItem>();
        if (collectItem != null)
        {
            if (_vc.m_Collect == true)
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

        if (collectItem != null)
        {
            if (_vc.m_Collect == true)
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

        if (collectItem != null)
        {
            if (_vc.m_Collect == true)
            {
                //collectItem.capsuleCollect();
                gameObject.SetActive(true);
            }
        }
    }
}
    