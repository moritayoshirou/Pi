using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudController : MonoBehaviour
{


    //ç≈è¨ÉTÉCÉY
    private float minimum = 1.0f;

    //ägëÂèkè¨ÉXÉsÅ[Éh
    private float magSpeed = 8.0f;

    //ägëÂó¶
    private float magnification = 0.2f;

    //Use this initialization
    private void Start()
    {
       
    }


    // Update is called once per frame
    void Update()
    {
        //â_ÇägëÂèkè¨
        this.transform.localScale = new Vector3(this.minimum + Mathf.Sin(Time.time * this.magSpeed) * this.magnification, this.transform.localScale.y, this.minimum + Mathf.Sin(Time.time * this.magSpeed) * this.magnification);
    }
}
