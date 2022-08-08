using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enterLevels : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void OpenScene()
    {
        SceneManager.LoadScene("level1");
        SceneManager.LoadScene("level2");
        SceneManager.LoadScene("level3");
        SceneManager.LoadScene("level4");
    }
}
