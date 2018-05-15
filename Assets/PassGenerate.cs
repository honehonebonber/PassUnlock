using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class PassGenerate : MonoBehaviour {
	public static int[] basicPass = new int[9]{1,2,3,4,5,6,7,8,9};
	public static int[] pass = new int[9];
	// Use this for initialization
	void Start () {
		pass = basicPass.OrderBy(i => Guid.NewGuid()).ToArray();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
