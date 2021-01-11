using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun : MonoBehaviour
{
    [Header("총구섬광")]
    [SerializeField] ParticleSystem ps_MuzzleFlash;
    [Header("총알 프리펩")]
    [SerializeField] GameObject go_bullet_prefab;
    [Header("총알 스피드")]
    [SerializeField] float bulletSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tryfire();
    }
    void tryfire()
    {
        if (Input.GetButton("Fire1"))
        {
            Fire();
        }
    }
    void Fire()
    {
        Debug.Log("총알발사");
        ps_MuzzleFlash.Play();
        var clone= Instantiate(go_bullet_prefab, ps_MuzzleFlash.transform.position, Quaternion.identity);
        clone.GetComponent<Rigidbody>().AddForce(transform.forward*bulletSpeed);

    }
}
