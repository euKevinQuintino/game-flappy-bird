using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {
  public GameManager gameManager;
  private bool jumpKeyWasPressed;
	public float velocity = 1;
	private Rigidbody2D bird;
  void Start() {
		bird = GetComponent<Rigidbody2D>();
  }

  void Update() {
    if (Input.GetKeyDown("space") || Input.GetMouseButtonDown(0)) {
      jumpKeyWasPressed = true;
    }
  }

  private void FixedUpdate() {
    if (jumpKeyWasPressed) {
      bird.velocity = Vector2.up * velocity;
      jumpKeyWasPressed = false;
    }
  }

  private void OnCollisionEnter2D(Collision2D collision) {
    gameManager.EndGame();
  }
}
