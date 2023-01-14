using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class TypeText : MonoBehaviour
{
    public Text text1;

    public string text = "Заброшенный лес находится позади проклятой горы. Если ты хочешь отправится туда, то возьми с собой на помощь эту волшебную подушечку, как только захочешь поспать, просто поклади её рядом и поспи.";

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