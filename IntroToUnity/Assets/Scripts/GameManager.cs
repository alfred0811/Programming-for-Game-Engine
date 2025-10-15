using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class GameManager : MonoBehaviour
{
    // score text in UI
    [SerializeField]
    private TMP_Text scoreText = null;
    // prefab for the mushroom
    [SerializeField]
    private GameObject mushroomPrefab = null;
    // prefab for bomb
    [SerializeField]
    private GameObject bombPrefab = null;
    // how soon to start spawning
    [SerializeField]
    private float spawnDelay = 2.0f;
    [SerializeField]
    private float spawnRate = 1.0f;
    [SerializeField]
    private RangeInt spawnAmount = new RangeInt(1,2);
    [SerializeField]
    private float bombChance = 0.1f;
    [SerializeField]
    private Vector2 spawnPosition = Vector3.zero;
    [SerializeField]
    private Vector2 bombTarget = Vector3.zero;

    private void SpawnItems()
    {
        int numSpawns = Random.Range(spawnAmount.start, spawnAmount.end + 1);
    }

    public void AddToScore(int amount)
    {
        //score += amount;
        
    }
}
