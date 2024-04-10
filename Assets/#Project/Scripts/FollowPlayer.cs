using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] private float offset = -10;
    [SerializeField] Transform target;
    [SerializeField] private float speed;

    void Update()
    {
        float z = transform.position.z + speed * Time.deltaTime; 
        Vector3 position = transform.position;
        position.z = Mathf.Min(target.position.z + offset, z);
        transform.position = position;
    }
}
