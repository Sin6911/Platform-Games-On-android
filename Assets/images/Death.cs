using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    int Cherry = 0;


    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {   
     
        if (other.CompareTag("Player"))
        {
                if(Cherry > 0)
            {
                SceneManager.LoadScene("SampleScene");
                Cherry--;
            }

                else
                 {
                SceneManager.LoadScene("Lose");

                 }
                
                

         


        }


    }
}

