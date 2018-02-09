using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingBook.Utils
{
    public class TrieNode
    {
        const int wordLength = 255;
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

        public Trie() {
            this.root = new TrieNode();
        }

        public void Insert(string str) {
            var temp = this.root;
            foreach (var item in str)
            {
                if (temp.Children[item] == null) {
                    temp.Children[item] = new TrieNode();
                }
                temp = temp.Children[item];
            }
            temp.IsEndOfWord = true;
        }

        public bool Search(string str)
        {
            var temp = this.root;
            foreach (var item in str)
            {
                if (temp.Children[item] == null)
                {
                    return false;
                }
                temp = temp.Children[item];
            }
            return temp != null && temp.IsEndOfWord;
        }
    }


    }
