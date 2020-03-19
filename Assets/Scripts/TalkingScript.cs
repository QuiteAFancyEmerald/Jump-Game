using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// Script for talking to characters
/// </summary>
public class TalkingScript : MonoBehaviour
{
    public GameObject textbox;
    public string dialogue = "Words words words."; // Words being put into the dialogue box
    public Text targetText; // text box that is being targeted

    /// <summary>
    /// populate Target text with the words in dialogue
    /// </summary>
    void Start()
    {
        targetText.text = dialogue;
    }
    /// <summary>
    /// Collision triggers population of the text box
    /// </summary>
    /// <param name="collision"></param>
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Player")) //Player must cause the collision
        {
            Debug.Log("Activate text."); //Debug
            textbox.gameObject.SetActive(true); // Spawn the text box
        }
    }
}