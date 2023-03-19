using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GemManagement : MonoBehaviour
{
    public int GemCollected = 0;
    public Text GemOutPut;

    private void Update()
    {
        GemOutPut.text = "Gem:"+ GemCollected;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void CollectGem()
    {
        GemCollected++;
    }
}
