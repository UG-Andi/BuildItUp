﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlaceableBuildings : MonoBehaviour {

    [HideInInspector]
    public List<Collider> colliders = new List<Collider>();

	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}

    void OnTriggerEnter(Collider c)
    {
        if (c.tag == "Building")
        {
            colliders.Add(c);
        }
    }

    void OnTriggerExit(Collider c)
    {
        if (c.tag == "Building")
        {
            colliders.Remove(c);
        }
    }
}
