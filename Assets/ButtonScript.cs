using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour {
	private int buttonID;
	public GameObject instance;
	private bool touch = false;
	// Use this for initialization
	void Start () {
		buttonID = int.Parse (this.transform.tag);
		instance = this.gameObject;
	}
	
	// Update is called once per frame
	void Update () {
		if (PassManager.nowDrag == false) {
			touch = false;
			ChangeWhite ();
		}
	}

	public void DragStart(){
		PassManager.nowDrag = true;
		if (buttonID == PassGenerate.pass [0]) {
			PassManager.nowPass++;
			touch = true;
			ChangeGreen ();
		} else {
			ChangeRed ();
			StartCoroutine ("Miss");
		}
	}
	public void DragEnd(){
		ChangeWhite ();
		PassManager.nowDrag = false;
		Miss ();
	}
	public void Drag(){
		if (PassManager.nowDrag == true && touch == false) {
			if (buttonID == PassGenerate.pass [PassManager.nowPass]) {
				ChangeGreen ();
				PassManager.nowPass++;
				touch = true;
				if (PassManager.nowPass == 9) {
					Debug.Log ("Clear!");
				}
			} else {
				ChangeRed ();
				StartCoroutine ("Miss");
			}
		}
	}
	private void ChangeRed(){
		this.GetComponent<Image> ().color = new Color(255.0f/255.0f, 0f/255.0f, 0f/255.0f, 255.0f/255.0f);
	}
	private void ChangeWhite(){
		this.GetComponent<Image> ().color = new Color(255.0f/255.0f, 255.0f/255.0f, 255.0f/255.0f, 255.0f/255.0f);
	}
	private void ChangeGreen(){
		this.GetComponent<Image> ().color = new Color(0f/255.0f, 255.0f/255.0f, 0f/255.0f, 255.0f/255.0f);	
	}
	IEnumerator Miss(){
		PassManager.nowPass = 1;
		yield return new WaitForSeconds(0.5f);
		ChangeWhite ();
		PassManager.nowDrag = false;
		touch = false;
	}
}
