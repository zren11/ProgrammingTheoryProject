using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] objectPrefabs;
    public float xRange = 3;
    public float zPosition = 3;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnRandomObject", 1, 1f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomObject()
    {
        int index = Random.Range(0, objectPrefabs.Length);
        Vector3 spawnPosition = new Vector3(Random.Range(-xRange, xRange), 0, zPosition);
        Instantiate(objectPrefabs[index], spawnPosition, objectPrefabs[index].transform.rotation);
    }
}
