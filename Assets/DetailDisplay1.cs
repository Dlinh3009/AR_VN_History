using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DetailDisplay : MonoBehaviour
{

  

    // Start is called before the first frame update
    void Start()
    {
        GameObject buttonTemplate = transform.GetChild(0).gameObject;

        buttonTemplate.transform.GetChild(0).GetComponentInChildren<TMP_Text>().text = StaticData.ListHero[StaticData.indexer].Name;
        buttonTemplate.transform.GetChild(1).GetComponent<TMP_Text>().text = StaticData.Attribute;
    }


    public void Back()
    {
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);

    }

    // Update is called once per frame
    void Update()
    {

    }
}