using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WanderingText : MonoBehaviour
{
    private RectTransform ract;

    // Start is called before the first frame update
    void Start()
    {
        ract = GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        ract.position = Vector2.Lerp(new Vector2(ract.position.x, ract.position.y), new Vector2(ract.position.x-Random.Range(0,0.2f), ract.position.y - Random.Range(0, 0.2f)), Time.deltaTime/5f); 
    }
}
