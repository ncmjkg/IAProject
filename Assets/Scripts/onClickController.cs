using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class onClickController : MonoBehaviour {

    public Transform canvas;
    private static onClickController instance;

    // Use this for initialization

    //button to next scene
    public void NextScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    //voice setting menu on or not
    public void SettingMenu()
    {
        if (canvas.gameObject.activeInHierarchy == false)
        {
            canvas.gameObject.SetActive(true);
        }
        else
        {
            canvas.gameObject.SetActive(false);
        }
    }

    //quit game
    public void Quit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
		Application.Quit();
#endif
    }

    //avoid destroy pss by scene and duplicate
    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);

        if (this.gameObject.activeInHierarchy == true)
        {
            this.gameObject.SetActive(false);
        }
    }
}
