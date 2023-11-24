using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGenerator : MonoBehaviour
{
    // Referinta la prefab
    public GameObject Slice;
    public float MaxTerrainOpening = 5f;
    public int ResetTime = 10;
    private float _timeCounter; 

    // Update is called once per frame
    void Update()
    {
        _timeCounter += Time.deltaTime;

        if(_timeCounter >+ ResetTime) {
            GenerateNewObstacle();
        }

    }

    private void GenerateNewObstacle() {
        _timeCounter = 0f;

        float newPosition = Random.Range(-MaxTerrainOpening, MaxTerrainOpening);

        // Pozitia noua
        Vector3 goPosition = new Vector3(newPosition, 0f, 0f);

        // Obiect nou
        GameObject go = GameObject.Instantiate(Slice, parent: this.transform);

        go.transform.localPosition = goPosition;   

        go.transform.parent = null;
    }
}
