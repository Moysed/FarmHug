using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectItem : MonoBehaviour
{
    public int capsulePickup {  get; private set; }

    public void capsuleCollect()
    {
        capsulePickup++;
    }
}
