﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class look : MonoBehaviour
{
    // Start is called before the first frame update
    void Update()
    {
        this.transform.LookAt(Camera.main.transform.position);
    }
}
