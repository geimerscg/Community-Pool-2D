using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField]
    private GameObject _kidPrefab;
    [SerializeField]
    private GameObject _girlPrefab;
    
        // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(KidSpawnRoutine());
        StartCoroutine(GirlSpawnRoutine());
    }


    IEnumerator KidSpawnRoutine() 
    {
        yield return new WaitForSeconds(3.0f);

        while (true)
        {
            Vector3 startingSpot = new Vector3(Random.Range(-8f, 8f), 8f, 0);
            GameObject newKid = Instantiate(_kidPrefab, startingSpot, Quaternion.identity);
            yield return new WaitForSeconds(5.0f);
        }
    }

    IEnumerator GirlSpawnRoutine()
    {
        yield return new WaitForSeconds(3.0f);

        while (true)
        {
            Vector3 startingSpot = new Vector3(6f, 8f, 0);
            GameObject newGirl = Instantiate(_girlPrefab, startingSpot, Quaternion.identity);
            yield return new WaitForSeconds(5.0f);
        }
    }


}
