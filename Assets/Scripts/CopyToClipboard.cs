using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CopyToClipboard : MonoBehaviour
{
    //Text aButton = Object.GetChild<Text>().text;
    public GameObject aObject;
    public Button aButton;
    public string aString;

    private void Awake()
    {
        aObject = GameObject.Find("e1");
        aString = aObject.GetComponentInChildren<Text>().text;
        CopyClipboard(aString);
    }

    public void CopyClipboard(string s)
    {
        TextEditor te = new TextEditor();
        te.text = s;
        te.SelectAll();
        te.Copy();
    }
}
