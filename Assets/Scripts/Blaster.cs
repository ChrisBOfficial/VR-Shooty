using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Blaster : MonoBehaviour
{
    public GameObject m_ProjectilePrefab = null;

    private ProjectilePool m_ProjectilePool = null;

    private void Awake()
    {
        m_ProjectilePool = new ProjectilePool(m_ProjectilePrefab, 10);
    }
}
