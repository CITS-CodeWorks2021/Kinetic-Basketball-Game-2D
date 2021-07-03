using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaperBall : MonoBehaviour
{
    public Rigidbody2D rb;

    public float releaseTime = .15f;

    private bool isPressed = false;

    private void Update()
    {
        if(isPressed)
        {
            rb.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
        
    }
    void OnMouseDown()
    {
        isPressed = true;
        rb.isKinematic = true;
        Debug.Log("Mouse Click");
    }

    void OnMouseUp()
    {
        isPressed = false;
        Debug.Log("Mouse Released");
        rb.isKinematic = false;

        StartCoroutine(Release());
    }

    IEnumerator Release()
    {
        yield return new WaitForSeconds(releaseTime);

        GetComponent<SpringJoint2D>().enabled = false;
    }

}
