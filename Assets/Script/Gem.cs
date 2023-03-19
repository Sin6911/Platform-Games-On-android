using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Gem : MonoBehaviour, Icollect
{
    public static event Action onGemcollected;
    public void Collect()
    {
     
        onGemcollected?.Invoke();
        Destroy(gameObject);
    }

 
}
