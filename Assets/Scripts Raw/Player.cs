using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

[RequireComponent(typeof(Controller2D))]

public class Player : MonoBehaviour
{
    Controller2D controller;
    
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<Controller2D>();
    }

    
}
