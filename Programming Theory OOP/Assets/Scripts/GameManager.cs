using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public bool isGameActive;
    public List<GameObject> animals;

    private float spawnRate = 1.5f;
    private GameObject player;
    private float radius = 20f;

    public TextMeshProUGUI gameOverText;


    // Start is called before the first frame update
    void Start()
    {
        StartGame(); // change later
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnAnimal()
    {
        while (isGameActive)
        {
            yield return new WaitForSeconds(spawnRate);
            int index = Random.Range(0, animals.Count);
            //Vector3 lookDirection = player.transform.position - animals[index].transform.position;
            Instantiate(animals[index],GenerateSpawnPosition(radius), animals[index].transform.rotation);

        }
    }

    public void StartGame()
    {
        isGameActive = true;
        StartCoroutine(SpawnAnimal());
    }

    public void GameOver()
    {
        gameOverText.gameObject.SetActive(true);
        isGameActive = false;
        
    }

    private Vector3 GenerateSpawnPosition(float circleRadius)
    {

        Vector2 spawnVec2 = Random.insideUnitCircle.normalized * circleRadius;
        Vector3 randomPos = new Vector3(spawnVec2.x, 0, spawnVec2.y);
        return randomPos;
    }

}
