using UnityEngine;

public class TheScript : MonoBehaviour
{
    
    [SerializeField] private float cerealBol;

    [SerializeField] public bool boule = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("J'ai ajouté un truc");
        print ("Ola");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Hello World!");
    }
    
}
