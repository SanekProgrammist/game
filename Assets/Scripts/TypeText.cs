using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class TypeText : MonoBehaviour
{
    public Text text1;

    public string text = "";

    void Start()
    {
        StartCoroutine("showText", text);
    }

    IEnumerator showText(string text)
    {
        int i = 0;
        while (i <= text.Length)
        {
            text1.text = text.Substring(0, i);
            i += 1;

            yield return new WaitForSeconds(0.05f);
        }
    }
}