using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oma_zombie : MonoBehaviour
{
    // Start is called before the first frame update
    int eteenpain_nopeus = -2;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CharacterController hahmokontrolleri = GetComponent<CharacterController>();

        Vector3 nopeus = new Vector3(eteenpain_nopeus, 0, 0);

        hahmokontrolleri.SimpleMove(nopeus);
    }

    void OnCollisionEnter(Collision collision)
    {
        

        //Check for a match with the specific tag on any GameObject that collides with your GameObject
        if (collision.gameObject.tag == "seina")
        {
            //If the GameObject has the same tag as specified, output this message in the console
            Debug.Log("Tormasin seinaan");
        }
    }
}
