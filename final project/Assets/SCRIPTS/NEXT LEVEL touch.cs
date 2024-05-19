using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NEXTLEVELtouch : MonoBehaviour
{
    public string scenename;
    // Start is called before the first frame update
    void OnCollisionEnter (Collision collision)
    {
        if(collision.gameObject.name == "Player")
        {
            SceneManager.LoadScene(scenename); 
        }
    }
   
}
