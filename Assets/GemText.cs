using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GemText : MonoBehaviour
{
    private void Start()
    {
        
        UpdateHighGemText();
        
    }
    [SerializeField] TextMeshProUGUI gemText;
    [SerializeField] TextMeshProUGUI HighGemtext;
    int gemCount;


    public void OnEnable()
    {
        Gem.onGemcollected += IncrementGemCount;
    }
    private void onDisable()
    {
        Gem.onGemcollected -= IncrementGemCount;
    }
    public void IncrementGemCount()
    {
        gemCount++;
        gemText.text = $"Gem:{gemCount}";
        CheckHighGem();
        Check100Gem();

        //DeleteData();



    }
    void CheckHighGem()
    {
        if(gemCount > PlayerPrefs.GetInt("HighGem",0))
        {
            PlayerPrefs.SetInt("HighGem", gemCount);
            

        }
    }
    void Check100Gem()
    {
        if (PlayerPrefs.GetInt("HighGem", 0) ==100)
        {


            SceneManager.LoadScene("NewGame");
        }
    }

    private void UpdateHighGemText()
    {
        HighGemtext.text = $"Gemcollected:{PlayerPrefs.GetInt("HighGem", 0)}";
    }
    
    public void DeleteData()
    {
        PlayerPrefs.DeleteKey("HighGem");
    }
}
