using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoHorizontal : MonoBehaviour
{
    Rigidbody2D rigidbody2d;
    public float speed = 10;
    GroundDetector_Raycast ground;
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        ground = GetComponent<GroundDetector_Raycast>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        transform.position = transform.position + new Vector3(horizontal * Time.deltaTime, 0);
        anim.SetBool("grounded", ground.grounded);
        anim.SetBool("moving", horizontal != 0);
        if (horizontal > 0)
        {
            rigidbody2d.velocity = new Vector2(speed, rigidbody2d.velocity.y);
            //     transform.localScale = new Vector3(1, 1, 1);
        }
        if (horizontal < 0)
        {
            rigidbody2d.velocity = new Vector2(speed * -1, rigidbody2d.velocity.y);
            //    transform.localScale = new Vector3(-1, 1, 1);
        }
    }
    void Awake()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
    }
}
