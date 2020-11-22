using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChoiceAct : MonoBehaviour {

	public void Go_Basecamp()
    {
        SceneManager.LoadScene("Basecamp");
    }

    public void Go_Explore()
    {
        SceneManager.LoadScene("Scene_ExploreTask");
    }
}
