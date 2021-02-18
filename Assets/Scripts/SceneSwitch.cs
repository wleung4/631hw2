using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    public void SwitchToScene1(){
        SceneManager.LoadScene("Scene 1");
    }

    public void switchToScene2(){
        SceneManager.LoadScene("Scene 2");
    }
}
