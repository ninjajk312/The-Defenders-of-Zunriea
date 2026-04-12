using UnityEngine;
using UnityEngine.SceneManagement;

public class spawnManager : MonoBehaviour
{
    public int enemyCount = 0;
    public int spawnType = 1;
    public int bossTime = 0;
    public int Stage = 1;

    public bool bossSpawning = true;

    public GameObject[] Enemies;
    public GameObject[] Boss;
    public Vector3[] positions;

    private bossOne currentBoss;
    private playerSystem player;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<playerSystem>();

        currentBoss = GameObject.Find("Boss").GetComponent<bossOne>();

        InvokeRepeating("SpawnEnemies", 2.5f, 10f);

    }


    void SpawnEnemies()
    {
        if (player == null) 
        {

            SceneManager.LoadScene(0, LoadSceneMode.Single);
        }

        if (enemyCount == 20 || enemyCount > 20)
        {
            bossTime = 1;

            if (bossTime == 1 && bossSpawning == true)
            {


                bossSpawning = false;

                if(Stage == 1) 
                {
                    Instantiate(Boss[0], positions[0], Boss[0].transform.rotation);
                    
                }
                else if(Stage == 2) 
                {
                    Instantiate(Boss[0], positions[0], Boss[0].transform.rotation);
                }
                else 
                {
                    Instantiate(Boss[0], positions[0], Boss[0].transform.rotation);
                }

            }
            else if (bossTime == 2)
            {
                Debug.Log("you Won");

                SceneManager.LoadScene(0, LoadSceneMode.Single);
            }
            else
            {
                

                if (bossTime == 1 && currentBoss.isDead == true)
                {
                    bossTime = 2;
                }
            }
        }
        else
        {
            spawnType = RandomType();

            if (spawnType == 1)
            {
                EnemySetOne(0, 3);
                EnemySetOne(2, 5);
            }
            else if (spawnType == 2)
            {
                EnemySetTwo();
            }
            else if (spawnType == 3)
            {
                EnemySetThree();
            }
            else if (spawnType == 4)
            {
                EnemySetfour();
            }
            else 
            {
                
            }
        }
    }

    void EnemySetOne(int pos1, int pos2)
    {
        Instantiate(Enemies[0], positions[pos1], Enemies[0].transform.rotation);
        Instantiate(Enemies[1], positions[pos2], Enemies[1].transform.rotation);
        enemyCount += 2;

    }

    void EnemySetTwo()
    {
        Instantiate(Enemies[5], positions[6], Enemies[5].transform.rotation);
        Instantiate(Enemies[5], positions[8], Enemies[5].transform.rotation);
        Instantiate(Enemies[5], positions[11], Enemies[5].transform.rotation);
        Instantiate(Enemies[5], positions[9], Enemies[5].transform.rotation);

        enemyCount += 4;

    }

    void EnemySetThree()
    {
        Instantiate(Enemies[2], positions[7], Enemies[2].transform.rotation);
        Instantiate(Enemies[2], positions[8], Enemies[2].transform.rotation);
        Instantiate(Enemies[2], positions[9], Enemies[2].transform.rotation);
        Instantiate(Enemies[2], positions[10], Enemies[2].transform.rotation);

        enemyCount += 4;

    }

    void EnemySetfour()
    {

        bool a = true;

        if(a == true){
            Instantiate(Enemies[3], positions[1], Enemies[3].transform.rotation);
            Instantiate(Enemies[4], positions[3], Enemies[3].transform.rotation);

            a = false;
        }
        else if (a == false)
        {
            Instantiate(Enemies[4], positions[4], Enemies[3].transform.rotation);
            Instantiate(Enemies[3], positions[0], Enemies[3].transform.rotation);

            a = true;
        }


        enemyCount += 2;

    }

    //Work on Bossfind!!!
    bool Bossfind()
    {
        bool a = false;

        if(a == true)
        {
            return (true);
        }
        else
        {
            return (false);
        }
    }
    int RandomType()
    {
        int random_number = Random.Range(1, 5);



        return (random_number);
    }
}
