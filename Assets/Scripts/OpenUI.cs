using UnityEngine;
public class OpenUI : MonoBehaviour
{
    [SerializeField] GameObject UIPayment;
    [SerializeField] GameObject UIStatement;
    // Rigidbody rb;
    void Start()
    {
        // rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
       
    }
    private void OnTriggerEnter(Collider targetObj)
    {
        if (targetObj.tag == "UIOpener")
        {
       
            UIPayment.gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        UIPayment.gameObject.SetActive(false);
    }


}
