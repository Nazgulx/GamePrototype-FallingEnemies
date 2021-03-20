using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

[RequireComponent(typeof(Controller2D))]

public class Player : MonoBehaviour {

    float moveSpeed = 6f;
    float gravity = -20;
    Vector3 velocity;

    Controller2D controller;
    
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<Controller2D>();
    }

    void Update() {
        Vector2 input = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

        velocity.x = input.x * moveSpeed;
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }


}
