using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float rotate_speed;
    public float translate_speed;

	void FixedUpdate () {

        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        float mouseInput = Input.GetAxis("Mouse X");

        Vector3 moveHorizontal = transform.right * horizontalInput;
        Vector3 moveVertical = transform.forward * verticalInput;

        Vector3 move = (moveHorizontal + moveVertical).normalized * translate_speed * Time.fixedDeltaTime;

        Vector3 rotation = new Vector3(0f, mouseInput, 0f) * rotate_speed;

        transform.position += move;
        transform.Rotate(rotation);

    }
}
