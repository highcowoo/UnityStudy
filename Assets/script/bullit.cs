using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullit : MonoBehaviour
{
    [Header("피격이펙트")]
    [SerializeField] GameObject go_Rico;
    [Header("총알데미지")]
    [SerializeField] int damage;

    private void OnCollisionEnter(Collision other)
    {
        ContactPoint contactPoint = other.contacts[0];
        var clone = Instantiate(go_Rico, contactPoint.point, Quaternion.LookRotation(contactPoint.normal));
        Destroy(clone, 0.5f);
        Destroy(gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
