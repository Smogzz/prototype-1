using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraScript : MonoBehaviour
{
    public GameObject Camara_1;
    public GameObject Camara_2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    //"1" and "2" are ferering to the keys on the yey board FYI :>
    void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            cameraOne ();
        }

         if (Input.GetKeyDown("2"))
        {
            cameraTwo ();
        }
    }

    void cameraOne()
    {
        Camara_1.SetActive(true);
        Camara_2.SetActive(false);
    }
     void cameraTwo()
    {
        Camara_1.SetActive(false);
        Camara_2.SetActive(true);
    }
}
