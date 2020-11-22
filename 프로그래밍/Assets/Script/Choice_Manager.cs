using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Choice_Manager : MonoBehaviour {

    //public static Turning_Manager instance;

    //private string question;
    private List<string> answerList;

    public GameObject go; //평소에 비활성화 목적. setActive

    //public Text question_Text; //선택지 위에 질문(설명)을 따로 표기할 경우
    public Text[] answer_Text;
    public GameObject[] answer_Button;

    public bool choiceIng; //대기 ()=> !choiceIng
    private bool keyInput; //키처리

    private int count; //배열의 크기
    private int result; //선택한 결과물

    private WaitForSeconds waitTime = new WaitForSeconds(0.01f);


    // Use this for initialization
    void Start () {
        answerList = new List<string>();

        for(int i = 0; i < answer_Text.Length; i++)
        {
            answer_Text[i].text = "";
            answer_Button[i].SetActive(false);
        }
        //question_Text.text = "";
	}

    public void ShowChoice(Choice_Point _choice) //선택지 창 활성화
    {
        choiceIng = true;
        go.SetActive(true);
        result = 0;
        //question = _choice.question;
        for(int i = 0; i < _choice.answers.Length; i++)
        {
            answerList.Add(_choice.answers[i]);
            answer_Button[i].SetActive(true);
            count = i;
        }
        Selection();
        StartCoroutine(ChoiceCoroutine());
    }

    public void ExitChoice()
    {
        for(int i = 0; i <= count; i++)
        {
            answer_Text[i].text = "";
            answer_Button[i].SetActive(false);
        }

        answerList.Clear();
        //question_Text.text = "";
        choiceIng = false;
        go.SetActive(false);
    }

    public int Getresult()
    {
        return result;
    }

    IEnumerator ChoiceCoroutine()
    {
        //TypingQuestion());
        TypingAnswer();

        yield return new WaitForSeconds(0.2f);
        keyInput = true;
    }

    /*public void TypingQuestion() //선택지 창 외에 따로 질문(설명) 창이 있을 경우
    {
        for(int i = 0; i < question.Length; i++)
        {
            question_Text.text += question[i];
        }
        return;
    }*/

    public void TypingAnswer()
    {
        for (int i = 0; i <= count; i++)
        {
            for(int j = 0; j < answerList[i].Length; j++)
            {
                answer_Text[i].text += answerList[i][j];
            }
        }
        return;
    }

    // Update is called once per frame
    void Update () {
        if (keyInput)
        {
            /*if (OnMouseOver())
            {
                if (result > 0)
                    result--;
                else
                    result = count;
            }*/
            if (Input.GetKeyDown(KeyCode.UpArrow))//Input.OnMouseEnter()
            {
                if (result > 0)
                    result--;
                else
                    result = count;
                Selection();
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                if (result < 0)
                    result++;
                else
                    result = count;
                Selection();
            }
            else if (Input.GetKeyDown(KeyCode.Z) || Input.GetMouseButtonUp(0))//Input.GetMouseButtonUp())
            {
                keyInput = false;
                ExitChoice();
                Getresult();
            }
        }
	}

    public void Selection() //무엇이 선택되었는지 알기 위한 함수
    {
        Color color = answer_Button[0].GetComponent<Image>().color;
        color.a = 0.75f;
        for(int i = 0; i <= count; i++)
        {
            answer_Button[0].GetComponent<Image>().color = color;
        }
        color.a = 1f;
        answer_Button[result].GetComponent<Image>().color = color;
    }

    private void OnMouseOver()
    {
        keyInput = true;
        Selection();
    }
}
