using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    // Start is called before the first frame update
    public void agent()
    {
        SceneManager.LoadScene(3);
    }
    public void computational()
    {
        SceneManager.LoadScene(4);

    }
    public void backAgent()
    {
        SceneManager.LoadScene(0);

    }
    public void backCom()
    {
        SceneManager.LoadScene(0);

    }
    public void hummingBird()
    {
        SceneManager.LoadScene(1);
    }
    public void penguin()
    {
        SceneManager.LoadScene(2);

    }
    public void palinmenu()
    {
        SceneManager.LoadScene(5);

    }
    public void bracketmenu()
    {
        SceneManager.LoadScene(6);

    }
    public void backCommenu()
    {
        SceneManager.LoadScene(4);


    }
    public void palin()
    {
        SceneManager.LoadScene(7);

    }
    public void parenthesis()
    {
        SceneManager.LoadScene(8);

    }
    public void openparenlang()
    {
        SceneManager.LoadScene(9);
    }
    public void openpalinlan()
    {
        SceneManager.LoadScene(10);
    }

    public void backparentlang()
    {
        SceneManager.LoadScene(6);

    }
    public void backlearning()
    {
        SceneManager.LoadScene(0);

    }
    public void openlearning()
    {
        SceneManager.LoadScene(11);

    }
    public void backpalinlan()
    {
        SceneManager.LoadScene(5);

    }

    public void learning()
    {
        SceneManager.LoadScene(8);

    }
    public void quit()
    {
#if (UNITY_EDITOR || DEVELOPMENT_BUILD)
        Debug.Log(this.name + " : " + this.GetType() + " : " + System.Reflection.MethodBase.GetCurrentMethod().Name);
#endif
#if (UNITY_EDITOR)
        UnityEditor.EditorApplication.isPlaying = false;
#elif (UNITY_STANDALONE) 
    Application.Quit();
#elif (UNITY_WEBGL)
    Application.OpenURL("about:blank");
#endif

    }
    public void backfrompalinworld()
    {
        SceneManager.LoadScene(5);

    }
    public void backfromparenworld()
    {

        SceneManager.LoadScene(6);
    }
    public void backhumming()
    {
        SceneManager.LoadScene(3);
    }
    public void inclink()
    {
        Application.OpenURL("http://www.niazilab.com/");
    }
}