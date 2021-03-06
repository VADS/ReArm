using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiShot : BaseWeapon
{
    public float maxHorizontalSpeed = 5;
    public float verticalSpeed = 250;

    public override void fireWeapon(Vector2 spawnPosition)
    {
        GameObject middleBullet;
        middleBullet = Instantiate(this.bulletToInstatiate, spawnPosition, Quaternion.identity);
        middleBullet.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, verticalSpeed));

        if (isWeaponOvercharged)
        {
            GameObject newBulletL;
            newBulletL = Instantiate(this.bulletToInstatiate, spawnPosition, Quaternion.identity);
            newBulletL.GetComponent<Rigidbody2D>().AddForce(new Vector2(-maxHorizontalSpeed, verticalSpeed));

            GameObject newBulletR;
            newBulletR = Instantiate(this.bulletToInstatiate, spawnPosition, Quaternion.identity);
            newBulletR.GetComponent<Rigidbody2D>().AddForce(new Vector2(maxHorizontalSpeed, verticalSpeed));
        }
    }
}