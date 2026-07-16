using UnityEngine;

public class BillBoard : MonoBehaviour
{
    private Camera gameCamera;
    private void Awake()
    {
        gameCamera = Camera.main;
    }
    private void LateUpdate()
    {
        transform.LookAt(transform.position + gameCamera.transform.forward);
    }
}
