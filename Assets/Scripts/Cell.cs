using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Cell : MonoBehaviour
{
    [SerializeField]
    public int cell_id;
    public string cell_name;
    public int cell_price;
    public GameObject Name;
    public GameObject Price;
    public GameObject Position1;
    public GameObject Position2;
    public GameObject Position3;
    public GameObject Position4;
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
