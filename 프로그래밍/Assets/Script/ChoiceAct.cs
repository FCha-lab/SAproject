using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChoiceAct : MonoBehaviour {

	public void Go_Basecamp()
    {
        SceneManager.LoadScene("Basecamp");
    }

    public void Go_Explore_Greedia()
    {
        SceneManager.LoadScene("ExploreTask_Greedia");
    }

    public void Go_Explore_Narci()
    {
        SceneManager.LoadScene("ExploreTask_Narci");
    }

    public void Go_Explore_Pessiho()
    {
        SceneManager.LoadScene("ExploreTask_Pessiho");
    }

    public void add_dialogue()
    {

    }
}
