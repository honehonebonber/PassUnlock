using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class TimeManager : MonoBehaviour {
    float nowTime;
    public static float clearTime;
	// Use this for initialization
	void Start () {
        nowTime = 0f;
	}
	
	// Update is called once per frame
	void Update () {
        nowTime += Time.deltaTime;
        GetComponent<Text>().text = nowTime.ToString("F1");
	}
    public void Clear(){
        clearTime = nowTime;
        SceneManager.LoadScene("Clear");
    }
}
