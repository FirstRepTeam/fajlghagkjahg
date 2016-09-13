using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EnemyController : MonoBehaviour {

    public GameObject Monster;
    public GameObject spawnSpot1;
    public GameObject spawnSpot2;
    public GameObject spawnSpot3;


    
    public BoxCollider2D _monsterHitbox;


    public float _scoreCounter = 0;

    [SerializeField]
    private Text _scoreText;
    [SerializeField]
    private Text _topScoreText;

    void Start()
    {
        BigMom.Init();
        _monsterHitbox = Monster.GetComponent<BoxCollider2D>();
        SpawnEnemy();
        _topScoreText.text = "BestScore: " + PlayerPrefs.GetFloat("BestScore").ToString();
    }

    public void UpdateScore()
    {
        
        _scoreText.text = "Score: " + _scoreCounter.ToString();
        if (PlayerPrefs.HasKey("BestScore"))
        {
            if (PlayerPrefs.GetFloat("BestScore") < _scoreCounter)
            {
                PlayerPrefs.SetFloat("BestScore", _scoreCounter);
            }
        }
        else
            PlayerPrefs.SetFloat("BestScore",_scoreCounter);
        _topScoreText.text = "BestScore: " + PlayerPrefs.GetFloat("BestScore").ToString();
    }

    public Vector3 choseRandomSpawnSpot()
    {
        if (Random.Range(0f, 100) < 35)
            return spawnSpot1.transform.position;
        else if (Random.Range(0f, 100) < 65)
            return spawnSpot2.transform.position;
        else
            return spawnSpot3.transform.position;
    }

    public void StartCorutineOutside()
    {
        StartCoroutine(SpawnNewMonsterAfterDeath());
    }

   public IEnumerator SpawnNewMonsterAfterDeath()
    {

        _scoreCounter++;
        UpdateScore();
        yield return new WaitForSeconds(1.0f);

        SpawnEnemy();
    }

    public void SpawnEnemy()
    {
        Vector3 MonsterPosition = choseRandomSpawnSpot();
        MonsterPosition = new Vector3(

            
           MonsterPosition.x,
           MonsterPosition.y + _monsterHitbox.size.y/1.5f,
           MonsterPosition.z
   );
        
        Instantiate(Monster, MonsterPosition, Quaternion.identity);
    }
}
