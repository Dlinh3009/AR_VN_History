using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Firebase.Database;
using UnityEditor;

[Serializable]
public class Hero
{
    public string Character;
    public string FunnyStory;
    public string Heritage;
    public string Image;
    public string Information;
    public string Name;
    public string Victory;
    public string Video;

}

public class HeroScripts : MonoBehaviour
{
    // Start is called before the first frame update
    public Hero Hero;
    public string Name;
    DatabaseReference dbRef;

    public void Awake()
    {
        dbRef = FirebaseDatabase.DefaultInstance.RootReference;

    }
    public void SaveDataFn()
    {
        string json = JsonUtility.ToJson(Hero);
        dbRef.Child("Hero").Child(Name).SetRawJsonValueAsync(json);

    }
    public void LoadDataFn()
    {
        StartCoroutine(LoadDataEnum());
    }

    //get detail 
    IEnumerator LoadDataEnum()
    {

        var serverData = dbRef.Child("Hero").Child(Name).GetValueAsync();
        yield return new WaitUntil(predicate: () => serverData.IsCompleted);

        print("process is complete");

        DataSnapshot snapshot = serverData.Result;
        string jsonData = snapshot.GetRawJsonValue();
        Debug.Log("New User Created");
        if (jsonData != null)
        {
            print("sever data was found");
            Hero = JsonUtility.FromJson<Hero>(jsonData);
        }
        else { print("sever data was not found"); }

    }


    //get all name
    public void ReadDataFn()
    {
        StartCoroutine(ReadData());
    }
    IEnumerator ReadData()
    {
        var serverData = dbRef.Child("Hero").GetValueAsync();
        yield return new WaitUntil(predicate: () => serverData.IsCompleted);

        print("process is complete");

        DataSnapshot snapshot = serverData.Result;
        string jsonData = snapshot.GetRawJsonValue();

        List<string> res = new List<string>();
        foreach (DataSnapshot child in snapshot.Children)
        {

            string jsonDataChild = child.GetRawJsonValue();
            Hero Child = JsonUtility.FromJson<Hero>(jsonDataChild);
            res.Add(Child.Name);
        }
        foreach (string tes in res)
        {
            print(tes);
        }
        print(res);
    }

}
