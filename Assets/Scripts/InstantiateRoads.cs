using UnityEngine;



public class InstantiateRoads : MonoBehaviour
{
    [SerializeField] private GameObject _carriles = default;
    [SerializeField] private Transform _spawnPoint = default;
    [SerializeField] private GameObject[] obstacleSpawns = default;
    [SerializeField] private GameObject obstacle1 = default;
    [SerializeField] private float repeatRate = 3f;
    [SerializeField] private GameObject _player = default;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Instantiate(_carriles, _spawnPoint.transform.position, Quaternion.identity);
            Destroy(gameObject, 3f);
            _player.GetComponent<PlayerStats>().AddScore();
        }
    }

    private void Start()
    { 
        ObstacleSpawn();
        _player = GameObject.FindGameObjectWithTag("Player");
    }
    

    private void ObstacleSpawn()
    {
        int randomSpawn = Random.Range(0, 2); 
       GameObject obstacle = Instantiate(obstacle1, obstacleSpawns[randomSpawn].transform.position, Quaternion.identity);
    }

    public void AccelerateRepeatRate()
    {
        repeatRate -= 0.1f;
    }
}
