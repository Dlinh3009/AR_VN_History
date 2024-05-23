/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Firebase.Database;
using UnityEditor;

[Serializable]
public class dataToSave {
    public string userName;
    public int totalCoins;
    public int crrLevel;
    public int highScore;
} 

public class DataSaver : MonoBehaviour
{
    // Start is called before the first frame update
    public dataToSave dts;
    public string userId;
    DatabaseReference dbRef;

    public void Awake()
    {
        dbRef = FirebaseDatabase.DefaultInstance.RootReference;

    }
    public void SaveDataFn()
    {
        string json = JsonUtility.ToJson(dts);
        dbRef.Child("users").Child(userId).SetRawJsonValueAsync(json);

    }
    public void LoadDataFn() {
        //StartCoroutine(LoadDataEnum());
    }
    IEnumerator LoadDataEnum() {

        var serverData = dbRef.Child("users").Child(userId).GetValueAsync();
        yield return new WaitUntil(predicate: () => serverData.IsCompleted);

        print("process is complete");

        DataSnapshot snapshot = serverData.Result;
        string jsonData = snapshot.GetRawJsonValue();

        if (jsonData != null)
        {
            print("sever data was found");
            dts = JsonUtility.FromJson<dataToSave>(jsonData);
        }
        else { print("sever data was not found"); }

    }

    public void ReadDataFn()
    {
        //StartCoroutine(ReadData());
    }
    IEnumerator ReadData()
    {
        print("process is complete");
        var serverData = dbRef.Child("users").GetValueAsync();
        yield return new WaitUntil(predicate: () => serverData.IsCompleted);

        print("process is complete");

        DataSnapshot snapshot = serverData.Result;
        List<string> res=new List<string>();
        foreach (DataSnapshot child in snapshot.Children) {
           
            string jsonDataChild = child.GetRawJsonValue();
            dataToSave Child = JsonUtility.FromJson<dataToSave>(jsonDataChild);
            res.Add(Child.userName);
        }
        foreach (string tes in res) {
            print(tes);
        }
        print(res);

       
       

    }


}




*/