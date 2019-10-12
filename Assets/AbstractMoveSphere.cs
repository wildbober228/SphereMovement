using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class AbstractMoveSphere : MonoBehaviour
{
    //[HideInInspector]
    public bool start;

   

    public virtual void Move(Transform point)
    {

    }

    public virtual void EnableSphere()
    {
        start = true;
    }
}
