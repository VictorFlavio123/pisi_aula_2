using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageManager : MonoBehaviour {

    private Vector3 ballStartPosition, ballStartMinSpeed, ballStartMaxSpeed;
    public Vector3 ballStartSpeed;
    public BolinhaPhysics bolinha;

    public Transform destructableParent, bolinhasParent;


    public float powerupInterval;
    private float powerupTimer;
    public GameObject[] powerups;
    public Transform powerupArea;


    private void Start()
    {
        ballStartPosition = bolinha.transform.position;
        ballStartMinSpeed = bolinha.minSpeed;
        ballStartMaxSpeed = bolinha.maxSpeed;


        RespawnBall();
    }
    private void FixedUpdate()
    {
        powerupTimer += Time.fixedDeltaTime;
        if (powerupTimer >= powerupInterval)
        {
            powerupTimer = 0;
            InstantiatePowerup();
        }

        if (destructableParent.childCount <= 0)
            StageOver();

        //if (bolinhasParent.childCount <= 0)
        //    RespawnBall();

    }

    public void StageOver()
    {
        Debug.Log("Próximo fase");
        int current = SceneManager.GetActiveScene().buildIndex;
        int count = SceneManager.sceneCountInBuildSettings;
        SceneManager.LoadScene((current + 1) % count);
    }
    public void RespawnBall()
    {
        bolinha.transform.position = ballStartPosition;
        bolinha.myRigidbody.velocity = ballStartSpeed;
        bolinha.minSpeed = ballStartMinSpeed;
        bolinha.maxSpeed = ballStartMaxSpeed;
    }
    public void InstantiatePowerup()
    {
        var powerup = powerups[Random.Range(0,powerups.Length)];
        powerup = Instantiate(powerup);

        powerup.transform.position = powerupArea.position + new Vector3(Random.Range(-1, 1) * powerupArea.localScale.x / 2, Random.Range(-1, 1) * powerupArea.localScale.y / 2, 0);
    }





}
