using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Go_StartPage : MonoBehaviour {

    public void StartPage()
    {
        SceneManager.LoadScene("StartPage"); //이후 메뉴로 변경하면 될 항목
    }
}
