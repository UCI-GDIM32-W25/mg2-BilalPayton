using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] private TMP_Text _pointsText;
    [SerializeField] private GameObject _coinPrefab;

    private void Start()
    {
        _pointsText.text = "Points: 0";
    }

    private void Update()
    {
        
        int randomNum = Random.Range(1, 750);

        if (randomNum == 1)
        {
            GameObject newCoin = Instantiate(_coinPrefab);
            newCoin.transform.position = new Vector3(14, 12.5f, 0);
            
        }
    }

    public void UpdatePoints(int points)
    {
        _pointsText.text = "Points: " + points;
    }
}
