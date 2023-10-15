using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 15.0f;
    private float turnSpeed = 30.0f;
    private float horizontalInput;
    private float verticalInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Variable pour stocker une valeur entre -1 et 1 pour savoir si on a appuyer boutton ou pas, récupération des inputs
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        //On va faire bouger le véhicule en avant
        this.transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        
        //Tourner sous forme de rotation le véhicule droite ou gauche
        this.transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
