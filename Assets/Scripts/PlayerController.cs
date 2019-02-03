using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float rotate_speed;
    public float translate_speed;

	void Update () {

        var x = Input.GetAxis("Horizontal") * Time.deltaTime;
        var z = Input.GetAxis("Vertical") * Time.deltaTime;

        transform.Rotate(0, x*rotate_speed, 0);
        transform.Translate(0, 0, z*translate_speed);

    }
}
