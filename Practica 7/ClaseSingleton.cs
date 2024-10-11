using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClaseSingleton : MonoBehaviour
{
    public static ClaseSingleton Instance { get; private set; }

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            //Se modifica de this a gameObject
        }
        else
        {
            Instance = this;

            DontDestroyOnLoad(this);

        }

    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            int index_escena = SceneManager.GetActiveScene().buildIndex;
            index_escena++;
            index_escena %= 4;
            CambioEscena(index_escena);
        }
    }
    public void CambioEscena(int idx)
    {
        SceneManager.LoadScene(idx);
    }


}