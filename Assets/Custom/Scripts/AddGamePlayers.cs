using Assets.Custom.Scripts;
using Assets.Custom.Scripts.Controllers;
using Assets.Custom.Scripts.Movements;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddGamePlayers : MonoBehaviour
{
    public GameObject leftBack;

    public GameObject rightBack;

    public GameObject leftCentralBack;

    public GameObject rightCentralBack;

    public GameObject leftMidfielder;

    public GameObject rightMidfielder;

    public GameObject leftWing;

    public GameObject rigthWing;

    public GameObject leftStriker;

    public GameObject rightStriker;

    private GameManager gameManager;

    public GameObject gamePlayer;

    private List<GameObject> generatedDefensivePlayers;

    // Start is called before the first frame update
    void Start()
    {

        gameManager = GameManager.Instance;
        generatedDefensivePlayers = new List<GameObject>();

        //leftBack.AddComponent<LeftBackMovement>();
        leftBack.transform.position= gameManager.Players[0].HomePosition;
        generatedDefensivePlayers.Add(leftBack);

        //leftCentralBack.AddComponent<LeftCentralBackMovement>();
        leftCentralBack.transform.position = gameManager.Players[1].HomePosition;
        generatedDefensivePlayers.Add(leftCentralBack);

        //rightCentralBack.AddComponent<RightCentralBackMovement>();
        rightCentralBack.transform.position = gameManager.Players[2].HomePosition;
        generatedDefensivePlayers.Add(rightCentralBack);

        //rightBack.AddComponent<RightBackMovement>();
        rightBack.transform.position = gameManager.Players[3].HomePosition;
        generatedDefensivePlayers.Add(rightBack);

        //rightMidfielder.AddComponent<RightDefensiveMidfielderMovement>();
        rightMidfielder.transform.position = gameManager.Players[4].HomePosition;
        generatedDefensivePlayers.Add(rightMidfielder);

        //leftMidfielder.AddComponent<LeftDefensiveMidfielderMovement>();
        leftMidfielder.transform.position = gameManager.Players[5].HomePosition;
        generatedDefensivePlayers.Add(leftMidfielder);

        //rigthWing.AddComponent<RightWingMovement>();
        rigthWing.transform.position = gameManager.Players[6].HomePosition;
        generatedDefensivePlayers.Add(rigthWing);

        //leftWing.AddComponent<LeftWingMovement>();
        leftWing.transform.position = gameManager.Players[7].HomePosition;
        generatedDefensivePlayers.Add(leftWing);

        //leftStriker.AddComponent<LeftStrikerMovement>();
        leftStriker.transform.position = gameManager.Players[8].HomePosition;
        generatedDefensivePlayers.Add(leftStriker);

        //rightStriker.AddComponent<RightStrikerMovement>();
        rightStriker.transform.position = gameManager.Players[9].HomePosition;
        generatedDefensivePlayers.Add(rightStriker);

        gameManager.DefensivePlayersAsGameObjects = generatedDefensivePlayers;

        gameManager._Formation.UpdatePlayerMovementScripts();

        GameObject[] offensivePlayers = GameObject.FindGameObjectsWithTag("OffensivePlayer");
        PlayerKitController.UpdateOffensivePlayerKits(offensivePlayers);

        PlayerKitController.UpdateDefensivePlayerKits(gameManager.DefensivePlayersAsGameObjects);
    }

    // Update is called once per frame
    void Update()
    {
    }
}
