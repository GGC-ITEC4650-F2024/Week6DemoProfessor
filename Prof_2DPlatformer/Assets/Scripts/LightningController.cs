using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightningController : PickUpController
{

    public override void invClick(GameObject invIconGO) {
        base.invClick(invIconGO);
        // heal the player.
        PlayerController p = GameObject.FindGameObjectWithTag("Player")
            .GetComponent<PlayerController>();
        
        p.speed *= 2;
    }
}
