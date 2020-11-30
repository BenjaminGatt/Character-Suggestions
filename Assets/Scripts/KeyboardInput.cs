using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KeyboardInput : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("a"))
        {
            SceneManager.LoadScene("ACharacters");
        }
        else if (Input.GetKeyDown("c"))
        {
            SceneManager.LoadScene("CCharacters");
        }
        else if (Input.GetKeyDown("e"))
        {
            SceneManager.LoadScene("ECharacters");
        }
        else if (Input.GetKeyDown("i"))
        {
            SceneManager.LoadScene("ICharacters");
        }
        else if (Input.GetKeyDown("o"))
        {
            SceneManager.LoadScene("OCharacters");
        }
        else if (Input.GetKeyDown("u"))
        {
            SceneManager.LoadScene("UCharacters");
        }
    }
}