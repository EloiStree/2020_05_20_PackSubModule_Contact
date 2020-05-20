using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EloiExperiments : MonoBehaviour
{



    public void OpenWebsite()
    {
        OpenUrl("http://eloistree.com/");
    }
    public void OpenToolbox()
    {
        OpenUrl("https://eloistree.page.link/toolbox");
    }
    public void OpenDiscord()
    {
        OpenUrl("https://eloistree.page.link/discord");
    }
    public void OpenUrl(string url){ Application.OpenURL(url); }
}
