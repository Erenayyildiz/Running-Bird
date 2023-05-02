using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour
{
    [SerializeField] GameObject portal;
    void OnTriggerEnter(Collider other)
    {
       if(other.gameObject == portal)
        {
            NextLevel();
        } 
    }
    void NextLevel()
    {
        Scene currentSceneIndex = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentSceneIndex.buildIndex + 1);
    }

}
