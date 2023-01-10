using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundDetector_Raycast : MonoBehaviour
{
    public bool grounded;
    public float length = 1;
    public LayerMask mask;

    public List<Vector3> origiPoints;

    void Update()
    {
        grounded = false;
        for (int i = 0; i < origiPoints.Count; i++)
        {
            Debug.DrawRay(transform.position + origiPoints[i], Vector3.down * length, Color.red);
            RaycastHit2D hit = Physics2D.Raycast(transform.position + origiPoints[i], Vector3.down, length, mask);
            if (hit.collider != null)
            {
                if (hit.collider.tag == "Plataforma Movil")
                {
                    transform.parent = hit.transform;
                }

                Debug.DrawRay(transform.position + origiPoints[i], Vector3.down * hit.distance, Color.green);
                grounded = true;
            }
        }
        if (!grounded)
        {
            transform.parent = null;
        }
        
    }
}



        //Debug.DrawRay(transform.position, Vector3.down * length, Color.red);

       //RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector3.down, length, mask);

       // if (hit.collider != null)
        //{
            //Debug.DrawRay(transform.position, Vector3.down * hit.distance, Color.green);
          //  grounded = true;
        //}
        //else
        //{
         //   grounded = false;
       // }
    

