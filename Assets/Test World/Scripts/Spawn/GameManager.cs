using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
	//public int m_NumRoundsToWin = 5;
	public float m_StartDelay = 3f;
	public float m_EndDelay = 3f;
	public GameObject ShipPrefab;             // Reference to the prefab the player will control.
	public GameObject EnemyShipPrefab;        // Reference to the prefab the AI will control.
	public Transform PlayerSpawn;
	public Transform EnemySpawn;
	public Text MessageText;
	//public ShipManager[] m_Tanks;               // A collection of managers for enabling and disabling different aspects of the ships.

	//private int m_RoundNumber;
	private WaitForSeconds m_StartWait;
	private WaitForSeconds m_EndWait;

	private void Start()
	{
		m_StartWait = new WaitForSeconds(m_StartDelay);
		m_EndWait = new WaitForSeconds(m_EndDelay);

		SpawnAllShips();

		//StartCoroutine(GameLoop());
	}

	private void SpawnAllShips()
	{
		//Spawn Player
		GameObject player = Instantiate(ShipPrefab, PlayerSpawn.position, PlayerSpawn.rotation);

		//Spawn Player
		GameObject enemy = Instantiate(EnemyShipPrefab, EnemySpawn.position, PlayerSpawn.rotation);

		/*
		 // For all the enemies...
           for (int i = 0; i < EnemyShips.Length; i++)
           {
               // ... create them, set their player number and references needed for control.
               EnemyShips[i].m_Instance =
                   Instantiate(EnemyShipPrefab, EnemyShips[i].m_SpawnPoint.position, EnemyShips[i].m_SpawnPoint.rotation) as GameObject;
               EnemyShips[i].m_PlayerNumber = i + 1;
               EnemyShips[i].Setup();
            }
		 */
	}



	//IMPLEMENT WAVE SPAWNING
	/*
	private IEnumerator GameLoop()
	{
		yield return StartCoroutine(RoundStarting());
		yield return StartCoroutine(RoundPlaying());
		yield return StartCoroutine(RoundEnding());
	}
	private IEnumerator RoundStarting()
	{
		yield return m_StartWait;
	}


	private IEnumerator RoundPlaying()
	{
		yield return null;
	}


	private IEnumerator RoundEnding()
	{
		yield return m_EndWait;
	}

	private bool OneShipLeft()
    {
        int numTanksLeft = 0;

        for (int i = 0; i < m_Tanks.Length; i++)
        {
            if (m_Tanks[i].m_Instance.activeSelf)
                numTanksLeft++;
        }

        return numTanksLeft <= 1;
    }

	private bool CanPlaceShip()
	{
		return enemyShip == null;
	}

	// Returns a string message to display at the end of each round.
    private string EndMessage()
	{
        // By default when a round ends there are no winners so the default end message is a draw.
        string message = "DRAW!";
		           
		// If there is a winner then change the message to reflect that.
        if (m_RoundWinner != null)
            message = m_RoundWinner.m_ColoredPlayerText + " WINS THE ROUND!";
			           
		// Add some line breaks after the initial message.
        message += "\n\n\n\n";

        // Go through all the tanks and add each of their scores to the message.
        for (int i = 0; i < m_Tanks.Length; i++)
        {
            message += m_Tanks[i].m_ColoredPlayerText + ": " + m_Tanks[i].m_Wins + " WINS\n";
        }

        // If there is a game winner, change the entire message to reflect that.
        if (m_GameWinner != null)
            message = m_GameWinner.m_ColoredPlayerText + " WINS THE GAME!";

        return message;
    }
	
	*/
}

