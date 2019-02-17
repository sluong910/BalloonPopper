using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManageBalloons : MonoBehaviour
{
    public GameObject blueBalloon;

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
        if (Random.Range(0, 100.0f) <= 6f)
        {
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
            Instantiate(blueBalloon, spawnPos, Quaternion.identity);
        }
    }

    private bool IsSpawnValid(Vector2 spawnPosition)
    {
        return Physics2D.OverlapCircle(spawnPosition, 0.1f) == null;
    }
}
