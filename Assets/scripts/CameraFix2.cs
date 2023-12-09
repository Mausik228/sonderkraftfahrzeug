using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFix2 : MonoBehaviour
{
    public GameObject cube;
    public GameObject cam;
    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = cube.transform.position - cam.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        cam.transform.position = cube.transform.position - offset;
    }
}
