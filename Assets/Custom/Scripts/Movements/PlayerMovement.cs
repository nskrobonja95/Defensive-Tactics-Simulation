using Assets.Custom.Scripts;
using Assets.Custom.Scripts.FootballLogic;
using Assets.Custom.Scripts.States;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlayerMovement : MonoBehaviour
{
    public float PlayerSpeed;

    protected Vector3 HomePosition;

    protected GameObject ballObj;

    protected Terrain footballFieldTerrain;

    protected GameObject footballField;

    protected FootballField field;

    protected Vector3 newPosition;

    protected Vector3 orientation;

    private GameManager _gameManager;

    Animator animator;

    protected abstract void CalculateBestPosition(Vector3 homePosition, 
        Vector3 ballPosition, int fieldWidth, int fieldLength);

    //private PlayerState currentState;

    void Start()
    {
        _gameManager = GameManager.Instance;
        HomePosition = gameObject.transform.position;
        newPosition = HomePosition;
        ballObj = GameObject.Find("BallObj");
        //footballField = GameObject.Find("FootballFieldTerrain");
        //footballFieldTerrain = footballField.GetComponent<Terrain>();
        //field = new FootballField((int)footballFieldTerrain.terrainData.size.x,
        //     (int)footballFieldTerrain.terrainData.size.z, 0.2f);
        field = new FootballField((int)_gameManager.FieldWidth, (int)_gameManager.FieldLength, 0.2f);
        PlayerSpeed = 0.099f;
        if (this.gameObject.transform.GetChild(0).GetComponent<Animator>() != null)
        {
            animator = this.gameObject.transform.GetChild(0).GetComponent<Animator>();            
        }
        else
        {
            animator = GetComponent<Animator>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        CalculateBestPosition(HomePosition, ballObj.transform.position, 
            (int)_gameManager.FieldWidth, (int)_gameManager.FieldLength);
        if (gameObject.transform.position != newPosition) {
            animator.SetBool("Running", true);
            orientation = newPosition - gameObject.transform.position;
            gameObject.transform.rotation = Quaternion.LookRotation(orientation);
            gameObject.transform.position = Vector3.MoveTowards(
                gameObject.transform.position, newPosition, PlayerSpeed);
        }
        else
        {
            orientation = ballObj.transform.position - gameObject.transform.position;
            gameObject.transform.rotation = Quaternion.LookRotation(orientation);
            animator.SetBool("Running", false);
        }
    }

    
       
}
