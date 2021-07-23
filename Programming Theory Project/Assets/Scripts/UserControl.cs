using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UserControl : MonoBehaviour
{
    [SerializeField] private Camera mainCamera;
    [SerializeField] private TextMeshProUGUI activeText;
    private TileBlock _selectedBlock;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            HandleSelection();
        }
    }
    
    public void HandleSelection ()
    {
        Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            //the collider could be children of the unit, so we make sure to check in the parent
            TileBlock tileBlock = hit.collider.GetComponentInParent<TileBlock>();
            _selectedBlock = tileBlock;
            Debug.Log("Clicked on a " + tileBlock.GetName() + ", has coin: " + tileBlock.isCoinActive());
            
            activeText.SetText(_selectedBlock.GetName());
        }
    }
}
