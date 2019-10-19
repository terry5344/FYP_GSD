using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WallGG : MonoBehaviour
{
    public Text tipsText;

    public void OpenWall()
    {
        if (PlayerWalk.keyCount >= 1) {
            Destroy(gameObject);
            tipsText.text = "I give you power. Now you can press space. keep going";
        }
    }

}
