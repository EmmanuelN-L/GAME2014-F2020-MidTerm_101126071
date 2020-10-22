/*
Source file name: BackgroundController.cs
Student Name: Emmanuel Nofuente-Loblack
Student ID: 101126071
Date Last Modified: October 21st, 2020, 9:48 PM
Program Description: Background controller translated the background to make the ship look like it's moving
Revision History: Added 2 new variables horizontal speed and vertical boundary  also changed the boundary and move function
for it to go from right to left.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    public float verticalSpeed;
    public float verticalBoundary;
    public float horizontalSpeed;
    public float horizontalBoundary;

    // Update is called once per frame
    void Update()
    {
        _Move();
        _CheckBounds();
    }

    private void _Reset()
    {
        transform.position = new Vector3(horizontalBoundary, verticalBoundary);
    }

    private void _Move()
    {
        transform.position -= new Vector3(horizontalSpeed, verticalSpeed) * Time.deltaTime;
    }

    private void _CheckBounds()
    {
        // if the background is lower than the bottom of the screen then reset
        if (transform.position.x <= -horizontalBoundary)
        {
            _Reset();
        }
    }
}
