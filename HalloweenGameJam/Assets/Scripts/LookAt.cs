using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    public GameObject sprite;
    void Start()
    {
        sprite = this.gameObject;
    }
    void Update()
    {
        sprite.transform.rotation = Camera.main.transform.rotation;
    }
}
