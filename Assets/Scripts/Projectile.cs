using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float m_Lifetime = 5.0f;

    private Rigidbody m_Rigidbody = null;

    private void Awake()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
        SetInnactive();
    }

    private void OnCollisionEnter(Collision collision)
    {
        SetInnactive();
    }

    public void Launch(Blaster blaster)
    {
        // Position
        // TODO: Setup with barrel
        transform.position = blaster.transform.position;
        transform.rotation = blaster.transform.rotation;

        // Activate
        gameObject.SetActive(true);

        // Fire, and track
        // TODO: Setup force
        m_Rigidbody.AddRelativeForce(Vector3.forward * 10, ForceMode.Impulse);
        StartCoroutine(TrackLifetime());
    }

    private IEnumerator TrackLifetime()
    {
        yield return new WaitForSeconds(m_Lifetime);
        SetInnactive();
    }

    public void SetInnactive()
    {
        m_Rigidbody.velocity = Vector3.zero;
        m_Rigidbody.angularVelocity = Vector3.zero;

        gameObject.SetActive(false);
    }
}
