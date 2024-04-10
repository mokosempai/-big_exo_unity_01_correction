using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] private float offset = -10;
    [SerializeField] Transform target;
    void Update()
    {
        Vector3 position = transform.position;
        position.z = target.position.z + offset;
        transform.position = position;
    }
}
