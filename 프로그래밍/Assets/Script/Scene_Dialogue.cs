using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[System.Serializable]

public class Dialogue
{
    [TextArea]
    public string dialogue;
    public Sprite cg;
    public string name; //캐릭터 이름 직접 입력할 경우 활성
}

public class Scene_Dialogue : MonoBehaviour
{
    private Choice_Manager theChoice;
    public Choice_Point point;

    [SerializeField] private SpriteRenderer StandingCG;
    [SerializeField] private CanvasRenderer DialrogueBox; //대화창. 이후 그림으로 적용시 SpriteRenderer 변수 사용
    [SerializeField] private Text name_Dialogue; //등장인물 이름 적용시 활성
    [SerializeField] private Text txt_Dialogue;

    private bool isDialogue = false;
    private int count = 0;

    [SerializeField] private Dialogue[] dialogue;

    [SerializeField] bool isAutoEvent = false;
    public int goNextEvent; //다음 이벤트 선택번호. 개발 과정에서 직접 입력
    public bool isChoice = false; //true일 경우 선택지 이벤트 발동

    public void Start_Dialogue()
    {
        DialrogueBox.gameObject.SetActive(true);
        StandingCG.gameObject.SetActive(true);
        txt_Dialogue.gameObject.SetActive(true);
        name_Dialogue.gameObject.SetActive(true);

        count = 0;
        NextDialogue();
    }

    public void EndDialogue() //모든 대사가 끝난 후의 행동
    {
        DialrogueBox.gameObject.SetActive(false);
        StandingCG.gameObject.SetActive(false);
        txt_Dialogue.gameObject.SetActive(false);
        name_Dialogue.gameObject.SetActive(false);
        isDialogue = false;

        if (isChoice) //정해진 선택지에 의한 다음 행동 선택
        {
            theChoice.ShowChoice(point);
        }
        else if (!isChoice) //개발자의 다음 신 선택
        {
            GoNextEvent(goNextEvent);
        }
    }

    private void NextDialogue()
    {
        txt_Dialogue.text = string.Empty; //다른 문장 지우고 시작
        StopAllCoroutines();

        StartCoroutine(TypeSentence(dialogue[count].dialogue));
        StandingCG.sprite = dialogue[count].cg;
        name_Dialogue.text = dialogue[count].name; //캐릭터 이름 직접 입력할 경우 활성
        //name_Dialogue.text = dialogue[count].cg.ToString(); //캐릭터 이름을 파일 이름으로 출력할 경우 활성
        count++;
    }

    IEnumerator TypeSentence(string dialogue) //텍스트 시간단위 입력
    {
        foreach (var letter in dialogue)
        {
            txt_Dialogue.text += letter;
            yield return new WaitForSeconds(0.05f);
        }
    }

    public void GoNextEvent(int eventNum) //
    {
        if(eventNum == 0)
            SceneManager.LoadScene("Basecamp");
    }

    // Use this for initialization
    void Start()
    {
        isDialogue = true;
        theChoice = FindObjectOfType<Choice_Manager>();
    }

    // Update is called once per frame
    void Update()
    { 
        if (isDialogue)
        {
            if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.KeypadEnter) || Input.GetKeyDown(KeyCode.Return) || Input.GetMouseButtonDown(0))
            {
                if (count < dialogue.Length)
                    NextDialogue();
                else
                    EndDialogue();
            }
        }
    }
}
