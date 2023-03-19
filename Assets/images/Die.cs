using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Die : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void LoadGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void Return()
        {
        SceneManager.LoadScene("Start");
    }
}
