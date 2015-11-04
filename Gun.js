﻿#pragma strict

// This is the bullet prefab the will be instantiated when the player clicks
   // It must be set to an object in the editor 
   var Bullet : GameObject; 
   
   // Fire a bullet 
   function Fire () {
       // Create a new bullet pointing in the same direction as the gun 
       var newBullet : GameObject = Instantiate(Bullet, transform.position, transform.rotation); 
   } 
   
   function Update () {
       // Fire if the left mouse button is clicked 
       if (Input.GetButtonDown("Fire1")) {
           Fire();
       } 
   }