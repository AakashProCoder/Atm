using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
public class WithState : MonoBehaviour
{
    [SerializeField] GameObject UIPayment;
    [SerializeField] GameObject UIStatement;
    public TMP_InputField getAmount;
    public GameObject TotalAmount;
    public GameObject Insuff;
    public Transform InstantiationPlace;
    public GameObject TransactList;
    int WithdrawAmount;
    int totalAmount;
    int i = 1;
    public void GetAmount()
    {
        WithdrawAmount = Convert.ToInt32(getAmount.text);

        totalAmount = Convert.ToInt32(TotalAmount.GetComponent<TextMeshProUGUI>().text);

    }

    public List<int> TransactionNumber = new List<int>();
    public List<int> balance = new List<int>();
    public void Check()
    {
        if (totalAmount >= WithdrawAmount)
        {
            totalAmount = totalAmount - WithdrawAmount;
            TotalAmount.GetComponent<TextMeshProUGUI>().text = Convert.ToString(totalAmount);
            balance.Add(WithdrawAmount);
            TransactionNumber.Add(i++);
            


        }
        else if (totalAmount < WithdrawAmount)
        {
            Insuff.SetActive(true);
        }


    }
    void Start()
    {
        

    }
    public void MTCheck()
    {
        if (getAmount.text == "")
        {
            Insuff.SetActive(false);
            
        }
    }
    void Update()
    {
        Invoke("MTCheck", 2f);
    }
    public void State()
    {
        UIStatement.SetActive(true);
        UIPayment.SetActive(false);
        InstantiateStore();
      
    }
    GameObject go;
    public void InstantiateStore()
    {
        for (int i = 0; i < balance.Count; i++)
        {

            go = Instantiate(TransactList, InstantiationPlace);
            go.transform.GetChild(0).GetChild(0).GetComponent<TextMeshProUGUI>().text = Convert.ToString(TransactionNumber[i]);
            go.transform.GetChild(1).GetChild(0).GetComponent<TextMeshProUGUI>().text = Convert.ToString(balance[i]);



        }
    }
}
