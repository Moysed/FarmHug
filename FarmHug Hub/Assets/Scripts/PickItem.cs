using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickItem : MonoBehaviour
{
    public VirtualController _vc;

    private void Awake()
    {
        _vc = new VirtualController();
    }

    private void OnCollisionEnter(Collision target)
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

    private void OnCollisionStay(Collision target)
    {
        if (target.gameObject.tag == "OBJ")
        {
            Debug.Log("Item Collision Stay");
            if (_vc.m_Collect != false)
            {
                Destroy(target.gameObject);
            }
        }
    }
}
