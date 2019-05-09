using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menuScript : MonoBehaviour {

    public Canvas quitMenu;
    public Button buildingOne;
    public Button exitButton;
    public Button homeButton;
    public Button resetButton;
	// Use this for initialization
	void Start () {
        quitMenu = quitMenu.GetComponent<Canvas>();
        buildingOne = buildingOne.GetComponent<Button>();
        exitButton = exitButton.GetComponent<Button>();
        quitMenu.enabled = false;
	}

    public void ExitPress()
    {
        quitMenu.enabled = true;
        buildingOne.enabled = false;
    }

    public void NoPress()
    {
        quitMenu.enabled = false;
      
    }


    public void LiveLaunch ()
    {
        SceneManager.LoadScene(2);
    }

    public void SelectHome ()
    {
        SceneManager.LoadScene(0);
    }

    public void ExitApplication()
    {
        Application.Quit();
    }

    public void resetSceneLiver()
    {
        SceneManager.LoadScene(2);
    }

    public void resetScenePoolM()
    {
        SceneManager.LoadScene(3);
    }

    public void resetSceneHall()
    {
        SceneManager.LoadScene(4);
    }

    public void resetSceneDock()
    {
        SceneManager.LoadScene(1);
    }

    public void resetSceneCathedral()
    {
        SceneManager.LoadScene(5);
    }

    public void resetSceneWorld()
    {
        SceneManager.LoadScene(6);
    }
	// Update is called once per frame
	void Update () {
		
	}
}
