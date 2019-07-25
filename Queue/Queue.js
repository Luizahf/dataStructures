/*
 * Algorythim analisys of Queues and it's basic operations in JavaScript
 * Goal: Improve knowledge about queue data structures and improve practice
 *
 * Queue implementation through Nodes
 */

// Creates a Node with the data informed and sets the Next attr
class Node {
  constructor(data) {
    (this.data = data), (this.next = null);
  }
}

class Queue {
  // Sets the front and back attrs for the queue
  constructor() {
    this.front = null;
    this.back = null;
  }

  // Adds/Stores data as a Node in the back of the Queue
  enqueue = data => {
    newNode = new Node(data);
    if (this.back) {
      this.back.next = newNode;
      this.back = newNode;
    } else {
      this.front = newNode;
      this.back = newNode;
    }
  };

  // Removes the first data Node of the Queue
  dequeue = () => {
    if (this.front) {
      this.front = front.next;
    }
  };

  // Checks if the Queue is empty
  isEmpty = () => {
    return this.front == null;
  };

  // Shows the element that's in the front of the Queue
  getFront = () => {
    return this.front;
  };
}
