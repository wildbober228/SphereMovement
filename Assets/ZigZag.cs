using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZigZag : AbstractMoveSphere
{
    [SerializeField]
    Transform point;

    Vector3 start_position;
    [SerializeField]
    float speed;

    [SerializeField]
    GameObject buttons;
    void Start()
    {
      
        start_position = this.transform.position;
    }


    void Update()
    {
        if (start)
        {
            Move(point);
        }
    }

    void ResetPos()
    {     
        transform.position = start_position;
        buttons.SetActive(true);
    }

    public override void Move(Transform point)
    {
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, point.position, step);
        transform.position = transform.position + new Vector3(0, 0, 1) * Mathf.Cos(Time.time * 15.0f) * 0.2f;
        if (transform.position.x > point.position.x -0.09)
        {
            start = false;
            ResetPos();
        }
       
    }

    public override void EnableSphere()
    {
        buttons.SetActive(false);
        base.EnableSphere();
    }
}
