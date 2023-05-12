using System.Collections; 
using System.Collections.Generic; 
using UnityEngine; 
using UnityEngine.SceneManagement;
 
public class Ded : MonoBehaviour 
{ 
private void OnTriggerEnter(Collider other) 
    { 
        if(other.gameObject.CompareTag("obstacle")) 
        { 
            FindObjectOfType<EnemySpawner>().isSpawning = false;
            //Destroy(gameObject); 
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        } 
    } 
} 