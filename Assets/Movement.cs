using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Animator _animator;
    public float maximumSpeed;
    public Transform Player;

    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float horiz = Input.GetAxis("Horizontal");
        float vert = Input.GetAxis("Vertical");

        _animator.SetFloat("x", horiz);
        _animator.SetFloat("y", vert);
        Debug.Log(horiz + " " + vert);
        Vector3 movDir = new Vector3(horiz, 0, vert);
        Player.Translate(movDir*maximumSpeed*Time.deltaTime);
    }
}
