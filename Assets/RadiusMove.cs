using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadiusMove : AbstractMoveSphere
{
    [SerializeField]
    Transform point;

    Vector3 start_position;
    [SerializeField]
    float speed;

    [SerializeField] float angle = 0;  
    [SerializeField] float radius = 0.5f;

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
        radius = 5;
        angle = 0;
        transform.position = start_position;
        buttons.SetActive(true);
    }

    public override void Move(Transform point)
    {
        angle += Time.deltaTime;
        radius -= Time.deltaTime / 3;
        var x = Mathf.Cos(angle * speed) * radius;
        var z = Mathf.Sin(angle * speed) * radius;
        transform.position = new Vector3(x, 1.173f,z);
        if (radius <= 0)
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
