using System;
class Node
{
    // Hacker rank problem link: https://www.hackerrank.com/challenges/30-linked-list/problem
    /*
        Complete the insert function in your editor so that it creates a new Node (pass  as the Node constructor argument) and inserts it at the tail of the linked list referenced by the  parameter. 
        Once the new node is added, return the reference to the  node.
    */
	public int data;
	public Node next;
    public Node(int d){
        data=d;
        next=null;
    }
		
}
class Solution {
	public static  Node insert(Node head,int data)
	{
      // Create a new Node with the given data
      var newNode = new Node(data);
      if(head == null) return newNode; // return the new node if the head is null
      var last = head;
      while(last.next!=null) 
      {
          // traverse through till we find the node with next is null
          // Check the Node constructor
          last = last.next;
      }
      last.next = newNode; // asiign the new node to lat node next, so that the new node stays at the last
      return head;
    }

	public static void display(Node head)
	{
		Node start=head;
		while(start!=null)
		{
			Console.Write(start.data+" ");
			start=start.next;
		}
	}
    static void Main(String[] args) {
	
		Node head=null;
        int T=Int32.Parse(Console.ReadLine());
        while(T-->0){
            int data=Int32.Parse(Console.ReadLine());
            head=insert(head,data);
        }
		display(head);
	}
}
	