using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void LoadARScene() {
        SceneManager.LoadScene("AR");
    }
    public void LoadWikiScene() {
        SceneManager.LoadScene("Wiki1");
    }
}
