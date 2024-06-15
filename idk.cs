using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class idk : MonoBehaviour
{
    public int lives = 1;
    public int level = 1;

    public Vector3 newPosition;
    public int speed = 2;

    // Start is called before the first frame update
    void Start()
    {
        print(lives = lives + level);


        /* GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position new Vector3(x,0 y,0, z,0);
         GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position new Vector3(x,-0.5f, y,1, z,0);
         GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position new Vector3(x,-0.5f, y,1, z,0);
         GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position new Vector3(x,-0.5f, y,2 , z,0);
         GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position new Vector3(x,-0.5f, y,2, z,0);
         GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position new Vector3(x,0 y,3, z,0);*/

    }

    // Update is called once per frame
    void Update()
    {
        newPosition = transform.position;
        newPosition.z += speed * Time.deltaTime;

        transform.position = newPosition;
    }
}
