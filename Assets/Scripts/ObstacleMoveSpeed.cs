using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//leave a lot of space between things
// parenthesis are for parameters of methods, brackets are for bodies of code

public class ObstacleMoveSpeed : MonoBehaviour
{
    public float deadZone = -45f;
    public float moveSpeed = 5;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;
   
   if (transform.position.x < deadZone)
        {
            Debug.Log("tree deleted");
            Destroy(gameObject);
        }

    }
    
}
 