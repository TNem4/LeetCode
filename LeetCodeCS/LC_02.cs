using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCS
{
  
 public class ListNode 
    {
        public int val;
        public ListNode next;
        public ListNode(int val=0, ListNode next=null) 
            {
                this.val = val;
                this.next = next;
            }
    }
 
    internal class LC_02
    {
        ListNode AddTwoNumbers(ListNode l1, ListNode l2, int carry = 0)
        {
            if(l1 == null && l2 == null && carry == 0)
            {
                return null;
            }
            int l1Val = l1?.val ?? 0;
            int l2Val = l2?.val ?? 0;
            int total = l1Val + l2Val + carry;
            carry = total / 10;
            ListNode resultNode = new ListNode(total % 10);
            resultNode.next = AddTwoNumbers(l1?.next, l2?.next, carry);
            return resultNode;
            
        }
    }
}
