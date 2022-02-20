using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public float maximumTime = 1;
    private float timer = 0;
    public GameObject Pipes;
    public float height;
    void Start()
    {
        GameObject newPipe = Instantiate (Pipes);
        newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > maximumTime) {
            GameObject newPipe = Instantiate (Pipes);
            newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            Destroy(newPipe, 15);
            timer = 0;
        }

        timer += Time.deltaTime;
    }
}
