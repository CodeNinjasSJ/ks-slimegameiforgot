using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivesManager : MonoBehaviour
{
    [Header("Lives")]
    public LivesManager livesManager;
    public int lives;
    public GameObject[] hearts;
    // Start is called before the first frame update
    public void RemoveLife()
    {
        lives -= 1;
        print("Lives left: " + lives);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (livesManager.lives < 0)
        {
            return;
        }
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 clickStartLocation = Input.mousePosition;
        }
        if(Input.GetMouseButton(0))
        {

        }
    }
}
