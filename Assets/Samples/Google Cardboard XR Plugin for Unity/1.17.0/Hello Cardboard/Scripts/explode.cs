using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explode : MonoBehaviour
{

    private ParticleSystem ps;
    public float timer = 0;
    public bool timerReached;
    public bool start_timer;

    // Start is called before the first frame update
    void Start()
    {
        ps = GetComponent<ParticleSystem>();
        var emission = ps.emission;
        emission.enabled = false;
        timerReached = false;
        start_timer = false;
    }

    void Update()
    {
        if (!timerReached && start_timer)
            timer += Time.deltaTime;

        if (!timerReached && timer > 0.3)
        {

            timerReached = true;
            var emission = ps.emission;
            emission.enabled = false;
            gameObject.active = false;
            // Destroy(gameObject);

        }
    }

    public void OnPointerEnter()
    {
        var emission = ps.emission;
        emission.enabled = true;
        start_timer = true;

        // emission.enabled = false;
        // Destroy(gameObject);
    }





}
