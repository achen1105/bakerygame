using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManager : MonoBehaviour
{
    // main scene = 0
    // about scene = 1
    // start scene = 2
    public int sceneNum;

    
    // Start is called before the first frame update
    void Start()
    {
        sceneNum = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }

    // changeScene is called once per frame
    /**
        @param sNum the new scene number
    */
    public void changeScene(int sNum)
    {
        sceneNum = sNum;

        if (sNum == 1)
        {
            SceneManager.LoadScene();
        }
    }
    


}
