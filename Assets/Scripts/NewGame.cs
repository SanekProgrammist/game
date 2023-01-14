using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewGame : MonoBehaviour
{
    public int location4;
    public int location5;

    
    public void NewGame1()
    {
        SceneManager.LoadScene(location4);
    }

    public void Titri()
    {
        SceneManager.LoadScene(location5);
    }
}
