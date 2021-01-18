using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BasecampButton : MonoBehaviour {

    [SerializeField] GameObject panel;

    private int day = 0; //진행일수

    public void UIOpen()
    {
        bool open = panel.activeSelf; //panel상태를 activeself로 확인
        panel.SetActive(!open);
    }

    public void Action()
    {
        if(day == 0) //진행일수에 따른 이벤트 변경 요소
            SceneManager.LoadScene("ScriptScene");
    }
}
