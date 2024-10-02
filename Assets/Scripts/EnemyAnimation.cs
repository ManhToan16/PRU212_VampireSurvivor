using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAnimation : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform sprite;
    public float speed;
    public float minSize,maxSize;
    private float activeSize;
    void Start()
    {
        activeSize=maxSize;
        speed = speed * Random.RandomRange(.75f, 1.25f);
    }

    // Update is called once per frame
    void Update()
    {
        sprite.localScale = Vector3.MoveTowards(sprite.localScale,Vector3.one*activeSize,speed*Time.deltaTime);
        if (sprite.localScale.x == activeSize)
        {
            if (activeSize == maxSize)
            {
                activeSize=minSize;
            }
            else
            {
                activeSize=maxSize;
            }
        }
    }
}
