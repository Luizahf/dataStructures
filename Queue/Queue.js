/*
 * Algorythim analisys of Queues and it's basic operations in JavaScript
 * Goal: Improve knowledge about queue data structures and improve practice
 *
 * Queue implementation through Nodes
 */

/**
 * Creates a Node with the data informed and sets the Next attr
 * @class
 * @param  {generic} data Informed data to construct the Node
 * @param  {next} null Link to the next node
 */
class Node {
  constructor(data) {
    (this.data = data), (this.next = null);
  }
}

/**
 * Sets the front and back attrs for the queue
 * @class
 * @param  {Node} front First element added to the Queue
 * @param  {Node} back Last element added to the Queue
 */
class Queue {
  constructor() {
    this.front = null;
    this.back = null;
  }

  /**
   * Adds/Stores data as a Node in the back of the Queue
   * @class
   * @param  {generic} data Data informed to create a node and be added to the Queue
   */
  enqueue = data => {
    var newNode = new Node(data);
    if (this.back) {
      this.back.next = newNode;
      this.back = newNode;
    } else {
      this.front = newNode;
      this.back = newNode;
    }
  };

  /**
   * Removes the first data Node of the Queue
   * @class
   */
  dequeue = () => {
    if (this.front) {
      this.front = front.next;
    }
  };

  /**
   * Checks if the Queue is empty
   * @returns {boolean} Boolean value triggered when the Queue is null
   */
  isEmpty = () => {
    return this.front == null;
  };

  /**
   * Shows the element that's in the front of the Queue
   * @returns {Node} The first element int he Queue
   */
  getFront = () => {
    return this.front;
  };
}
