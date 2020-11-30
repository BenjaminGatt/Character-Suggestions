using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OnBtnClick : MonoBehaviour
{
    public void GetText()
    {
        Text txt = transform.Find("Text").GetComponent<Text>();
        Debug.Log($"Text: {txt.text}");
        ClipboardExtension.CopyToClipboard(txt.text);
        SceneManager.LoadScene("InputListener");
    }
}
