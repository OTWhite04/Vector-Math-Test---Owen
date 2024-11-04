using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorTesting : MonoBehaviour
{
    //declaring the two cubes and target as a transform
    public GameObject Cube1;
    public GameObject Cube2;
    public Transform target;
  
    // Start is called before the first frame update
    void Start()
    {
        //Shortcut to move the cube forward
        transform.position = Vector3.forward;
    }

    void OnDrawGizmos()
    {
        Vector3 direction = target.position - transform.position;
        float distance = direction.magnitude;
        transform.forward = direction;

        Gizmos.DrawLine(target.position, transform.position);
        
        if(distance <= 1.0f)
        {
            Gizmos.color = Color.green;
        }
        else if (distance > 1.0f)
        {
            Gizmos.color = Color.red;
        }
       
    }


    private void OnGUI()
    {
       
    }





}
