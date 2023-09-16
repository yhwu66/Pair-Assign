using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Skybox))]
public class SpaceSetter : MonoBehaviour
{
    [SerializeField] List<Material> _spaceMaterials;

    Skybox _skybox;

    private void Awake()
    {
        _skybox = GetComponent<Skybox>();
    }

    private void OnEnable()
    {
        AddSkybox(0);
    }

    private void AddSkybox(int skybox)
    {
        if (_skybox != null && skybox <= _spaceMaterials.Count && skybox >= 0)
        {
            _skybox.material = _spaceMaterials[skybox];
        }
    }
}
