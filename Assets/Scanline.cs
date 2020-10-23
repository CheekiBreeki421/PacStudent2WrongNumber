using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scanline : MonoBehaviour
{
    private RectTransform pos;
    // Start is called before the first frame update
    void Start()
    {
        pos = GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {

        if (pos.position.y <= -100f)
        {
            pos.position = new Vector2(pos.position.x, 700);
        }

    }
    private void LateUpdate()
    {
       
        pos.position = Vector2.Lerp(new Vector2(pos.position.x, pos.position.y), new Vector2(pos.position.x, pos.position.y - 30), Time.deltaTime / 0.5f);
    }
}
