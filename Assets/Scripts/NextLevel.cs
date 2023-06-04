using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D col) {
        if (col.gameObject.GetComponent<playermove>()){
                Scene currentScene = SceneManager.GetActiveScene ();

    string sceneName = currentScene.name;
   
    SceneManager.LoadScene(currentScene.buildIndex + 1);
            
        }
    }
}
