﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  // UI部品を使うために必要！

public class GameDirector : MonoBehaviour {

	GameObject car;
	GameObject flag;
	GameObject distance;

	void Start () {
			this.car = GameObject.Find("car");
			this.flag = GameObject.Find("flag");
			this.distance = GameObject.Find("Distance");
	}

	void Update () {
			float length = this.flag.transform.position.x - this.car.transform.position.x;
			if(length >= 0){
				this.distance.GetComponent<Text>().text = "ゴールまで" + length.ToString("F2") + "m";
			} else {
				this.distance.GetComponent<Text>().text = "Game Over";
			}
	}
}
