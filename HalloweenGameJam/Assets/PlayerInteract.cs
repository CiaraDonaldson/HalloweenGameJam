using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        //anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "door")
        {
            Debug.Log("Open");
                anim.Play("Base Layer.DoorDouble_Open", -1, 0);
           
           
        }
    }
}
