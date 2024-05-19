using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerbehavior : MonoBehaviour
{
    public float MoveSpeed = 30f;
    public float RotateSpeed = 100f;

    private float _vInput;
    private float _hInput;

    private Rigidbody _rb;
    
    public float JumpVelocity = 5f;
    private bool _isJumping;
    // Start is called before the first frame update
    void Start()
    {
      //player movement 
      _rb = GetComponent<Rigidbody>();
      
    }
    void Update()
    {
        _vInput = Input.GetAxis("Vertical") * MoveSpeed;
        _hInput = Input.GetAxis("Horizontal") * RotateSpeed;
        //JUMPING!!!!!!!
        _isJumping |= Input.GetKeyDown(KeyCode.J);

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 rotation = Vector3.up * _hInput;

        Quaternion angleRot = Quaternion.Euler(rotation * Time.fixedDeltaTime);

        _rb.MovePosition(this.transform.position + this.transform.forward * _vInput * Time.fixedDeltaTime);

        _rb.MoveRotation(_rb.rotation * angleRot);
        //Jumping!!!!
        if(_isJumping)
        {
            _rb.AddForce(Vector3.up * JumpVelocity, ForceMode.Impulse);
        }
        _isJumping = false;
    }
}
