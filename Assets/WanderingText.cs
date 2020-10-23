using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WanderingText : MonoBehaviour
{
    private Transform pos;

    // Start is called before the first frame update
    void Start()
    {
        pos = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        pos.position = Vector2.Lerp(new Vector2(pos.position.x, pos.position.y), new Vector2(pos.position.x-Random.Range(-30f,30f), pos.position.y - Random.Range(-30f, 30f)), Time.deltaTime/1); 
    }
}
