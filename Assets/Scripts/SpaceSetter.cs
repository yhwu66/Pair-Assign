using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Skybox))]
public class SpaceSetter : MonoBehaviour
{
    [SerializeField] List<Material> _spaceMaterials;

    Skybox _skybox;

    void Awake()
    {
        _skybox = GetComponent<Skybox>();
    }

    void OnEnable()
    {
        AddSkybox(0);
    }

    void AddSkybox(int skybox)
    {
        if (_skybox != null && skybox <= _spaceMaterials.Count && skybox >= 0)
        {
            _skybox.material = _spaceMaterials[skybox];
        }
    }
}
