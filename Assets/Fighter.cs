using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Fighter : MonoBehaviour {

    [SerializeField] float xSpeed = 3f;
    [SerializeField] float rollFactor = 10f;

    float controlThrow;

    Vector3 initialOffsetFromCamera;

	// Use this for initialization
	void Start () {
        initialOffsetFromCamera = transform.localPosition;
	}
	
	// Update is called once per frame
	void Update () {
        ProcessTranslation();
        RotateShip();
	}

    private void RotateShip()
    {
        transform.localRotation = Quaternion.Euler(0, 0, -controlThrow * rollFactor);
    }

    private void ProcessTranslation()
    {
        controlThrow = CrossPlatformInputManager.GetAxis("Horizontal");
        float xOffset = controlThrow * xSpeed * Time.deltaTime;
        float currentX = transform.localPosition.x;
        float newXPos = Mathf.Clamp(currentX + xOffset, -2.9f, 3.9f); // todo expose
        transform.localPosition = new Vector3(newXPos, transform.localPosition.y, transform.localPosition.z);
    }
}
