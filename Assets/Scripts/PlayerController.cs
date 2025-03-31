using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horsePower;
    [SerializeField] float turnSpeed = 30.0f;
    [SerializeField] float horizontalInput;
    [SerializeField] float verticalInput;
    public float speed;

    [SerializeField] Rigidbody playerRb;
    //[SerializeField] GameObject centerOfMass;

    // Start is called before the first frame update
    void Start()
    {
        //playerRb = GetComponent<Rigidbody>();
        //playerRb.centerOfMass = centerOfMass.transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Variable pour stocker une valeur entre -1 et 1 pour savoir si on a appuyer boutton ou pas, récupération des inputs
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        //On va faire bouger le véhicule en avant
        //this.playerRb.AddRelativeForce(Vector3.forward * verticalInput * horsePower);
        this.transform.Translate(Vector3.forward * Time.deltaTime * turnSpeed * verticalInput);
        
        //Tourner sous forme de rotation le véhicule droite ou gauche
        this.transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
