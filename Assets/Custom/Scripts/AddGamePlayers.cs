using Assets.Custom.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddGamePlayers : MonoBehaviour
{
    private GameManager gameManager;

    public GameObject gamePlayer;

    private List<GameObject> generatedDefensivePlayers;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameManager.Instance;
        generatedDefensivePlayers = new List<GameObject>();

        GameObject instance = Instantiate(gamePlayer, gameObject.transform);
        instance.transform.position= gameManager.Players[0].HomePosition;
        generatedDefensivePlayers.Add(instance);

        instance = Instantiate(gamePlayer, gameObject.transform);
        instance.transform.position = gameManager.Players[1].HomePosition;
        generatedDefensivePlayers.Add(instance);

        instance = Instantiate(gamePlayer, gameObject.transform);
        instance.transform.position = gameManager.Players[2].HomePosition;
        generatedDefensivePlayers.Add(instance);

        instance = Instantiate(gamePlayer, gameObject.transform);
        instance.transform.position = gameManager.Players[3].HomePosition;
        generatedDefensivePlayers.Add(instance);

        instance = Instantiate(gamePlayer, gameObject.transform);
        instance.transform.position = gameManager.Players[4].HomePosition;
        generatedDefensivePlayers.Add(instance);

        instance = Instantiate(gamePlayer, gameObject.transform);
        instance.transform.position = gameManager.Players[5].HomePosition;
        generatedDefensivePlayers.Add(instance);

        instance = Instantiate(gamePlayer, gameObject.transform);
        instance.transform.position = gameManager.Players[6].HomePosition;
        generatedDefensivePlayers.Add(instance);

        instance = Instantiate(gamePlayer, gameObject.transform);
        instance.transform.position = gameManager.Players[7].HomePosition;
        generatedDefensivePlayers.Add(instance);

        instance = Instantiate(gamePlayer, gameObject.transform);
        instance.transform.position = gameManager.Players[8].HomePosition;
        generatedDefensivePlayers.Add(instance);

        instance = Instantiate(gamePlayer, gameObject.transform);
        instance.transform.position = gameManager.Players[9].HomePosition;
        generatedDefensivePlayers.Add(instance);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
