using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakePipe : MonoBehaviour
{
    float timer = 0;
    public float timeDiff;
    public GameObject pipe;
    GameObject newPipe;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > (1 * timeDiff)) {
            newPipe = Instantiate(pipe);
            newPipe.transform.position = new Vector3(0, Random.Range(-3.0f, 3.0f), 0);
            timer = 0;
            Destroy(newPipe, 5.0f);
        }
    }
}
