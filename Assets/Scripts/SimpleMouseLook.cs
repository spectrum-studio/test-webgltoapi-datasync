using UnityEngine;

public class SimpleMouseLook : MonoBehaviour
{
    public float mouseSensitivity = 1500f;

    float xRotation = 0f;
    float yRotation = 0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        yRotation += mouseX;

        // 両軸で回転（カメラだけ）
        transform.localRotation = Quaternion.Euler(xRotation, yRotation, 0f);
    }
}
