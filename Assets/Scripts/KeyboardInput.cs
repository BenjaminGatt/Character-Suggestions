using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardInput : MonoBehaviour
{
    private float startTime;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("e"))
        {
            Debug.Log("pressed e");
            startTime = Time.time;
        }
        if (Input.GetKey("e") && (Time.time - startTime > 2f))
        {
            Debug.Log("e ê é è ë ē ĕ ě ẽ ė ẹ ę ẻ");
        }
    }
}
