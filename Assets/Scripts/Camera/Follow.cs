using System;
using UnityEngine;

public class Follow : MonoBehaviour
{
    [SerializeField] GameObject target;

    [SerializeField] float minY;
    [SerializeField] float maxY;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    void LateUpdate()
    {
        Vector3 pos = new Vector3(target.transform.position.x, target.transform.position.y, transform.position.z);
        pos.y = Mathf.Clamp(pos.y, minY, maxY);
        transform.position = pos;
    }

}
