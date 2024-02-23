using System;
using UnityEngine;

public class BuilderRayCast : MonoBehaviour
{
    [SerializeField] private Camera _rayCamera;
    [SerializeField] private TowerBuilder _towerBuilder;

    private void Update() 
    {
        CheckToBuild();
    }

    private void CheckToBuild()
    {
        if(!Input.GetMouseButtonDown(0)) return;

        var ray = _rayCamera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if(Physics.Raycast(ray, out hit))
        {
            var hitCollider = hit.collider;
            if(hitCollider.CompareTag("BuildPoint"))
            {
                if(hitCollider.TryGetComponent<TowerBuildPoint>(out var buildPoint))
                {
                    if(!buildPoint._CanBuild) return;

                    if(_towerBuilder.Construct(buildPoint))
                    {
                        buildPoint.ChangeBuildingRPermission(false);
                    }
                }
            }
        }
    }
}
