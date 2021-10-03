using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateVelocity : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        GameObject[] bodies = GameObject.FindGameObjectsWithTag("Body");
        Rigidbody2D[] rigidbodies = new Rigidbody2D[bodies.Length];
        float G = GameObject.Find("Slider_gravity").GetComponent<Slider>().value;

        for (int i = 0; i < bodies.Length; i++)
        {
            rigidbodies[i] = bodies[i].GetComponent<Rigidbody2D>();
        }

        rigidbodies[0].velocity += Time.deltaTime * G * ((rigidbodies[1].position - rigidbodies[0].position).normalized * rigidbodies[1].mass / Mathf.Pow(Vector3.Distance(rigidbodies[0].position, rigidbodies[1].position), 2) +
                                                        (rigidbodies[2].position - rigidbodies[0].position).normalized * rigidbodies[2].mass / Mathf.Pow(Vector3.Distance(rigidbodies[0].position, rigidbodies[2].position), 2));

        rigidbodies[1].velocity += Time.deltaTime * G * ((rigidbodies[0].position - rigidbodies[1].position).normalized * rigidbodies[0].mass / Mathf.Pow(Vector3.Distance(rigidbodies[1].position, rigidbodies[0].position), 2) +
                                                        (rigidbodies[2].position - rigidbodies[1].position).normalized * rigidbodies[2].mass / Mathf.Pow(Vector3.Distance(rigidbodies[1].position, rigidbodies[2].position), 2));

        rigidbodies[2].velocity += Time.deltaTime * G * ((rigidbodies[0].position - rigidbodies[2].position).normalized * rigidbodies[0].mass / Mathf.Pow(Vector3.Distance(rigidbodies[2].position, rigidbodies[0].position), 2) +
                                                        (rigidbodies[1].position - rigidbodies[2].position).normalized * rigidbodies[1].mass / Mathf.Pow(Vector3.Distance(rigidbodies[2].position, rigidbodies[1].position), 2));
        
    }
}
