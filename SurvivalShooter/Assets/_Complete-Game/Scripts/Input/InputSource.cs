using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputSource : MonoBehaviour
{
    public InputManager inputManager;
   
    void Start()
    {
        if (!inputManager)
            inputManager = GameObject.FindObjectOfType<InputManager>();
    }

    private void Update()
    {
        inputManager.SetPlayerIsShooting(Input.GetButton("Fire1"));
    }
    
    private void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        inputManager.MovePlayer(h, v);

        inputManager.TurnPlayer(Input.mousePosition);
    }
}
