using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("속도관련변수")]
    [SerializeField] float moveSpeed;
    [SerializeField] float jetPackSpeed;
    Rigidbody myRigid;
    // Start is called before the first frame update
    void Start()
    {
        myRigid = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        TryMove();
        TryJet();
    }
    void TryMove()
    {
        if (Input.GetAxisRaw("Horizontal") != 0)
        {
            Vector3 moveDir = new Vector3(Input.GetAxisRaw("Horizontal"),0,0 );
            myRigid.AddForce(moveDir * moveSpeed);
        }
    }
    void TryJet()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            myRigid.AddForce(Vector3.up * jetPackSpeed);
        }
        else
        {
            myRigid.AddForce(Vector3.down * jetPackSpeed);
        }
    }
}
