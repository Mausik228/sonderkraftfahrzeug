using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{
    public float speed = 50000;
    public float jumpforse = 50000;
    public GameObject ball;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) == true)
        {
            //ball.transform.Translate(Vector3.forward * Time.deltaTime * speed);
            GetComponent<Rigidbody>().AddForce(Vector3.forward * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.A) == true)
        {
            GetComponent<Rigidbody>().AddForce(Vector3.left * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.S) == true)
        {
            GetComponent<Rigidbody>().AddForce(Vector3.back * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.D) == true)
        {
            GetComponent<Rigidbody>().AddForce(Vector3.right * Time.deltaTime * speed);
        }
        if (Input.GetKeyDown(KeyCode.Space) && Physics.Raycast(ball.transform.position, Vector3.down, 0.501f))
        { GetComponent<Rigidbody>().AddForce(Vector3.up * jumpforse); }



    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Door")
            SceneManager.LoadScene("2");
        if (collision.gameObject.name == "Cube")
            ball.transform.position = new Vector3(100, 100, 100);
    }
}
