using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SelectMenu : MonoBehaviour {

    [SerializeField] GameObject menuBar;

    public void MenuOpenClose()
    {
        bool menuOpen = menuBar.activeSelf; //메뉴 여닫기
        menuBar.SetActive(!menuOpen);
    }

    public void StartPage()
    {
        SceneManager.LoadScene("StartPage"); //이후 메뉴로 변경하면 될 항목
    }

    public void save()
    {

    }

    public void load()
    {

    }
}
