using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeScript : MonoBehaviour
{
    float nilaiRandom; // nilai desimal

    void Start()
    {
        nilaiRandom = Random.Range(-1.57f, 3.67f);
        transform.position = new Vector2(transform.position.x, nilaiRandom);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(
            transform.position,
            Vector2.left * 100,
            Time.deltaTime * 5f
        );
    }
}
