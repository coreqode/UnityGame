using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sparkle : MonoBehaviour
{

    private ParticleSystem ps;


    // Start is called before the first frame update
    void Start()
    {
        ps = GetComponent<ParticleSystem>();
        var emission = ps.emission;
        emission.enabled = false;
    }

    public void OnPointerEnter()
    {
        var emission = ps.emission;
        emission.enabled = true;

    }

    public void OnPointerExit()
    {
        var emission = ps.emission;
        emission.enabled = false;

    }

}
