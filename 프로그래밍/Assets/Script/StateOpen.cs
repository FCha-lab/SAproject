using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateOpen : MonoBehaviour {

    [SerializeField] GameObject statusMenu;

    public string statusPoint;
    private bool mouseClick;

    /*public void OnClick() //클릭 설정 실패작
    {
        statusOpen();
    }

    public void statusOpen()
    {
        bool status = statusMenu.activeSelf; //메뉴 여닫기
        statusMenu.SetActive(!status);
    }*/

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        /*if (mouseClick)
        {
            if (Input.GetMouseButtonDown(0))
            {
                OnClick();
            }
        }*/
	}
}
