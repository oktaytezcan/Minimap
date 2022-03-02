using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    [SerializeField] float verSpeed;
    [SerializeField] float horSpeed;
    float hor;
    float ver;

    void Start()
    {
        
    }

   
    void Update()
    {

        hor = Input.GetAxis("Horizontal");
        ver = Input.GetAxis("Vertical");
        transform.Translate(hor * horSpeed * Time.deltaTime, 0f,ver*verSpeed * Time.deltaTime);







    }
}
