using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class CameraFacingBillboard : MonoBehaviour
{
    public Camera m_Camera;

    public float R;
    [Range(0f, 360f)]
    public float AngH;
    [Range(-90f, 90f)]
    public float AngV;

    void Update()
    {
        //transform.LookAt(transform.position + m_Camera.transform.rotation * Vector3.forward, m_Camera.transform.rotation * Vector3.up);

        transform.position = new Vector3(Mathf.Sin(AngH * Mathf.Deg2Rad) * Mathf.Cos(AngV * Mathf.Deg2Rad), Mathf.Sin(AngV * Mathf.Deg2Rad), Mathf.Cos(AngH * Mathf.Deg2Rad) * Mathf.Cos(AngV * Mathf.Deg2Rad)) * R;
        transform.LookAt(transform.position + m_Camera.transform.rotation * Vector3.forward, m_Camera.transform.rotation * Vector3.up);
    }
}