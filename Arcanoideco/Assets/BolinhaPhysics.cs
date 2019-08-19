using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolinhaPhysics : MonoBehaviour {


    public Vector2 maxSpeed;
    public Vector2 minSpeed;
    public Rigidbody myRigidbody;
    public Renderer myRenderer;

    private Color originalColor;
    public Color pierceColor;


    public float piercing = 0;

    private Vector3 lastVelocity;


    public void SetPierceTime(float time)
    {
        piercing = time;
        if (piercing > 0)
            myRenderer.material.color = pierceColor;
    }


    private void Awake()
    {
        myRigidbody = GetComponent<Rigidbody>();
        myRenderer = GetComponent<Renderer>();

        originalColor = myRenderer.material.color;
    }
    private void OnCollisionEnter(Collision collision)
    {
        var col = collision.collider;
        if (col.tag == "Destructable")
        {
            var health = col.GetComponent<HealthBlock>();
            if (health == null)
            {
                Destroy(col.gameObject);
                //col.gameObject.SetActive(false);

                if (piercing > 0)
                    myRigidbody.velocity = lastVelocity;
            }
            else
            {
                health.GetDamaged(1);
                if(health.IsDead && piercing > 0)
                    myRigidbody.velocity = lastVelocity;
            }
        }
    }
    void FixedUpdate ()
    {
        Vector3 direction = myRigidbody.velocity;


        if (direction.x >= 0)
            direction.x = Mathf.Clamp(direction.x, minSpeed.x, maxSpeed.x);          
        else
            direction.x = Mathf.Clamp(direction.x, -maxSpeed.x, -minSpeed.x);

        if (direction.y > 0)
            direction.y = Mathf.Clamp(direction.y, minSpeed.y, maxSpeed.y);
        else
            direction.y = Mathf.Clamp(direction.y, -maxSpeed.y, -minSpeed.y);

        myRigidbody.velocity = direction;

        lastVelocity = myRigidbody.velocity;






        if (piercing > 0)
        {
            piercing -= Time.fixedDeltaTime;

            if (piercing <= 0)
                myRenderer.material.color = originalColor;
        }

    }
}
