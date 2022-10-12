using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HanabiControl : MonoBehaviour
{
    public GameObject fireP;
    ParticleSystem ps;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>(); 
        rb.AddForce(Random.Range(-300,300),Random.Range(900,1200),0);
        // gradient = new Gradient();

    }

    // Update is called once per frame
    void Update()
    {
        if(rb.velocity.y<0){
            GameObject fire = Instantiate(fireP) as GameObject;
            fire.transform.position = transform.position;

            // ps = fire.GetComponent<ParticleSystem>();
            // var col = ps.colorOverLifetime;
            // col.enabled = true;

            // Gradient grad = new Gradient();
            // grad.SetKeys( new GradientColorKey[] { new GradientColorKey(Color.yellow, 0.0f), new GradientColorKey(Color.red, 1.0f) }, new GradientAlphaKey[] { new GradientAlphaKey(1.0f, 0.0f), new GradientAlphaKey(0.0f, 1.0f) } );

            // col.color = grad;
            Destroy(gameObject);
        }
    }
}
