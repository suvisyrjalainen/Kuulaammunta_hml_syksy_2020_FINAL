using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ammu : MonoBehaviour
{
    Camera FPSCamera;

    public float throwForce = 10000f;
    public GameObject throwObjPrefab;
    private GameObject ammus = null;
    public LineRenderer lr;
    

    // Start is called before the first frame update
    void Start()
    {
        FPSCamera = Camera.main;

        if (gameObject.CompareTag("pyssy"))
        {
            lr.enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && gameObject.CompareTag("ase"))
        {
            Throw();
            
        }

        if (Input.GetButtonDown("Fire2") && gameObject.CompareTag("pyssy"))
        {
            StartCoroutine(Fire());

        }

    }

    public void Throw()
    {

        ammus = Instantiate(throwObjPrefab, transform.position, Quaternion.identity);
        ammus.GetComponent<Rigidbody>().AddForce(FPSCamera.transform.forward * throwForce, ForceMode.Impulse);
    }

    public IEnumerator Fire()
    {
        RaycastHit hit;
        if(Physics.Raycast(transform.position, transform.forward, out hit))
        {
            Debug.Log(hit.collider.gameObject.name);
            lr.SetPosition(0, transform.position);
            lr.SetPosition(1, hit.point);
        }

        lr.enabled = true;
        yield return new WaitForSecondsRealtime(0.1f);
        lr.enabled = false;
    }
}
