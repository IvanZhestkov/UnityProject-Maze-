﻿using System;
using UnityEngine;

[RequireComponent(typeof(MazeConstructor))]               

public class GameController : MonoBehaviour
{
    private MazeConstructor generator;

    void Start()
    {
        generator = GetComponent<MazeConstructor>();
		generator.GenerateNewMaze(13, 15);
    }
}