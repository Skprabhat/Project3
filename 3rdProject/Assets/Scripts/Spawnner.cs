using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnner : MonoBehaviour
{
    public GameObject[] obstaclePreFab;
    public int startPt = 2;
    public int endPt = 50;
    public Transform player;
    // Start is called before the first frame update
    void Start()
    {
        Spawn(startPt, endPt);
    }

    // Update is called once per frame
    void Update()
    {
        if (player.position.y > endPt - 10)
        {
            var temp = endPt + 6;
            endPt += 48;
            startPt = temp;
            Spawn(startPt, endPt);
        }
    }
    void Spawn(int startPos, int endPos)
    {
        for (int i = startPos; i <= endPos; i += 6)
        {
            Instantiate(obstaclePreFab[Random.Range(0, 2)], new Vector2(0, i), Quaternion.identity);
        }
    }
}
