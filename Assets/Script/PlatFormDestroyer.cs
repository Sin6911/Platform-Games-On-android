using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatFormDestroyer : MonoBehaviour
{
    public GameObject platformDestructionPoint;
    // Start is called before the first frame update
    void Start()
    {
        platformDestructionPoint = GameObject.Find("PlatFormDestructionPoint");
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < platformDestructionPoint.transform.position.x)
        {
            Destroy(gameObject);
        }
    }
}
