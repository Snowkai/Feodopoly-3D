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
    public GameObject Name_c;
    public GameObject Price_c;
    public GameObject Position1;
    public GameObject Position2;
    public GameObject Position3;
    public GameObject Position4;
    // Start is called before the first frame update

    private void OnValidate()
    {
        Name_c.GetComponent<TextMeshPro>().text = cell_name;
        Price_c.GetComponent<TextMeshPro>().text = cell_price.ToString();
    }
    void Start()
    {
        //Name_c.GetComponent<TextMeshPro>().text = cell_name;
        //Price_c.GetComponent<TextMeshPro>().text = cell_price.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
