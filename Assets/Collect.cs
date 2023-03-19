using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect : MonoBehaviour
{
    public GemManagement GM;

    private void OnTriggerEnter2D(Collider2D Item)
    {
        if(Item.name=="Player")
        {
            Debug.Log("collecd");
            GM.CollectGem();
            Destroy(gameObject);
        }
    }
}
