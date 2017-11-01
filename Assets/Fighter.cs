using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Fighter : MonoBehaviour {

    [SerializeField] float xClampMin = -2.9f;
    [SerializeField] float xClampMax = 3.9f;

    [SerializeField] float yClampMin = -2.9f;
    [SerializeField] float yClampMax = 3.9f;

    [SerializeField] float xSpeed = 10f;
    [SerializeField] float ySpeed = 10f;

    [SerializeField] float rollFactor = 25f;
    [SerializeField] float pitchFactor = 25f;

    float xThrow, yThrow;

	// Use this for initialization
	void Start () {
   
    }
	
	// Update is called once per frame
	void Update () {
        ProcessTranslation();
        RotateShip();
	}

    private void RotateShip()
    {
        transform.localRotation = Quaternion.Euler(-yThrow * pitchFactor, 0, -xThrow * rollFactor);
    }

    private void ProcessTranslation()
    {
        xThrow = CrossPlatformInputManager.GetAxis("Horizontal");
        yThrow = CrossPlatformInputManager.GetAxis("Vertical");

        float xOffset = xThrow * xSpeed * Time.deltaTime;
        float yOffset = yThrow * ySpeed * Time.deltaTime;

        float currentX = transform.localPosition.x;
        float newX = Mathf.Clamp(currentX + xOffset, xClampMin, xClampMax);

        float currentY = transform.localPosition.y;
        float newY = Mathf.Clamp(currentY + yOffset, yClampMin, yClampMax);

        transform.localPosition = new Vector3(newX, newY, transform.localPosition.z);
    }
}
