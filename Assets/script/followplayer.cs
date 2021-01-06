using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followplayer : MonoBehaviour
{
    [Header("따라갈대상지정")]
    [SerializeField] Transform tf_player;

    [Header("따라갈 속도 지정")] [Range(0,1)]
    [SerializeField] float speed;

    Vector3 currentPos;
    // Start is called before the first frame update
    void Start()
    {
        currentPos = tf_player.position - transform.position; 
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, tf_player.position-currentPos , speed);

    }
}
