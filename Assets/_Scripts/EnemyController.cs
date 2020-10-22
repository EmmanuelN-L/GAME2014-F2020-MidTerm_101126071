/*
Source file name:EnemyController.cs
Student Name:Emmanuel Nofuente-Loblack
Student ID:101126071
Date Last Modified: October 21st, 2020, 9:48 PM
Program Description:Enemies will be placed on screen and will move up and down on the screen 
Revision History: Added vertical speed and vertical boundary for enemy's movement so that they dont go off the screen.
Also adjusted the checkbounds and move function for moving up and down and not going off the screen

 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float horizontalSpeed;
    public float horizontalBoundary;
    public float verticalSpeed;
    public float verticalBoundary;
    public float direction;

    // Update is called once per frame
    void Update()
    {
        _Move();
        _CheckBounds();
    }

    private void _Move()
    {
        transform.position += new Vector3(0.0f, verticalSpeed * direction * Time.deltaTime, 0.0f);
    }

    private void _CheckBounds()
    {
        // check top right boundary
        if (transform.position.y >= verticalBoundary)
        {
            direction = -1.0f;
        }

        // check bottom boundary
        if (transform.position.y <= -verticalBoundary)
        {
            direction = 1.0f;
        }
    }
}
