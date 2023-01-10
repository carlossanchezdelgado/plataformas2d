using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{
    public GameObject Target;
    public int Speed;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        transform.position = Vector3.Lerp(transform.position, new Vector3(Target.transform.position.x + 5, 0, -10), Speed * Time.deltaTime);

    }
}