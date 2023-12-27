using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicRepository
{
    public class Node
    {
        public Audio data;
        public Node next;
        public Node prev;

        public Node(Audio data)
        {
            this.data = data;
            next = null;
            prev = null;
        }
    }
}
