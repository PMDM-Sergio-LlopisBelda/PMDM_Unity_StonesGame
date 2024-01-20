using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stone : MonoBehaviour
{
    public GameObject particles;
    private const float yDie = -30.0f;
    public int pointsPerDeath = 1;
    private AudioSource audioSource;
    private Renderer rendererGO;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        rendererGO = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < yDie) {
            StartCoroutine(DestroyStone());
        }
    }

    private void OnMouseDown() {
        audioSource.Play();
        Destroy(Instantiate(particles, transform.position, Quaternion.identity), 1.0f);
        StartCoroutine(DestroyStone());
        GameManager.points+=pointsPerDeath;
        GameManager.stonesDestroyed += 1;
    }

    IEnumerator DestroyStone()
	{
        rendererGO.enabled = false;
        transform.Translate(100, 1000, 100);
        yield return new WaitForSeconds(2.0f);
        Destroy(gameObject);	
	}
}
