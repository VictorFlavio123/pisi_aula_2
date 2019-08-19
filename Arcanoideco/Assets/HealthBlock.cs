using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBlock : MonoBehaviour {

    public Color healthColor;
    private Color originalColor;
    private Renderer myRenderer;
    private Animation myAnimation;
    public int health = 3;

    public bool IsDead
    {
        get
        {
            return health <= 0;
        }
    }

    private void Start()
    {
        myRenderer = GetComponentInChildren<Renderer>();
        myAnimation = GetComponentInChildren<Animation>();

        originalColor = myRenderer.material.color;

        myRenderer.material.color = healthColor;
    }

    internal void GetDamaged(int v)
    {
        health -= v;
        myAnimation.Play();

        if (health <= 1)
            myRenderer.material.color = originalColor;
        if (IsDead)
            Destroy(gameObject);
    }
}
