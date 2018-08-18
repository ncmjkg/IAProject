using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

    public Transform PauseUI;

    public GameObject theVolume;
    //UnityEngine.SceneManagement.Scene dontDestroyOnLoad = theVolume;


    // Use this for initialization
    void Start () {

}
	
	// Update is called once per frame
	void Update () {
		
	}

    //set the pausing ui on or off
    public void SettingMenu()
    {
        if (PauseUI.gameObject.activeInHierarchy == false)
        {
            PauseUI.gameObject.SetActive(true);
        }
        else
        {
            PauseUI.gameObject.SetActive(false);
        }
    }

    //stop the game
    public static void PauseGame()
    {
        Time.timeScale = 0;
    }

    //back to game where it stop
    public static void ResumeGame()
    {
        Time.timeScale = 1;
    }


    //back to index page
    public void Menu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("index");
    }

    //restart the game
    public void Restart(string sceneName)
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(sceneName);
    }

    //voice volume setting ui on or off(not working)
    public void SettingVolume()
    {
        // Check for existance of GetComponent function on theVolume. Function probably does not exist and return value is probably not the correct type if it does
        if (theVolume.GetComponent("Setting").gameObject.activeInHierarchy == false)
        {
            theVolume.GetComponent("Setting").gameObject.SetActive(true);
        }
        else
        {
            theVolume.GetComponent("Setting").gameObject.SetActive(false);
        }
    }

}
