using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinearMove : AbstractMoveSphere
{
    [SerializeField]
    Transform point;
   
    Vector3 start_position;
    [SerializeField]
    float speed;


    [SerializeField] GameObject buttons;
    void Start()
    {
        start_position = this.transform.position;
    }

   
    void Update()
    {
        if (start){
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
        if(transform.position.x == point.position.x)
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
