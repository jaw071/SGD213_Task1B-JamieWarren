using UnityEngine;
using System.Collections.Generic;

// Enum to define the type of tag list
public enum TagListType
{
    Blacklist,  // List of tags to be excluded
    Whitelist   // List of tags to be included
}

public class DestroyedOnCollision : MonoBehaviour
{
    // Variable to store the type of tag list
    [SerializeField]
    private TagListType tagListType = TagListType.Blacklist;

    // A list of tags which we use to determine whether to destroy the game object or not
    // The action depends on the tagListType (Blacklist or Whitelist)
    [SerializeField]
    private List<string> tags;

    // Function that is called when the Collider2D other enters the trigger
    void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the tag of the game object that collided is in the list
        bool tagInList = tags.Contains(other.gameObject.tag);

        // If the tag list type is Blacklist and the tag is in the list, destroy the game object
        // If the tag list type is Whitelist and the tag is not in the list, destroy the game object
        if ((tagListType == TagListType.Blacklist && tagInList) || 
            (tagListType == TagListType.Whitelist && !tagInList))
        {
            // Destroy the game object
            Destroy(gameObject);
        }
    }
}
