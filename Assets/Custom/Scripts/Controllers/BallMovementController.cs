using Assets.Custom.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovementController : MonoBehaviour
{

    private GameManager _gameManager;

    // Start is called before the first frame update
    void Start()
    {
        _gameManager = GameManager.Instance;

        _gameManager.BallPosition = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(_gameManager.BallPosition != gameObject.transform.position)
        {
            gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, _gameManager.BallPosition, 0.1f);
        }
    }
}
