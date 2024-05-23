using System;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Firebase.Database;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.SceneManagement;

public static class ButtonExtension
{
    public static void AddEventListener<T>(this Button button, T param, Action<T> OnClick)
    {
        button.onClick.AddListener(delegate ()
        {
            OnClick(param);
        });
    }
}

[Serializable]
public class HeroList
{
    public Hero[] hero;
}



public class ListHero : MonoBehaviour
{
/*    DatabaseReference dbRef;*/

    public TextAsset textJson;
    public HeroList heroList = new HeroList();
    [SerializeField] List<Hero> allHero = new List<Hero>();

    void Start()
    {
        /* StartCoroutine(ReadDataFn());*/

        if (textJson != null)
        {
            heroList = JsonUtility.FromJson<HeroList>(textJson.text);

            if (heroList != null && heroList.hero != null)
            {
                foreach (Hero hero in heroList.hero)
                {
                    Debug.Log("Hero name: " + hero.Name + ", Health: " + hero.FunnyStory);
                    // Do whatever you need to do with each Hero object
                    StaticData.ListHero.Add(hero);
                    allHero.Add(hero);
                }
                
            }
            else
            {
                Debug.LogError("Failed to deserialize HeroList or hero array is null.");
            }
        }
        else
        {
            Debug.LogError("TextAsset textJson is null.");
        }
        GameObject buttonTemplate = transform.GetChild(1).gameObject;
        GameObject g;
        int N = allHero.Count;
        for (int i = 0; i < N; i++)
        {
            g = Instantiate(buttonTemplate, transform);
            g.transform.GetChild(0).GetComponent<TMP_Text>().text = allHero[i].Name;
            g.GetComponent<Button>().AddEventListener(i, ItemClicked);
        }

        Destroy(buttonTemplate);
    }

    /*IEnumerator ReadDataFn()
    {
        // Initialize dbRef here
        dbRef = FirebaseDatabase.DefaultInstance.RootReference;

        // Get data from Firebase
        var serverData = dbRef.Child("Hero").GetValueAsync();
        yield return new WaitUntil(predicate: () => serverData.IsCompleted);

        DataSnapshot snapshot = serverData.Result;
        string jsonData = snapshot.GetRawJsonValue();

        foreach (DataSnapshot child in snapshot.Children)
        {
            string jsonDataChild = child.GetRawJsonValue();
            Hero Child = JsonUtility.FromJson<Hero>(jsonDataChild);
            if (Child.Name != null)
            { allHero.Add(Child); }

            StaticData.ListHero = allHero;
        }

       


        //PopulateButtons();
    }
*/
    public void playGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    void ItemClicked(int itemIndex)
    {
        Debug.Log("------------item " + itemIndex + " clicked---------------");
        Debug.Log("name " + allHero[itemIndex].Name);
        StaticData.indexer = itemIndex;
        playGame();
    }

   /* public void Testt()
    {
        StartCoroutine(ReadDataFnTest());
    }
    IEnumerator ReadDataFnTest()
    {
        // Initialize dbRef here
        dbRef = FirebaseDatabase.DefaultInstance.RootReference;

        // Get data from Firebase
        var serverData = dbRef.Child("Hero").GetValueAsync();
        yield return new WaitUntil(predicate: () => serverData.IsCompleted);

        DataSnapshot snapshot = serverData.Result;
        string jsonData = snapshot.GetRawJsonValue();

        foreach (DataSnapshot child in snapshot.Children)
        {
            string jsonDataChild = child.GetRawJsonValue();
            Hero Child = JsonUtility.FromJson<Hero>(jsonDataChild);
            if (Child.Name != null)
            { allHero.Add(Child); }
            Debug.Log(Child);
            //StaticData.ListHero = allHero;
        }
    }*/
}
