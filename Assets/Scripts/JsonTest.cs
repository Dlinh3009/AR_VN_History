/*using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

*//*[Serializable]
public class HeroList
{
    public Hero[] hero;
}*//*


public class JsonTest : MonoBehaviour
{
    // Start is called before the first frame update
    public TextAsset textJson;
    public HeroList heroList = new HeroList();
   
   
    void Start()
    {
        // Check if textJson is not null before parsing
        if (textJson != null)
        {
            heroList = JsonUtility.FromJson<HeroList>(textJson.text);

            if (heroList != null && heroList.hero != null)
            {
                foreach (Hero hero in heroList.hero)
                {
                    Debug.Log("Hero name: " + hero.Name + ", Health: " + hero.Information);
                    // Do whatever you need to do with each Hero object
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
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
*/