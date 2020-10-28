using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraFollow : MonoBehaviour
{
    public Transform target;

    void LateUpdate()
    {
        if (target.position.y > transform.position.y)
        {
            Vector3 newPos = new Vector3(transform.position.x, target.position.y, transform.position.z);
            transform.position = newPos;
<<<<<<< HEAD
            ScoreScript.scoreValue++;
            Debug.Log(newPos);
=======
            // Debug.Log(newPos);
>>>>>>> b779a48... new platforms
        }

        else if (target.position.y < transform.position.y - 7)
        {
            // Debug.Log("end");
            SceneManager.LoadScene(2);
        }
    }
}
