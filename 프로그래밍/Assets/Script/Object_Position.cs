using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 드래그를 통해서 ObjectDrag가 활성화 되었을 때 스크립트가 호출되어 사용됨

public class Object_Position : MonoBehaviour
{
    Character_State[] cs = new Character_State[4];
    [SerializeField] Transform[] Center = null; // 패널 4개의 중앙 좌표를 받음
    [SerializeField] RectTransform[] PanelRect = null;  // 패널4개의 폭넓이
    [SerializeField] RectTransform[] G_Object = null;   // 오브젝트의 좌표
    Vector2[] Range1 = null;    // 패널 x좌표의 최대최소
    Vector2[] Range2 = null;    // 패널 y좌표의 최대최소 (Range변수는 패널의 최대 최소 좌표를 통하여 오브젝트가 패널 안에 있는지를 체크
    int[] flag = new int[4]; // 패널에 어느 오브젝트가 들어갔는지 체크(임시)
    public string[,] Char_Plan = new string[2, 4]; // Char_Plan[0,n]은 이름을 저장, Char_Plan[1,n]은 이름에 배정되는 작업이름 저장
    public bool[] p_check = new bool[4];          // 4개의 패널 중에서 작업이 배정 안된 것은 FALSE값을 가짐

    void Start()
    {
        Debug.Log(name);


        cs[0] = GameObject.Find("Lobe(Player)").GetComponent<Character_State>();
        cs[1] = GameObject.Find("Greedia(Character_2)").GetComponent<Character_State>();
        cs[2] = GameObject.Find("Narci(Character_3)").GetComponent<Character_State>();
        cs[3] = GameObject.Find("Pesshiho(Character_4)").GetComponent<Character_State>();

        Range1 = new Vector2[Center.Length];
        Range2 = new Vector2[Center.Length];

        for (int i = 0; i < PanelRect.Length; i++)
        {
            Range1[i].Set(Center[i].position.x - PanelRect[i].rect.width / 2, Center[i].position.x + PanelRect[i].rect.width / 2);
            Range2[i].Set(Center[i].position.y - PanelRect[i].rect.height / 2, Center[i].position.y + PanelRect[i].rect.height / 2);
        }
    }

    void Update()
    {
      
    }
    public void CheckInPanel()
    {
        // 오브젝트가 패널안에 있는지를 체크하고 
        // yes -> 정중앙 위치 어느패널에 있는지에 따라 작업 배정
        for (int i = 0; i < PanelRect.Length; i++)
        {
            for (int j = 0; j < PanelRect.Length; j++)
            {
                if (G_Object[i].position.x >= Range1[j].x && G_Object[i].position.x <= Range1[j].y)
                {

                    if (G_Object[i].position.y >= Range2[j].x && G_Object[i].position.y <= Range2[j].y)
                    {
                        if (flag[j] == 0)
                        {
                            Debug.Log("정중앙 위치");
                            G_Object[i].transform.position = new Vector2(Center[j].position.x, Center[j].position.y);
                            flag[j] = i + 1; // 현재로서는 이름:i가 j번째 패널에 배치됨을 표시, 추후에 수정 예정
                            Char_Plan[0, j] = string.Format("{0}", i + 1);
                            p_check[j] = true;
                            if (j == 0)
                                cs[i].work = "취사";                                                        
                            //Char_Plan[1, j] = "취사";                     
                            else if (j == 1)
                                cs[i].work = "경계";
                            //Char_Plan[1, j] = "경계";
                            else
                                cs[i].work = "탐색";
                            //Char_Plan[1, j] = "탐색";

                            Debug.Log("작업 배정 : "+Char_Plan[1,j]);
                            Debug.Log(flag[j]);
                            Debug.Log(j + "번째 들어감");
                            Debug.Log(i + "번째 오브젝트");
                        }
                        

                    }
                }
            }
        }
        for (int i = 0; i < 4; i++)
            Debug.Log(cs[i].work);
    }
    public void CheckFlag()
    {
        // 패널안에 들어갔다가 오브젝트가 밖으로 나왔을 경우를 체크
        for (int i = 0; i < 4; i++)
            Debug.Log("플래그" + i + "번째 " + flag[i]);
        for (int i = 0; i < PanelRect.Length; i++)
        {
            if (flag[i] != 0)
            {
                if (G_Object[flag[i] - 1].position.x >= Range1[i].x && G_Object[flag[i] - 1].position.x <= Range1[i].y
                    && G_Object[flag[i] - 1].position.y >= Range2[i].x && G_Object[flag[i] - 1].position.y <= Range2[i].y)
                {

                    Debug.Log("이미 선택 되어 있음.");
                    Debug.Log(flag[i]);
                    Debug.Log(i);

                }
                else
                {
                    cs[i].work = "없음";
                    flag[i] = 0;
                    p_check[i] = false;
                    Char_Plan[0, i] = null;
                    Char_Plan[1, i] = null;
                }
            }
        }
    }
    public void print() // 제대로 배정되었는지 확인 (디버그 용도 지워도 문제 없음)
    {
        for (int i = 0; i < 4; i++)
        {
            Debug.Log("tf" + p_check[i]);
            Debug.Log("캐릭이름" + Char_Plan[0, i]);
            Debug.Log("작업" + Char_Plan[1, i]);
        }
    }
    public void set()
    {
        Start();
        CheckFlag();
        CheckInPanel();
        print();
    }
}
