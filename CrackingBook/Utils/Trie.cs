using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingBook.Utils
{
    public class TrieNode
    {
        const int wordLength = 26;
        public TrieNode[] Children = new TrieNode[wordLength];
        public bool IsEndOfWord { get; set; }

        public TrieNode()
        {
            this.IsEndOfWord = false;
        }
    }

    public class Trie
    {
        public TrieNode root { get; set; }

        public function Insert()
    }


    }
