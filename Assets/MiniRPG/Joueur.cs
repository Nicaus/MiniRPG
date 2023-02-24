using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Joueur : MonoBehaviour
{
    private Rigidbody2D rig;
    private Animator anim;
    private Vector2 mouvementfleche;
    public float vitesse;

    [SerializeField]
    private Transform prefabArrow;

    // Start is called before the first frame update
    void Start(){
        rig = GetComponent<Rigidbody2D>();
        mouvementfleche = Vector2.zero;

        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update(){
        mouvementfleche.x = Input.GetAxisRaw("Horizontal");
        mouvementfleche.y = Input.GetAxisRaw("Vertical");
        anim.SetFloat("Horizontal", mouvementfleche.x);
        anim.SetFloat("Vertical", mouvementfleche.y);

        if (Input.GetButtonDown("Jump")){
            Instantiate(prefabArrow, transform.position, Quaternion.identity);
        }
    }

    private void FixedUpdate(){
        rig.velocity = mouvementfleche * vitesse;
        float vel = rig.velocity.magnitude;
        rig.velocity = rig.velocity.normalized * vitesse;
    }
}