using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ileri : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // kısa yol kordionatlarla uğraşmana gerek yok
      //  GetComponent<Rigidbody>().AddForce(Vector3.forward*5, ForceMode.Force);

        if (Input.GetKey("k"))
        {
            GetComponent<Rigidbody>().AddForce(10, 0, 0, ForceMode.Force);
        }
        if (Input.GetKey("h"))
        {
            GetComponent<Rigidbody>().AddForce(-10, 0, 0, ForceMode.Force);
        }
        if (Input.GetKey("u"))
        {
            GetComponent<Rigidbody>().AddForce(0, 0, 50, ForceMode.Force);
        }
        if (Input.GetKey("j"))
        {
            GetComponent<Rigidbody>().AddForce(0, 0, -30, ForceMode.Force);
        }
    }
}
