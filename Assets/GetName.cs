﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetName : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("NameText").GetComponentInChildren<Text>().text = NameSaver.PlayerName;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
