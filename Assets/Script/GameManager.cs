using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	public Text log;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	//純粋なセッター
	void SetLogClean(string txt){
		log.text = txt + "\n";
	}

	//ログに反映させるメソッド
	void SetLogAdd(string txt){
		log.text = log.text + txt + "\n";
	}


}
