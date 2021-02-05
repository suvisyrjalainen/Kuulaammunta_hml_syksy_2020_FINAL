using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oma_zombie : MonoBehaviour
{
    // Start is called before the first frame update
    int eteenpain_nopeus = -2;

    private float horisontaalinenPyorinta = 270;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CharacterController hahmokontrolleri = GetComponent<CharacterController>();

        Vector3 nopeus = new Vector3(eteenpain_nopeus, 0, 0);

        transform.localRotation = Quaternion.Euler(0, horisontaalinenPyorinta, 0);

        nopeus = transform.rotation * nopeus;

        hahmokontrolleri.SimpleMove(nopeus);
    }

    void OnCollisionEnter(Collision collision)
    {
        int kaannos = 0;
        kaannos = Random.Range(90, 270);

        if (collision.collider.gameObject.layer == LayerMask.NameToLayer("Wall"))
        {
            horisontaalinenPyorinta += kaannos;
        }
    }

}
