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
}

public class Scene_Dialogue : MonoBehaviour
{

    [SerializeField] private SpriteRenderer StandingCG;
    [SerializeField] private CanvasRenderer DialrogueBox; //이후 그림으로 적용시 SpriteRenderer 변수 사용
    [SerializeField] private Text name_Dialogue; //등장인물 이름 적용시 활성
    [SerializeField] private Text txt_Dialogue;

    private bool isDialogue = true;
    private int count = 0;

    [SerializeField] private Dialogue[] dialogue;

    public void Start_Dialogue()
    {
        DialrogueBox.gameObject.SetActive(true);
        StandingCG.gameObject.SetActive(true);
        txt_Dialogue.gameObject.SetActive(true);
        name_Dialogue.gameObject.SetActive(true);

        count = 0;
        NextDialogue();
    }

    private void NextDialogue()
    {
        txt_Dialogue.text = dialogue[count].dialogue;
        name_Dialogue.text = dialogue[count].dialogue;
        StandingCG.sprite = dialogue[count].cg;
        count++;
    }

    // Update is called once per frame
    void Update()
    { 
        if (isDialogue)
        {
            if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.KeypadEnter) /*|| Input.GetMouseDown(0)*/)
            {
                if (count < dialogue.Length)
                    NextDialogue();
                else
                    SceneManager.LoadScene("Basecamp");
            }
        }
    }
}
