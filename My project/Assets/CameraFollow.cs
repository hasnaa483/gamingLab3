 using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraFollow : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform Target;
public float CameraSpeed;
public float minX,maxX;
public float minY,maxY; 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate()
    {
        if (Target != null)
        {
            Vector2 newCamPosition = Vector2.Lerp(transform.position, Target.position, Time.deltaTime * CameraSpeed);
            transform.position = new Vector3(Mathf.Clamp(newCamPosition.x, minX, maxX), Mathf.Clamp(newCamPosition.y, minY, maxY), transform.position.z);
       float Calmpx = Mathf.Clamp(newCamPosition.x, minX, maxX);
       float Calmpy = Mathf.Clamp(newCamPosition.y, minY, maxY);
       transform.position = new Vector3(Calmpx, Calmpy, -10f);
        }
    }
}
 