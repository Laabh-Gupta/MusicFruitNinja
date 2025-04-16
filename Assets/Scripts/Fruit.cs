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

    private void Awake() {
        fruitRB = GetComponent<Rigidbody>();
        fruitCollider = GetComponent<Collider>();
        juiceEffect = GetComponentInChildren<ParticleSystem>();

        uiManager = FindObjectOfType<CanvasScript>();
    }

    private void OnTriggerEnter(Collider collider) {
        if (collider.CompareTag("Player")) {
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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
