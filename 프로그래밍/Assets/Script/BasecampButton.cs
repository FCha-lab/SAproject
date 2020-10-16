using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BasecampButton : MonoBehaviour {

    [SerializeField] GameObject panel;

    public void UIOpen()
    {
        bool open = panel.activeSelf; //panel상태를 activeself로 확인
        panel.SetActive(!open);
    }

    public void Action()
    {
        SceneManager.LoadScene("ScriptScene");
    }
}
