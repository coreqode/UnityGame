using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fall : MonoBehaviour
{
    // Start is called before the first frame update
    public Collider col;
    public Rigidbody rb;
    public Vector3 orgPos;
    public Vector3 down_vec;
    public bool gazing;
    public int counter=0;
    void Start()
    {
        orgPos =  new Vector3(transform.position.x, transform.position.y, transform.position.z);

        col = GetComponent<Collider>();
        rb = GetComponent<Rigidbody>();
        col.isTrigger=true;
        gazing = false;
        down_vec = new Vector3(0,-1,0);

    }


    void Update()
    {
        if(gazing==true){

            transform.Translate(down_vec * Time.deltaTime);
            counter+=1;
        }

        if(counter>150){
            counter=0;
            gazing=false;
            transform.position = orgPos;
        }


    }


    public void OnPointerEnter(){

        gazing = true;

    }

    // private void OnCollisionEnter(Collision collision)
    // {
    //     OnTheGround = true;
    //     // col.attachedRigidbody.useGravity = false;
    // }


    // public void OnPointerExit(){
    //     transform.Translate(orginalPosition);
    // }

    // void OnCollisionEnter(Collision collision){
    // transform.position = orginalPosition;

    // }

    // private void MoveToTarget(){
    //     transform.Translate(orginalPosition);
    //     OnTheGround = false;

    // }
}
