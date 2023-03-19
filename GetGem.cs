using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GetGem : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI Gem;



    private void Start()
    {
        Gem.text = $"Gemcollected:{PlayerPrefs.GetInt("HighGem", 0)}";
    }
}
