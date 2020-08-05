using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu1 : MonoBehaviour
{
    // Start is called before the first frame update
    public void hummingBird()
    {
        SceneManager.LoadScene(1);
    }
    public void penguin()
    {
        SceneManager.LoadScene(2);

    }
    public void back()
    {
        SceneManager.LoadScene(0);

    }
}

