﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sliderupdate : MonoBehaviour {
    Text text;

	// Use this for initialization
	void Start () {
        text = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {

	}

    public void setSlidervalue(float slidervalue)
    {
        text.text = slidervalue.ToString();
    }
}
