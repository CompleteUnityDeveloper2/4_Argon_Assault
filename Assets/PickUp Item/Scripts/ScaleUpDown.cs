using System.Collections;
using UnityEngine;

public class ScaleUpDown : MonoBehaviour {

	public float ScaleSpeed;
	public float ScalePercentage;

	bool IsScaleUp = true ;

	Vector3 Scale ;
	void Start () {
		Scale = transform.localScale;
	}
	

	void Update () {
		Vector3 s = transform.localScale;
		if (IsScaleUp) {
			transform.localScale = new Vector3 (
				s.x + ScaleSpeed * Scale.x * 0.01f,
				s.y + ScaleSpeed * Scale.y * 0.01f,
				s.z + ScaleSpeed * Scale.z * 0.01f);
			if (s.x >= Scale.x + Scale.x * ScalePercentage)
				IsScaleUp = false;
		} else {
			transform.localScale = new Vector3 (
				s.x - ScaleSpeed * Scale.x * 0.01f,
				s.y - ScaleSpeed * Scale.y * 0.01f,
				s.z - ScaleSpeed * Scale.z * 0.01f);
			if (s.x <= Scale.x )
				IsScaleUp = true;
		}

	}
}
