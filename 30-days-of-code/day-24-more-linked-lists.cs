using System;
using System.Collections.Generic;
class Node
{
    public int data;
    public Node next;
    public Node(int d)
    {
        data = d;
        next = null;
    }

}
class Solution
{
    // Hackerrank problem link: https://www.hackerrank.com/challenges/30-linked-list-deletion/problem
    
    public static Node removeDuplicates(Node head)
    {
        /* 
        check whether the head is null or not
        check whether the head.next is null, this means that we have reached the last
        */
        if (head == null || head.next == null) return head;
        /*
        if the head.data and the head.next.data is same, then we got a match
        constrain is "The data elements of the linked list argument will always be in non-decreasing order."
        */
        if (head.data == head.next.data)
        {
            // Assign the head.next with head.next.next, so that we can skip the matched data
            head.next = head.next.next;
            // call the method to reset, and continue with new head
            removeDuplicates(head);
        }
        else
        {
            // if no match, continue with next
            removeDuplicates(head.next);
        }
        return head;
    }

    public static Node insert(Node head, int data)
    {
        Node p = new Node(data);


        if (head == null)
            head = p;
        else if (head.next == null)
            head.next = p;
        else
        {
            Node start = head;
            while (start.next != null)
                start = start.next;
            start.next = p;

        }
        return head;
    }
    public static void display(Node head)
    {
        Node start = head;
        while (start != null)
        {
            Console.Write(start.data + " ");
            start = start.next;
        }
    }
    static void Main(String[] args)
    {

        Node head = null;
        int T = Int32.Parse(Console.ReadLine());
        while (T-- > 0)
        {
            int data = Int32.Parse(Console.ReadLine());
            head = insert(head, data);
        }
        head = removeDuplicates(head);
        display(head);
    }
}
