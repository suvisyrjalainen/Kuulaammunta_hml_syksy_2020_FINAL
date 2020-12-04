﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombie : MonoBehaviour
{

    public float eteenpain_nopeus = 1.0f;

    int layer_index;
    //public LayerMask includeLayers;
    public LayerMask wallMask;
    // Start is called before the first frame update
    void Start()
    {
        layer_index = LayerMask.GetMask("Wall");
    }

    // Update is called once per frame
    void Update()
    {
        CharacterController hahmokontrolleri = GetComponent<CharacterController>();
        Vector3 nopeus = new Vector3(0, 0, eteenpain_nopeus);
        hahmokontrolleri.SimpleMove(nopeus);
    }

    void OnTriggerEnter(Collider other)
    {
        print("osui");
        if (other.gameObject.layer == layer_index)
        {
            print("osui seinaan");
        }
        if (other.gameObject.tag == "seina")
        {
            print("osui seina ykkoseen");
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.layer == LayerMask.NameToLayer("Wall"))
        {
            print("osui seinaan");
            transform.rotation *= Quaternion.Euler(0, 180, 0);
            eteenpain_nopeus = -1.0f;
        }
    }


}
