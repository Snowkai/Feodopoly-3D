using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Card : MonoBehaviour
{
    [SerializeField]
    public int card_id;
    public string card_name;
    public string card_description;
    public GameObject Name;
    public GameObject Description;
    // Start is called before the first frame update
    void Start()
    {
        Name.GetComponent<TextMeshPro>().text = card_name;
        Description.GetComponent<TextMeshPro>().text = card_description;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
