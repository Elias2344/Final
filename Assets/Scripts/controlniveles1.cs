using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class controlniveles : MonoBehaviour
{
    // Start is called before the first frame update
    
    public void Lv1(){
        SceneManager.LoadScene("SceneManagemen");
    }
    public void BackToMenu(){
        SceneManager.LoadScene("menu");   
    }
}
