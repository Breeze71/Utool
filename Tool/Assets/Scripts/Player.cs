using UnityEngine;


public class Player : MonoBehaviour
{
    [SerializeField] private InventoryManagerSO inventoryManagerSO;
    [SerializeField] private float moveSpeed = 5f;
    private Vector3 moveDirection;


    private void Update() 
    {
        Movement();    
    }

    private void Movement()
    {
        Vector2 inputVector = InputManager.Instance.GetMovementInput();
        moveDirection = new Vector3(inputVector.x, inputVector.y, 0);

        float moveDistance = moveSpeed * Time.deltaTime;
        
        transform.position += moveDirection * moveDistance;

        // Slerp Rotate
        float rotateSpeed = 8f;
        transform.right = Vector3.Slerp(transform.right, moveDirection, Time.deltaTime * rotateSpeed);
    }

    private void OnTriggerEnter2D(Collider2D collider) 
    {
        ItemController item = collider.GetComponent<ItemController>();
        if(collider != null)
        {
            inventoryManagerSO.AddItem(item.GetItemSO(), 1);
            Destroy(collider.gameObject);
        }
    }

    private void OnApplicationQuit() 
    {
        inventoryManagerSO.ClearAll();
    }

}
