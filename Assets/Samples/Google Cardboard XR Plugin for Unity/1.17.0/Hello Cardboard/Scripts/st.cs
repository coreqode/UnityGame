using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shape : MonoBehaviour
{
    public bool change;
    public GameObject sphere;
    // Start is called before the first frame update

    void Start()
    {
        change = false;
        sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        sphere.transform.position = transform.position;
        sphere.active = false;
        gameObject.active = true;
    }
    // // Update is called once per frame
    void Update()
    {
        if(change==true){
            gameObject.active = false;
            sphere.active = true;
        }
        else{
            gameObject.active = false;
            // shape = GameObject.FindWithTag("shape");
            // shape.active = true;
        }
    }

    public void OnPointerEnter()
    {
        change = true;
    }

    public void OnPointerExit()
    {
        change = false;
        // gameObject.active = true;
        // sphere.active = false;

    }
}
