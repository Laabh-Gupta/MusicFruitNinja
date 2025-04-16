using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject[] fruitPrefabs;

    public GameObject[] pitchedFruitPrefabs;

    public float minSpawnDelay = 0.25f;
    public float maxSpawnDelay = 1f;

    public float minAngle = -15f;
    public float maxAngle = 15f;

    public float minForce = 18f;
    public float maxForce = 22f;

    public float maxLifetime = 5f;

    private Collider spawnArea;

    public string spawnMode = "keyboard";

    public bool freeEnabled = false;

    public bool isFreeze = false;
    public bool isFrenzy = false;

    public int bonusProb = 5;

    public Background background;

    public CanvasScript cs;

    public Blade blade;

    private void Awake() {

    }

    // Start is called before the first frame update
    void Start()
    {
        spawnArea = GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (spawnMode == "keyboard") {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                GameObject fruitPrefab = fruitPrefabs[0];

                Vector3 position = new Vector3();
                position.x = Random.Range(spawnArea.bounds.min.x, spawnArea.bounds.max.x);
                position.y = Random.Range(spawnArea.bounds.min.y, spawnArea.bounds.max.y);
                position.z = Random.Range(spawnArea.bounds.min.z, spawnArea.bounds.max.z);


                Quaternion rotation = Quaternion.Euler(0f, 0f, Random.Range(minAngle, maxAngle));

                GameObject fruit = Instantiate(fruitPrefab, position, rotation);
                Destroy(fruit, maxLifetime);

                float force = Random.Range(minForce, maxForce);
                fruit.GetComponent<Rigidbody>().AddForce(fruit.transform.up * force, ForceMode.Impulse);
            }

            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                GameObject fruitPrefab = fruitPrefabs[1];

                Vector3 position = new Vector3();
                position.x = Random.Range(spawnArea.bounds.min.x, spawnArea.bounds.max.x);
                position.y = Random.Range(spawnArea.bounds.min.y, spawnArea.bounds.max.y);
                position.z = Random.Range(spawnArea.bounds.min.z, spawnArea.bounds.max.z);


                Quaternion rotation = Quaternion.Euler(0f, 0f, Random.Range(minAngle, maxAngle));

                GameObject fruit = Instantiate(fruitPrefab, position, rotation);
                Destroy(fruit, maxLifetime);

                float force = Random.Range(minForce, maxForce);
                fruit.GetComponent<Rigidbody>().AddForce(fruit.transform.up * force, ForceMode.Impulse);
            }

            if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                GameObject fruitPrefab = fruitPrefabs[2];

                Vector3 position = new Vector3();
                position.x = Random.Range(spawnArea.bounds.min.x, spawnArea.bounds.max.x);
                position.y = Random.Range(spawnArea.bounds.min.y, spawnArea.bounds.max.y);
                position.z = Random.Range(spawnArea.bounds.min.z, spawnArea.bounds.max.z);


                Quaternion rotation = Quaternion.Euler(0f, 0f, Random.Range(minAngle, maxAngle));

                GameObject fruit = Instantiate(fruitPrefab, position, rotation);
                Destroy(fruit, maxLifetime);

                float force = Random.Range(minForce, maxForce);
                fruit.GetComponent<Rigidbody>().AddForce(fruit.transform.up * force, ForceMode.Impulse);
            }

            if (Input.GetKeyDown(KeyCode.Alpha4))
            {
                GameObject fruitPrefab = fruitPrefabs[3];

                Vector3 position = new Vector3();
                position.x = Random.Range(spawnArea.bounds.min.x, spawnArea.bounds.max.x);
                position.y = Random.Range(spawnArea.bounds.min.y, spawnArea.bounds.max.y);
                position.z = Random.Range(spawnArea.bounds.min.z, spawnArea.bounds.max.z);


                Quaternion rotation = Quaternion.Euler(0f, 0f, Random.Range(minAngle, maxAngle));

                GameObject fruit = Instantiate(fruitPrefab, position, rotation);
                Destroy(fruit, maxLifetime);

                float force = Random.Range(minForce, maxForce);
                fruit.GetComponent<Rigidbody>().AddForce(fruit.transform.up * force, ForceMode.Impulse);
            }

            if (Input.GetKeyDown(KeyCode.Alpha5))
            {
                GameObject fruitPrefab = fruitPrefabs[4];

                Vector3 position = new Vector3();
                position.x = Random.Range(spawnArea.bounds.min.x, spawnArea.bounds.max.x);
                position.y = Random.Range(spawnArea.bounds.min.y, spawnArea.bounds.max.y);
                position.z = Random.Range(spawnArea.bounds.min.z, spawnArea.bounds.max.z);


                Quaternion rotation = Quaternion.Euler(0f, 0f, Random.Range(minAngle, maxAngle));

                GameObject fruit = Instantiate(fruitPrefab, position, rotation);
                Destroy(fruit, maxLifetime);

                float force = Random.Range(minForce, maxForce);
                fruit.GetComponent<Rigidbody>().AddForce(fruit.transform.up * force, ForceMode.Impulse);
            }

            if (Input.GetKeyDown(KeyCode.Alpha6))
            {
                GameObject fruitPrefab = fruitPrefabs[5];

                Vector3 position = new Vector3();
                position.x = Random.Range(spawnArea.bounds.min.x, spawnArea.bounds.max.x);
                position.y = Random.Range(spawnArea.bounds.min.y, spawnArea.bounds.max.y);
                position.z = Random.Range(spawnArea.bounds.min.z, spawnArea.bounds.max.z);


                Quaternion rotation = Quaternion.Euler(0f, 0f, Random.Range(minAngle, maxAngle));

                GameObject fruit = Instantiate(fruitPrefab, position, rotation);
                Destroy(fruit, maxLifetime);

                float force = Random.Range(minForce, maxForce);
                fruit.GetComponent<Rigidbody>().AddForce(fruit.transform.up * force, ForceMode.Impulse);
            }

            if (Input.GetKeyDown(KeyCode.Alpha7))
            {
                GameObject fruitPrefab = fruitPrefabs[6];

                Vector3 position = new Vector3();
                position.x = Random.Range(spawnArea.bounds.min.x, spawnArea.bounds.max.x);
                position.y = Random.Range(spawnArea.bounds.min.y, spawnArea.bounds.max.y);
                position.z = Random.Range(spawnArea.bounds.min.z, spawnArea.bounds.max.z);


                Quaternion rotation = Quaternion.Euler(0f, 0f, Random.Range(minAngle, maxAngle));

                GameObject fruit = Instantiate(fruitPrefab, position, rotation);
                Destroy(fruit, maxLifetime);

                float force = Random.Range(minForce, maxForce);
                fruit.GetComponent<Rigidbody>().AddForce(fruit.transform.up * force, ForceMode.Impulse);
            }

            if (Input.GetKeyDown(KeyCode.Alpha8))
            {
                GameObject fruitPrefab = fruitPrefabs[7];

                Vector3 position = new Vector3();
                position.x = Random.Range(spawnArea.bounds.min.x, spawnArea.bounds.max.x);
                position.y = Random.Range(spawnArea.bounds.min.y, spawnArea.bounds.max.y);
                position.z = Random.Range(spawnArea.bounds.min.z, spawnArea.bounds.max.z);


                Quaternion rotation = Quaternion.Euler(0f, 0f, Random.Range(minAngle, maxAngle));

                GameObject fruit = Instantiate(fruitPrefab, position, rotation);
                Destroy(fruit, maxLifetime);

                float force = Random.Range(minForce, maxForce);
                fruit.GetComponent<Rigidbody>().AddForce(fruit.transform.up * force, ForceMode.Impulse);
            }

            if (Input.GetKeyDown(KeyCode.Alpha9))
            {
                GameObject fruitPrefab = fruitPrefabs[8];

                Vector3 position = new Vector3();
                position.x = Random.Range(spawnArea.bounds.min.x, spawnArea.bounds.max.x);
                position.y = Random.Range(spawnArea.bounds.min.y, spawnArea.bounds.max.y);
                position.z = Random.Range(spawnArea.bounds.min.z, spawnArea.bounds.max.z);


                Quaternion rotation = Quaternion.Euler(0f, 0f, Random.Range(minAngle, maxAngle));

                GameObject fruit = Instantiate(fruitPrefab, position, rotation);
                Destroy(fruit, maxLifetime);

                float force = Random.Range(minForce, maxForce);
                fruit.GetComponent<Rigidbody>().AddForce(fruit.transform.up * force, ForceMode.Impulse);
            }

            if (Input.GetKeyDown(KeyCode.Alpha0))
            {
                GameObject fruitPrefab = fruitPrefabs[9];

                Vector3 position = new Vector3();
                position.x = Random.Range(spawnArea.bounds.min.x, spawnArea.bounds.max.x);
                position.y = Random.Range(spawnArea.bounds.min.y, spawnArea.bounds.max.y);
                position.z = Random.Range(spawnArea.bounds.min.z, spawnArea.bounds.max.z);


                Quaternion rotation = Quaternion.Euler(0f, 0f, Random.Range(minAngle, maxAngle));

                GameObject fruit = Instantiate(fruitPrefab, position, rotation);
                Destroy(fruit, maxLifetime);

                float force = Random.Range(minForce, maxForce);
                fruit.GetComponent<Rigidbody>().AddForce(fruit.transform.up * force, ForceMode.Impulse);
            }

            
            if (Input.GetKeyDown(KeyCode.A))
            {
                Debug.Log("a pressed");
                spawnMode = "free";
                if (!freeEnabled) {
                    StartCoroutine(NormalSpawn());
                    freeEnabled = true;
                }
                cs.setPlayModeFree();
            }
            
            
            
        }
    }

    public void stopFreeplay() {
        StopAllCoroutines();
        Debug.Log("Stopping free");
        freeEnabled = false;
        spawnMode = "keyboard";
    }

    private void OnEnable() {
        //StartCoroutine(NormalSpawn());
    }

    private void onDisable() {
        StopAllCoroutines();
    }

    public IEnumerator NormalSpawn() {
        yield return new WaitForSeconds(2f);

        while (enabled) {
            if (spawnMode == "free") {
                int index;
                GameObject fruitPrefab;
                if (blade.soundMode == "default") {
                    index = Random.Range(0, fruitPrefabs.Length);
                    if (index == fruitPrefabs.Length - 1) {
                        int bProb = bonusProb;
                        if (isFrenzy) {
                            bProb *= 4;
                        }

                        int special = Random.Range(0, bProb);
                        if (special < bProb - 1 || isFreeze) {
                            index = Random.Range(0, fruitPrefabs.Length - 2);
                        }
                    } else if (index == fruitPrefabs.Length - 2) {
                        int special = Random.Range(0, bonusProb);
                        if (special < bonusProb - 1 || isFrenzy) {
                            index = Random.Range(0, fruitPrefabs.Length - 2);
                        }
                    }

                    fruitPrefab = fruitPrefabs[index];
                } else {
                    index = Random.Range(0, pitchedFruitPrefabs.Length);
                    if (index == pitchedFruitPrefabs.Length - 1) {
                        int bProb = bonusProb;
                        if (isFrenzy) {
                            bProb *= 4;
                        }
                        int special = Random.Range(0, bProb);
                        if (special < bProb - 1 || isFreeze) {
                            index = Random.Range(0, pitchedFruitPrefabs.Length - 2);
                        }
                    } else if (index == pitchedFruitPrefabs.Length - 2) {
                        int special = Random.Range(0, bonusProb);
                        if (special < bonusProb - 1 || isFrenzy) {
                            index = Random.Range(0, pitchedFruitPrefabs.Length - 2);
                        }
                    }

                    fruitPrefab = pitchedFruitPrefabs[index];
                }

                Vector3 position = new Vector3();
                position.x = Random.Range(spawnArea.bounds.min.x, spawnArea.bounds.max.x);
                position.y = Random.Range(spawnArea.bounds.min.y, spawnArea.bounds.max.y);
                position.z = Random.Range(spawnArea.bounds.min.z, spawnArea.bounds.max.z);


                Quaternion rotation = Quaternion.Euler(0f, 0f, Random.Range(minAngle, maxAngle));

                GameObject fruit = Instantiate(fruitPrefab, position, rotation);
                Destroy(fruit, maxLifetime);

                float force = Random.Range(minForce, maxForce);
                fruit.GetComponent<Rigidbody>().AddForce(fruit.transform.up * force, ForceMode.Impulse);

                if (!isFrenzy) {
                    yield return new WaitForSeconds(Random.Range(minSpawnDelay, maxSpawnDelay)); 
                } else {
                    yield return new WaitForSeconds(0.1f);
                }
                
            } 
        }
    }

    public IEnumerator FreezeTime() {
        isFreeze = true;
        if (isFrenzy) {
            StartCoroutine(background.FrenzyToDoubleColor());
        } else {
            StartCoroutine(background.DefaultToFreezeColor());
        }
        
        Time.timeScale = 0.5f;
        yield return new WaitForSecondsRealtime(10);
        Time.timeScale = 1f;
        isFreeze = false;

        if (isFrenzy) {
            StartCoroutine(background.DoubleToFrenzyColor());
        } else {
            StartCoroutine(background.FreezeToDefaultColor());
        }
        
    }

    public IEnumerator FrenzyTime() {
        isFrenzy = true;
        if (isFreeze) {
            StartCoroutine(background.FreezeToDoubleColor());
        } else {
            StartCoroutine(background.DefaultToFrenzyColor());
        }

        yield return new WaitForSecondsRealtime(10);
        isFrenzy = false;

        if (isFreeze) {
            StartCoroutine(background.DoubleToFreezeColor());
        } else {
            StartCoroutine(background.FrenzyToDefaultColor());
        }
    }
}
