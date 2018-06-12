using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class ClearScene : MonoBehaviour {
    
	// Use this for initialization
	void Start () {
        GameObject scoreText = GameObject.Find("Score");
        Text text = scoreText.GetComponent<Text>();
        text.text = TimeManager.clearTime.ToString("F1");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void TitleBack(){
        SceneManager.LoadScene("Title");
    }
}
