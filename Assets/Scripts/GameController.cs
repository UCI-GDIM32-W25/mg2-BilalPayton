using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] private GameObject _coinPrefab;
    [SerializeField] private TMP_Text _pointsText;

    private int _points;


    void Start()
    {
        Instantiate(_coinPrefab);
    }

    void Update()
    {
        
    }
}
