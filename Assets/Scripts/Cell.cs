using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Cell : MonoBehaviour
{
    public int cell_id;
    public string cell_name;
    public int cell_price;
    [SerializeField] GameObject Name;
    [SerializeField] GameObject Price;
    public Vector3 position1;
    public Vector3 position2;
    public Vector3 position3;
    public Vector3 position4;
    // Start is called before the first frame update
    void Start()
    {
        Name.GetComponent<TextMeshPro>().text = cell_name;
        Price.GetComponent<TextMeshPro>().text = cell_price.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
