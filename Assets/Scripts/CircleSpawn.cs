using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleSpawn : MonoBehaviour
{
    // the sprites we can use
    [SerializeField] Sprite[] sprites; // this is serialized since this is not a public but we need to see it


    // a float for the range it can move in
    float range = 10;

    // Start is called before the first frame update
    void Start()
    {
        // invokes our function SpawnCircle after X seconds, then every Y seconds
        InvokeRepeating("SpawnCircle", 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    Vector3 RandomRadius()
    {
        return new Vector3(Random.Range(-range, range), Random.Range(-range, range), Random.Range(-range, range));
    }

    // spawns a circle
    void SpawnCircle()
    {
        // how we spawn one circle at a time
        GameObject circle = Instantiate(Resources.Load("Prefabs/Blue"), transform.position + RandomRadius(), Quaternion.identity, null) as GameObject;
        // set the sprite renderer
        SpriteRenderer spriteRenderer = circle.GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = sprites[GetComponent<ColorPicker>().SetSprite()];
    }
}
