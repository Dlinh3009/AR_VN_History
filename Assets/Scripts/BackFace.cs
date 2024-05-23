using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class BackFace : MonoBehaviour
{
    public GameObject tieuSu, chienCong, video;
    VirtualButtonBehaviour[] awa;
    // Start is called before the first frame update
    void Start()
    {
        awa = GetComponentsInChildren<VirtualButtonBehaviour>();
        for (int i = 0; i < awa.Length; ++i)
        {
            awa[i].RegisterOnButtonPressed(OnButtonPressed);
            awa[i].RegisterOnButtonReleased(OnButtonReleased);
        }
        tieuSu.SetActive(false);
        chienCong.SetActive(false);
        video.SetActive(false);
    }

    public void OnButtonPressed(VirtualButtonBehaviour go)
    {
        if (go.VirtualButtonName == "TieuSu")
        {
            tieuSu.SetActive(true);
            chienCong.SetActive(false);
            video.SetActive(false);
        }
        if (go.VirtualButtonName == "ChienCong")
        {
            tieuSu.SetActive(false);
            chienCong.SetActive(true);
            video.SetActive(false);
        }
        if (go.VirtualButtonName == "Video")
        {
            tieuSu.SetActive(false);
            chienCong.SetActive(false);
            video.SetActive(true);
        }
    }

    public void OnButtonReleased(VirtualButtonBehaviour go)
    {
        if (go.VirtualButtonName == "TieuSu")
        {
            tieuSu.SetActive(false);
            chienCong.SetActive(false);
            video.SetActive(false);
        }
        if (go.VirtualButtonName == "ChienCong")
        {
            tieuSu.SetActive(false);
            chienCong.SetActive(false);
            video.SetActive(false);
        }
        if (go.VirtualButtonName == "Video")
        {
            tieuSu.SetActive(false);
            chienCong.SetActive(false);
            video.SetActive(false);
        }
    }

}