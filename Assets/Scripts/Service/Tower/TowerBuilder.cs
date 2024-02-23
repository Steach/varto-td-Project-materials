using UnityEngine;

public class TowerBuilder : MonoBehaviour
{
    [SerializeField] private GameObject tower;
    public bool Construct(TowerBuildPoint point)
    {
        if(!point._CanBuild) return false;

        Instantiate(tower, point.transform);
        return true;
    }
}
