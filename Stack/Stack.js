/*
 * Algorythim analisys of Stacks and it's basic operations in JavaScript
 * Goal: Improve knowledge about stacks data structures and improve practice
 *
 * Stack implementation through Nodes
 */

/**
 * @param  {generic} data Informed data to construct the Node
 * @param  {next} null Link to the next node
 */
class Node {
  constructor(data) {
    this.data = data;
    this.next = null;
  }
}

/**
 * Sets the rop attr for the Stack
 * @param  {Node} top Last element added to the Stack
 */
class Stack {
  constructor() {
    this.top = null;
  }

  /**
   * Creates a new Node with the given data and pushes it on top of the stack
   * @param  {generic} data Data informed to create a node and be added in the top of the Stack
   */
  push(data) {
    var newNode = new Node(data);
    newNode.next = this.top;
    this.top = newNode;
  }

  /**
   *  Removes the top Node of the Stack
   */
  pop() {
    if (this.top) {
      this.top = this.top.next;
    }
  }

  /**
   * Shows the element that's in the front of the Queue
   * @returns {Node} The top node of the Stack
   */
  peek() {
    return this.top;
  }

  /**
   * Checks if the Stack is empty
   * @returns {boolean} Boolean value triggered when the Stack is null
   */
  isEmpty() {
    return this.top == null;
  }
}
