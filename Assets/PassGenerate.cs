using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class PassGenerate : MonoBehaviour {
    public static int[] basicPass = new int[9] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
    public static int[] pass = new int[9];
    List<List<int>> passList = new List<List<int>>();
   /* private int[] nextPass1 = new int[3] { 2, 4, 5 };
    private int[] nextPass2 = new int[5] { 1, 3, 4, 5, 6 };
    private int[] nextPass3 = new int[3] { 2, 5, 6 };
    private int[] nextPass4 = new int[5] { 1, 2, 5, 7, 8 };
    private int[] nextPass5 = new int[8] { 1, 2, 3, 4, 6, 7, 8, 9 };
    private int[] nextPass6 = new int[5] { 2, 3, 5, 8, 9 };
    private int[] nextPass7 = new int[3] { 4, 5, 8 };
    private int[] nextPass8 = new int[5] { 4, 5, 6, 7, 9 };
    private int[] nextPass9 = new int[3] { 5, 6, 8 };*/
    private int nowPass = 0;
    private int l = 1;
	// Use this for initialization
	void Start () {
        
        PassGanerate();

	}
	
    void PassListAdd(){
        passList.Add(new List<int>(new int[] { 2, 4, 5 }));
    }
    void PassGanerate(){
        List<int> passCopy = basicPass.ToList();
        for (int i = 0; i <= 8; i++)
        {
            if (i == 0)
            {
                pass[0] = UnityEngine.Random.Range(1, 9);
                passCopy.Remove(pass[0]);
            }
            else
            {
                int j = nextPass(i);
                List<int> blackList = new List<int>{};
                while (passCopy.IndexOf(j) == -1)
                {
                    if (blackList.IndexOf(j) == -1)
                    {
                        blackList.Add(j);
                    }
                    //ifでブラックリスト内に上のnextPass(多次元配列のListにする）の中身が全部入ってたらreturn
                    j = nextPass(i);
                }

                pass[i] = j;
                passCopy.Remove(j);
            }
        }
    }
	// Update is called once per frame
	void Update () {
		
	}
    private int nextPass(int i){
        if(pass[i-1] == 1){
            int k = UnityEngine.Random.Range(0, 2);
            return nextPass1[k];
        }else if(pass[i-1] == 2){
            int k = UnityEngine.Random.Range(0, 4);
            return nextPass2[k];
        }else if(pass[i-1] == 3){
            int k = UnityEngine.Random.Range(0, 2);
            return nextPass3[k];
        }else if(pass[i-1] == 4){
            int k = UnityEngine.Random.Range(0, 4);
            return nextPass4[k];
        }else if(pass[i-1] == 5){
            int k = UnityEngine.Random.Range(0, 7);
            return nextPass5[k];
        }else if(pass[i-1] == 6){
            int k = UnityEngine.Random.Range(0, 4);
            return nextPass6[k];
        }else if(pass[i-1] == 7){
            int k = UnityEngine.Random.Range(0, 2);
            return nextPass7[k];
        }else if(pass[i-1] == 8){
            int k = UnityEngine.Random.Range(0, 4);
            return nextPass8[k];
        }else if(pass[i-1] == 9){
            int k = UnityEngine.Random.Range(0, 2);
            return nextPass9[k];
        }else{
            return 1;
        }
    }
}
