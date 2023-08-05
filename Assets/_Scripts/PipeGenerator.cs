using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeGenerator : MonoBehaviour
{
    public GameObject pipe;
    public float time; 
    float elapsedTime = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;
        if (elapsedTime > time)
        {
            GameObject newPipe = Instantiate(pipe);
            newPipe.transform.position = new Vector3(1, Random.Range(-1f, 3f), 0);
            elapsedTime = 0f;
            Destroy(newPipe, 5f);
        }
    }
}
