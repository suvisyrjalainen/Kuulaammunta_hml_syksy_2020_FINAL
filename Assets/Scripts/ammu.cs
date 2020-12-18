﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ammu : MonoBehaviour
{
    Camera FPSCamera;

    public float throwForce = 10f;
    public GameObject throwObjPrefab;
    private GameObject ammus = null;
    

    // Start is called before the first frame update
    void Start()
    {
        FPSCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Throw();
            
        }

    }

    public void Throw()
    {

        ammus = Instantiate(throwObjPrefab, transform.position, Quaternion.identity);
        ammus.GetComponent<Rigidbody>().AddForce(FPSCamera.transform.forward * throwForce, ForceMode.Impulse);
    }
}
