/*
 * Algorythim analisys of Stacks and it's basic operations in JavaScript
 * Goal: Improve knowledge about stacks data structures and improve practice
 *
 * Stack implementation through Nodes
 */

// Creates a Node with the data and sets "next" value with null default
class Node {
  constructor(data) {
    this.data = data;
    this.next = null;
  }
}

class Stack {
  // Sets the Stack attr top with null default
  constructor() {
    this.top = null;
  }

  // Creates a new Node with the given data and pushes it on top of the stack
  push(data) {
    var newNode = new Node(data);
    newNode.next = this.top;
    this.top = newNode;
  }

  // Removes the top Node of the Stack
  pop() {
    if (this.top) {
      this.top = this.top.next;
    }
  }

  // Returns the top Node
  peek() {
    return this.top;
  }

  // Checks if the Stack is empty
  isEmpty() {
    return this.top == null;
  }
}
