using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : MonoBehaviour
{
    public GameObject whole;
    public GameObject sliced;

    private Rigidbody fruitRB;
    private Collider fruitCollider;
    private ParticleSystem juiceEffect;
    private CanvasScript uiManager;

    private float spawnTime; // ⏱️ Time when the fruit spawns

    private void Awake() {
        fruitRB = GetComponent<Rigidbody>();
        fruitCollider = GetComponent<Collider>();
        juiceEffect = GetComponentInChildren<ParticleSystem>();

        uiManager = FindObjectOfType<CanvasScript>();
    }

    private void Start()
    {
        spawnTime = Time.time; // 🟢 Record spawn time when fruit appears
    }

    private void OnTriggerEnter(Collider collider) {
        if (collider.CompareTag("Player")) {
            float sliceTime = Time.time; // 🔴 Time when fruit is sliced
            float responseTime = sliceTime - spawnTime; // ⏱️ Calculate response

            Debug.Log("Response Time: " + responseTime.ToString("F3") + " seconds");

            // Optionally store this data for analytics or export
            PlayerPrefs.SetFloat("LastResponseTime", responseTime);

            Blade blade = collider.GetComponent<Blade>();
            Slice(blade.direction, blade.transform.position, blade.sliceForce);
        }
    }

    private void Slice(Vector3 direction, Vector3 position, float force) {
        whole.SetActive(false);
        sliced.SetActive(true);
        fruitCollider.enabled = false;

        juiceEffect.Play();

        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        sliced.transform.rotation = Quaternion.Euler(0f, 0f, angle);

        Rigidbody[] slices = sliced.GetComponentsInChildren<Rigidbody>();
        for (int i = 0; i < slices.Length; i++) {
            slices[i].velocity = fruitRB.velocity;
            slices[i].AddForceAtPosition(direction * force, position, ForceMode.Impulse);
        }

        if (uiManager != null) {
            uiManager.IncreaseScore(5);
        }
    }

    void Update()
    {
        
    }
}
 