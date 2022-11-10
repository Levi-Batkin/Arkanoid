using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class MenuController : MonoBehaviour
{
    public GameObject mainMenu, optionsMenu, howtoplayMenu;
    public GameObject play, quit;
    public GameObject musicOn, musicOff;
    public Slider musicVol;
    float musicVolToSet;
    // Start is called before the first frame update
    void Start()
    {
        mainMenu.SetActive(true);
        optionsMenu.SetActive(false);
        howtoplayMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Play()
    {
        StartCoroutine(LoadGame());
    }
    IEnumerator LoadGame()
    {
        AsyncOperation loadGame = SceneManager.LoadSceneAsync("Game");
        while (!loadGame.isDone)
        {
            yield return null;
        }
    }
    public void MainMenu()
    {
        mainMenu.SetActive(true);
        optionsMenu.SetActive(false);
        howtoplayMenu.SetActive(false);
    }
    public void OptionsMenu()
    {
        mainMenu.SetActive(false);
        optionsMenu.SetActive(true);
        howtoplayMenu.SetActive(false);    
    }
    public void HowToPlayMenu()
    {
        mainMenu.SetActive(false);
        optionsMenu.SetActive(false);
        howtoplayMenu.SetActive(true);    
    }
    public void ToggleMusic()
    {
        if(musicOn.activeSelf == true)
        {
            PlayerPrefs.SetFloat("musicVol", musicVol.value);
            musicVol.value = 0f;
            musicOn.SetActive(false);
            musicOff.SetActive(true);
        }
        else if(musicOff.activeSelf == true)
        {
            musicVolToSet = PlayerPrefs.GetFloat("musicVol");
            musicVol.value = musicVolToSet;
            musicOn.SetActive(true);
            musicOff.SetActive(false);
        }
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
