/*
 * Algorythim analisys of Binary Search Trees and it's basic operations
 * Goal: Improve knowledge about Binary Search Tree's data structure and improve practice
 *
 * Binary Search Tree implementation through Nodes
 */

/**
 * @class Models the data informed in a Node
 * @param  {int} data - Informed data to construct the Node
 * @property {Node} left - Link to the node at the left
 * @property {Node} right - Link to the node at the right
 */
class Node {
  constructor(data) {
    this.right = null;
    this.left = null;
    this.data = data;
  }
}
/**
 * @class Sets the Tree data structure
 * @property {Node} headRoot - First element added to the Tree
 */
class Tree {
  constructor() {
    this.headRoot = null;
  }

  /**
   * @function insert - Adds a value as a node in the Tree folowing the binary search method
   * @param {int} value - Informed value that will be added to the Tree
   * @param {Node} node - Current node / node to add the value recived
   */
  insert(value, node = this.headRoot) {
    if (this.headRoot == null) {
      this.headRoot = new Node(value);
    } else {
      if (value <= node.data) {
        if (node.left == null) {
          node.left = new Node(value);
        } else {
          this.insert(value, node.left);
        }
      } else {
        if (node.right == null) {
          node.right = new Node(value);
        } else {
          this.insert(value, node.right);
        }
      }
    }
  }

  /**
   * @function contains - Checks is the Tree contains the value informed
   * @param {int} value - Informed value to check if it part of the Tree
   * @param {Node} node - Current node to check if is equal the value informed
   * @returns {boolean} -Indicates if the value informed is part of the Tree
   */
  contains(value, node = this.headRoot) {
    if (node.data == value) {
      return true;
    } else if (value <= node.data) {
      if (node.left) {
        return this.contains(value, node.left);
      } else {
        return false;
      }
    } else if (value > node.data) {
      if (node.right) {
        return this.contains(value, node.right);
      } else {
        return false;
      }
    }
  }

  /**
   * @function checkBST - Checks if the Tree is a binary search tree
   * @param {Node} node - Current node to be analized
   * @param {int} min - Minimum value accepted for the node
   * @param {int} max - Maximum value accepted for the node
   * @returns {boolean} - Indicates if the tree is a binary search tree
   */
  checkBST(node = this.headRoot, min = Int16Array.min, max = Int16Array.max) {
    if (node == null) {
      return true;
    } else if (node < min || node > max) {
      return false;
    } else {
      return (
        this.checkBST(node.left, min, node.data + 1) &&
        this.checkBST(node.right, node.data - 1, max)
      );
    }
  }
}
