using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicRepository
{
    public class LinkedList2
    {
        private Node head;
        private Node tail;

        public Node GetFirst()
        {
            return head;
        }

        public Node GetLast()
        {
            return tail;
        }

        public void AddNode(Audio data) 
        {
            Node madeNode = new Node(data);

            if(head == null)
            {
                head = madeNode;
                tail = madeNode;
            }
            else
            {
                tail.next = madeNode;
                madeNode.prev = tail;
                tail = madeNode;
            }    
        }
        public Node getBeforeQ(Node q) 
        {
            if(q == null || q.prev == null)
            {
                return null;
            }

            return q.prev;
        }

        public int count()
        {
            int cnt = 0;
            Node tmp = head;

            while(tmp != null)
            {
                cnt++;
                tmp = tmp.next;
            }
            return cnt;
        }

        public void removeNode()
        {
            if(head == null)
            {
                Console.WriteLine("danh sach dang rong, ban khong the xoa");
                return;
            }
            if(head == tail)
            {
                head = null;
                tail = null;
            }
            else
            {
                tail = tail.prev;
                tail.next = null;
            }
        }
        public void RemoveAt(int index)
        {
            if (index < 0 || index >= count())
            {
                Console.WriteLine("Vị trí không hợp lệ");
                return;
            }

            Node current = head;
            int currentIndex = 0;

            // Di chuyển đến vị trí cần xóa
            while (currentIndex < index)
            {
                current = current.next;
                currentIndex++;
            }

            // Nếu nút cần xóa là nút đầu danh sách
            if (current.prev == null)
            {
                head = current.next;
                if (head != null)
                {
                    head.prev = null;
                }
                else
                {
                    // Nếu danh sách chỉ có một phần tử, cập nhật tail
                    tail = null;
                }
            }
            else
            {
                // Nếu nút cần xóa không phải là nút đầu danh sách
                current.prev.next = current.next;
                if (current.next != null)
                {
                    current.next.prev = current.prev;
                }
                else
                {
                    // Nếu nút cần xóa là nút cuối danh sách, cập nhật tail
                    tail = current.prev;
                }
            }
        }

    }
}
