using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManageBalloons : MonoBehaviour
{
    public GameObject blueBalloon;
    public GameObject greenBalloon;
    public static bool GameFinished = false;
    private int endingGame = 0;

    // Start is called before the first frame update
    void Start()
    {
        int initialBalloonCount = (int)Random.Range(0, 5.0f);
        for (int i = 0; i < initialBalloonCount; i++)
        {
            SpawnBalloon();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (endingGame > 150)
        {
            // End of game : trigger police scene
            GameFinished = true;
            return;
        }
        if (Random.Range(0, 100.0f) <= 6f)
        {
            SpawnBalloon();
        }
        else if (Score.CurrentScore > 30)
        {
            endingGame++;
            SpawnBalloon();
        }
    }

    private void SpawnBalloon()
    {
        // Boundaries for the Balloon to spawn within the screen
        float xBoundary = 5.5f;
        float yMin = -6.4f;
        Vector2 spawnPos = new Vector2(Random.Range(-xBoundary, xBoundary), yMin);

        // Only spawn if balloon does not overlap with another balloon
        if (IsSpawnValid(spawnPos))
        {
            GameObject balloon;
            if (Random.Range(0, 1.0f) < 0.5)
            {
                balloon = blueBalloon;
            }
            else
            {
                balloon = greenBalloon;
            }
            Instantiate(balloon, spawnPos, Quaternion.identity);
        }
    }

    private bool IsSpawnValid(Vector2 spawnPosition)
    {
        return Physics2D.OverlapCircle(spawnPosition, 0.1f) == null;
    }
}
