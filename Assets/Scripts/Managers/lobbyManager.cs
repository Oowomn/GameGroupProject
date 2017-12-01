using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[System.Serializable]
public class lobbyManager : MonoBehaviour {
    Canvas canvas;
    public Text setttingTitle;
    public int mode;

    public Button btn_easy;
    public Button btn_normal;
    public Button btn_hard;

    public Button btn_place1;
    public Button btn_place2;

    // Use this for initialization
    void Start () {
        canvas = GetComponent<Canvas>();
        getMode();
    }
	
	// Update is called once per frame
	void Update () {

    }

    public void EasyLvl() {
        Debug.Log("Easy");
        SetMode();
    }
    public void NormalLvl()
    {
        Debug.Log("Normal");
        
    }
    public void HardLvl()
    {
        Debug.Log("Hard");
        SetMode();
    }

    public void place1()
    {
        Debug.Log("place1");
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

}
