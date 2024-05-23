using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DetailHero : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject buttonTemplate = transform.GetChild(0).gameObject;

        buttonTemplate.transform.GetChild(0).GetComponentInChildren<TMP_Text>().text = StaticData.ListHero[StaticData.indexer].Name;
         /* buttonTemplate.transform.GetChild(1).GetComponentInChildren<TMP_Text>().text = StaticData.ListHero[StaticData.indexer].Character;
          buttonTemplate.transform.GetChild(2).GetComponentInChildren<TMP_Text>().text = StaticData.ListHero[StaticData.indexer].Information;
          buttonTemplate.transform.GetChild(3).GetComponentInChildren<TMP_Text>().text = StaticData.ListHero[StaticData.indexer].Victory;
          buttonTemplate.transform.GetChild(4).GetComponentInChildren<TMP_Text>().text = StaticData.ListHero[StaticData.indexer].Heritage;
          buttonTemplate.transform.GetChild(5).GetComponentInChildren<TMP_Text>().text = StaticData.ListHero[StaticData.indexer].FunnyStory;
          buttonTemplate.transform.GetChild(6).GetComponentInChildren<TMP_Text>().text = StaticData.ListHero[StaticData.indexer].Image;
          buttonTemplate.transform.GetChild(7).GetComponentInChildren<TMP_Text>().text = StaticData.ListHero[StaticData.indexer].Video;*/

        
    }

    public void SwitchScence()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);


    }

    public void Test()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }


    public void SetFunnyStory()
    {
        StaticData.Attribute = StaticData.ListHero[StaticData.indexer].FunnyStory; 
    }

    public void SetCharacter()
    {
        StaticData.Attribute = StaticData.ListHero[StaticData.indexer].Character;
    }
    public void SetInformation()
    {
        StaticData.Attribute = StaticData.ListHero[StaticData.indexer].Information;
    }
    public void SetVictory()
    {
        StaticData.Attribute = StaticData.ListHero[StaticData.indexer].Victory;
    }
    public void SetHeritage()
    {
        StaticData.Attribute = StaticData.ListHero[StaticData.indexer].Heritage;
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
