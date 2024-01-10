using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickItem : MonoBehaviour
{


    private void Awake()
    {

    }

    private void OnTriggerEnter(Collider target)
    {
        VirtualController _vc = target.GetComponent<VirtualController>();
        if (_vc != null)
        {
            if (target.gameObject.tag == "OBJ")
            {
                Debug.Log("Item Collision");
                if (_vc.m_Collect != false)
                {
                    Destroy(target.gameObject);
                }
            }
        }
    }

    private void OnTriggerStay(Collider target)
    {
        VirtualController _vc = target.GetComponent<VirtualController>();
        if (_vc != null)
        {
            if (target.gameObject.tag == "OBJ")
            {
                Debug.Log("Item Collision");
                if (_vc.m_Collect != false)
                {
                    Destroy(target.gameObject);
                }
            }
        }
    }
}
