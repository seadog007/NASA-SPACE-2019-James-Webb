﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameData
{

    public static int money = 3500;
    public static int tech_point = 1;
    public static int round_money = 2;
    public static int round_tech = 1;
    public static int current_round = 1;
    //int STOCK_PRICE;
    public static int RESEARCH_PRICE = 2000;
    public static float RESEARCH_RATE = 1f;
    public static int STOCK_PRICE = 1000;
    public static float STOCK_RATE = 0.05f;
    public static int MAX_ROUND = 30;

    public static bool gameover = false;
}

public class Data_Manager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    { 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   
}