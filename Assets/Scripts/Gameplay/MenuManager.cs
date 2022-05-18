using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private GameObject _colorPanel;
    void Awake()
    {
        
        GameManager.OnGmaeStateChange += GameManager_OnGmaeStateChange;
    }
    void OnDestroy()
    {
        GameManager.OnGmaeStateChange -= GameManager_OnGmaeStateChange;
    }
    private void GameManager_OnGmaeStateChange(GameState state)
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
