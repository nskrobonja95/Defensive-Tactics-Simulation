using Assets.Custom.Scripts;
using Assets.Custom.Scripts.Controllers;
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

        gameManager.DefensivePlayersAsGameObjects = generatedDefensivePlayers;

        GameObject[] offensivePlayers = GameObject.FindGameObjectsWithTag("OffensivePlayer");
        PlayerKitController.UpdateOffensivePlayerKits(offensivePlayers);
        /*foreach(GameObject offPlayer in offensivePlayers)
        {
            GameObject spine = offPlayer.transform.GetChild(0).gameObject;
            spine.transform.GetChild(0).gameObject.GetComponent<Renderer>().material.color = gameManager.SelectedAwayKit.ShirtColor;
            spine.transform.GetChild(2).gameObject.transform.GetChild(0).
                transform.GetChild(0).gameObject.GetComponent<Renderer>().material.color = gameManager.SelectedAwayKit.ShirtColor;
            spine.transform.GetChild(3).gameObject.transform.GetChild(0).
                transform.GetChild(1).gameObject.GetComponent<Renderer>().material.color = gameManager.SelectedAwayKit.ShirtColor;
            spine.transform.GetChild(4).gameObject.transform.GetChild(0).
                GetComponent<Renderer>().material.color = gameManager.SelectedAwayKit.ShortsColor;
            spine.transform.GetChild(5).gameObject.transform.GetChild(1).
                GetComponent<Renderer>().material.color = gameManager.SelectedAwayKit.ShortsColor;
        }*/

        PlayerKitController.UpdateDefensivePlayerKits(gameManager.DefensivePlayersAsGameObjects);
        /*foreach(GameObject defPlayer in gameManager.DefensivePlayersAsGameObjects)
        {
            GameObject spine = defPlayer.transform.GetChild(0).gameObject;
            spine.transform.GetChild(0).gameObject.GetComponent<Renderer>().material.color = gameManager.SelectedHomeKit.ShirtColor;
            spine.transform.GetChild(2).gameObject.transform.GetChild(0).
                transform.GetChild(0).gameObject.GetComponent<Renderer>().material.color = gameManager.SelectedHomeKit.ShirtColor;
            spine.transform.GetChild(3).gameObject.transform.GetChild(0).
                transform.GetChild(1).gameObject.GetComponent<Renderer>().material.color = gameManager.SelectedHomeKit.ShirtColor;
            spine.transform.GetChild(4).gameObject.transform.GetChild(0).
                GetComponent<Renderer>().material.color = gameManager.SelectedHomeKit.ShortsColor;
            spine.transform.GetChild(5).gameObject.transform.GetChild(1).
                GetComponent<Renderer>().material.color = gameManager.SelectedHomeKit.ShortsColor;
        }*/
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
