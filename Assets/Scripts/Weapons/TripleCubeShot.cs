﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TripleCubeShot : BaseWeapon
{
    public float horizontalSpeed = 350;
    public float verticalSpeed = 75;
    public override void fireWeapon(Vector3 spawnPosition) {
        GameObject upperBullet;
        upperBullet = Instantiate(this.bulletToInstatiate, spawnPosition, Quaternion.identity);
        upperBullet.GetComponent<Rigidbody>().AddForce(new Vector3(horizontalSpeed, -verticalSpeed, 0));

        GameObject middleBullet;
        middleBullet = Instantiate(this.bulletToInstatiate, spawnPosition, Quaternion.identity);
        middleBullet.GetComponent<Rigidbody>().AddForce(new Vector3(horizontalSpeed, 0, 0));
        
        GameObject lowerBullet;
        lowerBullet = Instantiate(this.bulletToInstatiate, spawnPosition, Quaternion.identity);
        lowerBullet.GetComponent<Rigidbody>().AddForce(new Vector3(horizontalSpeed, verticalSpeed, 0));
    }
}
