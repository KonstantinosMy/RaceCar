using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class winCON : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        { 

            SceneManager.LoadScene("Demo 3");
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "red")
        {
            Debug.Log("RED WINS");
            SceneManager.LoadScene("Demo 3");
        }
        else if (other.tag == "blue")
        {
            Debug.Log("BLUE WINS");
            SceneManager.LoadScene("Demo 3");
        }
    }
}
