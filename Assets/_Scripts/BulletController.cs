/*
Source file name:BulletController.cs
Student Name:Emmanuel Nofuente-Loblack
Student ID:101126071
Date Last Modified: October 21st, 2020, 9:48 PM
Program Description:This the projectile that is fired from the ship there is 3 different types of bullets the code allows for using
using the same script and being able to change speed and boundary of the bullets individually.
Revision History: Added a horizontal speed and horizontal boundary variable. Adjusted the move function for moving to the right. 
Added a checkbounds horizontal function. To check when it reaches the end of the screen.

 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour, IApplyDamage
{
    public float verticalSpeed;
    public float verticalBoundary;
    public float horizontalSpeed;
    public float horizontalBoundary;
    public BulletManager bulletManager;
    public int damage;
    
    // Start is called before the first frame update
    void Start()
    {
        bulletManager = FindObjectOfType<BulletManager>();
    }

    // Update is called once per frame
    void Update()
    {
        _Move();
        _CheckBoundsHorizontal();
        //_CheckBounds();
    }
    //Bullets will move horizontally instead of vertically
    private void _Move()
    {
        transform.position += new Vector3(horizontalSpeed, verticalSpeed, 0.0f) * Time.deltaTime;
    }

    private void _CheckBounds()
    {
        if (transform.position.y > verticalBoundary)
        {
            bulletManager.ReturnBullet(gameObject);
        }
    }
    //Once the bullet reaches the end of the bounds the bullet will return
    private void _CheckBoundsHorizontal()
    {
        if (transform.position.x > horizontalBoundary)
        {
            bulletManager.ReturnBullet(gameObject);
        }
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        //Debug.Log(other.gameObject.name);
        bulletManager.ReturnBullet(gameObject);
    }

    public int ApplyDamage()
    {
        return damage;
    }
}
