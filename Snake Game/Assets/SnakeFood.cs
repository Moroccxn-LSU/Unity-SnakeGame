//  C# Snake Game
//  By: Adam Elkhanoufi
//  04/21/2022
//
//  Script for the Food object

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeFood : MonoBehaviour
{
    public BoxCollider2D foodBounds;

    private void Start()
    {
        randPos();
    }

    private void randPos()
    {
        Bounds bounds = this.foodBounds.bounds;

        float x = Random.Range(bounds.min.x, bounds.max.x);
        float y = Random.Range(bounds.min.y, bounds.max.y);

        this.transform.position = new Vector3(Mathf.Round(x), Mathf.Round(y), 0.0f);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            ScoreSystem.location.addPoint();
            randPos();
        }
    }
}