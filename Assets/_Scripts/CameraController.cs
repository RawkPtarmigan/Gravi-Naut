﻿using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour 
{
    private Camera thisCamera;
    private GameObject player;
    private Transform target;

    private Vector3 velocity = Vector3.zero;
    public float dampTime = 0.5f;
    public float defaultSize = 1.95f;
    public float pauseSize = 5f;    

    void Start()
    {
        thisCamera = Camera.main;
        thisCamera.orthographicSize = defaultSize;
        player = GameObject.Find("Player");
        target = player.transform;
    }

    void Update()
    {
        if(target)
        {
            Vector3 point = thisCamera.WorldToViewportPoint(target.position);
            Vector3 delta = target.position - thisCamera.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, point.z));
            Vector3 destination = transform.position + delta;
            transform.position = Vector3.SmoothDamp(transform.position, destination, ref velocity, dampTime);
        }
    }
}