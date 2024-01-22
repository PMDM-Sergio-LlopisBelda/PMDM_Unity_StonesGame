using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
//using System;
using MagicPigGames;

public class MainLoop: MonoBehaviour {
	
	public GameObject[] stones = new GameObject[3];
	public float torque = 5.0f;
	public float minAntiGravity = 20.0f, maxAntiGravity = 40.0f;
	public float minLateralForce = -15.0f, maxLateralForce = 15.0f;
	public float minTimeBetweenStones = 1f, maxTimeBetweenStones = 3f;
	public float minX = -30.0f, maxX = 30.0f;
	public float minZ = -5.0f, maxZ = 20.0f;
	public int stonesToSpawn = 20;
	public ProgressBar progress; 
	
	//private bool enableStones = true;
	private Rigidbody rb;
	
	// Use this for initialization
	void Start () {
		StartCoroutine(ThrowStones());
		//progress.sizeMax = stonesToSpawn;
		progress.SetProgress(0);
	}
	
	// Update is called once per frame
	void Update () {
	}

	IEnumerator ThrowStones()
	{
		// Initial delay
		yield return new WaitForSeconds(2.0f);		
		while(stonesToSpawn > GameManager.stonesThrown) {
			GameObject stone = (GameObject) Instantiate(stones[Random.Range(0, stones.Length)]);
			stone.transform.position = new Vector3(Random.Range(minX, maxX), -30.0f, Random.Range(minZ, maxZ));
			stone.transform.rotation = Random.rotation;

			rb = stone.GetComponent<Rigidbody>();
			
			rb.AddTorque(Vector3.up * torque, ForceMode.Impulse);
			rb.AddTorque(Vector3.right * torque, ForceMode.Impulse);
			rb.AddTorque(Vector3.forward * torque, ForceMode.Impulse);
			
			rb.AddForce(Vector3.up * Random.Range(minAntiGravity, maxAntiGravity), ForceMode.Impulse);
			rb.AddForce(Vector3.right * Random.Range(minLateralForce, maxLateralForce), ForceMode.Impulse);

			GameManager.stonesThrown++;
			float progBarNum = (float) GameManager.stonesThrown / stonesToSpawn;
			progress.SetProgress(progBarNum);
			//counter++;

			yield return new WaitForSeconds(Random.Range(minTimeBetweenStones, maxTimeBetweenStones));
			
		}

		yield return new WaitForSeconds(5f);
		SceneManager.LoadScene("Final");
		
	}
}

