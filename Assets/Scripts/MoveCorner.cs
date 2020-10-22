using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditorInternal;
using UnityEngine;

public class MoveCorner : MonoBehaviour
{
    [SerializeField]
    private GameObject item;
    private TweenManage tweener;
    private List<GameObject> itemList;
    private List<Vector2> locations;
    private List<int> rotations;
    private Vector2 nextPos;
    private int nextNextPos;
    private int nextRot;
    private int nextNextRot;
    // Start is called before the first frame update
    public MoveCorner()
    {
        itemList = new List<GameObject>();
        locations = new List<Vector2>();
        rotations = new List<int>();
    }

    void Start()
    {
        item = this.gameObject;
        tweener = GetComponent<TweenManage>();
        itemList.Add(item);
        locations.Add(new Vector2(-5, 10));
        locations.Add(new Vector2(-5, 14));
        locations.Add(new Vector2(-10, 14));
        locations.Add(new Vector2(-10, 10));
        rotations.Add(0);
        rotations.Add(90);
        rotations.Add(180);
        rotations.Add(270);
        nextPos = locations[0];
        nextNextPos = 1;
        nextRot = rotations[0];

    }

    // Update is called once per frame

    void Update()
    {
        if ((Vector2)transform.position != nextPos)
        {
            for (int i = 0; i < itemList.Count; i++)
            {
                if (tweener.AddTween(itemList[i].transform, itemList[i].transform.position, nextPos, 20f))
                {
                    transform.rotation = Quaternion.Euler(0,0,nextRot);
                    break;
                }

            }
        }
        else 
        {
            if (nextNextPos == 4) 
            { 
                nextNextPos = 0;
            }
            nextPos = locations[nextNextPos];
            nextRot = rotations[nextNextPos];
            nextNextPos++;
        }
        
        
    }
}
