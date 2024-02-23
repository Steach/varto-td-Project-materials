using System.Collections;
using UnityEngine;

//namespace _Projects.Scripts.Service.Enemy
public class EnemyBuilder : MonoBehaviour
{
    public GameObject enemyPrefab;
    public Transform spawnPoint;
    public Transform endPoint;
    [SerializeField] private int _wave;
    [SerializeField] private int _enemyInWave;
    [SerializeField] private int _waveTime;

    private void Start() 
    {
        StartCoroutine(EnemySpawnRoutine());
    }

    private IEnumerator EnemySpawnRoutine()
    {
        int needSpawn = _wave * _enemyInWave;

        while(needSpawn > 0)
        {
            GameObject tempEnemy = Instantiate(enemyPrefab, spawnPoint.position, Quaternion.identity);
            EnemyLogic tempLogic = tempEnemy.GetComponent<EnemyLogic>();

            tempLogic.MoveTo(endPoint);
            needSpawn--;

            yield return new WaitForSeconds(1.5f);
        }
        yield return new WaitForSeconds(_waveTime);

        _wave++;

        StartCoroutine(EnemySpawnRoutine());
    }
}