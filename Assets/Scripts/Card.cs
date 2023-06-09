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
    public GameObject text_name;
    public GameObject text_discription;
    // Start is called before the first frame update

    private void OnValidate()
    {
        text_name.GetComponent<TextMeshPro>().text = card_name;
        text_discription.GetComponent<TextMeshPro>().text=card_description;
    }
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
