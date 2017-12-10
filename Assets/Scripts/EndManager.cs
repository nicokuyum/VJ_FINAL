﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndManager : MonoBehaviour {
    public Text text;
	// Use this for initialization
	void Start () {
        switch (GameManager.Instance().Looser) {
            case -1:
                text.text = "";
                break;
            case 0:
                text.text = "Blue wins";
                text.color = new Color(74 /255f, 190/255f, 239/255f);
                break;
            case 1:
                text.text = "Red wins";
                text.color = Color.red;
                break;
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}