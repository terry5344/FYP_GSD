using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainQuestUse : MonoBehaviour
{
    public GameObject MainQuest;
    
    public void mainQuest1()
    {
        LobbyTeleport.teleportName = "main1";
    }

    public void closeMainQuest()
    {
        MainQuest.SetActive(false);
    }

    public void openMainQuest()
    {
        MainQuest.SetActive(true);
    }
}
