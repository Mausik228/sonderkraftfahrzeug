using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmimationManager : MonoBehaviour
{
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) == true)
        {
            anim.SetBool("Forward", true);
        }
        else
        {
            anim.SetBool("Forward", false);
        }
        if (Input.GetKey(KeyCode.A) == true)
        {
            anim.SetBool("Left", true);
        }
        else
        {
            anim.SetBool("Left", false);
        }
        if (Input.GetKey(KeyCode.S) == true)
        {
            anim.SetBool("Back", true);
        }
        else
        {
            anim.SetBool("Back", false);
        }
        if (Input.GetKey(KeyCode.D) == true)
        {
            anim.SetBool("Right", true);
        }
        else
        {
            anim.SetBool("Right", false);
        }
    }
}
