using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImpactReact : MonoBehaviour
{
    public bool shouldShake;
    public float simpleAmount;

    // Start is called before the first frame update
    void Start()
    {
        

        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        CameraShake.onSimpleShake.Invoke(simpleAmount);
    }
    // Update is called once per frame
    void Update()
    {
        if (!shouldShake) return;
    }
}
