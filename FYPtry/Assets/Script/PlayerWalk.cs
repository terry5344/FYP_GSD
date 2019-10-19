using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerWalk : MonoBehaviour
{
    public int playerSpeed;
    public static int keyCount = 0;
    public Text keyText;
    public Text tipsText;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            transform.position = transform.position + Camera.main.transform.forward * playerSpeed * Time.deltaTime;
            
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Key"))
        {
           
            keyCount++;
            keyText.text = "Key:"+keyCount.ToString();
            Destroy(other.gameObject);
            tipsText.text = "click the wall ";

        }
  
      

            /* 
              if (other.gameObject.CompareTag("lobby"))
             {
                 SceneManager.LoadScene("lobby");
             }
             */
        }
}
