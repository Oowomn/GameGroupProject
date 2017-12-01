using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[System.Serializable]
public class lobbyManager : MonoBehaviour {
    public Text setttingTitle;
    public int mode;

    public Button btn_easy;
    public Button btn_normal;
    public Button btn_hard;

    public Button btn_place1;
    public Button btn_place2;
    public Text HighestScoreText;

    private PlayerProgrss playerProgess;

    // Use this for initialization
    void Start () {
        playerProgess = new PlayerProgrss();
        btn_place1.interactable = false;
        btn_place1.gameObject.SetActive(false);
        btn_place2.interactable = false;
        btn_place2.gameObject.SetActive(false);
        btn_easy.interactable = false;
        btn_easy.gameObject.SetActive(false);
        btn_normal.interactable = false;
        btn_normal.gameObject.SetActive(false);
        btn_hard.interactable = false;
        btn_hard.gameObject.SetActive(false);
        getMode();

        if (PlayerPrefs.HasKey("highestScore"))
        {
            playerProgess.higestScose = PlayerPrefs.GetInt("highestScore");
        }
        else
            playerProgess.higestScose = 0;

    }
	
	// Update is called once per frame
	void Update () {

        HighestScoreText.text = "Highest Score : " + playerProgess.higestScose;
    }

    public void EasyLvl() {
        Debug.Log("Easy");
        submitGameLevel(1);
        SetMode();
    }
    public void NormalLvl()
    {
        Debug.Log("Normal");
        submitGameLevel(2);
        SetMode();
    }
    public void HardLvl()
    {
        Debug.Log("Hard");
        submitGameLevel(3);
        SetMode();
        
    }

    public void place1()
    {
        Debug.Log("place1");
        SavePlayerProgress();
        SceneManager.LoadScene("development");
    }
    public void place2()
    {
        Debug.Log("place2");
    }

    void SetMode()
    {
        if (mode == 1)
        {
            Debug.Log("1");
            mode = 2;
            getMode();
            
        }
        else
        {
            Debug.Log("2");
            mode = 1;
            getMode();
            
        }
    }

    void getMode() {
        if (mode == 1)
        {
            Debug.Log("1");
            setttingTitle.text = "LEVEL";
            btn_place1.interactable = false;
            btn_place1.gameObject.SetActive(false);
            btn_place2.interactable = false;
            btn_place2.gameObject.SetActive(false);

            btn_easy.interactable = true;
            btn_easy.gameObject.SetActive(true);
            btn_normal.interactable = true;
            btn_normal.gameObject.SetActive(true);
            btn_hard.interactable = true;
            btn_hard.gameObject.SetActive(true);


        }
        else
        {
            Debug.Log("2");
            setttingTitle.text = "VENUE";
            btn_place1.interactable = true;
            btn_place1.gameObject.SetActive(true);
            btn_place2.interactable = true;
            btn_place2.gameObject.SetActive(true);

            btn_easy.interactable = false;
            btn_easy.gameObject.SetActive(false);
            btn_normal.interactable = false;
            btn_normal.gameObject.SetActive(false);
            btn_hard.interactable = false;
            btn_hard.gameObject.SetActive(false);
        }
    }



    public void Quit()
    {
        if (mode == 2)
        {
            mode = 1;
            getMode();
        }
        else {
            Debug.Log("quit");
            Application.Quit();
        }
    }

    public void submitGameLevel(int gameLevel)
    {
        playerProgess.gameLevel = gameLevel;
    }

    private void SavePlayerProgress()
    {
        PlayerPrefs.SetInt("gameLevel", playerProgess.gameLevel);
    }

}
