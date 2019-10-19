using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AchievementUse : MonoBehaviour
{
    public GameObject achievementUI;

    public void closeAchievement()
    {
        achievementUI.SetActive(false);
    }

    public void openAchievement()
    {
        achievementUI.SetActive(true);
    }

}
