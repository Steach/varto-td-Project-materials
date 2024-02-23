using UnityEngine;

public class TowerBuildPoint : MonoBehaviour
{
    public bool _CanBuild => _canBuild;
    [SerializeField] private GameObject _constractionMarker;
    private bool _canBuild = true;

    public void ChangeBuildingRPermission(bool userCanBuild)
    {
        _canBuild = userCanBuild;
        _constractionMarker.SetActive(userCanBuild);
    }
}
