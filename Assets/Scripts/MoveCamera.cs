using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
	public float speed = 1f;

	void Update()
	{
		float z = Input.GetAxis("Vertical");
		float x = Input.GetAxis("Horizontal");
        transform.Translate(new Vector3(speed * x, 0, speed * z));

        if (Input.GetKey("q"))
		{
			transform.Rotate(new Vector3 (0, transform.rotation.y - 1,0));
		}
		if (Input.GetKey("e"))
		{
			transform.Rotate(new Vector3(0, transform.rotation.y + 1, 0));
		}

	}
}