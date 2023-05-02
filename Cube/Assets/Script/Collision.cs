using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Animations;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collision : MonoBehaviour
{
    float restartTime = 1.5f;

    void OnCollisionEnter(UnityEngine.Collision collision)
    {
        if (collision.collider)
        {
            GetComponent<Animator>().SetTrigger("Death");
            GetComponent<ScoreManager>().ResetScore();
            GetComponent<PlayerMovement>().enabled = false;
            GetComponent<CapsuleCollider>().enabled = false;
            StartCoroutine(RestartGame());
        }
    }

    IEnumerator RestartGame()
    {
        yield return new WaitForSeconds(restartTime);

        Scene currentSceneIndex = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentSceneIndex.buildIndex);
    }
}
