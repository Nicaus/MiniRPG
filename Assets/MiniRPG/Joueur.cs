using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Joueur : MonoBehaviour
{
    private Rigidbody2D rig;
    private Vector2 mouvementfleche;
    public float vitesse;

    // Start is called before the first frame update
    void Start(){
        rig = GetComponent<Rigidbody2D>();
        mouvementfleche = Vector2.zero;
    }

    // Update is called once per frame
    void Update(){
        mouvementfleche.x = Input.GetAxisRaw("Horizontal");
        mouvementfleche.y = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate(){
        rig.velocity = mouvementfleche * vitesse;
        float vel = rig.velocity.magnitude;
        rig.velocity = rig.velocity.normalized / vel;
    }
}