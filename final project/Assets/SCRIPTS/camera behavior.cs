using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerabehavior : MonoBehaviour
{
    public Vector3 CamOffset = new Vector3(2f,10f,100f);

    private Transform _target;
    // Start is called before the first frame update
    void Start()
    {
        _target = GameObject.Find("Player").transform;
    }

    // Update is called once per frame
    void LateUpdate()
    {
      this.transform.position = _target.TransformPoint(CamOffset);

      this.transform.LookAt(_target);
    }
}
